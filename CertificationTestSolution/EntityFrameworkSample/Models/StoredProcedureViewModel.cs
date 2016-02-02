using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkSample.Models
{
    public class StoredProcedureViewModel
    {
        public IEnumerable<ufnGetAllCategories_Result> Categories { get; internal set; }
        public ufnGetCustomerInformation_Result Customer { get; internal set; }
    }
}