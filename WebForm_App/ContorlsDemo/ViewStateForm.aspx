<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateForm.aspx.cs" 
     MasterPageFile="~/Site.Master"
    Inherits="WebForm_App.ContorlsDemo.ViewStateForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>DEMO View State</h1>
    <asp:TextBox ID="txtmessage" runat="server" TextMode="MultiLine"></asp:TextBox>
    <table>
        <tr>
            <td>
                <asp:Button ID="btnSet" runat="server" Text="Set Message" 
                    OnClick="btnSet_Click" />
            </td>
             <td>
                <asp:Button ID="bnGet" runat="server" Text="Get Message" OnClick="bnGet_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

 