using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPHelloWebForm
{
    public partial class WFProject3 : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 1;
            int number3;
            int series = Convert.ToInt32(TextBox1.Text);

            if (series == 1)
                Label3.Text = Convert.ToString(number1);
            else if (series == 2)
                Label3.Text = Convert.ToString(number2);
            else 
            { 
                for (int i = 2; i < series; i++)
                {
                    number3 = number1 + number2;
                    Label3.Text = Convert.ToString(number3);
                    number1 = number2;
                    number2 = number3;
                }
            }
        }
    }
}