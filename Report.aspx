<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Report.aspx.vb" Inherits="Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
       <div style="width:100%; height:500px; text-align: left;">
        <div style="margin-left:20%;width:60%;float:left;text-align:center;height:100%; direction: rtl;">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Rent Car" style="font-size: xx-large; font-weight: 700"></asp:Label>


            <br />
            <br />
            <asp:Table ID="Table1" runat="server" GridLines="Both" HorizontalAlign="Center">
            </asp:Table>
            </div>
           </div>

</asp:Content>

