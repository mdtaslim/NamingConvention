namespace NamingConvention.NamingConventions
{
    [Flags]
    public enum EnumName
    {
        One,
        Two,
        Three,
        All = (One | Two) & Three
    }
}
