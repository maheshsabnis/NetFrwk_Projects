<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QueryStringSender.aspx.cs" Inherits="WebForm_App.ContorlsDemo.QueryStringSender" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <h1>The Sender Page Using QueryString</h1> 
      <asp:DropDownList ID="ddlDepartments" runat="server" AutoPostBack="True" 
             OnSelectedIndexChanged="ddlDepartments_SelectedIndexChanged">
             <asp:ListItem Text="Select DeptName"></asp:ListItem>
             <asp:ListItem Value="IT" Text="Information Technology"></asp:ListItem>
             <asp:ListItem Value="HRD" Text="Human Resource"></asp:ListItem>
             <asp:ListItem Value="AC" Text="Accounts"></asp:ListItem>
             <asp:ListItem Value="TRG" Text="Training"></asp:ListItem>
             <asp:ListItem Value="AD" Text="Administration"></asp:ListItem>
         </asp:DropDownList>
</asp:Content>
