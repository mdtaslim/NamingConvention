namespace NamingConvention.NamingConventions
{
    public record RecordName
    {
    }

    public record class RecordName
    {
    }

    public record struct RecordName
    {
        private char _firstElement;
    }

    public readonly record struct Measurement
    {
        public Measurement()
        {
            Value = double.NaN;
            Description = "Undefined";
        }


        public Measurement(double value, string description)
        {
            Value = value;
            Description = description;
        }

        public double Value { get; init; }
        public string Description { get; init; }

        public override string ToString() => $"{Value} ({Description})";
    }
}
