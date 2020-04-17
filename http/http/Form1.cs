using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace http
{
    public partial class Form1 : Form
    {
        public void Mon()
        {
            textBox2.Text = "0";
            string money;
            double akcii;
            for (int i = 0; i < всеАкцииDataGridView.RowCount - 1; i++)
            {
                for (int k = 0; k < dataGridView1.RowCount; k++)
                {
                    if (Convert.ToString(всеАкцииDataGridView.Rows[i].Cells[1].Value) == Convert.ToString(dataGridView1.Rows[k].Cells[0].Value))
                    {
                        akcii = Convert.ToDouble(всеАкцииDataGridView.Rows[i].Cells[2].Value);
                        money = dataGridView1.Rows[k].Cells[2].Value.ToString();
                        money = money.Replace(".", ",");
                        textBox2.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) + Convert.ToDouble(money) * akcii);
                    }

                }
            }
        }

        public decimal perevod(string money)
        {
            money = money.Replace(".", ",");
            return Convert.ToDecimal(money);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void деньгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.деньгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.economicDataSet);

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "economicDataSet.Сделки". При необходимости она может быть перемещена или удалена.
            this.сделкиTableAdapter.Fill(this.economicDataSet.Сделки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "economicDataSet.ВсеАкции". При необходимости она может быть перемещена или удалена.
            this.всеАкцииTableAdapter.Fill(this.economicDataSet.ВсеАкции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "economicDataSet.Деньги". При необходимости она может быть перемещена или удалена.
            this.деньгиTableAdapter.Fill(this.economicDataSet.Деньги);
            timer1.Start();
            timer2.Start();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Data = DateTime.Now;
            var Name = textBox4.Text;
            var Price = perevod(textBox5.Text);
            var Count = Convert.ToInt32(textBox6.Text);
            var a = economicDataSet.ВсеАкции.FirstOrDefault(b => b.Название_акции == Name);
            if (a == null)
            {
                всеАкцииTableAdapter.Insert(Name, Count);
            }
            else
            {
                всеАкцииTableAdapter.Update(Count, Name);
            }
            сделкиTableAdapter.Insert(Data, Name, Price, Count);
            деньгиTableAdapter.Update(-Price * Count);

            всеАкцииTableAdapter.Fill(economicDataSet.ВсеАкции);
            сделкиTableAdapter.Fill(economicDataSet.Сделки);
            деньгиTableAdapter.Fill(economicDataSet.Деньги);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox5.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(perevod(textBox5.Text) * perevod(textBox6.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox6_TextChanged(sender, e);
        }

        private void всеАкцииDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                textBox11.Text = всеАкцииDataGridView[1, всеАкцииDataGridView.CurrentRow.Index].Value.ToString();
                textBox10.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    var a = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    if (a == textBox11.Text) { textBox10.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value); }
                }
            }
            catch { }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToString(perevod(textBox10.Text) * Convert.ToInt32(textBox9.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Data = DateTime.Now;
            var Name = textBox11.Text;
            var Price = perevod(textBox10.Text);
            var Count = -Convert.ToInt32(textBox9.Text);
            var a = economicDataSet.ВсеАкции.FirstOrDefault(b => b.Количество_акций >= -Count && b.Название_акции == Name);
            if (a == null) return;
            if (a.Количество_акций == -Count)
            {
                всеАкцииTableAdapter.Delete(Name);
            }
            else
            {
                всеАкцииTableAdapter.Update(Count, Name);
            }
            сделкиTableAdapter.Insert(Data, Name, Price, Count);
            деньгиTableAdapter.Update(Price * (-Count));

            сделкиTableAdapter.Fill(economicDataSet.Сделки);
            деньгиTableAdapter.Fill(economicDataSet.Деньги);
            всеАкцииTableAdapter.Fill(economicDataSet.ВсеАкции);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5_Click(sender,e);
            var a = economicDataSet.Деньги.FirstOrDefault(x => x.Наличные_деньги > Convert.ToDecimal(500000));
            if (a == null) return;
            try
            {
                //int k = 0;
                string procent;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    procent = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    if (procent[0] == '-')
                    {
                        procent = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                        if (procent[0] == '+')
                        {

                            textBox4.Text = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            textBox5.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                            textBox6.Text = "30";
                            button3_Click(sender, e);
                            //i++;
                            //if (k > 10) break;
                        }
                    }

                }
            }
            catch { }
        }
        //продажа по клику
        private void button4_Click(object sender, EventArgs e)
        {
            string procent;
            for (int i = 0; i < всеАкцииDataGridView.RowCount - 1; i++)
            {
                for (int k = 0; k < dataGridView1.RowCount; k++)
                {
                    if (Convert.ToString(всеАкцииDataGridView.Rows[i].Cells[1].Value) == Convert.ToString(dataGridView1.Rows[k].Cells[0].Value))
                    {
                        procent = Convert.ToString(dataGridView1.Rows[k].Cells[6].Value);
                        if (procent[0] == '-')
                        {
                            textBox11.Text = всеАкцииDataGridView.Rows[i].Cells[1].Value.ToString();
                            textBox10.Text = dataGridView1.Rows[k].Cells[2].Value.ToString();
                            button2_Click(sender,e);
                        }

                    }

                }
            }
            Mon();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            HttpClient httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 2560000;
            try
            {
                string responseBodyAsText;
                string Buf2 = "";
                string Buf3 = "GTL";


                HttpResponseMessage response = await httpClient.GetAsync(textBox1.Text);
                response.EnsureSuccessStatusCode();


                responseBodyAsText = await response.Content.ReadAsStringAsync();

                int l2 = responseBodyAsText.Length;
                int l3 = Buf3.Length;
                int f = 0;
                for (int i = 0; i < l2; i++)
                {
                    f = 0;
                    for (int j = 0; j < l3; j++)
                    {
                        if (responseBodyAsText.Substring(i + j, 1) != Buf3.Substring(j, 1))
                        {
                            f = 1;
                            break;
                        } // if
                    } // for
                    if (f == 0)
                    {
                        Buf2 = responseBodyAsText.Substring(i, l2 - i);
                        l2 = Buf2.Length - l3;
                        break;
                    } // if
                } // for
                if (f == 1)
                {
                    return;
                    //listBox1->Items->Add(L"Не нашли");
                } // if

                int row = 0, col = 0, s = 0, l = 0;
                string c;
                string Str = "";
                dataGridView1.Rows.Add();
                for (int i = 1; i < l2; i++)
                {
                    c = Buf2.Substring(i, 1);
                    if (c == "<")
                    {
                        s++;
                        if (s == 1 && !(String.IsNullOrWhiteSpace(Str)))
                        {

                            if (col == 0)
                            {
                                dataGridView1.Rows.Add();
                            } // if 
                            dataGridView1.Rows[row].Cells[col].Value = Str.Trim();
                            col++;
                            if (col >= 9)
                            {
                                row++;
                                col = 0;

                            } // if
                            if (row > 156) break;
                        } // if
                    }
                    else if (c == ">")
                    {
                        s--;
                        Str = "";
                        l = 0;
                    }
                    else if (s == 0)
                    {
                        Str = Str + c;
                        l++;
                    } // else
                } // for
            }
            catch (HttpRequestException hre)
            {
               
            }
            catch (Exception ex)
            {
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //продажа каждые 10 секунд
            button5_Click(sender,e);
            button4_Click(sender,e);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //покупка каждые 20 секунд, если денег больше 500к
           
            button5_Click(sender,e);
            button1_Click(sender,e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var a = economicDataSet.Деньги.FirstOrDefault(x => x.Код ==1);
            textBox3.Text = Convert.ToString(a.Наличные_деньги + Convert.ToDecimal(textBox2.Text));
        }
    }
}
