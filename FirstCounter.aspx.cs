using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class FirstCounter : System.Web.UI.Page
    {

        // int Counts = 0;
        // protected void Page_Load(object sender, EventArgs e)
        // {
        //     if (!IsPostBack) {
        //         Counter.Text = "0";
        //     }
        // }
        // 
        // protected void Count_Click(object sender, EventArgs e)
        // {
        //     Counts = Counts + 1;
        //     Counter.Text = Counts.ToString();
        // }

        // Second Method

        // int Counts = 1;
        // 
        // protected void Page_Load(object sender, EventArgs e)
        // {
        //     if (!IsPostBack)
        //     {
        //         Counter.Text = "0";
        //     }
        // }
        // 
        // protected void Count_Click(object sender, EventArgs e)
        // {
        //     if(ViewState["Counts"] != null)
        //     {
        //         Counts = (int)ViewState["Counts"] + 1;
        //     }
        //     Counter.Text = Counts.ToString();
        //     ViewState["Counts"] = Counts;
        // }

        // Third Method

        // protected void Page_Load(object sender, EventArgs e)
        // {
        //     if (!IsPostBack)
        //     {
        //         Counter.Text = "0";
        //     }
        // }
        // 
        // protected void Count_Click(object sender, EventArgs e)
        // {
        //     int Counts = Convert.ToInt32(Counter.Text) + 1;
        //     Counter.Text = Counts.ToString();
        // }

        // Difference between html input and asp .net control is of runat="server" property

        // protected void Page_Load(object sender, EventArgs e)
        // {
        // }
        // 
        // protected void Test_Click(object sender, EventArgs e)
        // {
        // }

        // Same Counter Across A Session

        // int Counts = 0;
        // 
        // protected void Page_Load(object sender, EventArgs e)
        // {
        //     if (!IsPostBack)
        //     {
        //         if (Session["Counts"] != null)
        //         {
        //             Counts = (int)Session["Counts"];
        //         }
        //         Counter.Text = Counts.ToString();
        //         Session["Counts"] = Counts;
        //     }
        // }
        // 
        // protected void Count_Click(object sender, EventArgs e)
        // {
        //     if (Session["Counts"] != null)
        //     {
        //         Counts = (int)Session["Counts"] + 1;
        //     }
        //     Counter.Text = Counts.ToString();
        //     Session["Counts"] = Counts;
        // }

        // Same Counter Across The Application

        int Counts = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["Counts"] != null)
                {
                    Counts = (int)Application["Counts"];
                }
                Counter.Text = Counts.ToString();
                Application["Counts"] = Counts;
            }
        }

        protected void Count_Click(object sender, EventArgs e)
        {
            if (Application["Counts"] != null)
            {
                Counts = (int)Application["Counts"] + 1;
            }
            Counter.Text = Counts.ToString();
            Application["Counts"] = Counts;
        }

    }
}