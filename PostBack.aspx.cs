using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class PostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCitiesInList();
            }
        }

        protected void CitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("City selected.");
        }

        private void LoadCitiesInList()
        {
            // CitiesList.Items.Clear();

            ListItem Karachi = new ListItem("Karachi");
            ListItem Lahore = new ListItem("Lahore");
            ListItem Islamabad = new ListItem("Islamabad");

            CitiesList.Items.Add(Karachi);
            CitiesList.Items.Add(Lahore);
            CitiesList.Items.Add(Islamabad);
        }
    }
}