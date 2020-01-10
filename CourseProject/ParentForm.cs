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

        private void покупателиНаЗаданнуюДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Покупатели на заданную дату")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!isOpen)
            {
                Form_CustomersByDate f1 = new Form_CustomersByDate();
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void покупкиСНаценкойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Покупатели, купившие с наценкой")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!isOpen)
            {
                Form_CustomersWithMargin f1 = new Form_CustomersWithMargin();
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Перекрестная таблица")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!isOpen)
            {
                Form_CrossTable f1 = new Form_CrossTable();
                f1.MdiParent = this;
                f1.Show();
            }
        }
    }
}
