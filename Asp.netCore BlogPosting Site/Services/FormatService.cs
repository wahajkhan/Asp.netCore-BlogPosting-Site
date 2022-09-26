using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore_BlogPosting_Site.Services
{
    public class FormatService
    {
        public string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("dd-MMM-yyyy hh:mm:tt");
        }
    }
}
