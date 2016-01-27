<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h1>Customers with orders from WCF Data Service</h1>
        <asp:GridView runat="server" ID="gvAdventureWorks_wcfdataservice" AutoGenerateColumns="false" CssClass="table table-striped" 
            UseAccessibleHeader="true" BorderStyle="None">
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="CustomerID" />
                <asp:BoundField HeaderText="Title" DataField="Title" />
                <asp:BoundField HeaderText="First Name" DataField="FirstName" />
                <asp:BoundField HeaderText="Last Name" DataField="LastName" />
                <asp:BoundField HeaderText="Phone" DataField="Phone" />
            </Columns>
        </asp:GridView>
    </div>
    <div class="row">
        <h1>Customers with orders from WCF Service</h1>
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

</asp:Content>
