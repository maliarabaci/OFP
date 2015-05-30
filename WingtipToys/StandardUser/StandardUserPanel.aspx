<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StandardUserPanel.aspx.cs" Inherits="WingtipToys.StandardUser.StandardUserPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Standard User Panel</h1>
    <hr />
    <p></p>
    <asp:Button ID="ViewButton" runat="server" Text="View" OnClick="ViewButton_Click"  CausesValidation="true"/>
    <p></p>
    <asp:Button ID="CreateProjectButton" runat="server" Text="Create Project" OnClick="CreateProjectButton_Click"  CausesValidation="true"/>
    <p></p>
    <asp:Button ID="MessageButton" runat="server" Text="Message" OnClick="MessageButton_Click" CausesValidation="false"/>
</asp:Content>