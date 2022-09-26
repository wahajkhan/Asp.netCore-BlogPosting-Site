using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore_BlogPosting_Site.Models
{
    public class MonthlySpeacial
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImgSrc { get; set; }
        public string ImgAlt { get; set; }
        public int Price { get; set; }
    }
}
