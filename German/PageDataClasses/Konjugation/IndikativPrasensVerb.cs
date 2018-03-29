using HtmlAgilityPack;

namespace German.PageDataClasses.Konjugation
{
    [HasXPath]
    public class IndikativPrasensVerb : IVerb
    {
        // Ich lade ein :

        [XPath("/i[@class='graytxt']")]
        //public Pronomen VerbPronomen { get; set; } // "Ich"
        public string VerbPronomen { get; set; } // "Ich"

        [XPath("/i[@h='1']")]
        public MainVerb MainPartOfVerb { get; set; } // "l" + "ade"

        [XPath("i[@class='particletxt']")]
        public string ParticleText { get; set; } // "ein"

        public override string ToString()
        {
            return ParticleText == null ? MainPartOfVerb.ToString() : MainPartOfVerb + " " + ParticleText;
        }

    }
}