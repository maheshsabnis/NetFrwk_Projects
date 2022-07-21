<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm_App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="form-group">
            <asp:Label runat="server">Emp No</asp:Label>
            <asp:TextBox runat="server" ID="txteno" TextMode="Number" CssClass="form-control"></asp:TextBox> 
        </div>
         <div class="form-group">
            <asp:Label runat="server">Emp Name</asp:Label>
            <asp:TextBox runat="server" ID="txtename" CssClass="form-control"></asp:TextBox> 
        </div>
         <div class="form-group">
            <asp:Label runat="server">Dept Name</asp:Label>
            <asp:DropDownList ID="ddlDname" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
         <div class="form-group">
            <asp:Label runat="server">Designation</asp:Label>
            <asp:DropDownList ID="ddlDesig" runat="server" CssClass="form-control" 
                 OnSelectedIndexChanged="ddlDesig_SelectedIndexChanged"></asp:DropDownList>
        </div>
         <div class="form-group">
            <asp:Label runat="server">Salary</asp:Label>
            <asp:TextBox runat="server" ID="txtsal" TextMode="Number" CssClass="form-control"></asp:TextBox> 
        </div>
        <div class="form-group">
            <asp:Button ID="btnNew" Text="New" CssClass="btn btn-warning" runat="server" OnClick="btnNew_Click"
                 />
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" 
                OnClick="btnSave_Click" />
        </div>
    </div>
    <asp:Label ID="lbldata" runat="server" Text="The Employee Data is: "></asp:Label>
</asp:Content>
