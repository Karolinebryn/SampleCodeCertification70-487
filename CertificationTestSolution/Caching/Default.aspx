<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Caching._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="row">
    <div class="col-md-12">
        <h1>Caching</h1>
    </div>
    <div class="col-md-12">
        <h2>Cache.Add()</h2>
        <p>Cache.Add() will do nothing if key exists in cache.</p>
        <asp:Button runat="server" OnClick="AddItemToCache" Text="Add Item to Cache" CssClass="btn btn-primary" />
        <asp:Button runat="server" OnClick="RemoveItemFromCache" Text="Remove Item from Cache" CssClass="btn btn-primary" />
        <div>
            <b>Status: </b>
            <asp:Label runat="server" ID="lblResult"></asp:Label>
        </div>
    </div>
    <div class="col-md-12">
        <h2>Cache.Insert()</h2>
        <p>Cache.Insert() will overwrite value in cache if key exists.</p>
        <asp:Button runat="server" OnClick="InsertItemToCache" Text="Insert Item to Cache" CssClass="btn btn-primary" />
        <div>
            <b>Status: </b>
            <asp:Label runat="server" ID="lblResult2"></asp:Label>
        </div>
    </div>
    <div class="col-md-12">
        <h2>CacheDependency</h2>
        <p>
            To test; click "Insert" button, then click "Check" button. The item should still exist in cache.
            Then open document (AppData/books.xml), change something and save it. Click "Check" button again.
            Item should no longer be in cache.
        </p>
        <asp:Button runat="server" OnClick="InsertItemWithDependency" Text="Insert Item to Cache" CssClass="btn btn-primary" />
        <asp:Button runat="server" OnClick="CheckIfItemWithDependencyExists" Text="Check if item is in Cache" CssClass="btn btn-primary" />

        <div>
            <b>Status: </b>
            <asp:Label runat="server" ID="lblResult3"></asp:Label>
        </div>
    </div>
    
</div>

</asp:Content>
