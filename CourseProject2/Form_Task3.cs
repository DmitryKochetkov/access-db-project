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
                    /*
                    cmd.CommandText = "SELECT [Должность]" +
                        ", SUM(IIF([Должность] = \'Разработчик\', 1, 0)) AS[0 %]" +
                        ", SUM(IIF([Должность] = 0.1, 1, 0)) AS[10 %]" +
                        ", SUM(IIF([Должность] = 15, 1, 0)) AS [15 %]" +
                        "FROM Таблица1.[Номер отдела] * Таблица1.[Должность]";
                        */

                    cmd.CommandText = "SELECT Таблица1. FROM Таблица1 CROSS JOIN Таблица1";
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

                //Dictionary<int, int> counts = new Dictionary<int, int>();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    
                }
            }
        }
    }
}
