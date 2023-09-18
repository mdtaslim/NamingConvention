namespace NamingConvention.NamingConventions
{
    public class StructName
    {
        public double FirstValue { get; }
        public double SecondValue { get; }

        public StructName(double firstValue, double secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }

        public override string ToString() => $"({FirstValue}, {FirstValue})";
    }

    public readonly struct ReadonlyStructName
    {
        private readonly string _name;

        public double FirstValue { get; init; }
        public double SecondValue { get; init; }

        public ReadonlyStructName(string name, double firstValue, double secondValue)
        {
            _name = name;
            FirstValue = firstValue;
            SecondValue = secondValue;
        }

        public readonly override string ToString() => $"({FirstValue}, {FirstValue})";

        public readonly double Sum()
        {
            return FirstValue + SecondValue;
        }
    }
}
