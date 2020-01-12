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
    public partial class Form_Table1 : Form
    {
        public Form_Table1()
        {
            InitializeComponent();
        }

        private void Form_Table1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Таблица1' table. You can move, or remove it, as needed.
            this.таблица1TableAdapter.Fill(this.database1DataSet.Таблица1);
        }
    }
}
