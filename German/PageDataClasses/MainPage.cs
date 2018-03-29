using German.PageDataClasses.Header;
using German.PageDataClasses.Konjugation;
using HtmlAgilityPack;

namespace German.PageDataClasses
{
    [HasXPath]
    public class MainPage
    {
        [XPath("((//div[@class='wrapperW']/div[@class='word-wrap']/div[@id='ch_divSimple']/div[@class='result-block-api']//div[@class='word-wrap-row'])[1]//div[@class='wrap-three-col'])[1]")]
        public IndikativPrasensTense PresentTense2 { get; set; }



        /*
        [XPath("//div[@class='wrapperW']/div[@id='ch_divConjugatorHeader']")]
        public HeaderKonjugation Header { get; set; }
        */


        [XPath("((//div[@class='wrapperW']/div[@class='word-wrap']/div[@id='ch_divSimple']/div[@class='result-block-api']//div[@class='word-wrap-row'])[1]//div[@class='wrap-three-col'])[1]")]        
        public IndikativPrasensTense PresentTense { get; set; }

        
        [XPath("((//div[@class='wrapperW']/div[@class='word-wrap']/div[@id='ch_divSimple']/div[@class='result-block-api']//div[@class='word-wrap-row'])[2]//div[@class='wrap-three-col'])[1]")]
        public IndikativPerfektTense PerfektTense { get; set; }

        
        [XPath("((//div[@class='wrapperW']/div[@class='word-wrap']/div[@id='ch_divSimple']/div[@class='result-block-api']//div[@class='word-wrap-row'])[5]//div[@class='wrap-three-col'])[3]")]
        public ImperativPresentTense ImperativTense { get; set; }
        
    }
}
