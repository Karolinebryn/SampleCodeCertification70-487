using AzureDataStorage.TableStorage;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzureDataStorage.Pages
{
    public partial class TableStorage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillCustomersList();
            }
        }

        private CloudTableClient InitTableClient()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString;
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            var tableClient = storageAccount.CreateCloudTableClient();
            return tableClient;
        }

        protected void btnCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                var tableName = tbTableName.Text;
                var tableClient = InitTableClient();
                CloudTable table = tableClient.GetTableReference(tableName);
                table.CreateIfNotExists();

                lblCreateTableMessage.Text = "Table '" + tableName + "' successfuly created!";
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        protected void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            var firstName = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var phone = tbPhone.Text;
            var email = tbEmail.Text;

            try
            {
                var tableClient = InitTableClient();
                CloudTable table = tableClient.GetTableReference("customers");
                table.CreateIfNotExists();

                var customer = new CustomerEntity(lastName, firstName)
                {
                    Email = email,
                    PhoneNumber = phone
                };

                var insertOperation = TableOperation.Insert(customer);
                table.Execute(insertOperation);

                tbFirstName.Text = string.Empty;
                tbLastName.Text = string.Empty;
                tbPhone.Text = string.Empty;
                tbEmail.Text = string.Empty;
                lblCreateCustomerMessage.Text = "Customer '" + firstName + " " + lastName + "' is successfuly created!";
                FillCustomersList();
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        private void FillCustomersList(string lastname = null)
        {
            try
            {
                var tableClient = InitTableClient();
                CloudTable table = tableClient.GetTableReference("customers");
                table.CreateIfNotExists();

                var query = new TableQuery<CustomerEntity>();

                if (!string.IsNullOrEmpty(lastname))
                {
                    query = query.Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, lastname));
                }

                var result = table.ExecuteQuery(query);
                rpAllCustomers.DataSource = result;
                rpAllCustomers.DataBind();
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        protected void btnFilterLastName_Click(object sender, EventArgs e)
        {
            var lastname = tbFilterLastName.Text;
            FillCustomersList(lastname);
        }

        protected void btnQuery1_Click(object sender, EventArgs e)
        {
            try
            {
                var tableClient = InitTableClient();
                CloudTable table = tableClient.GetTableReference("customers");
                table.CreateIfNotExists();

                // Define the query, and select only the PhoneNumber property.
                var projectionQuery = new TableQuery<DynamicTableEntity>().Select(new string[] { "PhoneNumber" });

                // Define an entity resolver to work with the entity after retrieval.
                EntityResolver<string> resolver = (pk, rk, ts, props, etag) => props.ContainsKey("PhoneNumber") ? props["PhoneNumber"].StringValue : null;
                var phoneNumbersOnly = table.ExecuteQuery(projectionQuery, resolver, null, null);

                rpCustomers2.DataSource = phoneNumbersOnly;
                rpCustomers2.DataBind();
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }
    }
}