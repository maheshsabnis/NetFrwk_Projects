<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeptRESTClient.aspx.cs" Inherits="WebForm_Client.DeptRESTClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="DeptNo"></asp:Label>
            <asp:TextBox ID="txtdno" runat="server" CssClass="form-control"
               ></asp:TextBox>
            <asp:RequiredFieldValidator ID="deptnorequired" runat="server" ErrorMessage="DeptNo is Required"
                  ControlToValidate="txtdno"></asp:RequiredFieldValidator>
         
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
            <asp:Button ID="btnUpdate" runat="server" Text="Button" 
                CssClass="btn btn-primary" OnClick="btnUpdate_Click" />
        </div>
    </div>
    <br/>
    <asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>

    <hr />
    <asp:GridView ID="gvDept" runat="server" BackColor="#DEBA84" 
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" 
       CellSpacing="2" 
       >
        <Columns>
            <asp:BoundField DataField="DeptNo" ReadOnly="true" HeaderText="DeptNo" />
            <asp:BoundField DataField="DeptName" HeaderText="DeptName" />
            <asp:BoundField DataField="Location" HeaderText="Location" />
            <asp:BoundField DataField="Capacity" HeaderText="Capacity" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:CommandField ButtonType="Button" ShowEditButton="True" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
</asp:GridView>
</asp:Content>
