using HtmlAgilityPack;

namespace German.PageDataClasses.Konjugation
{
    [HasXPath]
    public class IndikativPerfektTense : ITense<IndikativPerfektVerb>
    {
        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[1]")]
        public IndikativPerfektVerb SingularFirstPerson { get; set; }

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[2]")]
        public IndikativPerfektVerb SingularSecondPerson { get; set; }

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[3]")]
        public IndikativPerfektVerb SingularThirdPerson { get; set; }




        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[4]")]
        public IndikativPerfektVerb PluralFirstPerson { get; set; }

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[5]")]
        public IndikativPerfektVerb PluralSecondPerson { get; set; }

        [XPath("/div[@class='blue-box-wrap']/ul[@class='wrap-verbs-listing']/li[6]")]
        public IndikativPerfektVerb PluralThirdPerson { get; set; }
    }
}
