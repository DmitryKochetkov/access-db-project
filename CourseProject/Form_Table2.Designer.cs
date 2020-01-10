namespace CourseProject
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
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.организацияОбслуживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблица2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new CourseProject.Database1DataSet();
            this.таблица2TableAdapter = new CourseProject.Database1DataSetTableAdapters.Таблица2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn,
            this.наименованиеТовараDataGridViewTextBoxColumn,
            this.стоимостьТовараDataGridViewTextBoxColumn,
            this.организацияОбслуживанияDataGridViewTextBoxColumn,
            this.наценкаDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.таблица2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "Код товара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            // 
            // наименованиеТовараDataGridViewTextBoxColumn
            // 
            this.наименованиеТовараDataGridViewTextBoxColumn.DataPropertyName = "Наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.Name = "наименованиеТовараDataGridViewTextBoxColumn";
            this.наименованиеТовараDataGridViewTextBoxColumn.Width = 150;
            // 
            // стоимостьТовараDataGridViewTextBoxColumn
            // 
            this.стоимостьТовараDataGridViewTextBoxColumn.DataPropertyName = "Стоимость товара";
            this.стоимостьТовараDataGridViewTextBoxColumn.HeaderText = "Стоимость товара";
            this.стоимостьТовараDataGridViewTextBoxColumn.Name = "стоимостьТовараDataGridViewTextBoxColumn";
            // 
            // организацияОбслуживанияDataGridViewTextBoxColumn
            // 
            this.организацияОбслуживанияDataGridViewTextBoxColumn.DataPropertyName = "Организация обслуживания";
            this.организацияОбслуживанияDataGridViewTextBoxColumn.HeaderText = "Организация обслуживания";
            this.организацияОбслуживанияDataGridViewTextBoxColumn.Name = "организацияОбслуживанияDataGridViewTextBoxColumn";
            // 
            // наценкаDataGridViewTextBoxColumn
            // 
            this.наценкаDataGridViewTextBoxColumn.DataPropertyName = "Наценка";
            this.наценкаDataGridViewTextBoxColumn.HeaderText = "Наценка";
            this.наценкаDataGridViewTextBoxColumn.Name = "наценкаDataGridViewTextBoxColumn";
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            // 
            // таблица2BindingSource
            // 
            this.таблица2BindingSource.DataMember = "Таблица2";
            this.таблица2BindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица2TableAdapter
            // 
            this.таблица2TableAdapter.ClearBeforeFill = true;
            // 
            // Form_Table2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 325);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Table2";
            this.Text = "Form_Table2";
            this.Load += new System.EventHandler(this.Form_Table2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource таблица2BindingSource;
        private Database1DataSetTableAdapters.Таблица2TableAdapter таблица2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn организацияОбслуживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
    }
}