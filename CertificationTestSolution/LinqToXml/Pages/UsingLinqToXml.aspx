<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsingLinqToXml.aspx.cs" Inherits="LinqToXml.Pages.UsingLinqToXml" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        
        <div class="col-md-12">
            <h2>Process XML Data Using Linq to XML</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h3>Create a new XmlDocument</h3>
            <asp:Label runat="server" ID="lblResult1"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Load XML from file</h3>
            <textarea runat="server" ID="taBox" style="border: none;width: 100%;height: 300px;">

            </textarea>
        </div>
        <div class="col-md-6">
            <h3>Parse string to XML</h3>

            <textarea runat="server" ID="taBox2" style="border: none;width: 100%;height: 300px;">
            </textarea>
        </div>
        <div class="col-md-6">
            <h3>Simple XML filtering using Linq</h3>
            <a href="SimpleXmlFiltering.aspx" class="btn btn-primary">Go to example</a>
        </div>
    </div>
</asp:Content>
