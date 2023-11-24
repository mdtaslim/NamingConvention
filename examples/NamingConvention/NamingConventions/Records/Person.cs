namespace NamingConvention.NamingConventions.Records
{
    public record Person
    {
        public required string Firstname { get; init; }
        public required string Lastname { get; init; }
    };

    //public record Person(string FirstName, string LastName);

    //public readonly record struct Point(double X, double Y, double Z);
    //public record struct Point
    //{
    //    public double X { get; init; }
    //    public double Y { get; init; }
    //    public double Z { get; init; }
    //}
}
