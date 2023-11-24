namespace NamingConvention.NamingConventions.Structs
{
    public interface ICounter
    {
        void Increment();
    }

    public struct Counter : ICounter
    {
        int value;

        public override string ToString() => value.ToString();

        void ICounter.Increment() => value++;
    }
}
