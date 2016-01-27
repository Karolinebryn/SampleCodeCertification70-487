<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="row">
        <div class="col-md-4">
            <h3>WCF Data Service</h3>
            <p>Click here for a WCF Data Service example</p>
            <a href="Pages/WcfDataService.aspx" class="btn btn-primary">Go</a>
        </div>
        <div class="col-md-4">
            <h3>WCF Service</h3>
            <p>Click here for a WCF Service example</p>
            <a href="Pages/WcfService.aspx" class="btn btn-primary">Go</a>
        </div>
    </div>

</asp:Content>
