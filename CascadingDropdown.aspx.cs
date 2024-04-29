using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class CascadingDropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ContinentsList.AutoPostBack = true;
                CountriesList.AutoPostBack = true;
                CitiesList.AutoPostBack = true;

                DataSet ContinentsDataset = GetData("SPGetContinents", null);

                ContinentsList.DataSource = ContinentsDataset;
                ContinentsList.DataTextField = "ContinentName";
                ContinentsList.DataValueField = "ContinentId";
                ContinentsList.DataBind();
                
                ListItem SelectContinentItem = new ListItem("Select continent", "-1");
                ContinentsList.Items.Insert(0, SelectContinentItem);

                ListItem SelectCountryItem = new ListItem("Select country", "-1");
                CountriesList.Items.Add(SelectCountryItem);
                CountriesList.Enabled = false;

                ListItem SelectCityItem = new ListItem("Select city", "-1");
                CitiesList.Items.Add(SelectCityItem);
                CitiesList.Enabled = false;
            }
        }

        private DataSet GetData(string StoredProcedureName, SqlParameter StoredProcedureParameter)
        {
            string ConnectionString = "data source=DESKTOP-KMKAHQA\\SQLEXPRESS01; database=AdoStore; integrated security=SSPI; TrustServerCertificate=true;";
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter Adapter = new SqlDataAdapter(StoredProcedureName, Connection);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (StoredProcedureParameter != null) {
                    Adapter.SelectCommand.Parameters.Add(StoredProcedureParameter);
                }
                DataSet Dataset = new DataSet();
                Adapter.Fill(Dataset);
                return Dataset;
            }
        }

        protected void ContinentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ContinentsList.SelectedValue == "-1")
            {
                CountriesList.Items.Clear();
                CountriesList.Enabled = false;

                ListItem SelectCountryItem = new ListItem("Select country", "-1");
                CountriesList.Items.Insert(0, SelectCountryItem);

                CitiesList.Items.Clear();
                CitiesList.Enabled = false;

                ListItem SelectCityItem = new ListItem("Select city", "-1");
                CitiesList.Items.Insert(0, SelectCityItem);
            }
            else
            {
                SqlParameter ContinentIdParameter = new SqlParameter("@ContinentId", ContinentsList.SelectedValue);
                DataSet CountriesDataset = GetData("SPGetCountries", ContinentIdParameter);

                CountriesList.DataSource = CountriesDataset;
                CountriesList.DataTextField = "CountryName";
                CountriesList.DataValueField = "CountryId";
                CountriesList.DataBind();

                ListItem SelectCountryItem = new ListItem("Select country", "-1");
                CountriesList.Items.Insert(0, SelectCountryItem);
                CountriesList.Enabled = true;

                CitiesList.Items.Clear();
                CitiesList.Enabled = false;

                ListItem SelectCityItem = new ListItem("Select city", "-1");
                CitiesList.Items.Insert(0, SelectCityItem);
            }
        }

        protected void CountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountriesList.SelectedValue == "-1")
            {
                CitiesList.Items.Clear();
                CitiesList.Enabled = false;

                ListItem SelectCityItem = new ListItem("Select city", "-1");
                CitiesList.Items.Insert(0, SelectCityItem);
            }
            else
            {
                SqlParameter CountryIdParameter = new SqlParameter("@CountryId", CountriesList.SelectedValue);
                DataSet CitiesDataset = GetData("SPGetCities", CountryIdParameter);

                CitiesList.DataSource = CitiesDataset;
                CitiesList.DataTextField = "CityName";
                CitiesList.DataValueField = "CityId";
                CitiesList.DataBind();

                ListItem SelectCityItem = new ListItem("Select city", "-1");
                CitiesList.Items.Insert(0, SelectCityItem);
                CitiesList.Enabled = true;
            }
        }

        protected void CitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}