using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class PublicResult
    {
        public bool IsSuccess { get; set; }

        public string ErrorCode { get; set; }

        public string Message { get; set; }

        public dynamic Data { get; set; }
    }
}