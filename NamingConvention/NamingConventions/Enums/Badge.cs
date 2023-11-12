namespace NamingConvention.NamingConventions.Enums
{
    [Flags]
    public enum Badge
    {
        Gold,
        Platinum,
        Diamond,
        All = (Diamond | Platinum) & Gold
    }
}
