﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WcfDataService.aspx.cs" Inherits="WebApplication1.Pages.WcfDataService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h1>WCF Data Service</h1>
        <h2>Customer with orders (top 10 ordered by last name)</h2>
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
</asp:Content>
