<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="EditCostumer.aspx.vb" Inherits="EditCostumer" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:100%; height:650px; text-align: left;">
        <div style="margin-left:25%;width:50%;float:left;text-align:center;height:100%; direction: ltr;">


            <br />
            <asp:Label ID="Label1" runat="server" Text="Edit Customer" style="font-size: xx-large; font-weight: 700"></asp:Label>


            <br />


            <br />
            <span style="color: #003366"><strong>ID<br />
            </strong>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="183px" AppendDataBoundItems="True" AutoPostBack="True" CausesValidation="True">
            </asp:DropDownList>
            <br />
            </span>


            <br />
            <span style="color: #003366"><strong>First Name<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="183px"></asp:TextBox>
            <br />
            <br />
            Last Name<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="183px"></asp:TextBox>
            <br />
            <br />
            Contact Number<br />
            <asp:TextBox ID="TextBox3" runat="server" Width="183px"></asp:TextBox>
            <br />
            <br />
            Email<br />
            <asp:TextBox ID="TextBox5" runat="server" Width="183px"></asp:TextBox>
            <br />
            <br />
            Remark<br />
            <asp:TextBox ID="TextBox4" runat="server" Width="183px" Height="70px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Wrong Username Or Password" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#003366" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Submit" Width="186px" />
            </strong></span>


        </div>
    </div>
 
   

</asp:Content>
