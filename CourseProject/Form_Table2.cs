using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Form_Table2 : Form
    {
        public Form_Table2()
        {
            InitializeComponent();
        }

        private void Form_Table2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Таблица2' table. You can move, or remove it, as needed.
            this.таблица2TableAdapter.Fill(this.database1DataSet.Таблица2);
        }
    }
}
