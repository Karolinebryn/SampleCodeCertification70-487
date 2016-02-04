using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.AdventureWorks.Models
{
    public class Result
    {
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
        public object Data { get; set; }
    }
}