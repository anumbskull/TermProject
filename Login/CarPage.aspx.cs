using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServices;
using TermClasses;

namespace Login
{
    public partial class CarPage : System.Web.UI.Page
    {
        CarService carWS;
        Agency agencyclass;
        Car rentalcar;
        protected void Page_Load(object sender, EventArgs e)
        {
            carWS = new CarService();
            if (Session["login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnAgencySearch_Click(object sender, EventArgs e)
        {

            carWS = new CarService();
            gdvGetAgency.DataSource = carWS.GetRentalCarAgencies(txtCity.Text, ddlStateCreate.SelectedValue);
            gdvGetAgency.DataBind();
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            //TODO: Write code to find selected dealer, put dealer in an agency class and store that into session object. [DONE]
            //TODO: Test to make sure it works.

            agencyclass = new Agency();
            CheckBox CBox;
            for (int row = 0; row < gdvGetAgency.Rows.Count; row++)
            {
                CBox = (CheckBox)gdvGetAgency.Rows[row].FindControl("chkSelect");

                if (CBox.Checked)
                {
                    agencyclass.Agencyid = int.Parse(gdvGetAgency.Rows[row].Cells[1].Text);
                    agencyclass.Name = gdvGetAgency.Rows[row].Cells[2].Text;
                    agencyclass.City = gdvGetAgency.Rows[row].Cells[3].Text;
                    agencyclass.State = gdvGetAgency.Rows[row].Cells[4].Text;
                    Session["CarAgency"] = agencyclass;
                    break;
                }
            }
        }

        protected void btnCarSearch_Click(object sender, EventArgs e)
        {
            carWS = new CarService();

            String[] amenity = new String[] { txtNumDoors.Text, txtNumAirbags.Text, ddlPowerSteering.SelectedValue, txtNumSeats.Text, txtColor.Text, ddlGPS.SelectedValue };
            gdvFindCar.DataSource = carWS.FindCarsbyAgency(agencyclass.Agencyid, amenity, agencyclass.City, agencyclass.State);
            gdvFindCar.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TODO: Write code to find selected cars, and rent the car [Find Selected Cars = DONE]
            //TODO: Check to make sure it works.
            CheckBox CBox;
            carWS = new CarService();
            String rentresults = " ";
            for (int row = 0; row < gdvGetAgency.Rows.Count; row++)
            {
                CBox = (CheckBox)gdvFindCar.Rows[row].FindControl("chkCar");

                if (CBox.Checked)
                {
                    rentalcar = new Car();
                    rentalcar.Carid = int.Parse(gdvFindCar.Rows[row].Cells[1].Text);
                    rentalcar.Agencyid = int.Parse(gdvFindCar.Rows[row].Cells[2].Text);
                    rentalcar.Carmake = gdvFindCar.Rows[row].Cells[3].Text;
                    rentalcar.Carmodel = gdvFindCar.Rows[row].Cells[4].Text;

                    //rent the car
                    int custid = 0;
                    DateTime Start = new DateTime();
                    DateTime End = new DateTime();

                    if (carWS.Reserve(rentalcar.Agencyid, custid, rentalcar.Carid, Start, End))
                    {
                        rentresults = rentresults + " The Car, " + rentalcar.Carid + " was successfully rented.";
                    }
                    else
                    {
                        rentresults = rentresults + " The Car, " + rentalcar.Carid + " was not available during your requested time.";
                    }

                }
            }
            lblResults.Text = rentresults;
        }
    }
}