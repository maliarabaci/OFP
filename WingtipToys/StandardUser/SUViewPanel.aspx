<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SUViewPanel.aspx.cs" Inherits="WingtipToys.StandardUser.SUViewPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataKeyNames="ProductID" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="ImagePath" HeaderText="ImagePath" SortExpression="ImagePath" />
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
        </Columns>
        <SelectedRowStyle BackColor="White" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WingtipToys %>" SelectCommand="SELECT [ProductID], [ProductName], [Description], [ImagePath], [UnitPrice], [CategoryID] FROM [Products]"></asp:SqlDataSource>
    <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" Width="919px">
        <Nodes>
            <asp:TreeNode Text="Programs" Value="Programs">
                <asp:TreeNode Text="Public Institution Programs" Value="Public Institution Programs">
                    <asp:TreeNode Text="Grant Programs" Value="Grant Programs"></asp:TreeNode>
                    <asp:TreeNode Text="RfP" Value="RfP"></asp:TreeNode>
                    <asp:TreeNode Text="Applied Programs" Value="Applied Programs"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="Charity Programs" Value="Charity Programs">
                    <asp:TreeNode Text="Charity Programs" Value="Supported Charity Programs"></asp:TreeNode>
                    <asp:TreeNode Text="Supported Charity Programs" Value="Supported Charity Programs"></asp:TreeNode>
                </asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="Crowdfunding Projects" Value="Crowdfunding Projects">
                <asp:TreeNode Text="Projects" Value="New Node"></asp:TreeNode>
                <asp:TreeNode Text="Supported Projects" Value="Supported Projects"></asp:TreeNode>
                <asp:TreeNode Text="My Projects" Value="My Projects"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
    </asp:TreeView>
</asp:Content>
