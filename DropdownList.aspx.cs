using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.Data.SqlClient;

namespace Asp.Net
{
    public partial class DropdownList : System.Web.UI.Page
    {
        // protected void Page_Error(object sender, EventArgs e)
        // {
        //     Exception Error = Server.GetLastError();
        //     Server.ClearError();
        //     Response.Redirect("~/OpinionShow.aspx?ComplimentaryRemark=An error has occured and logged, to be soon fixed.&Opinion=" + Error.Message);
        // }

        protected void Page_Load(object sender, EventArgs e)
        {
            SelectButton.Text = "Select";

            if (!Page.IsPostBack)
            {

                Trace.Warn("Suits Population Started");
                ListItem SelectHanger = new ListItem("Select", "-1");
                SuitsList.Items.Add(SelectHanger);

                Response.Write("A dropdown for suits");
                ListItem First = new ListItem("Mark 1", "1");
                SuitsList.Items.Add(First);
                First.Enabled = false;

                for (int iteration = 2; iteration < 86; iteration++)
                {
                    ListItem Current = new ListItem(String.Format("Mark {0}", iteration), iteration.ToString());
                    SuitsList.Items.Add(Current);
                }

                if (SuitsList.Items.Count > 0)
                {
                    SuitsList.ClearSelection();
                    SuitsList.Items[SuitsList.Items.Count - 1].Selected = true;
                }
                Trace.Warn("Suits Population Ended");

                Trace.Warn("Employees Population Started");

                string ConnectionString = "data source=DESKTOP-KMKAHQA\\SQLEXPRESS01; database=AdoStore; integrated security=SSPI; TrustServerCertificate=true;";

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand Command = new SqlCommand("Select EmployeeName from Employees", Connection);
                    Connection.Open();
                    EmployeesList.DataSource = Command.ExecuteReader();
                    EmployeesList.DataTextField = "EmployeeName";
                    EmployeesList.DataValueField = "EmployeeName";
                    EmployeesList.DataBind();
                }

                Trace.Warn("Employees Population Ended");

                Trace.Warn("Countries Population Started");

                DataSet CountriesDataset = new DataSet();
                CountriesDataset.ReadXml(Server.MapPath("~/Countries.xml"));
                CountriesList.DataTextField = "CountryName";
                CountriesList.DataValueField = "CountryId";
                CountriesList.DataSource = CountriesDataset;
                CountriesList.DataBind();

                Trace.Warn("Countries Population Ended");

                // try
                // {
                //     DataSet CountriesDataset = new DataSet();
                //     CountriesDataset.ReadXml(Server.MapPath("~/Countries.xml"));
                //     CountriesList.DataTextField = "CountryName";
                //     CountriesList.DataValueField = "CountryId";
                //     CountriesList.DataSource = CountriesDataset;
                //     CountriesList.DataBind();
                // }
                // catch(System.IO.FileNotFoundException FileNotFoundError)
                // {
                //     Response.Write("The xml file with the data is missing.");
                // }
                // catch(Exception Error)
                // {
                //     Response.Write("An unknown error occured, which is logged and will be fixed in the near future.");
                // }
                // finally
                // {
                //     Response.Write("Finally, I would like to thank you.");
                // }

            }
        }

        protected void SelectButton_Click(object sender, EventArgs e)
        {
            if (SuitsList.SelectedIndex == 0)
            {
                Response.Write("Please select a valid suit mark.");
            }
            else
            {
                if(SuitsList.SelectedItem.Text == "Mark 50")
                {
                    Response.Write("Its made of nanotech, you like it?");
                }
                else{
                    Response.Write(String.Format("Mark {0} was good but mark 50 was one of its kind.", SuitsList.SelectedValue));
                }
            }
        }
    }
}