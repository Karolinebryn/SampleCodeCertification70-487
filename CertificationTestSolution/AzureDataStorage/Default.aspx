<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AzureDataStorage._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-md-12">
            <h1>Azure Data Storage</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Blob Storage</h2>
            <p>See examples on how to use Azure Blob Storage</p>
            <a href="Pages/BlobStorage.aspx" class="btn btn-primary">Go</a>
        </div>
        <div class="col-md-4">
            <h2>Table Storage</h2>
            <p>See examples on how to use Azure Table Storage</p>
            <a href="Pages/TableStorage.aspx" class="btn btn-primary">Go</a>
        </div>
        <div class="col-md-4">
            <h2>Queue Storage</h2>
            <p>See examples on how to use Azure Queue Storage</p>
            <a href="Pages/QueueStorage.aspx" class="btn btn-primary">Go</a>
        </div>
    </div>

</asp:Content>
