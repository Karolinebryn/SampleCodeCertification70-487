using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Configuration;

namespace AzureDataStorage.Pages
{
    public partial class QueueStorage : System.Web.UI.Page
    {
        public object CloudConfigurationManager { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private CloudQueueClient InitQueueClient()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString;
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
            return queueClient;
        }

        protected void btnCreateQueue_Click(object sender, EventArgs e)
        {
            var queueName = tbQueueName.Text;

            try
            {
                var queueClient = InitQueueClient();
                CloudQueue queue = queueClient.GetQueueReference(queueName);

                // Create the queue if it doesn't already exist
                queue.CreateIfNotExists();
                lblCreateQueueMessage.Text = "Queue '" + queueName + "' is successfuly created!";
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        protected void tbInsertMessage_Click(object sender, EventArgs e)
        {
            var messageText = tbMessageText.Text;
            try
            {
                var queueClient = InitQueueClient();
                CloudQueue queue = queueClient.GetQueueReference("my-messages");
                queue.CreateIfNotExists();

                // Create a message and add it to the queue.
                CloudQueueMessage message = new CloudQueueMessage(messageText);
                queue.AddMessage(message);

                lblInsertMessageMessage.Text = "Message '" + messageText + "' is successfuly inserted to queue!";
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }


        protected void btnPeekMessages_Click(object sender, EventArgs e)
        {
            try
            {
                var queueClient = InitQueueClient();
                CloudQueue queue = queueClient.GetQueueReference("my-messages");

                var messages = queue.PeekMessages(10);
                var result = "<p>";

                foreach(var message in messages)
                {
                    result += message.AsString + "<br />";
                }

                result += "</p>";
                lblPeekAllMessagesResult.Text = result;
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        protected void btnGetMessage_Click(object sender, EventArgs e)
        {
            try
            {
                var queueClient = InitQueueClient();
                CloudQueue queue = queueClient.GetQueueReference("my-messages");
                //get message at top of queue
                var message = queue.GetMessage();
                //delete message from queue after fetching it
                queue.DeleteMessage(message);

                lblGetMessageResult.Text = "Message is fetched and removed from queue. Message: " + message.AsString;
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }
    }
}