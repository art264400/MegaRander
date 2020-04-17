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
    public partial class addWorker : Form
    {
        bool _Rc;
        public bool Rc { get { return _Rc; } }
        public string FIO
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Education
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string Qualification
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public addWorker()
        {
            InitializeComponent();
            _Rc = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
