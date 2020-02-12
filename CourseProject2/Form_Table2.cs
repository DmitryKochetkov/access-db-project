using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject2
{
    public partial class Form_Table2 : Form
    {
        public Form_Table2()
        {
            InitializeComponent();
        }

        private void Form_Table2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Таблица2". При необходимости она может быть перемещена или удалена.
            this.таблица2TableAdapter.Fill(this.database1DataSet.Таблица2);

        }
    }
}
