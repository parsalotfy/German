namespace German.PageDataClasses.Konjugation
{
    public interface IVerb
    {
        //Pronomen VerbPronomen { get; set; }
        string VerbPronomen { get; set; }
        MainVerb MainPartOfVerb { get; set; }        
    }
}
