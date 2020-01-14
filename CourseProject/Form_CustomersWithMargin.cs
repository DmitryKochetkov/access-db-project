using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Form_CustomersWithMargin : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Дмитрий\source\repos\CourseProject\CourseProject\Database1.accdb");
        public Form_CustomersWithMargin()
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
                    cmd.CommandText = "SELECT DISTINCT [Шифр покупателя] FROM Таблица1 INNER JOIN Таблица2 ON Таблица1.[Код Товара] = Таблица2.[Код Товара] WHERE Наценка > 0";
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
                Database1DataSetTableAdapters.Таблица1TableAdapter adapter1 = new Database1DataSetTableAdapters.Таблица1TableAdapter();
                adapter1.Fill(database1DataSet1.Таблица1);
                dataGridView1.DataSource = adapter1.GetData();

                Database1DataSetTableAdapters.Таблица2TableAdapter adapter2 = new Database1DataSetTableAdapters.Таблица2TableAdapter();
                adapter2.Fill(database1DataSet1.Таблица2);
                DataTable table2 = adapter2.GetData();

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (dataGridView1.Columns[i].Name != "Шифр покупателя" && dataGridView1.Columns[i].Name != "Код товара")
                    {
                        dataGridView1.Columns.RemoveAt(i);
                        i--;
                    }
                }

                
                HashSet<object> customers = new HashSet<object>();
                for (int i = 0; i < dataGridView1.RowCount - 1; i++) //TODO: Fix Bug
                {
                    if (!customers.Contains(dataGridView1.Rows[i].Cells[1].Value))
                    {
                        if (!(table2.Rows.Find((int)dataGridView1.Rows[i].Cells[0].Value) == null))
                        {
                            if (table2.Rows.Find((int)dataGridView1.Rows[i].Cells[0].Value).Field<decimal>("Наценка") > 0)
                            customers.Add(dataGridView1.Rows[i].Cells[1].Value);
                            else
                            {
                                dataGridView1.Rows.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }

                dataGridView1.Columns.RemoveAt(0);
            }
        }
    }
}
