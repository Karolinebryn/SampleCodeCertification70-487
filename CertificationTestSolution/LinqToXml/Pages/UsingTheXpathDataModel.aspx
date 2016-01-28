<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsingTheXpathDataModel.aspx.cs" Inherits="LinqToXml.Pages.UsingTheXpathDataModel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
        
        <div class="col-md-12">
            <h2>Process XML Data Using the XPath Data Model</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h3>Read XML Document using XPathDocument</h3>
            <asp:Label runat="server" ID="lblResult1"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Select XML Data Using XPathNavigator</h3>
            <textarea runat="server" ID="Textarea3" style="width: 100%;height: 200px;"></textarea>
        </div>
        <div class="col-md-6">
            <h3>XPath Queries and Namespaces</h3>
            <textarea runat="server" ID="Textarea4" style="width: 100%;height: 200px;"></textarea>
        </div>
         <div class="col-md-6">
            <h3>Editing XML Data usin XPathNavigator</h3>
            <textarea runat="server" ID="Textarea5" style="width: 100%;height: 200px;"></textarea>
        </div>
    </div>
</asp:Content>
