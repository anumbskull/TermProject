using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServices;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;
using TermClasses;

namespace Project3
{
    public partial class Login : System.Web.UI.Page
    {
        TermProjectWS termWS;

        protected void Page_Load(object sender, EventArgs e)
        {
            termWS = new TermProjectWS();
            if (!IsPostBack)
            {
                if (Request.Cookies["CIS3342_Login"] != null)
                {
                    HttpCookie cookie = Request.Cookies["CIS3342_Login"];
                    txtUserName.Text = cookie.Values["User"].ToString();
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtNameCreate.Text = "";
            txtPassCreate.Text = "";
            txtRePassCreate.Text = "";
            txtUserCreate.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            lblErorUsCreate.Text = "";

            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text.Equals(""))
            {
                lblLoginError.Text = "You must have a Username";
                return;
            }
            else if (txtPassword.Text.Equals(""))
            {
                lblLoginError.Text = "You must have a password";
                return;
            }
            Customer cust = termWS.Login(txtUserName.Text, txtPassword.Text);
            if (cust != null)
            {
                Session["Cust"] = cust;
                if (rblCookies.SelectedValue.Equals("0"))
                {
                    HttpCookie myCookie = new HttpCookie("CIS3342_Login");
                    myCookie.Values["User"] = txtUserName.Text;
                    myCookie.Values["Pass"] = txtPassword.Text;
                    myCookie.Expires = new DateTime(3001, 1, 1);
                    Response.Cookies.Add(myCookie);
                }
                else if (rblCookies.SelectedValue.Equals("1"))
                {
                    HttpCookie myCookie = new HttpCookie("CIS3342_Login");
                    myCookie.Expires = DateTime.Now;
                    Response.Cookies.Add(myCookie);
                }
                Session["Login"] = txtUserName.Text;
                Response.Redirect("Main.aspx");
            }

            lblLoginError.Text = "Username and password combination is invalid";
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int temp;
            try
            {
                MailAddress m = new MailAddress(txtEmailCreate.Text);
            }
            catch
            {
                lblErorUsCreate.Text = "You must have a Valid Email";
                return;
            }
            if (txtNameCreate.Text.Equals(""))
            {
                lblErorUsCreate.Text = "You must have a Name";
                return;
            }
            else if (txtUserCreate.Text.Equals(""))
            {
                lblErorUsCreate.Text = "You must have a Username";
                return;
            }
            else if (txtPassCreate.Text.Equals("") || txtRePassCreate.Text.Equals(""))
            {
                lblErorUsCreate.Text = "You must have a password";
                return;
            }
            else if (!txtPassCreate.Text.Equals(txtRePassCreate.Text))
            {
                lblErorUsCreate.Text = "Both passwords must match";
                return;
            }
            else if (txtAddressCreate.Text.Equals(""))
            {
                lblErorUsCreate.Text = "You must have an Address";
                return;
            }
            else if (txtCityCreate.Text.Equals(""))
            {
                lblErorUsCreate.Text = "You must have a City";
                return;
            }
            else if (ddlStateCreate.SelectedIndex == 0)
            {
                lblErorUsCreate.Text = "You must have a State";
                return;
            }
            else if (txtZipCreate.Text.Equals(""))
            {
                lblErorUsCreate.Text = "You must have an Zip Code";
                return;
            }
            else if (!int.TryParse(txtZipCreate.Text, out temp) && txtZipCreate.Text.Length != 5)
            {
                lblErorUsCreate.Text = "You must use a valid Zip Code";
                return;
            }
            else if (txtEmailCreate.Text.Equals(""))
            {
                lblErorUsCreate.Text = "You must have an Email";
                return;
            }
            else
            {
                String name = txtNameCreate.Text;
                String user = txtUserCreate.Text;
                String pass = txtPassCreate.Text;
                String address = txtAddressCreate.Text;
                String city = txtCityCreate.Text;
                String state = ddlStateCreate.SelectedValue;
                int zip = int.Parse(txtZipCreate.Text);
                String email = txtEmailCreate.Text;

                if (termWS.FindUser(user) != -1)
                {
                    lblErorUsCreate.Text = "Username is already taken";
                    return;
                }
                Customer cust = new Customer();
                cust.Name = name;
                cust.Shipping = address;
                cust.City = city;
                cust.State = state;
                cust.Zip = zip;
                cust.Email = email;
                cust.CustID = -1;
                termWS.UserCreate(user, pass, cust);
                Session["Login"] = user;

                MultiView1.ActiveViewIndex = 2;
            }
        }

        protected void btnBackLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            lblLoginError.Text = "";

            MultiView1.ActiveViewIndex = 1;
        }


        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtNameCreate.Text = "";
            txtPassCreate.Text = "";
            txtRePassCreate.Text = "";
            txtUserCreate.Text = "";
            txtUserName.Text = "";
            lblErorUsCreate.Text = "";
        }

        }
    }
