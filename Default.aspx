<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:100%; height:500px; text-align: left;">
        <div style="margin-left:25%;width:50%;float:left;text-align:center;height:100%">


            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Please Login" style="font-size: xx-large; font-weight: 700"></asp:Label>


            <br />
            <br />
            <span style="color: #003366"><strong>UserName<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="183px"></asp:TextBox>
            <br />
            <br />
            Password<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="183px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Wrong Username Or Password" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#003366" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Login" Width="186px" />
            </strong></span>


        </div>
    </div>
 
   

</asp:Content>
