using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;
using System.Data;
using System.Data.SqlClient;

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
        public bool Login(String user, String pass)
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

            if (myDS.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool UserCreate(String user, String pass, String name, String address, String city, String state, int zip, String email)
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
                return false;
            }
            else
            {
                objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "AddUser";

                inputParameter = new SqlParameter("@user", user);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@pass", pass);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@name", name);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@address", address);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@city", city);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@state", state);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@zip", zip);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Int;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@email", email);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NVarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                objDB.DoUpdateUsingCmdObj(objCommand);

                return true;
            }
        }
    }
}
