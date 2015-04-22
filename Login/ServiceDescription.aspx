<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceDescription.aspx.cs" Inherits="Login.ServiceDiscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Table runat="server" BorderStyle="Groove" BorderWidth="10px" Font-Names="Baskerville Old Face" Font-Size="13.1pt" GridLines="Both">
                <asp:TableRow ID="TableRow5" runat="server">
                    <asp:TableCell>
                        GetRentalCarAgencies(String city, String state)
                    </asp:TableCell>
                    <asp:TableCell>
                        <p>
                            This will return a DataSet containing all the agencies within a given city and state.  
                            You have to pass in a String for the city an a String for the state.  
                        </p>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="TableRow1" runat="server">
                    <asp:TableCell>
                        GetCarsByAgency(int agency, String city, String state)
                    </asp:TableCell>
                    <asp:TableCell>
                        <p>
                            This method will return a DataSet containing all the cars from an agency in a given city and state.  
                            You have to pass the agencyID and the city and state.  
                        </p>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="TableRow2" runat="server">
                    <asp:TableCell>
                        FindCars(Sting[] requirements, String city, String state)
                    </asp:TableCell>
                    <asp:TableCell>
                        <p>
                            This will return a DataSet with all the cars in a city and state that have all the requirements the user want.  
                            The requirements is an array of strings of the names of the requirements.  
                            The Requirments, IN THIS ORDER, are Number of Doors(int), Number of airbags(int), PowerSteering("true" OR "false"), Number of seats(int), Color(string), GPS("true" OR "false").  
                            You also need to pass the city and state the cars are in.  
                        </p>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="TableRow3" runat="server">
                    <asp:TableCell>
                        FindCarsByAgency(int agency, Sting[] requirements, String city, String state) 
                    </asp:TableCell>
                    <asp:TableCell>
                        <p>
                            This will return a DataSet with all the cars in a city and state for a given agency that have all the requirements the user want.  
                            The agency is an int of the agencyID.  
                            The requirements is an array of strings of the names of the requirements.  
                            The Requirments, IN THIS ORDER, are Number of Doors(int), Number of airbags(int), PowerSteering("true" OR "false"), Number of seats(int), Color(string), GPS("true" OR "false").  
                            You also need to pass the city and state the cars are in.
                        </p>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="TableRow4" runat="server">
                    <asp:TableCell>
                        Reserve(int agency, int car, int customer, DateTime start, DateTime end) 
                    </asp:TableCell>
                    <asp:TableCell>
                        <p>
                            This will return a boolean telling you weather or not the reservation was made.  
                            if it returns true it was successful and false it was unsuccessful.  
                            You need to pass the agency's ID, the car's ID the customer's ID, the DateTime the reservation starts, and the DateIme the reservation ends.
                        </p>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="TableRow6" runat="server">
                    <asp:TableCell>
                        FindCustomer(int CustomerID, int TravelSiteID, String TravelSitePassword)
                    </asp:TableCell>
                    <asp:TableCell>
                        <p>
                            This will return a Customer class object containing all the desired information of the desired customer.  
                            The point of this is still a mystery but it works.  
                        </p>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
