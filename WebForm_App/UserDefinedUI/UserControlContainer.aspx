<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserControlContainer.aspx.cs" Inherits="WebForm_App.UserDefinedUI.UserControlContainer" %>

<%@ Register Src="~/UserDefinedUI/DbConnector.ascx" TagPrefix="uc1" TagName="DbConnector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <hr />
    <hr />
    <uc1:DbConnector runat="server" id="DbConnector" />
    <hr />
    <asp:GridView ID="gvTable" runat="server"></asp:GridView>
</asp:Content>
