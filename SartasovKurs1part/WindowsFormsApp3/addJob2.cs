using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class addJob2 : Form
    {
        bool _Rc;
        public bool Rc { get { return _Rc; } }
        public string JobName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public int Times
        {
            get { return Convert.ToInt32(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }
        public string Adress
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Client_Id
        {
            get { return Convert.ToInt32(comboBox1.SelectedValue); }
            set { comboBox1.SelectedValue = value; }
        }

        public DateTime Date
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public addJob2()
        {
            InitializeComponent();
            _Rc = false;
        }

        private void addJob2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Клиенты2". При необходимости она может быть перемещена или удалена.
            this.клиенты2TableAdapter.Fill(this.dataBaseDataSet.Клиенты2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Rc = true;
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
