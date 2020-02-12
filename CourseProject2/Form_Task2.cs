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
    public partial class Form_Task2 : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Дмитрий\Documents\access-db-project\CourseProject2\Database1.accdb");
        public Form_Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            if (!radioButton_SQL.Checked && !radioButton_Program.Checked)
            {
                MessageBox.Show("Выберите способ выборки!");
                return;
            }

            if (radioButton_SQL.Checked)
            {
                try
                {
                    connection.Open();
                    OleDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "SELECT [Номер отдела], [Номер название], [ФИО руководителя], " +
                    //"workers_count AS (SELECT COUNT(DISTINCT '[Номер отдела]') FROM Таблица1) FROM Таблица2";
                    //TODO: sql for each department?
                    cmd.CommandText = "SELECT First(Таблица1.[Номер отдела]) AS [Номер отдела поле], Count(Таблица1.[Номер отдела]) AS Повторы" +
                        " FROM Таблица1 GROUP BY Таблица1.[Номер отдела] HAVING(((Count(Таблица1.[Номер отдела])) > 1));";
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

                Dictionary<int, int> counts = new Dictionary<int, int>();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int current_key = (int)dataGridView1.Rows[i].Cells[2].Value;
                    if (counts.Keys.Contains(current_key))
                    {
                        counts[current_key] += 1;
                    }
                    else
                    {
                        counts.Add(current_key, 1);
                    }
                }

                Database1DataSetTableAdapters.Таблица2TableAdapter adapter2 = new Database1DataSetTableAdapters.Таблица2TableAdapter();
                adapter2.Fill(database1DataSet1.Таблица2);
                dataGridView1.DataSource = adapter2.GetData();

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[4].Value = counts[(int)dataGridView1.Rows[i].Cells[0].Value];
                }
            }
        }
    }
}
