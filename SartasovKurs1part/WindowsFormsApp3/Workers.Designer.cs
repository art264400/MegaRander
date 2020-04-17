namespace WindowsFormsApp3
{
    partial class Workers
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
            this.dataBaseDataSet = new WindowsFormsApp3.dataBaseDataSet();
            this.сотрудники2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудники2TableAdapter = new WindowsFormsApp3.dataBaseDataSetTableAdapters.Сотрудники2TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.dataBaseDataSetTableAdapters.TableAdapterManager();
            this.клиенты2TableAdapter = new WindowsFormsApp3.dataBaseDataSetTableAdapters.Клиенты2TableAdapter();
            this.работы2TableAdapter = new WindowsFormsApp3.dataBaseDataSetTableAdapters.Работы2TableAdapter();
            this.сотрудники2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.работы2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работы2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.клиенты2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работы2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работы2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиенты2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "dataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудники2BindingSource
            // 
            this.сотрудники2BindingSource.DataMember = "Сотрудники2";
            this.сотрудники2BindingSource.DataSource = this.dataBaseDataSet;
            // 
            // сотрудники2TableAdapter
            // 
            this.сотрудники2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.dataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Клиенты2TableAdapter = this.клиенты2TableAdapter;
            this.tableAdapterManager.Работы2TableAdapter = this.работы2TableAdapter;
            this.tableAdapterManager.Сотрудники2TableAdapter = this.сотрудники2TableAdapter;
            // 
            // клиенты2TableAdapter
            // 
            this.клиенты2TableAdapter.ClearBeforeFill = true;
            // 
            // работы2TableAdapter
            // 
            this.работы2TableAdapter.ClearBeforeFill = true;
            // 
            // сотрудники2DataGridView
            // 
            this.сотрудники2DataGridView.AutoGenerateColumns = false;
            this.сотрудники2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сотрудники2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.сотрудники2DataGridView.DataSource = this.сотрудники2BindingSource;
            this.сотрудники2DataGridView.Location = new System.Drawing.Point(12, 12);
            this.сотрудники2DataGridView.Name = "сотрудники2DataGridView";
            this.сотрудники2DataGridView.Size = new System.Drawing.Size(481, 149);
            this.сотрудники2DataGridView.TabIndex = 1;
            this.сотрудники2DataGridView.SelectionChanged += new System.EventHandler(this.сотрудники2DataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_сотрудника";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Образование";
            this.dataGridViewTextBoxColumn3.HeaderText = "Образование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Квалификация";
            this.dataGridViewTextBoxColumn4.HeaderText = "Квалификация";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // работы2BindingSource
            // 
            this.работы2BindingSource.DataMember = "Работы2";
            this.работы2BindingSource.DataSource = this.dataBaseDataSet;
            // 
            // работы2DataGridView
            // 
            this.работы2DataGridView.AutoGenerateColumns = false;
            this.работы2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.работы2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.работы2DataGridView.DataSource = this.работы2BindingSource;
            this.работы2DataGridView.Location = new System.Drawing.Point(12, 215);
            this.работы2DataGridView.Name = "работы2DataGridView";
            this.работы2DataGridView.Size = new System.Drawing.Size(728, 220);
            this.работы2DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код_работы";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код_работы";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Наименовине";
            this.dataGridViewTextBoxColumn6.HeaderText = "Наименовине";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Время_выполнения";
            this.dataGridViewTextBoxColumn7.HeaderText = "Время_выполнения";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код_сотрудника";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код_сотрудника";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Код_клиента";
            this.dataGridViewTextBoxColumn9.DataSource = this.клиенты2BindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "ФИО";
            this.dataGridViewTextBoxColumn9.HeaderText = "Код_клиента";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "Код_клиента";
            // 
            // клиенты2BindingSource
            // 
            this.клиенты2BindingSource.DataMember = "Клиенты2";
            this.клиенты2BindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Дата_заказа";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата_заказа";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Адрес_заказа";
            this.dataGridViewTextBoxColumn11.HeaderText = "Адрес_заказа";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "изменить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(500, 129);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = " В ВОРД";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(500, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "В ЭКСЕЛЬ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(255, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "В ЭКСЕЛЬ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 463);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.работы2DataGridView);
            this.Controls.Add(this.сотрудники2DataGridView);
            this.Name = "Workers";
            this.Text = "Workers";
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работы2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работы2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиенты2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource сотрудники2BindingSource;
        private dataBaseDataSetTableAdapters.Сотрудники2TableAdapter сотрудники2TableAdapter;
        private dataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView сотрудники2DataGridView;
        private dataBaseDataSetTableAdapters.Работы2TableAdapter работы2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource работы2BindingSource;
        private dataBaseDataSetTableAdapters.Клиенты2TableAdapter клиенты2TableAdapter;
        private System.Windows.Forms.DataGridView работы2DataGridView;
        private System.Windows.Forms.BindingSource клиенты2BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}