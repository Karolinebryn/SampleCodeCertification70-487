<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LinqToXml._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <h3>Simple XML Filtering</h3>
            <p>Click here to see the example</p>
            <a href="Pages/SimpleXmlFiltering.aspx" class="btn btn-primary">Go</a>
        </div>
        <div class="col-md-4">
            <h3>Parse a string to XML</h3>
            <p>Click here to see the example</p>
            <a href="Pages/ParseAString.aspx" class="btn btn-primary">Go</a>
        </div>
        <div class="col-md-4">
            <h3>Load XML From File</h3>
            <p>Click here to see the example</p>
            <a href="Pages/LoadXmlFromFile.aspx" class="btn btn-primary">Go</a>
        </div>
        <div class="col-md-4">
            <h3>Process XML Using the DOM Model</h3>
            <p>Click here to see the example</p>
            <a href="Pages/UsingTheDomModel.aspx" class="btn btn-primary">Go</a>
        </div>
        <div class="col-md-4">
            <h3>Process XML Using the XPath Data Model</h3>
            <p>Click here to see the example</p>
            <a href="Pages/UsingTheXpathDataModel.aspx" class="btn btn-primary">Go</a>
        </div>
    </div>

</asp:Content>
