<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleXmlFiltering.aspx.cs" Inherits="LinqToXml.Pages.SimpleXmlFiltering" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h2>Simple XML Filtering</h2>
            <asp:DropDownList runat="server" ID="ddlFilterContacts" OnSelectedIndexChanged="ddlFilterContacts_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="All" Text="Show all" Selected="True"></asp:ListItem>
                <asp:ListItem Value="Byen" Text="Byen"></asp:ListItem>
                <asp:ListItem Value="Lillebyen" Text="Lillebyen"></asp:ListItem>
            </asp:DropDownList>

            <asp:GridView runat="server" ID="gvContacts" AutoGenerateColumns="false" CssClass="table table-striped" 
            UseAccessibleHeader="true" BorderStyle="None">
                <Columns>
                    <asp:BoundField DataField="NodeType" HeaderText="Node Type" />
                    <asp:BoundField DataField="Xml" HeaderText="XML" />
                </Columns>

            </asp:GridView>
    </div>
</asp:Content>
