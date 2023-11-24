using System.Xml;
using NamingConvention.NamingConventions.Enums;

namespace NamingConvention.NamingConventions            // namespace - PascalCase.PascalCase...
{
    public interface IInterfaceName { }                     // interface - PascalCase with "I" prefix
    public class ClassName { }
    public abstract class AbstractClassName { }         
    public static class StaticClassName { }
    public sealed class SealedClassName { }
    public partial class PartialClassName { }
    public struct StructName { }
    public record RecordName { }
    public enum EnumMode { }

    public delegate void DelegateType(string message);

    // other type
    public event DelegateType SampleEvent;
    (double Sum, int Count) t2 = (4.5, 3);
    int? optionalInt = default;

    public class ClassName
    {
        //    Constructors
        //    Constants
        //    Fields
        //    Finalizers
        //    Methods
        //    Properties
        //    Indexers
        //    Operators
        //    Events
        //    Delegates
        //    Classes
        //    Interfaces
        //    Structure types
        //    Enumeration types
        //    xRecord

        public readonly IInterfaceName InterfaceName1;
        private readonly IInterfaceName interfaceName1;
        protected readonly IInterfaceName interfaceName1;

        public IInterfaceName InterfaceName;
        private IInterfaceName interfaceName;
        protected IInterfaceName interfaceName;

        // Use camelCase for method arguments, local variables, and private fields.

        public ClassName()
        {

        }
    }

    public class Person // class name PascalCase
    {
        public const string DefaultName = "MD";             // constant - PascalCase

        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? JoinDate { get; set; }             // Field - PascalCase
    }

   

    public class SampleEventArgs
    {
        public SampleEventArgs(string text) { Text = text; }
        public string Text { get; } // readonly
    }

    public class Bad_ClassService                                   // class name PascalCase
    {
        public string s { get; set; }                               // avoid using abbreviations or acronyms in names, except for widely known and accepted abbreviations.
        public IList<string> PlayerNameList { get; set; }           // avoid using List postfix for  collection type datas, use plurar name
        public static const string SHIPPINGTYPE = "DropShip";
        ClassName cName;
        ClassName empClassName;
        public DateTime client_Appointment;
        public TimeSpan time_Left;

        // Exceptions
        CustomerId customerId;
        XmlDocument xmlDocument;
        FtpHelper ftpHelper;
        UriPart uriPart;
    }

    public class ClassService   // class name PascalCase
    {
        // constant - PascalCase
        public const string Format = "MD";                          // constant - PascalCase            

        // property - PascalCase
        public char CategoryType { get; set; }                      // PascalCase - char Property
        public string Firstname { get; set; }                       // PascalCase - string Property
        public bool IsJoined { get; set; }                          // PascalCase - bool Property
        public short JoinDay { get; set; }                          // PascalCase - short Property
        public int JoinMonth { get; set; }                          // PascalCase - int Property
        public long JoinYear { get; set; }                          // PascalCase - long Property
        public double PreviousAmount { get; set; }                  // PascalCase - double Property
        public float NewAmount { get; set; }                        // PascalCase - float Property
        public decimal ExpectedAmount { get; set; }                 // PascalCase - decimal Property
        public DateTime JoinDateTime { get; set; }                  // PascalCase - DateTime Property
        public TimeSpan JoinTime { get; set; }                      // PascalCase - TimeSpan Property
        public DateTimeOffset EffectiveDate { get; set; }           // PascalCase - DateTimeOffset Property
        public byte AvatarImage { get; set; }                       // PascalCase - byte Property
        public dynamic Address { get; set; }                        // PascalCase - dynamic Property
        public ICollection<string> Tags { get; set; }               // PascalCase - 
        public IList<string> ProductNames { get; set; }             // PascalCase - 
        public IList<string> Categories { get; set; }               // PascalCase - 
        public IEnumerable<string> Members { get; set; }            // PascalCase - 
        public Badge CategoryType { get; set; }                  // PascalCase - 
        public ClassName ClassName { get; set; }                    // PascalCase - 
        public IInterfaceName InterfaceNameInit { get; init; }      // PascalCase - init-only property interface  


        // field with interface
        public IInterfaceName InterfaceName;                        // public field - PascalCase
        protected IInterfaceName InterfaceName1;                    // protected field - PascalCase
        private IInterfaceName _interfaceName;                      // private instant field - _camelCase  with ( _ )
        internal IInterfaceName _interfaceName1;                    // internal field - _camelCase  with ( _ )


        // field with access modifier
        private string _privateField;                               // camelCase with underscore (_) prefix - private field 
        private int _count;                                         // camelCase with underscore (_) prefix - private field 
        protected string ProtectedField;                            // PascalCase - protected field
        public string PublicField;                                  // PascalCase - public field
        public bool IsValid;                                        // PascalCase - public field
        
        // field with readonly access modifier
        private readonly string _readonlyPrivate;
        private readonly int _value;
        public readonly IInterfaceName InterfaceName21;
        public static readonly IInterfaceName InterfaceName22;
        protected readonly IInterfaceName InterfaceName23;
        protected static readonly IInterfaceName InterfaceName24;

        // field with static
        private static IInterfaceName s_workerQueue;                // private static field - s_camelCase  with s_ prefix
        private static readonly IInterfaceName s_workerQueue1;      // private  readonly static field - s_camelCase & static should come before readonly 
        internal static IInterfaceName s_workerQueue2;              // internal static field - s_camelCase  with s_ prefix


        // You cannot use the virtual modifier with the static, abstract, private, or override modifiers
        public virtual string s1_workerQueue1 { get; set; }

       [ThreadStatic]
        private static TimeSpan t_timeSpan;                         // private thread static field - t_camelCase  with t_ prefix
        [ThreadStatic]
        internal static TimeSpan t_timeSpan1;                       // internal thread static field - t_camelCase  with t_ prefix

        // delegate
        public delegate void SampleEventHandler(object sender, SampleEventArgs e);

        // event
        public event SampleEventHandler SampleEvent;                // PascalCase - event 
        public event Action EventProcessing;                        // PascalCase - event 

        public ClassService(IInterfaceName interfaceName)           // parameter name - camelCase
        {
            InterfaceName = interfaceName;
            _interfaceName = interfaceName;
        }

        public string StartProcess()                                // method name - PascalCase
        {
            return string.Empty;
        }

        public async Task<string> StartProcessAsync()               // async method name - PascalCase with Async postfix
        {
            return await Task.FromResult(string.Empty);
        }

        public string Add(string firstname,
            string lastname,
            DateTime? joinDate,
            bool isValid)                                           // method parameter name - camelCase
        {
            bool addedPerson = true;                                // local variable - camelCase
            const int OnePerson = 1;                                // local const - PascalCase

            var person = new Person();                              // use var when the type is explicitly named on the right-hand side
            
            var process = StartProcess();                           // don't use var when the type is explicitly named on the right-hand side, rather use string process = StartProcess()

            string process1 = StartProcess();
            Person person1 = new();

            return string.Empty;
        }
    }

    public class GenericClassName<T>
    {
        public void Add(T input) { }
    }

    public class MultipleGenericClassName<T>
    {
        public void Add(T input) { }
    }
}


// editor config
// https://stackoverflow.com/questions/28461204/whats-the-standard-naming-convention-for-readonly-static-logger-field

// We avoid this. unless absolutely necessary.
// We always specify the visibility, even if it's the default (e.g. private string _foo not string _foo).
// Visibility should be the first modifier (e.g. public abstract not abstract public).
// Namespace imports should be specified at the top of the file, outside of namespace declarations, and should be sorted alphabetically, with the exception of System.* namespaces, which are to be placed on top of all others.
// Avoid more than one empty line at any time. For example, do not have two blank lines between members of a type.
// Avoid spurious free spaces
// We use nameof(...) instead of name of a string
// Fields should be specified at the top within type declarations.




// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
// ** https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md



//https://en.wikipedia.org/wiki/Indentation_style
// Allman style - bracket on seperate line
//if(indexer == 10)
//{
//    value = 100
//}

// BSD KNF
//if(indexer == 10){
//    value = 100
//}


// Whitesmiths style
//if (indexer == 10)
//    {
//        value = 100;
//    }

// Horstmann style
//if (indexer == 10)
//{   int i = 11;
//    value = 100;
//}


// Pico style
//if (indexer == 10)
//{ int i = 11;
//  value = 100;}