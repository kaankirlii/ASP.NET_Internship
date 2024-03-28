using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPHelloWebForm
{
    public partial class WFProject1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            double number1, number2, result = 0;
            number1 = Convert.ToDouble(TextBox1.Text);
            number2 = Convert.ToDouble(TextBox2.Text);

            if (RadioButton1.Checked)
            {
                result = number1 + number2;
            }
            else if (RadioButton2.Checked)
            {
                result = number1 - number2;
            }
            else if (RadioButton3.Checked)
            {
                result = number1 * number2;
            }
            else if(RadioButton4.Checked)
            {
                result = number1 / number2;
            }

            Label1.Text = result.ToString();
        }

    }
}