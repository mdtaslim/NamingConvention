namespace NamingConvention.NamingConventions.Structs
{
    public struct Employee
    {
        public double Firstname { get; }
        public double Lastname { get; }

        public Employee(double firstname, double lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public override string ToString() => $"({Firstname}, {Lastname})";
    }
}
