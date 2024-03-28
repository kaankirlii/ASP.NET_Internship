using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPHelloWebForm
{
    public partial class WFProject5 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int guess=Convert.ToInt32(TextBox1.Text);
            switch (guess)
            {
                case 1: case 2: case 3: case 4: case 5:
                    Label2.Text = Convert.ToString("Try again! More than you guessed");
                    break;
                case 6:
                    Label2.Text = Convert.ToString("Wow! You guessed the number!");
                    break;
                case 7: case 8: case 9: case 10:
                    Label2.Text = Convert.ToString("Try again! Less than you guessed");
                    break;
                default:
                    Label2.Text = Convert.ToString("Please enter a number between 1 to 10!");
                    break;
            }
        }
    }
}