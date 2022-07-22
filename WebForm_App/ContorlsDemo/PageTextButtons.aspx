<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageTextButtons.aspx.cs" 
    MasterPageFile="~/Site.Master"
    Inherits="WebForm_App.ContorlsDemo.PageTextButtons" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <h1>Demo for ASP.NET Web Controls: TextBox and Button with their Events</h1>
     
     <div>
         <strong>Demo Text Boxes<br />
       
         </strong>
           Enter Name Name
          <asp:TextBox ID="txtname" runat="server" OnTextChanged="txtname_TextChanged" 
             AutoPostBack="True" EnableViewState="True"></asp:TextBox>
         <br />
         <asp:Button ID="btnDisplay" runat="server" Text="Display Name" 
             OnClick="btnDisplay_Click" />
         <br />
         <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
         <hr />
          Selected Department: <asp:Label ID="lblSelDept" runat="server" Text=""></asp:Label>
         <br/>
        
         <asp:DropDownList ID="ddlDepartments" runat="server" AutoPostBack="True" 
             OnSelectedIndexChanged="ddlDepartments_SelectedIndexChanged">
             <asp:ListItem Value="IT" Text="Information Technology"></asp:ListItem>
             <asp:ListItem Value="HRD" Text="Human Resource"></asp:ListItem>
             <asp:ListItem Value="AC" Text="Accounts"></asp:ListItem>
             <asp:ListItem Value="TRG" Text="Training"></asp:ListItem>
             <asp:ListItem Value="AD" Text="Administration"></asp:ListItem>
         </asp:DropDownList>
         <hr />
         <asp:GridView ID="gvEmployees" runat="server" BackColor="#DEBA84" 
             BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
             CellSpacing="2">
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
     </div>
     
</asp:Content>
