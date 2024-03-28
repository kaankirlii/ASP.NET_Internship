using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPHelloWebForm
{
    public partial class WFProject2 : System.Web.UI.Page
    {
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(TextBox1.Text);
            int fact = 1;

            if (number == 0 || number ==1) {
                Label3.Text = Convert.ToString(1);
            }
            else {
                while (number>=2)
                {
                    fact *= number;
                    number--;
                }
                Label3.Text = Convert.ToString(fact);
            } 
        }
    }
}