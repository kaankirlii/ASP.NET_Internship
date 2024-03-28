using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ASPHelloWebForm
{
    public partial class WFProject8 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, result = 0;
                n1 = Convert.ToInt32(TextBox1.Text);
                n2 = Convert.ToInt32(TextBox2.Text);
                result = n1 + n2;
                Label3.Text = "Total result is: "+result.ToString();
            }
            catch (Exception)
            {
                Label3.Text = "Please check out your inputs";
            }
        }
    }
}