using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace German.PageDataClasses.Header
{
    [HasXPath]
    public class HeaderKonjugation
    {
        [XPath("//div[2]/p[1]/h3/a")]
        public string Infinitiv { get; set; }

        [XPath("//div[2]/p[3]/h3/a")]
        public string PartizipPerfekt { get; set; }
    }
}
