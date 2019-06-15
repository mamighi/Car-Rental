<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="RemoveOperator.aspx.vb" Inherits="RemoveOperator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:100%; height:500px; text-align: left;">
        <div style="margin-left:25%;width:50%;float:left;text-align:center;height:100%">


            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Remove Operator" style="font-size: xx-large; font-weight: 700"></asp:Label>


            <br />
            <br />
            <span style="color: #003366"><strong>UserName<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="184px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Full Name<br />
            <asp:TextBox ID="TextBox3" runat="server" Width="183px" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            Remark<br />
            <asp:TextBox ID="TextBox4" runat="server" Width="183px" Height="70px" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#003366" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Remove" Width="186px" />
            </strong></span>


        </div>
    </div>
 
   

</asp:Content>
