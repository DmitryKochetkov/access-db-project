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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void таблица1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Таблица 1")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!isOpen)
            {
                Form_Table1 f1 = new Form_Table1();
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void таблица2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Таблица 2")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!isOpen)
            {
                Form_Table2 f2 = new Form_Table2();
                f2.MdiParent = this;
                f2.Show();
            }
        }
    }
}
