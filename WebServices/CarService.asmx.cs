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
        public Boolean Reserve(int agencyid, Customer cust, int carid, DateTime start, DateTime end)
        {
            TermProjectWS TPWS = new TermProjectWS();
            //checks to see if the user already has an id in data base
            if (cust.CustID == null)
            {
                //adds user to data base
                cust.CustID = TPWS.UserCreate(cust.Name + DateTime.Now.Millisecond, cust.Email, cust);
            }

            //find start date of reserves

            DataSet Wojak = new DataSet();

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AvailableToReserve";

            SqlParameter inputParameter = new SqlParameter("@agency", agencyid);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@carID", carid);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 32;
            objCommand.Parameters.Add(inputParameter);

            Wojak = objDB.GetDataSetUsingCmdObj(objCommand);
            int pepe = -1;



            DateTime compStart;
            DateTime compEnd;

            if (Wojak.Tables[0].Rows.Count == 0)
            {
                compStart = DateTime.Now.AddYears(1000);
                compEnd = DateTime.Now.AddYears(-1000);
            }
            else if (Wojak.Tables[0].Rows.Count == 1)
            {
                if ((DateTime)Wojak.Tables[0].Rows[0]["StartDate"] > end || (DateTime)Wojak.Tables[0].Rows[0]["EndDate"] < start)
                {
                    //call reserve
                    objCommand = new SqlCommand();
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "Reserve";

                    inputParameter = new SqlParameter("@agency", agencyid);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.Int;
                    inputParameter.Size = 32;
                    objCommand.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@car", carid);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.Int;
                    inputParameter.Size = 32;
                    objCommand.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@customer", cust.CustID);
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
                else
                {
                    return false;
                }
            }
            else
            {
                for (int row = 0; row < Wojak.Tables[0].Rows.Count; row++)
                {
                    if ((DateTime)Wojak.Tables[0].Rows[row]["StartDate"] > start)
                    {
                        pepe = row;
                        break;
                    }
                }

                if (pepe == 0)
                {
                    compStart = (DateTime)Wojak.Tables[0].Rows[pepe]["StartDate"];
                    compEnd = DateTime.Now.AddYears(-1000);
                }
                else if (pepe == -1)
                {
                    compStart = DateTime.Now.AddYears(1000);
                    compEnd = (DateTime)Wojak.Tables[0].Rows[Wojak.Tables[0].Rows.Count - 1]["EndDate"];
                }
                else
                {
                    compStart = (DateTime)Wojak.Tables[0].Rows[pepe]["StartDate"];
                    compEnd = (DateTime)Wojak.Tables[0].Rows[pepe - 1]["EndDate"];
                }
            }

            if (compStart > end && compEnd < start)
            {
                //call reserve
                objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "Reserve";

                inputParameter = new SqlParameter("@agency", agencyid);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Int;
                inputParameter.Size = 32;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@car", carid);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Int;
                inputParameter.Size = 32;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@customer", cust.CustID);
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
            else
            {
                return false;
            }
        }
    }
}