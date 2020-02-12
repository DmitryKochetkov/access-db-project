namespace CourseProject2
{
    partial class Form_Task2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton_Program = new System.Windows.Forms.RadioButton();
            this.radioButton_SQL = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet1 = new CourseProject2.Database1DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 290);
            this.dataGridView1.TabIndex = 20;
            // 
            // radioButton_Program
            // 
            this.radioButton_Program.AutoSize = true;
            this.radioButton_Program.Location = new System.Drawing.Point(193, 78);
            this.radioButton_Program.Name = "radioButton_Program";
            this.radioButton_Program.Size = new System.Drawing.Size(90, 17);
            this.radioButton_Program.TabIndex = 19;
            this.radioButton_Program.TabStop = true;
            this.radioButton_Program.Text = "Программно";
            this.radioButton_Program.UseVisualStyleBackColor = true;
            // 
            // radioButton_SQL
            // 
            this.radioButton_SQL.AutoSize = true;
            this.radioButton_SQL.Location = new System.Drawing.Point(193, 46);
            this.radioButton_SQL.Name = "radioButton_SQL";
            this.radioButton_SQL.Size = new System.Drawing.Size(113, 17);
            this.radioButton_SQL.TabIndex = 18;
            this.radioButton_SQL.TabStop = true;
            this.radioButton_SQL.Text = "При помощи SQL";
            this.radioButton_SQL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выборка:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Показать информацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form_Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton_Program);
            this.Controls.Add(this.radioButton_SQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Form_Task2";
            this.Text = "Задание 2 (информация об отделах)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton_Program;
        private System.Windows.Forms.RadioButton radioButton_SQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet1;
    }
}