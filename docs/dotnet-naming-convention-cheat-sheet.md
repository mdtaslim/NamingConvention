# Dotnet Naming Convention Cheatsheet

- [Dotnet Naming Convention Cheatsheet](#dotnet-naming-convention-cheatsheet)
  - [Naming Convention](#naming-convention)
    - [Naming Convention Case](#naming-convention-case)
    - [Naming Convention Case Type](#naming-convention-case-type)
    - [Naming Convention Word Type](#naming-convention-word-type)
  - [Some bad names](#some-bad-names)
  - [Example cheat](#example-cheat)
    - [namespace](#namespace)
    - [type](#type)
      - [class](#class)
      - [Struct](#struct)
      - [Enum](#enum)
      - [Record](#record)
      - [interface](#interface)
      - [Generic](#generic)
      - [Nullable types](#nullable-types)
      - [Tuples](#tuples)
    - [Message Broker](#message-broker)
    - [Unit Test](#unit-test)

## Naming Convention
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



## Some bad names

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

## Example cheat
### namespace
[namespace](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace)
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
#### Enum
[enum](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
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
#### Record
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
```cs

```
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

