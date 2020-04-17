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
    public partial class addClient : Form
    {
        bool _Rc;
        public bool Rc { get { return _Rc; } }
        public string FIO//фил
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public addClient()
        {
            
            InitializeComponent();
            _Rc = false;//по умолчанию _Rc=false
        }

        private void button1_Click(object sender, EventArgs e)//по нажатии ок
        {
            _Rc = true;//если нажата кнопка ок, то _Rc=true
            Close();//закрываем форму

        }

        private void button2_Click(object sender, EventArgs e)//по нажатии отмена
        {
            Close();//закрываем форму
        }
    }
}
