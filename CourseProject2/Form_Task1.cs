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
    public partial class Form_Task1 : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Дмитрий\Documents\access-db-project\CourseProject2\Database1.accdb");
        public Form_Task1()
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
                    cmd.CommandText = "SELECT [Фамилия], [Номер отдела] FROM Таблица1 WHERE [Должность] LIKE " + "'" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Нет работников с данной должностью", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() != textBox1.Text) {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }

                dataGridView1.Columns.RemoveAt(0);
                dataGridView1.Columns.RemoveAt(2);

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Нет работников с данной должностью", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
