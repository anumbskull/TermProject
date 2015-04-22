using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using TermClasses;

namespace WebServices
{
    /// <summary>
    /// Summary description for TermProjectWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TermProjectWS : System.Web.Services.WebService
    {
        DBConnect objDB = new DBConnect();

        [WebMethod]
        public Customer Login(String user, String pass)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Login";

            SqlParameter inputParameter = new SqlParameter("@user", user);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@pass", pass);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            Customer cust = new Customer();

            if (myDS.Tables[0].Rows.Count != 0)
            {
                cust.Name = myDS.Tables[0].Rows[0]["CustomerName"].ToString();
                cust.Email = myDS.Tables[0].Rows[0]["EmailAddress"].ToString();
                cust.Shipping = myDS.Tables[0].Rows[0]["ShippingAddress"].ToString();
                cust.City = myDS.Tables[0].Rows[0]["City"].ToString();
                cust.State = myDS.Tables[0].Rows[0]["State"].ToString();
                cust.Zip = (int)myDS.Tables[0].Rows[0]["Zip"];
                cust.CustID = (int)myDS.Tables[0].Rows[0]["CustomerID"];
                return cust;
            }
            else
            {
                return null;
            }
        }

        [WebMethod]
        public int FindUser(String user)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CheckUser";

            SqlParameter inputParameter = new SqlParameter("@user", user);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            if (myDS.Tables[0].Rows.Count != 0)
            {
                return int.Parse(myDS.Tables[0].Rows[0]["CustomerID"].ToString());
            }
            else
            {
                return -1;
            }
        }

        [WebMethod]
        public int UserCreate(String user, String pass, Customer cust)
        {
            int pepe = FindUser(user);

            if (pepe != -1)
            {
                return pepe;
            }
            else
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "AddUser";

                SqlParameter inputParameter = new SqlParameter("@user", user);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@pass", pass);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@name", cust.Name);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@address", cust.Shipping);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@city", cust.City);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@state", cust.State);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@zip", cust.Zip);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Int;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@email", cust.Email);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                objDB.DoUpdateUsingCmdObj(objCommand);

                pepe = FindUser(user);

                return pepe;
            }
        }
    }
}
