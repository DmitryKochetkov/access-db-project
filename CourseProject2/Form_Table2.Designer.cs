namespace CourseProject2
{
    partial class Form_Table2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new CourseProject2.Database1DataSet();
            this.таблица2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблица2TableAdapter = new CourseProject2.Database1DataSetTableAdapters.Таблица2TableAdapter();
            this.номерОтделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеОтделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОРуководителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонРуководителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерОтделаDataGridViewTextBoxColumn,
            this.названиеОтделаDataGridViewTextBoxColumn,
            this.фИОРуководителяDataGridViewTextBoxColumn,
            this.телефонРуководителяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.таблица2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица2BindingSource
            // 
            this.таблица2BindingSource.DataMember = "Таблица2";
            this.таблица2BindingSource.DataSource = this.database1DataSet;
            // 
            // таблица2TableAdapter
            // 
            this.таблица2TableAdapter.ClearBeforeFill = true;
            // 
            // номерОтделаDataGridViewTextBoxColumn
            // 
            this.номерОтделаDataGridViewTextBoxColumn.DataPropertyName = "Номер отдела";
            this.номерОтделаDataGridViewTextBoxColumn.HeaderText = "Номер отдела";
            this.номерОтделаDataGridViewTextBoxColumn.Name = "номерОтделаDataGridViewTextBoxColumn";
            this.номерОтделаDataGridViewTextBoxColumn.Width = 70;
            // 
            // названиеОтделаDataGridViewTextBoxColumn
            // 
            this.названиеОтделаDataGridViewTextBoxColumn.DataPropertyName = "Название отдела";
            this.названиеОтделаDataGridViewTextBoxColumn.HeaderText = "Название отдела";
            this.названиеОтделаDataGridViewTextBoxColumn.Name = "названиеОтделаDataGridViewTextBoxColumn";
            this.названиеОтделаDataGridViewTextBoxColumn.Width = 200;
            // 
            // фИОРуководителяDataGridViewTextBoxColumn
            // 
            this.фИОРуководителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО руководителя";
            this.фИОРуководителяDataGridViewTextBoxColumn.HeaderText = "ФИО руководителя";
            this.фИОРуководителяDataGridViewTextBoxColumn.Name = "фИОРуководителяDataGridViewTextBoxColumn";
            this.фИОРуководителяDataGridViewTextBoxColumn.Width = 200;
            // 
            // телефонРуководителяDataGridViewTextBoxColumn
            // 
            this.телефонРуководителяDataGridViewTextBoxColumn.DataPropertyName = "Телефон руководителя";
            this.телефонРуководителяDataGridViewTextBoxColumn.HeaderText = "Телефон руководителя";
            this.телефонРуководителяDataGridViewTextBoxColumn.Name = "телефонРуководителяDataGridViewTextBoxColumn";
            this.телефонРуководителяDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_Table2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 360);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Table2";
            this.Text = "Таблица 2";
            this.Load += new System.EventHandler(this.Form_Table2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource таблица2BindingSource;
        private Database1DataSetTableAdapters.Таблица2TableAdapter таблица2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОРуководителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонРуководителяDataGridViewTextBoxColumn;
    }
}