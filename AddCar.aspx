<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AddCar.aspx.vb" Inherits="AddCar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:100%; height:500px; text-align: left;">
        <div style="margin-left:25%;width:50%;float:left;text-align:center;height:100%">


            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Add Car" style="font-size: xx-large; font-weight: 700"></asp:Label>


            <br />
            <br />
            <span style="color: #003366"><strong>
            <br />
            <br />
            Car Type<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="183px">
                <asp:ListItem>MPV</asp:ListItem>
                <asp:ListItem>SUV</asp:ListItem>
                <asp:ListItem>Sedan Medium</asp:ListItem>
                <asp:ListItem>Sedan Compact</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Car Model<br />
            <asp:TextBox ID="TextBox3" runat="server" Width="183px"></asp:TextBox>
            <br />
            <br />
            Remark<br />
            <asp:TextBox ID="TextBox4" runat="server" Width="183px" Height="70px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Wrong Username Or Password" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#003366" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Submit" Width="186px" />
            </strong></span>


        </div>
    </div>
 
   

</asp:Content>
