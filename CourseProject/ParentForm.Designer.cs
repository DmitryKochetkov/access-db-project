namespace CourseProject
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблица1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблица2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданияSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкиСНаценкойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиНаЗаданнуюДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.заданияSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблица1ToolStripMenuItem,
            this.таблица2ToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // таблица1ToolStripMenuItem
            // 
            this.таблица1ToolStripMenuItem.Name = "таблица1ToolStripMenuItem";
            this.таблица1ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.таблица1ToolStripMenuItem.Text = "Таблица 1";
            this.таблица1ToolStripMenuItem.Click += new System.EventHandler(this.таблица1ToolStripMenuItem_Click);
            // 
            // таблица2ToolStripMenuItem
            // 
            this.таблица2ToolStripMenuItem.Name = "таблица2ToolStripMenuItem";
            this.таблица2ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.таблица2ToolStripMenuItem.Text = "Таблица 2";
            this.таблица2ToolStripMenuItem.Click += new System.EventHandler(this.таблица2ToolStripMenuItem_Click);
            // 
            // заданияSQLToolStripMenuItem
            // 
            this.заданияSQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупкиСНаценкойToolStripMenuItem,
            this.покупателиНаЗаданнуюДатуToolStripMenuItem,
            this.перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem});
            this.заданияSQLToolStripMenuItem.Name = "заданияSQLToolStripMenuItem";
            this.заданияSQLToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заданияSQLToolStripMenuItem.Text = "Задания";
            // 
            // покупкиСНаценкойToolStripMenuItem
            // 
            this.покупкиСНаценкойToolStripMenuItem.Name = "покупкиСНаценкойToolStripMenuItem";
            this.покупкиСНаценкойToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.покупкиСНаценкойToolStripMenuItem.Text = "Покупки с наценкой";
            this.покупкиСНаценкойToolStripMenuItem.Click += new System.EventHandler(this.покупкиСНаценкойToolStripMenuItem_Click);
            // 
            // покупателиНаЗаданнуюДатуToolStripMenuItem
            // 
            this.покупателиНаЗаданнуюДатуToolStripMenuItem.Name = "покупателиНаЗаданнуюДатуToolStripMenuItem";
            this.покупателиНаЗаданнуюДатуToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.покупателиНаЗаданнуюДатуToolStripMenuItem.Text = "Покупатели на заданную дату";
            this.покупателиНаЗаданнуюДатуToolStripMenuItem.Click += new System.EventHandler(this.покупателиНаЗаданнуюДатуToolStripMenuItem_Click);
            // 
            // перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem
            // 
            this.перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem.Name = "перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem";
            this.перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem.Text = "Перекрестная таблица (скидка, наименование)";
            this.перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem.Click += new System.EventHandler(this.перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 649);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "Course Project";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблица1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблица2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданияSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкиСНаценкойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиНаЗаданнуюДатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перекрестнаяТаблицаскидкаНаименованиеToolStripMenuItem;
    }
}

