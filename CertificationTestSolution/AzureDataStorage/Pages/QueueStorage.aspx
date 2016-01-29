<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QueueStorage.aspx.cs" Inherits="AzureDataStorage.Pages.QueueStorage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h2>Azure Queue Storage</h2>
            <asp:Label runat="server" ID="lblErrorMsg" ForeColor="Red"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h3>Create a queue</h3>
            <div class="form-group">
                <label>Queue name </label>
                <asp:TextBox runat="server" ID="tbQueueName" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="btnCreateQueue" Text="Create" OnClick="btnCreateQueue_Click" CssClass="btn btn-primary" />
            <asp:Label runat="server" ID="lblCreateQueueMessage"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Insert message to queue</h3>
            <div class="form-group">
                <label>Message </label>
                <asp:TextBox runat="server" ID="tbMessageText" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="tbInsertMessage" Text="Create" OnClick="tbInsertMessage_Click" CssClass="btn btn-primary" />
            <asp:Label runat="server" ID="lblInsertMessageMessage"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Peek messages in queue</h3>
            <asp:Button runat="server" ID="btnPeekAllMessages" Text="Peek" OnClick="btnPeekMessages_Click" CssClass="btn btn-primary" />
            <asp:Label runat="server" ID="lblPeekAllMessagesResult"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Get next message</h3>
            <p>To see that message is removed, click "Peek" button.</p>
            <asp:Button runat="server" ID="btnGetMessage" Text="Get" OnClick="btnGetMessage_Click" CssClass="btn btn-primary" />
            <asp:Label runat="server" ID="lblGetMessageResult"></asp:Label>
        </div>

    </div>
</asp:Content>
