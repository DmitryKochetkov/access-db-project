namespace CourseProject2
{
    partial class Form_Task1
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
            this.radioButton_Program = new System.Windows.Forms.RadioButton();
            this.radioButton_SQL = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_Program
            // 
            this.radioButton_Program.AutoSize = true;
            this.radioButton_Program.Location = new System.Drawing.Point(94, 112);
            this.radioButton_Program.Name = "radioButton_Program";
            this.radioButton_Program.Size = new System.Drawing.Size(90, 17);
            this.radioButton_Program.TabIndex = 14;
            this.radioButton_Program.TabStop = true;
            this.radioButton_Program.Text = "Программно";
            this.radioButton_Program.UseVisualStyleBackColor = true;
            // 
            // radioButton_SQL
            // 
            this.radioButton_SQL.AutoSize = true;
            this.radioButton_SQL.Location = new System.Drawing.Point(94, 80);
            this.radioButton_SQL.Name = "radioButton_SQL";
            this.radioButton_SQL.Size = new System.Drawing.Size(113, 17);
            this.radioButton_SQL.TabIndex = 13;
            this.radioButton_SQL.TabStop = true;
            this.radioButton_SQL.Text = "При помощи SQL";
            this.radioButton_SQL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выборка:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Показать работников";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 290);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Должность:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Form_Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 493);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton_Program);
            this.Controls.Add(this.radioButton_SQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Form_Task1";
            this.Text = "Задание 1 (работники с заданной должностью)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Program;
        private System.Windows.Forms.RadioButton radioButton_SQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}