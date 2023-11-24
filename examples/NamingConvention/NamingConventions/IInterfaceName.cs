namespace NamingConvention.NamingConventions
{
    public interface IInterfaceName
    {
    }


    // generic

    // use single letter for generic type
    // use T as type parameter
    public interface ISessionHelper<T>
    {
        T Session { get; }
    }

    // add descriptive type parameter with prefix T
    public interface ISessionChannel<TSession>
    {
        TSession Session { get; }
    }
}

// 'I' Prefix
// interface type
// same name with implementation eg. InterfaceNanme, SpecificInterfaceName
// Properties name should public
// case:                    PascalCasse
// Properties name case:    UpperPascalCase
// Method name case:        UpperPascalCase
