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
    /// Summary description for CarService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarService : System.Web.Services.WebService
    {
        String Mark = "Mark";
        String Nick = "Nick";

        DBConnect objDB = new DBConnect();

        [WebMethod]
        public DataSet GetRentalCarAgencies(String city, String state) 
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetRentalCarAgencies";

            SqlParameter inputParameter = new SqlParameter("@city", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@state", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet GetCarsByAgency(int agency, String city, String state)
        {
            //WORKS!!!
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCarsByAgency";

            SqlParameter inputParameter = new SqlParameter("@agency", agency);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@city", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@state", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        [WebMethod]
        public DataSet FindCars(String[] amenity, String city, String state)
        {
            //WORKS!!!!
            DataSet myDS = new DataSet();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FindsByAmenity";

            SqlParameter inputParameter = new SqlParameter("@numDoor", amenity[0]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@numAirbags", amenity[1]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@powerSteering", amenity[2]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@numSeats", amenity[3]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@carColor", amenity[4]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@GPS", amenity[5]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@city", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@state", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        [WebMethod]
        public DataSet FindCarsbyAgency(int agency, String[] amenity, String city, String state)
        {
            //WORKS!!!!
            DataSet myDS = new DataSet();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FindCarsByAgencyAndAmenity";

            SqlParameter inputParameter = new SqlParameter("@agency", agency);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@numDoor", amenity[0]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@numAirbags", amenity[1]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@powerSteering", amenity[2]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@numSeats", amenity[3]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@carColor", amenity[4]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@GPS", amenity[5]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.NVarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        [WebMethod]
        public Boolean Reserve(int agencyid, int custid, int carid, DateTime start, DateTime end)
        {
            //WORKS!!!
            
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Reserve";

            SqlParameter inputParameter = new SqlParameter("@agency", agencyid);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@car", carid);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);


            inputParameter = new SqlParameter("@customer", custid);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@start", start);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.DateTime;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@end", end);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.DateTime;
            objCommand.Parameters.Add(inputParameter);

            try
            {
                objDB.DoUpdateUsingCmdObj(objCommand);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        [WebMethod]
        public DataSet findCustomer(int custID, string user, string pass)
        {
            //WORKS!!!
            DataSet myDS = new DataSet();
            if (user == "NHMM" && pass == "Brewer")
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "FindCustomer";

                SqlParameter inputParameter = new SqlParameter("@cust", custID);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Int;
                inputParameter.Size = 32;
                objCommand.Parameters.Add(inputParameter);

                myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            }
            return myDS;
        }
    }
}
