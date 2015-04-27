using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.WebAPI.Commons
{
    public class Enums
    {
        public enum ResponseStatus
        {
            OK = 1000,
            Failed = 1001,
            RequestTimeout = 1002,
            ServiceNotFound = 2000,
            ServerNotFound = 3000
        }
    }
}