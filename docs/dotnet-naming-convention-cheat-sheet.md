- [Dotnet Naming Convention Cheatsheet](#dotnet-naming-convention-cheatsheet)
  - [Namespace](#namespace)
  - [Type](#type)
    - [Class](#class)
    - [Struct](#struct)
    - [Enum](#enum)
    - [Record](#record)
    - [Interface](#interface)
    - [Nullable types](#nullable-types)
    - [Tuples](#tuples)


# Dotnet Naming Convention Cheatsheet


| Identifier                        | Casing      | Example                                  |
| --------------------------------- | ----------- | ---------------------------------------- |
| Namespace                         | PascalCase  | System.Security                          |
| Type                              | PascalCase  | public class StreamReader { ... }        |
| Class                             | PascalCase  |                                          |
| Abstract class                    | PascalCase  |                                          |
| Sealed Class                      | PascalCase  |                                          |
| Partial Class                     | PascalCase  |                                          |
| Static Class                      | PascalCase  |                                          |
| Struct                            | PascalCase  |                                          |
| Record                            | PascalCase  |                                          |
| Interface                         | IPascalCase | IEnumerable                              |
| Enum                              |             | public enum FileMode {}                  |
| Event                             |             | public event EventHandler Exited;        |
| Delegate                          | PascalCase  |                                          |
| const - local                     | PascalCase  |                                          |
| const - gloabal                   | PascalCase  |                                          |
| Field - public                    | PascalCase  | public static readonly TimeSpan          |
| Field - protected                 | PascalCase  |                                          |
| Field - private                   | _camelCase  |                                          |
| Field - public readonly           | PascalCase  |                                          |
| Field - private readonly          | _camelCase  |                                          |
| Field - protected  readonly       | PascalCase  |                                          |
| Property                          |             | public string Firstname { get; }         |
| Property                          |             |                                          |
| Property                          |             |                                          |
| Property                          |             |                                          |
| Property                          |             |                                          |
| Property                          |             |                                          |
| Property                          |             |                                          |
| Property                          |             |                                          |
| Property - public virtual         |             |                                          |
| Property - public static readonly |             |                                          |
| Method                            | PascalCase  | public virtual string ToString();        |
| Method - constructor              | PascalCase  |                                          |
| Method - private                  | PascalCase  |                                          |
| Method - protected                | PascalCase  |                                          |
| Method - public virtual           | PascalCase  |                                          |
| Parameter                         | camelCase   | public static int ToInt32(string value); |
| Local Variable                    | camelCase   |                                          |


| Case Type       | Resource                                                                        |
| --------------- | ----------------------------------------------------------------------------- |
| PascalCase      | Type - (class, enum, struct, record), delegate, event, field, property,method |
| IPascalCase     | interface                                                                     |
|                 |                                                                               |
| CamelCase class | method parameter, local variable                                              |
| _CamelCase      | property (private, private readonly)                                          |


| Word Type | Resource                                                               |
| --------- | ---------------------------------------------------------------------- |
| Nown      | Type - (class, enum, struct, record), delegate, event, field, property |
| Verb      | method                                                                 |
|           |                                                                        |
| Adjective | local variable                                                         |
|           |                                                                        |


## Namespace
```cs
namespace NamingConvention.NamingConventions {}           // namespace - PascalCase.PascalCase...

```
## Type
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

### Class
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
### Struct
### Enum
### Record
### Interface
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
### Nullable types
### Tuples

