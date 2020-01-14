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
    public partial class Form_CrossTable : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Дмитрий\source\repos\CourseProject\CourseProject\Database1.accdb");
        public Form_CrossTable()
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
                    //cmd.CommandText = "SELECT * FROM (SELECT [Наименование товара], [Скидка] FROM Таблица2 GROUP BY [Скидка], [Наименование товара] ORDER BY [Скидка], [Наименование товара]) PIVOT (COUNT(discount))";
                    cmd.CommandText = "SELECT [Наименование товара]" +
                        ", SUM(IIF([Скидка] = 0, 1, 0)) AS[0 %]" +
                        ", SUM(IIF([Скидка] = 0.1, 1, 0)) AS[10 %]" + 
                        ", SUM(IIF([Скидка] = 15, 1, 0)) AS [15 %]" +
                        "FROM Таблица2 GROUP BY [Наименование товара]";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns[0].Width = 200;

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

            }
        }
    }
}
