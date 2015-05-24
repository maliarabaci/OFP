<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SUCreateProjectPanel.aspx.cs" Inherits="WingtipToys.StandardUser.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Project Name"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="Donation"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="Deadline"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</asp:Content>
