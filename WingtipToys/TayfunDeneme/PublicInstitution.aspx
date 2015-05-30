<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PublicInstitution.aspx.cs" Inherits="WingtipToys.TayfunDeneme.PublicInstitution" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
   <div class="row" >
      <div class="col-sm-3" >
          <nav>
         <ul class="nav nav-pills nav-stacked span12">
             <li><a href="#">Projects</a></li>
             <li><a href="#">Charitable Programs</a></li>
             <li><a href="#">Favourite Projects</a></li>
        </ul>
        </nav>
      </div>
      <div class="col-sm-6" >  

          
        <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns = "false"
        AllowPaging = "true" OnPageIndexChanging = "OnPaging">
        <Columns>
        <asp:BoundField DataField = "CustomerId" HeaderText = "Customer Id" />
        <asp:BoundField DataField = "ContactName" HeaderText = "Contact Name" />
        <asp:BoundField DataField = "City" HeaderText = "City" />
        <asp:BoundField DataField = "Country" HeaderText = "Country" />
        </Columns>
        </asp:GridView>

        </div>
        <div class="col-sm-3" >
         <h1>Tayfun</h1>
        </div>

   </div>
     </div>
</asp:Content>
