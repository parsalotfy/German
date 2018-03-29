namespace German.PageDataClasses.Konjugation
{
    public interface ITense<T> where T : IVerb
    {
        T SingularFirstPerson { get; set; }
        T SingularSecondPerson { get; set; }
        T SingularThirdPerson { get; set; }

        T PluralFirstPerson { get; set; }
        T PluralSecondPerson { get; set; }
        T PluralThirdPerson { get; set; }
    }
}
