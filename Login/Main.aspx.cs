using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServices;

namespace Login
{
    public partial class Main : System.Web.UI.Page
    {
        //CarService carWS;
        protected void Page_Load(object sender, EventArgs e)
        {
            //carWS = new CarService();
            //if (Session["login"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            //else
            //{
            //    gdvGetAgency.DataSource = carWS.GetRentalCarAgencies("Philly", "PA");
            //    gdvGetAgency.DataBind();

            //    gdvGetCarByAgency.DataSource = carWS.GetCarsByAgency(2, "Las Vegas", "NV");
            //    gdvGetCarByAgency.DataBind();

            //    String[] amenity = new String[] {"1","2","true","5","red","false"};

            //    gdvFindCarByAmenity.DataSource = carWS.FindCars(amenity, "Las Vegas", "NV");
            //    gdvFindCarByAmenity.DataBind();

            //    amenity = new String[] {"0","0","true","0","",""};

            //    gdvFindCarByAgencyANDAmenity.DataSource = carWS.FindCarsbyAgency(2, amenity, "Las Vegas", "NV");
            //    gdvFindCarByAgencyANDAmenity.DataBind();

            //    //lblReserveOutcome.Text = carWS.Reserve(1,1,1,DateTime.Now, DateTime.Now.AddYears(4)).ToString();

            //    gdvGetCust.DataSource = carWS.findCustomer(1, "NHMM", "Brewer");
            //    gdvGetCust.DataBind();
            //}
        }

        protected void btnCar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CarPage.aspx");
        }
    }
}