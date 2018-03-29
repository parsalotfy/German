using HtmlAgilityPack;

namespace German.PageDataClasses.Konjugation
{
    [HasXPath]
    public class IndikativPrasensTense : ITense<IndikativPrasensVerb>
    {
        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[1]")]
        public IndikativPrasensVerb SingularFirstPerson { get; set; }

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[2]")]
        public IndikativPrasensVerb SingularSecondPerson { get; set; }

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[3]")]
        public IndikativPrasensVerb SingularThirdPerson { get; set; }




        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[4]")]
        public IndikativPrasensVerb PluralFirstPerson { get; set; }

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[5]")]
        public IndikativPrasensVerb PluralSecondPerson { get; set; }

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[6]")]
        public IndikativPrasensVerb PluralThirdPerson { get; set; }
                
    }
}
