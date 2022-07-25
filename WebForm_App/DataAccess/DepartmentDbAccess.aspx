<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentDbAccess.aspx.cs" Inherits="WebForm_App.DataAccess.DepartmentDbAccess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="DeptNo"></asp:Label>
            <asp:TextBox ID="txtdno" runat="server" CssClass="form-control"
               ></asp:TextBox>
            <asp:RequiredFieldValidator ID="deptnorequired" runat="server" ErrorMessage="DeptNo is Required"
                  ControlToValidate="txtdno"></asp:RequiredFieldValidator>
           <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ErrorMessage="DeptNo Must be more than 0"
                 ControlToValidate="txtdno"
                 ValidationExpression="\d{5}"></asp:RegularExpressionValidator>--%>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="DeptName"></asp:Label>
            <asp:TextBox ID="txtdname" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                 ErrorMessage="DeptName is Required"
                 ControlToValidate="txtdname"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Location"></asp:Label>
            <asp:TextBox ID="txtloc" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                 ErrorMessage="Location is Required"
                 ControlToValidate="txtloc"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Capacity"></asp:Label>
            <asp:TextBox ID="txtcap" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnNew" runat="server" Text="New" CssClass="btn btn-warning" 
                OnClick="btnNew_Click"/>
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" 
                OnClick="btnSave_Click"/>
        </div>
    </div>
    <br/>
    <asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>

    <hr />
    <asp:GridView ID="gvDept" runat="server" BackColor="White" 
    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
</asp:GridView>
</asp:Content>
