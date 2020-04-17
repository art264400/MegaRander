using System;
using System.Windows.Forms;

namespace ConnectSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lessonProjectDataSet.link". При необходимости она может быть перемещена или удалена.
            this.linkTableAdapter.Fill(this.lessonProjectDataSet.link);

            //bindingNavigator1.BindingSource = dataGridView1.DataSource;
        }

        private void linkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.linkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lessonProjectDataSet);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lessonProjectDataSet1.all_product". При необходимости она может быть перемещена или удалена.
            this.all_productTableAdapter.Fill(this.lessonProjectDataSet1.all_product);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
