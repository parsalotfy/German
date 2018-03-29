using HtmlAgilityPack;
using System;

namespace German.PageDataClasses.Konjugation
{
    [HasXPath]
    public class ImperativVerb : IVerb
    {
        // Laden Sie ein!

        [XPath("/i[@h='1']")]
        public MainVerb MainPartOfVerb { get; set; } // "l" + "aden"

        [XPath("/i[@class='graytxt']")]
        //public Pronomen VerbPronomen { get; set; } // "Sie"        
        public string VerbPronomen { get; set; } // "Sie"        

        [XPath("/i[@class='particletxt']")]
        public string ParticleText { get; set; } // "ein"

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
