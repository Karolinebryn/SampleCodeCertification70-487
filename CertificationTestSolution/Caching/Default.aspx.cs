using System;
using System.Web.Caching;
using System.Web.UI;
using System.Xml;

namespace Caching
{
    public partial class _Default : Page
    {
        static int _counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        static bool itemRemoved = false;
        static CacheItemRemovedReason reason;
        CacheItemRemovedCallback onRemove = null;

        //TOTEST: set breakpoint here
        //Run solution and click AddItemToCache button
        //Either click RemoveItemFromCache button OR wait 60+ seconds and see that this event is fired
        public void RemovedCallback(string k, object v, CacheItemRemovedReason r)
        {
            itemRemoved = true;
            reason = r;
            //Callback cannot access placeholders in aspx file
            //lblResult.Text = "RemovedCallback event raised. Reason: " + reason;
        }

        public void AddItemToCache(Object sender, EventArgs e)
        {
            itemRemoved = false;

            onRemove = new CacheItemRemovedCallback(RemovedCallback);

            if (Cache["Key1"] == null)
                Cache.Add("Key1", "Value 1", null, DateTime.Now.AddSeconds(60), Cache.NoSlidingExpiration, CacheItemPriority.High, onRemove);

            lblResult.Text = "Value of cache key: " + Cache["Key1"];
        }

        public void RemoveItemFromCache(Object sender, EventArgs e)
        {
            if (Cache["Key1"] != null)
                Cache.Remove("Key1");
            lblResult.Text = "Removing from cache";
        }

        public void InsertItemToCache(Object sender, EventArgs e)
        {
            Cache.Insert("Key2", "Value 2 counter: " + _counter);
            var item = Cache.Get("Key2");
            lblResult2.Text = "Inserting item to cache: " + item;
            _counter++;
        }

        public void InsertItemWithDependency(Object sender, EventArgs e)
        {
            var uri = Server.MapPath("~/App_Data/books.xml");
            var document = new XmlDocument();
            document.Load(uri);

            var dependency = new CacheDependency(uri);
            Cache.Insert("Books", document, dependency);

            if (dependency.HasChanged)
            {
                //load document again
            }

            lblResult3.Text = "Books is added to cache with dependency";
        }

        private void CheckIfBooksIsInCache()
        {
            if (Cache["Books"] != null)
                lblResult3.Text = "Books is still in cache";
            else
                lblResult3.Text = "Books is not in cache";
        }

        public void CheckIfItemWithDependencyExists(Object sender, EventArgs e)
        {
            CheckIfBooksIsInCache();
        }
    }
}