using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebTreugolnik
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool Prov(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0) return false;
            if (a + b <= c || a + c <= b || a + b <= a) return false;
            return true;
        }

        protected void BtnClick(object sender, EventArgs e)
        {
            double error=0;

            bool re = true;

            re = double.TryParse(a.Text, out error);
            re = double.TryParse(b.Text, out error);
            re = double.TryParse(c.Text, out error);

            if (re)
            {
                var A = Convert.ToDouble(a.Text);
                var B = Convert.ToDouble(b.Text);
                var C = Convert.ToDouble(c.Text);
                if (Prov(A, B, C))
                {
                    var p = (A + B + C) / 2;
                    var res = Math.Sqrt(p * ((p - A) * (p - B) * (p - C)));
                    result.Text = res.ToString();
                }
                else
                {
                    result.Text = "Некорректные данные";
                }
            }
            else { result.Text = "ввел буквы"; }
           

        }
    }
}