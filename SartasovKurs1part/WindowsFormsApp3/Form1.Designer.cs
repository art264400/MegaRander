namespace WindowsFormsApp3
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.клиенты2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиенты2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new WindowsFormsApp3.dataBaseDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.работы2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудники2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet1 = new WindowsFormsApp3.dataBaseDataSet();
            this.работы2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.клиенты2TableAdapter = new WindowsFormsApp3.dataBaseDataSetTableAdapters.Клиенты2TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.dataBaseDataSetTableAdapters.TableAdapterManager();
            this.работы2TableAdapter = new WindowsFormsApp3.dataBaseDataSetTableAdapters.Работы2TableAdapter();
            this.сотрудники2TableAdapter = new WindowsFormsApp3.dataBaseDataSetTableAdapters.Сотрудники2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.клиенты2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиенты2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работы2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работы2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // клиенты2DataGridView
            // 
            this.клиенты2DataGridView.AutoGenerateColumns = false;
            this.клиенты2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиенты2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.клиенты2DataGridView.DataSource = this.клиенты2BindingSource;
            this.клиенты2DataGridView.Location = new System.Drawing.Point(12, 12);
            this.клиенты2DataGridView.Name = "клиенты2DataGridView";
            this.клиенты2DataGridView.Size = new System.Drawing.Size(351, 116);
            this.клиенты2DataGridView.TabIndex = 1;
            this.клиенты2DataGridView.SelectionChanged += new System.EventHandler(this.клиенты2DataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_клиента";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // клиенты2BindingSource
            // 
            this.клиенты2BindingSource.DataMember = "Клиенты2";
            this.клиенты2BindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "dataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // работы2DataGridView
            // 
            this.работы2DataGridView.AutoGenerateColumns = false;
            this.работы2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.работы2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn6});
            this.работы2DataGridView.DataSource = this.работы2BindingSource;
            this.работы2DataGridView.Location = new System.Drawing.Point(12, 185);
            this.работы2DataGridView.Name = "работы2DataGridView";
            this.работы2DataGridView.Size = new System.Drawing.Size(758, 220);
            this.работы2DataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код_работы";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код_работы";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименовине";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименовине";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Время_выполнения";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время_выполнения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Код_клиента";
            this.dataGridViewTextBoxColumn7.HeaderText = "Код_клиента";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Дата_заказа";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата_заказа";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Адрес_заказа";
            this.dataGridViewTextBoxColumn9.HeaderText = "Адрес_заказа";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код_сотрудника";
            this.dataGridViewTextBoxColumn6.DataSource = this.сотрудники2BindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "ФИО";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код_сотрудника";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Код_сотрудника";
            // 
            // сотрудники2BindingSource
            // 
            this.сотрудники2BindingSource.DataMember = "Сотрудники2";
            this.сотрудники2BindingSource.DataSource = this.dataBaseDataSet1;
            // 
            // dataBaseDataSet1
            // 
            this.dataBaseDataSet1.DataSetName = "dataBaseDataSet";
            this.dataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работы2BindingSource
            // 
            this.работы2BindingSource.DataMember = "Работы2";
            this.работы2BindingSource.DataSource = this.dataBaseDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(94, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(175, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(369, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "В ЭКСЕЛЬ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(268, 156);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "В ЭКСЕЛЬ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(369, 128);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = " В ВОРД";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(462, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 39);
            this.button10.TabIndex = 11;
            this.button10.Text = "все сотрудники";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // клиенты2TableAdapter
            // 
            this.клиенты2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.dataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Клиенты2TableAdapter = this.клиенты2TableAdapter;
            this.tableAdapterManager.Работы2TableAdapter = null;
            this.tableAdapterManager.Сотрудники2TableAdapter = null;
            // 
            // работы2TableAdapter
            // 
            this.работы2TableAdapter.ClearBeforeFill = true;
            // 
            // сотрудники2TableAdapter
            // 
            this.сотрудники2TableAdapter.ClearBeforeFill = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.работы2DataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.клиенты2DataGridView);
            this.Name = "Client";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клиенты2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиенты2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работы2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работы2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource клиенты2BindingSource;
        private dataBaseDataSetTableAdapters.Клиенты2TableAdapter клиенты2TableAdapter;
        private dataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView клиенты2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource работы2BindingSource;
        private dataBaseDataSetTableAdapters.Работы2TableAdapter работы2TableAdapter;
        private System.Windows.Forms.DataGridView работы2DataGridView;
        private dataBaseDataSet dataBaseDataSet1;
        private System.Windows.Forms.BindingSource сотрудники2BindingSource;
        private dataBaseDataSetTableAdapters.Сотрудники2TableAdapter сотрудники2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

