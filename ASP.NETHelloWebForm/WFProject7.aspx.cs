using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPHelloWebForm
{
    public partial class WFProject7 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int listBoxIndex = Convert.ToInt32(ListBox1.SelectedIndex);
            if (ListBox1.SelectedIndex == 0)
                Image1.ImageUrl = "~/red.png";
            else if (ListBox1.SelectedIndex == 1)
                Image1.ImageUrl = "~/green.png";
            else if (ListBox1.SelectedIndex == 2)
                Image1.ImageUrl = "~/blue.png";
        }
    }
}