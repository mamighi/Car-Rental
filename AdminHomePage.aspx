<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="AdminHomePage.aspx.vb" Inherits="AdminHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
      <div style="width:100%; height:500px; text-align: left;">
        <div style="margin-left:25%;width:50%;float:left;text-align:center;height:100%">
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Admin HomePage" style="font-size: xx-large; font-weight: 700"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" style="font-weight: 700; color: #003366" Text="Label"></asp:Label>
            <br />
            <br />
            <div style="width:100%;height:150px">
                <div style="width:50%;height:100%;float:left">

                    <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/Image/Adduser.jpg" Width="149px" />
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="#003366" NavigateUrl="~/AddOperator.aspx">Add Operator</asp:HyperLink>
                    <br />

                </div>
                 <div style="width:50%;height:100%;float:left">
                      <asp:Image ID="Image2" runat="server" Height="100px" ImageUrl="~/Image/user_edit.png" Width="149px" />
                      <br />
                      <br />
                      <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" ForeColor="#003366" NavigateUrl="~/RemoveOperator.aspx">Remove Operator</asp:HyperLink>
                    <br />
                    <br />

                </div>
            </div>
            <div style="width:100%;height:150px">
                <div style="width:50%;height:100%;float:left">
                      <asp:Image ID="Image3" runat="server" Height="100px" ImageUrl="~/Image/add_car.jpg" Width="149px" />
                      <br />
                      <br />
                      <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" ForeColor="#003366" NavigateUrl="~/AddCar.aspx">Add Car</asp:HyperLink>
                    <br />
                    <br />

                </div>
                   
               
                     
                     <div style="width:50%;height:100%;float:left">
                      <asp:Image ID="Image4" runat="server" Height="100px" ImageUrl="~/Image/edit_car.png" Width="149px" />
                    <br />
                    <br />
                         <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" ForeColor="#003366" NavigateUrl="~/EditCar.aspx">Edit/Remove Car</asp:HyperLink>

                </div>
                
            </div>
          </div>
      </div>
</asp:Content>

