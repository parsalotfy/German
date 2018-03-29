using HtmlAgilityPack;

namespace German.PageDataClasses.Konjugation
{
    [HasXPath]
    public class ImperativPresentTense : ITense<ImperativVerb>
    {

        public ImperativVerb SingularFirstPerson { get; set; } // !

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[1]")]
        public ImperativVerb SingularSecondPerson { get; set; } // Lade ein.

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[4]")]
        public ImperativVerb SingularSecondPersonFormell { get; set; } // Laden Sie ein.


        public ImperativVerb SingularThirdPerson { get; set; } // !

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[2]")]
        public ImperativVerb PluralFirstPerson { get; set; } // Laden wir ein.

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[3]")]
        public ImperativVerb PluralSecondPerson { get; set; } // Ladet ihr ein.


        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[4]")]
        public ImperativVerb PluralSecondPersonFormell { get; set; } // Laden Sie ein.


        public ImperativVerb PluralThirdPerson { get; set; } // !
    }
}
