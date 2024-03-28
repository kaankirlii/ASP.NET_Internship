using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPHelloWebForm
{
    public partial class WFProject4 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i<=ListBox1.Items.Count-1;i++)
            {
                if (ListBox1.Items[i].Selected)
                {
                    ListBox2.Items.Add(ListBox1.Items[i]);
                }
            }
        }
    }
}