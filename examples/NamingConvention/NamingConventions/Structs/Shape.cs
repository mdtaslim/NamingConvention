namespace NamingConvention.NamingConventions.Structs
{
    public readonly struct Shape
    {
        private readonly string _type;

        public double Width { get; init; }
        public double Height { get; init; }

        public Shape(string type, double width, double height)
        {
            _type = type;
            Width = width;
            Height = height;
        }

        public readonly override string ToString() => $"({Width}, {Height})";

        public readonly double Area()
        {
            return Width * Height;
        }
    }
}
