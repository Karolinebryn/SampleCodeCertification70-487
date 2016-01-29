using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzureDataStorage.Pages
{
    public partial class BlobStorage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillExistingContainersLists();
                FillBlobsInContainerList();
            }
        }

        private void FillBlobsInContainerList()
        {
            var blobClient = InitBlobClient();
            var container = blobClient.GetContainerReference("upload-files");
            var output = "<ul>";

            foreach (IListBlobItem item in container.ListBlobs(null, false))
            {            
                if (item.GetType() == typeof(CloudBlockBlob))
                {
                    CloudBlockBlob blob = (CloudBlockBlob)item;
                    output += "<li> Block blob of length " + blob.Properties.Length + ": " + blob.Uri + "</li>";

                }
                else if (item.GetType() == typeof(CloudPageBlob))
                {
                    CloudPageBlob pageBlob = (CloudPageBlob)item;
                    output += "<li>Page blob of length " + pageBlob.Properties.Length + ": " + pageBlob.Uri + "</li>";

                }
                else if (item.GetType() == typeof(CloudBlobDirectory))
                {
                    CloudBlobDirectory directory = (CloudBlobDirectory)item;
                    output += "<li>Directory: " + directory.Uri + "</li>";
                }
            }
            output += "</ul>";
            literalBlobsInContainer.Text = output;
        }

        private CloudBlobClient InitBlobClient()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString;
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            var blobClient = storageAccount.CreateCloudBlobClient();
            return blobClient;
        }

        protected void btnSelectContainer_Click(object sender, EventArgs e)
        {
            lblCreateContainerResult.Text = "";
            var containerName = tbContainerName.Text;

            try
            {
                var blobClient = InitBlobClient();
                var container = SelectBlobContainer(blobClient, containerName);

                tbContainerName.Text = "";
                lblCreateContainerResult.Text = "Container '" + containerName + "' is selected!";
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        private CloudBlobContainer SelectBlobContainer(CloudBlobClient blobClient, string containerName)
        {
            CloudBlobContainer container = blobClient.GetContainerReference(containerName);
            var wasCreated = container.CreateIfNotExists();

            if (wasCreated)
            {
                container.SetPermissions(new BlobContainerPermissions
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
                });

                FillExistingContainersLists();
            }
            return container;
        }

        private void FillExistingContainersLists()
        {
            try
            {
                var blobClient = InitBlobClient();
                var containers = blobClient.ListContainers();
                rpExistingContainers.DataSource = containers;
                rpExistingContainers.DataBind();
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        protected void btnUploadToContainer_Click(object sender, EventArgs e)
        {
            if (fileUploadToContainer.HasFile)
            {
                try
                {
                    var blobClient = InitBlobClient();
                    var container = blobClient.GetContainerReference("upload-files");
                    var blockBlob = container.GetBlockBlobReference(fileUploadToContainer.FileName);

                    var stream = fileUploadToContainer.PostedFile.InputStream;
                    blockBlob.UploadFromStream(stream);
                    lblUploadStatus.Text = "File successfully added to blob storage";
                }
                catch (Exception ex)
                {
                    lblUploadStatus.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
    }
}