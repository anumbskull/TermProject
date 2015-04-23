<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarPage.aspx.cs" Inherits="Login.CarPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please enter a city and state."></asp:Label>
            <br />
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <asp:DropDownList ID="ddlStateCreate" runat="server">
                <asp:ListItem Value="Select">Select one</asp:ListItem>
                <asp:ListItem Value="AL">Alabama</asp:ListItem>
                <asp:ListItem Value="AK">Alaska</asp:ListItem>
                <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                <asp:ListItem Value="AR">Arkansas</asp:ListItem>
                <asp:ListItem Value="CA">California</asp:ListItem>
                <asp:ListItem Value="CO">Colorado</asp:ListItem>
                <asp:ListItem Value="CT">Connecticut</asp:ListItem>
                <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
                <asp:ListItem Value="DE">Delaware</asp:ListItem>
                <asp:ListItem Value="FL">Florida</asp:ListItem>
                <asp:ListItem Value="GA">Georgia</asp:ListItem>
                <asp:ListItem Value="HI">Hawaii</asp:ListItem>
                <asp:ListItem Value="ID">Idaho</asp:ListItem>
                <asp:ListItem Value="IL">Illinois</asp:ListItem>
                <asp:ListItem Value="IN">Indiana</asp:ListItem>
                <asp:ListItem Value="IA">Iowa</asp:ListItem>
                <asp:ListItem Value="KS">Kansas</asp:ListItem>
                <asp:ListItem Value="KY">Kentucky</asp:ListItem>
                <asp:ListItem Value="LA">Louisiana</asp:ListItem>
                <asp:ListItem Value="ME">Maine</asp:ListItem>
                <asp:ListItem Value="MD">Maryland</asp:ListItem>
                <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
                <asp:ListItem Value="MI">Michigan</asp:ListItem>
                <asp:ListItem Value="MN">Minnesota</asp:ListItem>
                <asp:ListItem Value="MS">Mississippi</asp:ListItem>
                <asp:ListItem Value="MO">Missouri</asp:ListItem>
                <asp:ListItem Value="MT">Montana</asp:ListItem>
                <asp:ListItem Value="NE">Nebraska</asp:ListItem>
                <asp:ListItem Value="NV">Nevada</asp:ListItem>
                <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
                <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
                <asp:ListItem Value="NM">New Mexico</asp:ListItem>
                <asp:ListItem Value="NY">New York</asp:ListItem>
                <asp:ListItem Value="NC">North Carolina</asp:ListItem>
                <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                <asp:ListItem Value="OH">Ohio</asp:ListItem>
                <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
                <asp:ListItem Value="OR">Oregon</asp:ListItem>
                <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
                <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
                <asp:ListItem Value="SC">South Carolina</asp:ListItem>
                <asp:ListItem Value="SD">South Dakota</asp:ListItem>
                <asp:ListItem Value="TN">Tennessee</asp:ListItem>
                <asp:ListItem Value="TX">Texas</asp:ListItem>
                <asp:ListItem Value="UT">Utah</asp:ListItem>
                <asp:ListItem Value="VT">Vermont</asp:ListItem>
                <asp:ListItem Value="VA">Virginia</asp:ListItem>
                <asp:ListItem Value="WA">Washington</asp:ListItem>
                <asp:ListItem Value="WV">West Virginia</asp:ListItem>
                <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
                <asp:ListItem Value="WY">Wyoming</asp:ListItem>
            </asp:DropDownList>
        </div>
        <p>
            <asp:Button ID="btnAgencySearch" runat="server" OnClick="btnAgencySearch_Click" Text="Search" />
        </p>
        <asp:GridView ID="gdvGetAgency" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="AgencyID" HeaderText="AgencyID" />
                <asp:BoundField DataField="AgencyName" HeaderText="AgencyName" />
                <asp:BoundField DataField="AgencyCity" HeaderText="City" />
                <asp:BoundField DataField="AgencyState" HeaderText="State" />
            </Columns>
        </asp:GridView>

        <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Select" />
        <br />
            <asp:Label ID="Label2" runat="server" Text="Please enter which amenities you would like. "></asp:Label>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label3" runat="server" Text="Number of Doors:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="Label4" runat="server" Text="Number of Airbags:"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNumDoors" runat="server" Width="123px"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNumAirbags" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label5" runat="server" Text="Power Steering?"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="Label6" runat="server" Text="Number of Seats:"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlPowerSteering" runat="server">
                <asp:ListItem Value="Select">Select one</asp:ListItem>
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Value="false">No</asp:ListItem>
            </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNumSeats" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label7" runat="server" Text="Desired Color:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="Label8" runat="server" Text="GPS?"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGPS" runat="server">
                <asp:ListItem Value="Select">Select one</asp:ListItem>
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Value="false">No</asp:ListItem>
            </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        <br />
            <asp:Button ID="btnCarSearch" runat="server" OnClick="btnCarSearch_Click" Text="Search" />

        <asp:GridView ID="gdvFindCar" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkCar" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ImageField DataImageUrlField="Picture" HeaderText="Picture">
                </asp:ImageField>
                <asp:BoundField DataField="CarID" HeaderText="CarID" />
                <asp:BoundField DataField="AgencyID" HeaderText="AgencyID" />
                <asp:BoundField DataField="CarMake" HeaderText="Make" />
                <asp:BoundField DataField="CarModel" HeaderText="Model" />
            </Columns>
        </asp:GridView>

        <br />
        <asp:Table ID="Table2" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label9" runat="server" Text="Start"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label10" runat="server" Text="End"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Calendar ID="calStart" runat="server"></asp:Calendar>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Calendar ID="calEnd" runat="server"></asp:Calendar>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

        <br />
        <asp:Label ID="lblResults" runat="server"></asp:Label>

        <br />
        <asp:Button ID="btnRent" runat="server" Text="RENT" OnClick="btnRent_Click" />
    </form>
</body>
</html>
