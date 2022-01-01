using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLogViewer
{
    public enum SearchEnum
    {
        Datetime,
        Address,
        Host,
        Url,
        Controller,
        Action,
        Method,
        StatusCode,
        Form,
        ContentType,
        Body,
        QueryString,
        IP,
        UserAgent,
        UserName,
        AdditionalInfo
    }
}
