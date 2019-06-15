<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="CarRent.aspx.vb" Inherits="CarRent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <div style="width:100%; height:800px; text-align: left;">
        <div style="margin-left:25%;width:50%;float:left;text-align:center;height:100%">

            <br />
            <asp:Label ID="Label1" runat="server" Text="Rent Car" style="font-size: xx-large; font-weight: 700"></asp:Label>


            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <span style="color: #003366"><strong>Car ID<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="180px" AutoPostBack="True" CausesValidation="True">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Car Details" ForeColor="#006600"></asp:Label>
            <br />
            <br />
            Customer ID<br />
            <asp:DropDownList ID="DropDownList2" runat="server" Width="180px" AutoPostBack="True" CausesValidation="True">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Customer Details" ForeColor="#006600"></asp:Label>
            <br />
            <br />
            Check-Out Date<br />
            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="180px"></asp:TextBox>
            <br />
            <br />
            Duration (Days)<br />
            <asp:DropDownList ID="DropDownList3" runat="server" Width="180px" AppendDataBoundItems="True" AutoPostBack="True" CausesValidation="True">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Check-In Date<br />
            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Width="180px"></asp:TextBox>
            <br />
            <br />
            Cost<br />
            <asp:TextBox ID="TextBox3" runat="server" Width="180px"></asp:TextBox>
            <br />
            <br />
            Deposit<br />
            <asp:TextBox ID="TextBox4" runat="server" Width="180px"></asp:TextBox>
            <br />
            <br />
            Remark<br />
            <asp:TextBox ID="TextBox5" runat="server" Width="180px" TextMode="MultiLine" Height="66px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Wrong Username Or Password" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#003366" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Submit" Width="186px" />
            </strong></span>

        </div>
     </div>
</asp:Content>

