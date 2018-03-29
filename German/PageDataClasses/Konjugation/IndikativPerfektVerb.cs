using HtmlAgilityPack;
using System;

namespace German.PageDataClasses.Konjugation
{
    [HasXPath]
    public class IndikativPerfektVerb : IVerb
    {
        // Ich habe eingeladen :

            // Pronomen
        [XPath("/i[@class='graytxt']")]
        //public Pronomen VerbPronomen { get; set; } // "Ich"
        public string VerbPronomen { get; set; } // "Ich"

        [XPath("/i[@class='auxgraytxt']")]
        public string Auxiliaryverb { get; set; } // "habe"

        [XPath("(/i[@class='verbtxt norightspace'])[1]")]
        public string ParticleText { get; set; } // "ein"

        [XPath("(/i[@class='verbtxt norightspace'])[2]")]
        public string Ge { get; set; }// "ge"

        [XPath("/i[@h='1']")]
        public MainVerb MainPartOfVerb { get; set; } // "l" + "ade"

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
