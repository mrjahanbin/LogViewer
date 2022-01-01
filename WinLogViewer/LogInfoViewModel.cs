using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLogViewer
{
    public class LogInfoViewModel
    {
        public string Datetime { get; set; }
        public string Address { get; set; }
        public string Host { get; set; }
        public string Url { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Method { get; set; }
        public string StatusCode { get; set; }
        public string Form { get; set; }
        public string ContentType { get; set; }
        public string Body { get; set; }
        public string QueryString { get; set; }
        public string IP { get; set; }
        public string UserAgent { get; set; }
        public string UserName { get; set; }
        public string AdditionalInfo { get; set; }


    }
}
