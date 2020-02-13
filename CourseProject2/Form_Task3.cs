using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CourseProject2
{
    public partial class Form_Task3 : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Дмитрий\Documents\access-db-project\CourseProject2\Database1.accdb");
        public Form_Task3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            if (!radioButton_SQL.Checked && !radioButton_Program.Checked)
            {
                MessageBox.Show("Выберите способ выборки!");
                return;
            }

            if (radioButton_SQL.Checked)
            {
                dataGridView1.Columns.Clear();

                try
                {
                    connection.Open();
                    OleDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "TRANSFORM First(Таблица1.[Фамилия]) AS [First-Фамилия] " +
                        "SELECT Таблица1.[Должность] FROM Таблица1 GROUP BY Таблица1.[Должность] PIVOT Таблица1.[Номер отдела];";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.ToString(), "OleDb Exception: Ошибка при считывании из базы данных");
                }
            }
            else if (radioButton_Program.Checked)
            {
                Database1DataSetTableAdapters.Таблица1TableAdapter adapter = new Database1DataSetTableAdapters.Таблица1TableAdapter();
                adapter.Fill(database1DataSet1.Таблица1);
                dataGridView1.DataSource = adapter.GetData();

                /*

                Dictionary<string, int[]> crosstab = new Dictionary<string, int[]>(); //string into collection 1 to 8

                //init new columns
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int candidate = (int)dataGridView1.Rows[i].Cells[2].Value;
                    if (!dataGridView1.Columns.Contains(candidate.ToString()))
                    {
                        dataGridView1.Columns.Add(candidate.ToString(), candidate.ToString());
                    }
                }

                //init data for crosstab
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    string job = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    int department = (int)dataGridView1.Rows[i].Cells[2].Value;
                    if (!crosstab.Keys.Contains(job))
                    {
                        int[] buf = new int[8];
                        buf[department-1] = 1;
                        crosstab.Add(job, buf);
                    }
                    else crosstab[job][department] += 1;
                }


                //no repeat
                HashSet<string> no_repeat = new HashSet<string>();
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (no_repeat.Contains(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                    else no_repeat.Add(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }

                //view new data
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 4; j < 4 + 8; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = crosstab[dataGridView1.Rows[i].Cells[3].Value.ToString()][j-4].ToString();
                    }
                }

                //remove extra columns
                dataGridView1.Columns.RemoveAt(2);
                dataGridView1.Columns.RemoveAt(1);
                dataGridView1.Columns.RemoveAt(0);

                */

                string[][] table;

                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);

                //init new columns
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int candidate = (int)dataGridView1.Rows[i].Cells[2].Value;
                    if (!dataGridView1.Columns.Contains(candidate.ToString()))
                    {
                        dataGridView1.Columns.Add(candidate.ToString(), candidate.ToString());
                    }
                }

                //no repeat
                HashSet<string> no_repeat = new HashSet<string>();
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (no_repeat.Contains(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                    else no_repeat.Add(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }

                //fill surnames if possible
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int department = (int)dataGridView1.Rows[i].Cells[2].Value;
                    if (dataGridView1.Rows[i].Cells[department + 3].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[department + 3].Value = dataGridView1.Rows[i].Cells[1].Value;
                    }
                }
            }
        }
    }
}
