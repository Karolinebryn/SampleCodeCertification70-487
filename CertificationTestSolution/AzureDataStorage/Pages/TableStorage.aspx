<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TableStorage.aspx.cs" Inherits="AzureDataStorage.Pages.TableStorage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h2>Azure Table Storage</h2>
            <asp:Label runat="server" ID="lblErrorMsg" ForeColor="Red"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h3>Create new table</h3>
            <div class="form-group">
                <label>Table name </label>
                <asp:TextBox runat="server" ID="tbTableName" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="btnCreateTable" Text="Create" OnClick="btnCreateTable_Click" CssClass="btn btn-primary" />
            <asp:Label runat="server" ID="lblCreateTableMessage"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Add entity to table</h3>
            <div class="form-group">
                <label>First name</label>
                <asp:TextBox runat="server" ID="tbFirstName" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Last name</label>
                <asp:TextBox runat="server" ID="tbLastName" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Email</label>
                <asp:TextBox runat="server" ID="tbEmail" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Phone</label>
                <asp:TextBox runat="server" ID="tbPhone" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="btnCreateCustomer" Text="Save" OnClick="btnCreateCustomer_Click" CssClass="btn btn-primary" />
            <asp:Label runat="server" ID="lblCreateCustomerMessage"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Get and query entities in table</h3>
            <div class="form-inline">
                <div class="form-group">
                    <label>Last name</label>
                    <asp:TextBox runat="server" ID="tbFilterLastName" CssClass="form-control"></asp:TextBox>
                </div>
               <asp:Button runat="server" ID="btnFilterLastName" Text="Search" OnClick="btnFilterLastName_Click" CssClass="btn btn-primary" />     
            </div>
            
            <asp:Repeater runat="server" ID="rpAllCustomers">
                <HeaderTemplate>
                    <table class="table table-striped"><thead>
                        <tr>
                            <th>First name</th>
                            <th>Last name</th>
                            <th>Phone</th>
                            <th>Email</th>
                        </tr>
                           </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><asp:Label runat="server" Text='<%# Eval("RowKey") %>'></asp:Label></td>
                        <td><asp:Label runat="server" Text='<%# Eval("PartitionKey") %>'></asp:Label></td>
                        <td><asp:Label runat="server" Text='<%# Eval("PhoneNumber") %>'></asp:Label></td>
                        <td><asp:Label runat="server" Text='<%# Eval("Email") %>'></asp:Label></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-6">
            <h3>Query a subset of entity properties</h3>
            <p>Get only customers phone number</p>
            <asp:Button runat="server" ID="btnQuery1" Text="Get Phone Numbers" CssClass="btn btn-primary" OnClick="btnQuery1_Click" />
            <asp:Repeater runat="server" ID="rpCustomers2">
                <HeaderTemplate>
                    <ul>
                </HeaderTemplate>
                <ItemTemplate>
                   <li><asp:Label runat="server" Text='<%# Container.DataItem %>'></asp:Label></li> 
                </ItemTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
