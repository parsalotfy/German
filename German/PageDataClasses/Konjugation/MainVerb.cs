using HtmlAgilityPack;

namespace German.PageDataClasses.Konjugation
{
    [HasXPath]
    public class MainVerb
    {
        [XPath("/i[@class='verbtxt']")]
        public string Text { get; set; }

        [XPath("/i[@class='verbtxt-term']")]
        public string TextTerm { get; set; }

        public override string ToString()
        {
            return Text + TextTerm;
        }
    }
}
