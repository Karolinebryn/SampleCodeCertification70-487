<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ParseAString.aspx.cs" Inherits="LinqToXml.Pages.ParseAString" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h2>Parse a string</h2>
            <h4>String to be parsed</h4>

        <asp:TextBox runat="server" ID="tbStringToParse" Width="100%"></asp:TextBox>

            <br />
            <h4>Parsed string</h4>

            <textarea runat="server" ID="taParsedString" style="border: none;width: 100%;height: 600px;">

            </textarea>
        </div>

        
    </div>
</asp:Content>
