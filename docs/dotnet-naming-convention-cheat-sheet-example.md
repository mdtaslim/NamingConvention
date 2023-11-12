# Dotnet Naming Convention

- [Dotnet Naming Convention](#dotnet-naming-convention)
- [DOTNET Naming Convention](#dotnet-naming-convention-1)
  - [Common naming convention](#common-naming-convention)
    - [Choose your words](#choose-your-words)
    - [Naming Convention Case](#naming-convention-case)
    - [Naming Convention Case Type](#naming-convention-case-type)
    - [Naming Convention Word Type](#naming-convention-word-type)
    - [Some bad names](#some-bad-names)
  - [Convention rules](#convention-rules)
    - [Assemblies](#assemblies)
      - [DLL / EXE](#dll--exe)
    - [namespace](#namespace)
    - [type](#type)
      - [class](#class)
      - [Struct](#struct)
      - [enum (enumuration)](#enum-enumuration)
      - [record](#record)
      - [interface](#interface)
      - [abstract](#abstract)
      - [Names of Common Types](#names-of-common-types)
    - [Names of Type Members](#names-of-type-members)
      - [Methods](#methods)
      - [Properties](#properties)
      - [Events](#events)
      - [Fields](#fields)
      - [Generic](#generic)
      - [Nullable types](#nullable-types)
      - [Tuples](#tuples)
    - [DbContext](#dbcontext)
    - [More suffix](#more-suffix)
    - [LINQ](#linq)
    - [Message Broker](#message-broker)
    - [Unit Test](#unit-test)

# DOTNET Naming Convention
**Improved Communication** — “The best code communicates itself” . Any member of a development will be able to read and understand the code of another member through code.  
**Improved Code integration** — Distinct teams that rely on the code built by other teams won’t have problem understanding properly named interface and its entities.  
**Improved Consistency** — Helps formalize expectations and promote consistency within a development team.  
**Improved clarity** — Provides better understanding in case of code reuse after a long interval of time. Enhances clarity in cases of potential ambiguity.

**Note**: this guideline is only for naming convention. No code quality rules (except naming conventions) are added in this guideline.

## Common naming convention 
- ✅ Do use word (descriptive names) which have to reveal your intention
- ✅ Do follow consistent and meaningful single guideline for naming convention. For your organization / project / team wise
- ✅ Do follow same pattern for a single guideline. eg. GetUsers, GetUserById instead of FetchUsers, GetUserById
- ✅ Do use PascalCase / camelCase
- ✅ Do use PascalCase for abbreviations with 3 or more chars. eg. `FtpTransfer` 
- ✅ Do use both uppercase for 2 char abbreviations. eg. `UIControl`
- ✅ Do use implicit type var for local variable declarations. eg. `var customers = new Dictionary();`
- ✅ Do use meaningful names in domain context 
- DO use PascalCasing for all public member, type, and namespace names consisting of multiple words.
- ✅ DO use camelCasing for parameter names.

- ❌ Do not use one or two chars name
- ❌ Do not use abbreviations
- ❌ Do not use meaningless, disinfromative word
- ❌ Do not use avoid multi meaning word
- ❌ Do not use underscore or hyphen in your name
- ❌ Do not use hungarian notation, eg. `iName` for `int name`
- ❌ Do not use type identification. eg. `strName` for `string name`
- ❌ Do not use Screaming Caps (all uppercase) for local / global variables. eg. SHIPPINGTYPE 
- ❌ Do not use Screaming Caps (all uppercase) for constants or readonly variables. eg. SHIPPINGTYPE 
- ❌ Do not use abbreviations. except some commonly used abbreviations, eg. Id, Xml, Ftp, Uri
- ❌ Do not use same variable name with case sensitive
- ❌ DO NOT capitalize each word in so-called closed-form compound words. eg. FileName, PlaceHolder, EMail

### Choose your words
- ✅ choose easily readable identifier names.
  For example, a property named HorizontalAlignment is more English-readable than AlignmentHorizontal.
- ✅ DO favor readability over brevity.
  The property name CanScrollHorizontally is better than ScrollableX (an obscure reference to the X-axis).
- ✅ DO use semantically interesting names rather than language-specific keywords for type names.
  For example, GetLength is a better name than GetInt.

- ❌ DO NOT use underscores, hyphens, or any other nonalphanumeric characters.
- ❌ DO NOT use Hungarian notation.
- ❌ AVOID using identifiers that conflict with keywords of widely used programming languages.
- ❌ DO NOT use abbreviations or contractions as part of identifier names.
  For example, use GetWindow rather than GetWin.
- ❌ DO NOT use any acronyms that are not widely accepted, and even if they are, only when necessary.

- ✅ DO use a name similar to the old API when creating new versions of an existing API. This helps to highlight the relationship between the APIs.
- ✅ DO prefer adding a suffix rather than a prefix to indicate a new version of an existing API.
This will assist discovery when browsing documentation, or using IntelliSense. The old version of the API will be organized close to the new APIs, because most browsers and IntelliSense show identifiers in alphabetical order.
- ✅ CONSIDER using a brand new, but meaningful identifier, instead of adding a suffix or a prefix.
- ✅ DO use a numeric suffix to indicate a new version of an existing API, particularly if the existing name of the API is the only name that makes sense (i.e., if it is an industry standard) and if adding any meaningful suffix (or changing the name) is not an appropriate option.
- ✅ DO use the "64" suffix when introducing versions of APIs that operate on a 64-bit integer (a long integer) instead of a 32-bit integer. You only need to take this approach when the existing 32-bit API exists; don't do it for brand new APIs with only a 64-bit version.
- ❌ DO NOT use the "Ex" (or a similar) suffix for an identifier to distinguish it from an earlier version of the same API.
  
### Naming Convention Case
| Identifier                        | Casing      | Length | Plural | Word Type       | Example                                  |
| :-------------------------------- | ----------- | ------ | ------ | --------------- | ---------------------------------------- |
| Namespace                         | PascalCase  |        | ✅     | Noun            | System.Security                          |
| Type                              | PascalCase  |        |        | Noun            | public class StreamReader { ... }        |
| Class                             | PascalCase  |        |        | Noun            |                                          |
| Abstract class                    | PascalCase  |        |        | Noun            |                                          |
| Sealed Class                      | PascalCase  |        |        | Noun            |                                          |
| Partial Class                     | PascalCase  |        |        | Noun            |                                          |
| Static Class                      | PascalCase  |        |        | Noun            |                                          |
| Struct                            | PascalCase  |        |        | Noun            |                                          |
| Record                            | PascalCase  |        |        | Noun            |                                          |
| Interface                         | IPascalCase |        |        | Noun            | IEnumerable                              |
| Enum                              |             |        |        | Noun            | public enum FileMode {}                  |
| Enum (Flags)                      | PascalCase  |        | ✅     | Noun            | [Flags] public enum FileTypes {}         |
| Event                             |             |        |        | Noun            | public event EventHandler Exited;        |
| Delegate                          | PascalCase  |        |        | Noun            |                                          |
| const - local                     | PascalCase  |        |        | Noun, Adjective |                                          |
| const - global                    | PascalCase  |        |        | Noun, Adjective |                                          |
| Field - public                    | PascalCase  |        |        | Noun, Adjective | public static readonly TimeSpan          |
| Field - protected                 | PascalCase  |        |        | Noun, Adjective |                                          |
| Field - private                   | _camelCase  |        |        | Noun, Adjective |                                          |
| Field -  internal                 |             |        |        |                 |                                          |
| Field - protected internal        |             |        |        |                 |                                          |
| Field - private protected         |             |        |        |                 |                                          |
| Field - public readonly           | PascalCase  |        |        | Noun, Adjective |                                          |
| Field - private readonly          | _camelCase  |        |        | Noun, Adjective |                                          |
| Field - protected  readonly       | PascalCase  |        |        | Noun, Adjective |                                          |
| Field List, Collection etc        | PascalCase  |        | ✅     | Noun, Adjective | public List<string> Customers { get; }   |
| Property                          |             |        |        | Noun, Adjective |                                          |
| Property                          |             |        |        | Noun, Adjective |                                          |
| Property                          |             |        |        | Noun, Adjective |                                          |
| Property                          |             |        |        | Noun, Adjective |                                          |
| Property                          |             |        |        | Noun, Adjective |                                          |
| Property                          |             |        |        | Noun, Adjective |                                          |
| Property                          |             |        |        | Noun, Adjective |                                          |
| Property - public virtual         |             |        |        | Noun, Adjective |                                          |
| Property - public static readonly |             |        |        | Noun, Adjective |                                          |
| Method                            | PascalCase  |        | ✅     | verb            | public virtual string ToString();        |
| Method - constructor              | PascalCase  |        |        | Noun            |                                          |
| Method - private                  | PascalCase  |        |        | Noun            |                                          |
| Method - protected                | PascalCase  |        |        | Noun            |                                          |
| Method - public virtual           | PascalCase  |        |        | Noun            |                                          |
| Parameter                         | camelCase   |        |        | Noun            | public static int ToInt32(string value); |
| Local Variable                    | camelCase   |        |        | Noun            |                                          |


### Naming Convention Case Type
| Case Type       | Resource                                                                       |
| --------------- | ------------------------------------------------------------------------------ |
| PascalCase      | Type - (class, enum, struct, record), delegate, event, field, property, method |
| IPascalCase     | interface                                                                      |
|                 |                                                                                |
| CamelCase class | method parameter, local variable                                               |
| _CamelCase      | property (private, private readonly)                                           |

### Naming Convention Word Type
| Word Type | Resource                                                               |
| --------- | ---------------------------------------------------------------------- |
| Nown      | Type - (class, enum, struct, record), delegate, event, field, property |
| Verb      | method                                                                 |
|           |                                                                        |
| Adjective | local variable                                                         |
|           |                                                                        |


| Pascal      | Camel       | Not                |
| ----------- | ----------- | ------------------ |
| BitFlag     | bitFlag     | Bitflag            |
| Callback    | callback    | CallBack           |
| Canceled    | canceled    | Cancelled          |
| DoNot       | doNot       | Don't              |
| Email       | email       | EMail              |
| Endpoint    | endpoint    | EndPoint           |
| FileName    | fileName    | Filename           |
| Gridline    | gridline    | GridLine           |
| Hashtable   | hashtable   | HashTable          |
| Id          | id          | ID                 |
| Indexes     | indexes     | Indices            |
| LogOff      | logOff      | LogOut             |
| LogOn       | logOn       | LogIn              |
| Metadata    | metadata    | MetaData, metaData |
| Multipanel  | multipanel  | MultiPanel         |
| Multiview   | multiview   | MultiView          |
| Namespace   | namespace   | NameSpace          |
| Ok          | ok          | OK                 |
| Pi          | pi          | PI                 |
| Placeholder | placeholder | PlaceHolder        |
| SignIn      | signIn      | SignOn             |
| SignOut     | signOut     | SignOff            |
| UserName    | userName    | Username           |
| WhiteSpace  | whiteSpace  | Whitespace         |
| Writable    | writable    | Writeable          |


### Some bad names

| ❌ Bad                         | ✅ Good                |
| ------------------------------ | ---------------------- |
| cust                           | customer               |
| usr                            | user                   |
| userList, userCollection, list | users                  |
| lastName                       | lastname               |
| firstName                      | firstname              |
| MetaData                       | Metadata               |
| endpoint                       | EndPoint               |
| SignOn                         | SignIn                 |
| SignOff                        | SignOut                |
| hashtable                      | HashTable              |
| ID                             | Id                     |
| Username                       | UserName               |
| attr                           | attribute              |
| res                            | response, result       |
| act                            | actual                 |
| ex                             | exception              |
| num                            | number                 |
| sys                            | system                 |
| PlaceHolder                    | placeholder            |
| calc                           | calculation            |
| vald                           | validation             |
|                                |                        |
|                                |                        |
| fs                             | FileStream, fileStream |
| ts                             | transactionScope       |
| pos                            | position, positive     |
| GetInt                         | GetLength              |
| GetWin                         | GetWindow              |

## Convention rules
### Assemblies 
[Assemblies](https://learn.microsoft.com/en-us/dotnet/standard/assembly/)  
✅ DO assembly name with PascalCase.PascalCase....  
✅ DO assembly name with singular  

#### DLL / EXE
✅ DO name with PascalCase.PascalCase....  
✅ DO name with singular  

### namespace
[namespace](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace)
✅ DO organize namespaces with a clearly defined structure  
✅ DO maintain namespace with folder names  
✅ DO use `.` for multiple name. eg. `WepApp.Infrastructure.Reposiotories`
```cs
namespace NamingConvention.NamingConventions {}           // PascalCase.PascalCase..., plural except root

# usage
using NamingConvention.NamingConventions;
using NamingConventions = NamingConvention.NamingConventions;
```
### type
References: 
[Type](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types)

```cs
public interface IInterfaceName { }                     // PascalCase with "I" prefix
public class ClassName { }                              // PascalCase
public abstract class AbstractClassName { }             // PascalCase
public static class StaticClassName { }                 // PascalCase
public sealed class SealedClassName { }                 // PascalCase
public partial class PartialClassName { }               // PascalCase
public struct StructName { }                            // PascalCase
public record RecordName { }                            // PascalCase
public enum EnumMode { }                                // PascalCase
public delegate void DelegateType(string message);      // PascalCase

// other type
public event DelegateType SampleEvent;                  // PascalCase
(double Sum, int Count) t2 = (4.5, 3);                  // PascalCase
int? optionalInt = default;                             // camelCase
```

#### class
[class](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class)   
✅ Do class name with `PascalCase`  
✅ Do class name with `nouns` or `noun` phrases  
✅ DO method name with verb phrases    
✅ CONSIDER ending the name of derived classes with the name of the base class.  
✅ Add postfix based on purpose
  - `CustomerModel`
  - `CustomerVm`
  - `CustomerDto`
  - `CustomerCreateRequest`
  - `CustomerCreateCommand`
  - `CustomerCreateHandler`  
  
✅ DO CONSIDER ending the name of derived classes with the name of the base class. eg. `ArgumentOutOfRangeException` which is derived from `Exception`  
✅ DO ensure that the names differ only by the "I" prefix on the interface name when you are defining a class–interface pair where the class is a standard implementation of the interface.

❌ DO NOT give class names a prefix (e.g., "C")  
❌ DO NOT use abbreviations  
❌ DO NOT add prefix, For example `VmCustomer`, `CommandCustomerCreate`, You type `Vm` and press the completion key and are bombarded with a mile-long list of every class in the system.  
❌ DO NOT use any words which is shorter than 3 chararcters & which does not add any meaning.
```cs
public class ClassService                                 // PascalCase - class name
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

  [ThreadStatic]
  private static TimeSpan t_timeSpan;                         // private thread static field - t_camelCase  with t_ prefix
  [ThreadStatic]
  internal static TimeSpan t_timeSpan1;                       // internal thread static field - t_camelCase  with t_ prefix

  // delegate
  public delegate void SampleEventHandler(object sender, SampleEventArgs e);

  // event
  public event SampleEventHandler SampleEvent;                // PascalCase - event 
  public event Action EventProcessing;                        // PascalCase - event 

  // constructor
  public ClassService(IInterfaceName interfaceName)     // parameter name - camelCase
  {
      InterfaceName = interfaceName;
      _interfaceName = interfaceName;
  }

  // method
  public string StartProcess()                          // method name - PascalCase
  {
      return string.Empty;
  }

  public async Task<string> StartProcessAsync()         // async method name - PascalCase with Async postfix
  {
      return await Task.FromResult(string.Empty);
  }

  // method with parameter
  public string Add(string firstname,
      string lastname,
      DateTime? joinDate,
      bool isValid)                                       // method parameter name - camelCase
  {
      bool addedPerson = true;                            // local variable - camelCase
      const int OnePerson = 1;                            // local const - PascalCase

      var person = new Person();                          // use var when the type is explicitly named on the right-hand side
      
      var process = StartProcess();                       // don't use var when the type is explicitly named on the right-hand side, rather use string process = StartProcess()

      string process1 = StartProcess();
      Person person1 = new();

      return string.Empty;
  }

  // method with parameter overloading
  public string Add(string firstname,
      string lastname,
      DateTime? joinDate,
      bool isValid)                                       // method parameter name - camelCase
  {
      bool addedPerson = true;                            // local variable - camelCase
      const int OnePerson = 1;                            // local const - PascalCase

      var person = new Person();                          // use var when the type is explicitly named on the right-hand side
      
      var process = StartProcess();                       // don't use var when the type is explicitly named on the right-hand side, rather use string process = StartProcess()

      string process1 = StartProcess();
      Person person1 = new();

      return string.Empty;
  }
}
```
#### Struct
[struct](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct)
```cs
public struct Coord                         // PascalCase, Singular, No "Struct" suffix or No 'struct' or 's' postfix                                   
{
    public Coord(double width, double height)   // PascalCase - Constructor , camelCase - argument 
    {
        Width = width;
        Height = height;
    }

    public double Width { get; }
    public double Height { get; }

    public override string ToString() => $"({Width}, {Height})";    // PascalCase - method 
}

// follow class naming convention for struct
```
#### enum (enumuration)
[enum](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)  
✅ DO `PascalCase` for enum name and member name  
✅ DO use a singular type name for an enumeration unless its values are bit fields.  
✅ DO use a plural type name for an enumeration with bit fields as values, also called flags enum.

❌ DO NOT use "Enum" suffix in enum type names.  
❌ DO NOT use "Flag" or "Flags" suffixes in enum type names.  
❌ DO NOT use a prefix on enumeration value names (e.g., "ad" for ADO enums, "rtf" for rich text enums, etc.).  
❌ DO NOT use abbreviation for any word  
❌ DO NOT use any abbreviation prefix  
❌ DO NOT derive from this class; use the keyword supported by your language instead; for example, in C#, use the enum keyword.
```cs
enum WorkItemType{                  // PascalCase, Singular, No "Enum" suffix                                    
    Epic,
    Feature,
    UserStory,                      // PascalCase
    Task,
    Bug
}

[Flags]
enum CategoryTypes{                  // PascalCase, Plural, No "Enum" suffix                                    
    Group,
    Single,
    All = Group | Single
}
```
#### record
[record](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record)
```cs
public record Person(string FirstName, string LastName);    // PascalCase, Noun

public record Person                                
{
    public required string FirstName { get; init; }         // PascalCase
    public required string LastName { get; init; }
};

// folllow naming convention like class
```
#### interface  
[interface](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)  
✅ Do interface name with PascalCase  
✅ DO prefix interface names with the letter `I`, to indicate that the type is an interface.. For example
  - `IComponent` (descriptive noun),
  - `ICustomAttributeProvider` (noun phrase)
  - `IPersistable` (adjective) are appropriate interface names.  
  
✅ DO name interfaces with adjective phrases, or occasionally with nouns or noun phrases.
✅ DO method name with verb phrases  
✅ DO ensure that the names differ only by the `I` prefix on the interface name when you are defining a class–interface pair. For example
  - interface `IComponent`, class `Component`
  - interface `ICustomAttributeProvider`, class `CustomAttributeProvider`
  - interface `IPersistable`, class `Persistable`

❌ DO NOT use abbreviations for interface name, field, properties, method etc.
```cs

```

#### abstract
[abstract](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)


Generics were added to .NET Framework 2.0. The feature introduced a new kind of identifier called type parameter.

- ✅  DO name generic type parameters with descriptive names unless a single-letter name is completely self-explanatory and a descriptive name would not add value.
- ✅  CONSIDER using T as the type parameter name for types with one single-letter type parameter.
```
public int IComparer<T> { ... }
public delegate bool Predicate<T>(T item);
public struct Nullable<T> where T:struct { ... }
```
- ✅  DO prefix descriptive type parameter names with T.
```
public interface ISessionChannel<TSession> where TSession : ISession {
    TSession Session { get; }
}
```
- ✅ CONSIDER indicating constraints placed on a type parameter in the name of the parameter.
  For example, a parameter constrained to ISession might be called TSession.

#### Names of Common Types
- ✅ DO follow the guidelines described in the following table when naming types derived from or implementing certain .NET Framework types.

- System.Attribute
  - ✅ DO add the suffix "Attribute" to names of custom attribute classes.
- System.Delegate
  - ✅ DO add the suffix "EventHandler" to names of delegates that are used in events.
  - ✅ DO add the suffix "Callback" to names of delegates other than those used as event handlers.
  - ❌ DO NOT add the suffix "Delegate" to a delegate.
- System.EventArgs
  - ✅ DO add the suffix "EventArgs."  
- System.Exception
  - ✅ DO add the suffix "Exception."
- `IDictionary` `IDictionary<TKey,TValue>` 
  - ✅ DO add the suffix "Dictionary." Note that IDictionary is a specific type of collection, but this guideline takes precedence over the more general collections guideline that follows.
- IEnumerable, ICollection, IList, IEnumerable<T>, ICollection<T>, IList<T>
  - ✅ DO add the suffix "Collection."
- System.IO.Stream
  -	✅ DO add the suffix "Stream."
- CodeAccessPermission IPermission	
  - ✅ DO add the suffix "Permission."

### Names of Type Members
- ✅ DO declare all member variables at the top of a class, with static variables at the very top.
- ✅ DO use predefined type names instead of system type names like Int16, Single, UInt64, etc
 
#### Methods
- ✅ DO give methods names that are verbs or verb phrases, because methods are the means of taking action
 
#### Properties
- ✅ DO name properties using a noun, noun phrase, or adjective, because a property refers to data, and the name of the property reflects that.
- ✅ DO name collection properties with a plural phrase. For example
  - `public List<Customer> Customers { get; set; }`
- ✅ DO name Boolean properties with an affirmative phrase (CanSeek instead of CantSeek). Optionally, you can also prefix Boolean properties with "Is", "Can", or "Has", but only where it adds value.
- ✅ CONSIDER giving a property the same name as its type. For example, the following property correctly gets and sets an enum value named Color, so the property is named Color:

- ❌ DO NOT have properties that match the name of "Get" methods as in the following example:  
`public string TextWriter { get {...} set {...} }` `public string GetTextWriter(int value) { ... }`
- ❌ DO NOT name collection properties with using a singular phrase followed by "List" or "Collection". For example
  - `CustomerList`
  - 
#### Events
- ✅ DO name events with a verb or a verb phrase.
  Examples include Clicked, Painting, DroppedDown, and so on.
- ✅ DO give events names with a concept of before and after, using the present and past tenses.
  For example, a close event that is raised before a window is closed would be called Closing, and one that is raised after the window is closed would be called Closed.
- ✅ DO name event handlers (delegates used as types of events) with the "EventHandler" suffix, as shown in the following example:
  public delegate void ClickedEventHandler(object sender, ClickedEventArgs e);
- ✅ DO use two parameters named sender and e in event handlers.
  The sender parameter represents the object that raised the event. The sender parameter is typically of type object, even if it is possible to employ a more specific type.
- ✅ DO name event argument classes with the "EventArgs" suffix.
  
#### Fields
The field-naming guidelines apply to static public and protected fields. Internal and private fields are not covered by guidelines, and public or protected instance fields are not allowed by the member design guidelines.
- ✅ DO use PascalCasing in field names.
- ✅ DO name fields using a noun, noun phrase, or adjective.
  
- ❌ DO NOT use a prefix for field names.
- ❌ DO NOT use "Before" or "After" prefixes or postfixes to indicate pre- and post-events. Use present and past tenses as just described.
  For example, do not use "g_" or "s_" to indicate static fields.
#### Generic
```cs
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
```
#### Nullable types
#### Tuples

### DbContext
✅ DO use plural name for entity/table name
✅ DO use "DbContext" suffix for your DbContext
```
```
### More suffix

| Type                 | Suffix                    | Example                     | Tools                                 |
| -------------------- | ------------------------- | --------------------------- | ------------------------------------- |
| Validator            | `Validator`               | PostValidator               | FluentValidation                      |
| Entity Configuration | `EntityTypeConfiguration` | BlogEntityTypeConfiguration | System.Data.Entity.ModelConfiguration |
| Controller           | `Controller`              | UserController              |                                       |
| Repository           | `Repository`              | PostRepository              |                                       |
| Service              | `Service`                 | AccountService              |                                       |
| Helper               | `Helper`                  | FileHelper                  |                                       |
| Extension            | `Extension`               | JsonExtension               |                                       |
| Proxy                | `Proxy`                   | OrderProxy                  | Proxy Pattern                         |
| Provider             | `Provider`                |                             |                                       |
| Endpoint             |                           | WarehouseEndpoint           |                                       |
| Request              |                           |                             |                                       |
| Response             |                           |                             |                                       |
| View model           | `Vm`                      | OrderVm                     |                                       |

### LINQ
✅ DO use abbreviation for lamda expressioin varaible 
 - `persons.Where(p => p.IsActive)`
 - `postReviewers.FirstOrDefaultAsync(pr => pr.Id == reviewerId)`
 ```
Func<int, int> square = x => x * x;
var squaredNumbers = numbers.Select(x => x * x);
Func<int, int, bool> testForEquality = (x, y) => x == y;
Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
Func<int, int, int> constant = (_, _) => 42;
var IncrementBy = (int source, int increment = 1) => source + increment;

 Action<string> greet = name =>
{
    string greeting = $"Hello {name}!";
    Console.WriteLine(greeting);
};
 ```
✅ DO use abbreviation for query expression variable
```
from p in persons
let Student { Grade is var grade, Name is var name } = p
where grade > 65
select new { Grade = grade, Name = name };
```
[](https://learn.microsoft.com/en-us/dotnet/csharp/linq/)
[](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)

### Message Broker
```cs
// exchange name - kebab case
// queue name - kebab case
// Receive endpoint - kebab case
public record SubmitOrderCommand {}                                                // command, verb-noun sequence. following the tell style
public record OrderSubmittedEvent {}                                               // event, noun-verb (past tense) sequence
public record CreateOrderRequest {}   
public record CreateOrderResponse {}   
public class ValidateOrderStatusFilter<T> : IFilter<SendContext<T>> where T : class { } // Filter - verb, filter postfix
public interface TakeProductMessage{}
public record OrderSubmitted                                                // message
{
    public Guid CorrelationId { get; init; }                                // properties, PascalCase 
}

public class OrderSubmittedConsumer : IConsumer<OrderSubmittedEvent>             // PascalCase, Consumer prefix, same as event, command, message without postfix
{
    private readonly IOrderSubmitter _orderSubmitter;

    public SubmitOrderConsumer(IOrderSubmitter submitter) => _orderSubmitter = submitter;

    public async Task Consume(IConsumeContext<OrderSubmittedEvent> context)
    {
        await _orderSubmitter.Process(context.Message);
        await context.Send(new StartDelivery(context.Message.OrderId, DateTime.UtcNow));
    }
}

public State Submitted { get; private set; }                                // Transition state - PascalCase, verb (past tense)
public class OrderState : SagaStateMachineInstance {}                       // Saga State - PascalCase, noun, "State" postfix
public class OrderStateMachine : MassTransitStateMachine<OrderState> {}     // Saga State Machine - PascalCase, noun, "StateMachine" postfix
public class TakeProductActivity : Activity<OrderState, OrderAcceptedEvent> {}  // Activity - PascalCase, verb-noun, "Activity" postfix
public class OrderStateDefinition : SagaDefinition<OrderState> {}           // Saga State defination - PascalCase, verb "StateDenition" postfix
```
### Unit Test
- Test name should express a specific requirement
- Test name Explicitly express the intent of the test
- Test name should provide documentation
- Test name could include the expected input or state and the expected result for that input or state
- Avoid magic strings
- Test name could include the name of the tested method or class
- Test class name should be same as the sut (system under test) class with `Test` test postfix
  - if stub class is `StringCalculator`, then your class name should be `StringCalculatorTest`
- Test method name should be like below
  - `TestClassName_TestMethodName_ScenarioWithExpectedResult`
  - `TestMethodName_Scenario_ExpectedResult` - **recommended**
  - `TestMethodName_ExpectedResult_Scenario`
- System under test class variable name could be `private StringCalculator _sut`
- Fake variable should prefix/postfix with `fake` 
- Moq variable should prefix/postfix with `mock` 
- Stub variable should prefix/postfix with `stub` 

[unit test best practises](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
```cs
[Theory]
[InlineData("", 0)]
[InlineData(",", 0)]
public void Add_EmptyEntries_ShouldBeTreatedAsZero(string input, int expected)
{
    // Arrange
    var stringCalculator = new StringCalculator();

    // Act
    var actual = stringCalculator.Add(input);

    // Assert
    Assert.Equal(expected, actual);
}
```


<details>
  <summary>Resources</summary>

- microsoft
  - [dotnet Framework old Guidelines - microsoft***](https://learn.microsoft.com/en-us/previous-versions/dotnet/netframework-1.1/xzf533w0(v=vs.71)?redirectedfrom=MSDN) 
  - [Naming Guidelines ***](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)
  - [capitalization-conventions](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions)
  - [general-naming-conventions](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions)
  - [names-of-assemblies-and-dlls](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-assemblies-and-dlls)
  - [names-of-namespaces](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-namespaces)
  - [names-of-classes-structs-and-interfaces](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-classes-structs-and-interfaces)
  - [names-of-type-members](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-type-members)
  - [naming-parameters](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-parameters)
  - [naming-resources](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-resources)
  - [dotnet identifier names](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names)
  - [coding-conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
  - [naming-rules](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/naming-rules)
  - [coding-style](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)

- others
  - [C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
  - [naming_conventions](https://www.akadia.com/services/naming_conventions.html)
  - [csharp-style - Google style](https://google.github.io/styleguide/csharp-style.)
  - [coding-best-practices-in-c-sharp](https://www.freecodecamp.org/news/coding-best-practices-in-c-sharp/)
  - [Coding_Assistance__Naming_Style - Resharper](https://www.jetbrains.com/help/resharper/Coding_Assistance__Naming_Style.html)
  - [rules-to-better-naming-conventions](https://www.ssw.com.au/rules/rules-to-better-naming-conventions/)
  - [coding-style - SonarSource](https://github.com/SonarSource/sonar-dotnet/blob/master/docs/coding-style.md)
  - [convention - SonarSource](https://rules.sonarsource.com/csharp/tag/convention/)
  - [dofactory](https://www.dofactory.com/csharp-coding-standards)
</details> 




