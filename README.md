# SampleCodeCertification70-487
Some sample code related to the topics covered in exam 70-487

## Project descriptions

### AzureDataStorage
Blob Storage: create and list containers; upload blob to container and list all blobs in container.
Table Storage: create new table; add, get and query rows in table; query subset of entity properties; map entity to table
Queue Storage: create queue; insert message in queue; peek and get messages in queue.

### Caching
Add() and Insert() to cache, CacheDependency

### Data.AdventureWorks
AdventureWorksModel (EF6). Model from database. Database used is AdventureWorksLT (sample database on Azure).

### EntityFrameworkSample
Not a complete example project, and the nameing on some files is not right. 
It contains som simple operations using the EF Entities (DbContext); LazyLoading; Entity SQL; Async; Using Stored Procedure with EF.

This project is also using the AdventureWorks sample database (but not the EF model in Data.AdventureWorks)

### Linq to XML
Process XML using the DOM Model (create document, accessing attributes, read, remove nodes and attributes); 
Process XML using the XPath Data Model (read document, select using XPathNavigator, Queries and namespaces, editing XML data); 
Process XML Data Using Linq to XML (create document, load from file, parse string to XML, filter XML using linq).

### NuGetExample
Hosting your own NuGet feed. Run this site to get your NuGet url. Then create a new Package source using this url. 
See https://docs.nuget.org/create/hosting-your-own-nuget-feeds

### NuGetPackageExample
A project that is packed to a nuget package, and the .nupkg file is copied into the "~/Package" folder in the NuGetExample project.
See https://docs.nuget.org/create/creating-and-publishing-a-package

### WcfClient.AdventureWorks
A web application that is consuming both WcfDataService.AdventureWorks and WcfService.AdventureWorks. 
To show the differences between WCF Data Service and WCF Service. 
WCF Data Service: how to query using linq. 
WCF Service: fault exception.

### WcfClient.CallbackExample
A simple console application showing how to consume and use Duplex/Callback with WcfService.CallbackExample.

### WcfDataService.AdventureWorks
A simple WCF Data Service, using Data.AdventureWorks as data access layer. Set up service and include exception details.
See WcfClient.AdventureWorks on how to consume and use this service.

### WcfService.AdventureWorks
A simple WCF Service showing data with service contracts and data contracts. Using the Data.AdventureWorks as data access layer.
See WcfClient.AdventureWorks on how to consume and use this service.

### WcfService.CallbackExample
A simple WCF Service demonstrating Duplex/Callback. See WcfClient.CallbackExample on how to consume and use this service.

### WebApi.AdventureWorks
A simple web api using Data.AdventureWorks as data layer. Simple get/put calls; Async call; Basic authentication with tokens.
