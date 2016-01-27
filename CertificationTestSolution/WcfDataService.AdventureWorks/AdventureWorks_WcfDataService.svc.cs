//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using Data.AdventureWorks;
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace WcfDataService.AdventureWorks
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class AdventureWorks_WcfDataService : EntityFrameworkDataService<AdventureWorksEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("SalesOrderHeaders", EntitySetRights.AllRead | EntitySetRights.WriteMerge | EntitySetRights.WriteReplace);
            config.SetEntitySetAccessRule("SalesOrderDetails", EntitySetRights.AllRead | EntitySetRights.AllWrite);
            config.SetEntitySetAccessRule("Customers", EntitySetRights.AllRead);

            config.UseVerboseErrors = true;
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

        //protected override void HandleException(HandleExceptionArgs args)
        //{
        //    if ((args.Exception is TargetInvocationException) && args.Exception.InnerException != null)
        //    {
        //        if (args.Exception.InnerException is DataServiceException)
        //            args.Exception = args.Exception.InnerException as DataServiceException;
        //        else
        //            args.Exception = new DataServiceException(400, args.Exception.InnerException.Message);
        //    }
        //}
    }
}
