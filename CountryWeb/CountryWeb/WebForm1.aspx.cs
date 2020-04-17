using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_Cancel_OnClick(object sender, EventArgs e)
        {
            tb_Name.Text = "";
            tb_Area.Text = "";
        }

        protected void btn_Go_OnClick(object sender, EventArgs e)
        {
           Country.Country con =new Country.Country();
            try
            {
                con.Create(tb_Name.Text, ddl_Capital.Text, Convert.ToInt32(tb_Area.Text));
                lb_Result.Text = "OK";
            }
            catch (Exception exception)
            {
                lb_Result.Text = exception.Message;
            }
           
        }
    }
}