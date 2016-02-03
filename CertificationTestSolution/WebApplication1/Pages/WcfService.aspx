<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WcfService.aspx.cs" Inherits="WebApplication1.Pages.WcfService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1>WCF Service</h1>
        <h2>Customer with orders (top 10 ordered by last name)</h2>
        <asp:GridView runat="server" ID="gvAdventureWorks_wcfservice" AutoGenerateColumns="false" CssClass="table table-striped" 
            UseAccessibleHeader="true" BorderStyle="None">
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="Id" />
                <asp:BoundField HeaderText="Title" DataField="Title" />
                <asp:BoundField HeaderText="First Name" DataField="FirstName" />
                <asp:BoundField HeaderText="Last Name" DataField="LastName" />
                <asp:BoundField HeaderText="Phone" DataField="Phone" /> 
            </Columns>
        </asp:GridView>
    </div>
    <div class="row">
        <h2>Fault handling</h2>
        <asp:TextBox runat="server" ID="tbCustomerId"></asp:TextBox>
        <asp:Button runat="server" ID="btnSearchCustomerById" Text="Search customer by id" CssClass="btn btn-primary" OnClick="btnSearchCustomerById_Click" />
        <asp:Label runat="server" ID="lblSearchResult"></asp:Label>
    </div>
</asp:Content>
