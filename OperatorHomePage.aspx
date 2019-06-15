<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="OperatorHomePage.aspx.vb" Inherits="OperatorHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
      <div style="width:100%; height:500px; text-align: left;">
        <div style="margin-left:25%;width:50%;float:left;text-align:center;height:100%">
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Operator HomePage" style="font-size: xx-large; font-weight: 700"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" style="font-weight: 700; color: #003366" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <div style="width:100%;height:150px">
                <div style="width:50%;height:100%;float:left">

                    <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/Image/Adduser.jpg" Width="149px" />
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="#003366" NavigateUrl="~/AddCostumer.aspx">Add Customer</asp:HyperLink>

                </div>
                 <div style="width:50%;height:100%;float:left">
                      <asp:Image ID="Image2" runat="server" Height="100px" ImageUrl="~/Image/user_edit.png" Width="149px" />
                    <br />
                      <br />
                      <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" ForeColor="#003366" NavigateUrl="~/EditCostumer.aspx">Edit Customer</asp:HyperLink>
                    <br />

                </div>
            </div>
            <div style="width:100%;height:150px">
                <div style="width:50%;height:100%;float:left">
                      <asp:Image ID="Image3" runat="server" Height="100px" ImageUrl="~/Image/rent-a-car-icon.png" Width="149px" />
                    <br />
                      <br />
                      <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" ForeColor="#003366" NavigateUrl="~/CarRent.aspx">Rent Car</asp:HyperLink>
                    <br />

                </div>
                   
               
                     
                     <div style="width:50%;height:100%;float:left">
                      <asp:Image ID="Image4" runat="server" Height="100px" ImageUrl="~/Image/report.png" Width="149px" />
                         <br />
                         <br />
                         <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" ForeColor="#003366" NavigateUrl="~/Report.aspx">Generate Report</asp:HyperLink>
                    <br />
                    <br />

                </div>
                
            </div>
          </div>
      </div>
</asp:Content>

