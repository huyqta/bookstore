using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.WebAPI.Commons
{
    public class ApiResult
    {
        public string message { get; set; }
        public string status { get; set; }
        public string response { get; set; }
    }
}