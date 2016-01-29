<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BlobStorage.aspx.cs" Inherits="AzureDataStorage.Pages.BlobStorage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h2>Azure Blob Storage</h2>
            <asp:Label runat="server" ID="lblErrorMsg" ForeColor="Red"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h3>Select Blob Container</h3>
            <label>Existing containers</label><br />
            <asp:Repeater runat="server" ID="rpExistingContainers">
                <HeaderTemplate>
                    <p>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label runat="server" text='<%# Eval("Name") %>' /> <br />
                </ItemTemplate>
                <FooterTemplate>
                    </p>
                </FooterTemplate>
            </asp:Repeater>
            <div class="form-group">
                <label>Container name </label>
                <asp:TextBox runat="server" ID="tbContainerName" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="btnSelectContainer" Text="Select" OnClick="btnSelectContainer_Click" CssClass="btn btn-primary" />
            <asp:Label runat="server" ID="lblCreateContainerResult"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Upload to Blob Container</h3>
            <asp:FileUpload runat="server" ID="fileUploadToContainer" AllowMultiple="false" />
            <asp:Button runat="server" ID="btnUploadToContainer" Text="Upload" OnClick="btnUploadToContainer_Click" CssClass="btn btn-primary" />
            <asp:Label ID="lblUploadStatus" runat="server"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>All blobs in file upload container</h3>
            <asp:Literal runat="server" ID="literalBlobsInContainer"></asp:Literal>
        </div>
    </div>
</asp:Content>
