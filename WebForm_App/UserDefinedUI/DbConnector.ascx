<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DbConnector.ascx.cs" Inherits="WebForm_App.UserDefinedUI.DbConnector" %>
<table class="table table-bordered table-striped table-dark">
    <tr>
        <td>
            Database Server Name
        </td>
        <td>
            <asp:TextBox ID="txtdbserver" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td>
            Credentials
        </td>
        <td>
            <asp:DropDownList ID="ddlcrdentials" runat="server" CssClass="form-control"
                 OnSelectedIndexChanged="ddlcrdentials_SelectedIndexChanged">
                <asp:ListItem>Select The Credentials</asp:ListItem>
                <asp:ListItem Value="0" Text="Windows Authentication"></asp:ListItem>
                <asp:ListItem Value="1" Text="SQL Server Authentication"></asp:ListItem>
            </asp:DropDownList>
        </td>
          
    </tr>
     <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="txtuname" runat="server" TextMode="Password" CssClass="form-control"
                     Enabled="false"></asp:TextBox>
            </td>
        </tr>
    <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" CssClass="form-control"
                    Enabled="false"></asp:TextBox>
            </td>
        </tr>
    <tr>
        <td>Database Name</td>
        <td>
            <asp:TextBox ID="txtdbname" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
     
        <tr>
            <td>Table Name</td>
            <td>
                <asp:TextBox ID="txttablename" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
      
        <tr>
            <td colspan="2">
                <asp:Button ID="btnConnect" runat="server" Text="Connect"  CssClass="btn btn-warning"
                     OnClick="btnConnect_Click"/>
            </td>
            
        </tr>
    
</table>
