﻿- [C# Naming Convention](#c-naming-convention)
  - [Naming Convention](#naming-convention)
    - [Assemblies](#assemblies)
    - [DLLs](#dlls)
    - [Namespaces](#namespaces)
    - [Class](#class)
    - [Interface](#interface)
    - [Abstract](#abstract)
    - [struct](#struct)
    - [record](#record)
    - [Enumerations](#enumerations)
    - [Names of Generic Type Parameters](#names-of-generic-type-parameters)
    - [Names of Common Types](#names-of-common-types)
    - [Naming Enumerations](#naming-enumerations)
    - [Names of Type Members](#names-of-type-members)
      - [Methods](#methods)
      - [Properties](#properties)
      - [Events](#events)
      - [Fields](#fields)


# C# Naming Convention
Improved Communication — “The best code communicates itself” . Any member of a development will be able to read and understand the code of another member through code.
Improved Code integration — Distinct teams that rely on the code built by other teams won’t have problem understanding properly named interface and its entities.
Improved Consistency — Helps formalize expectations and promote consistency within a development team.
Improved clarity — Provides better understanding in case of code reuse after a long interval of time. Enhances clarity in cases of potential ambiguity.
## Naming Convention 

### Assemblies 
### DLLs
### Namespaces
### Class

:heavy_check_mark: DO  
- Do class name with PascalCase
- Do class name with nouns or noun phrases
- DO method name with verb phrases  
- CONSIDER ending the name of derived classes with the name of the base class.
- Add postfix based on purpose
  - `CustomerModel`
  - `CustomerVm`
  - `CustomerDto`
  - `CustomerCreateRequest`
  - `CustomerCreateCommand`
  - `CustomerCreateHandler`


:x: DON'T
- DO NOT give class names a prefix (e.g., "C")
- avoid abbreviations
- DO NOT add prefix, For example `VmCustomer`, `CommandCustomerCreate`, You type `Vm` and press the completion key and are bombarded with a mile-long list of every class in the system.


### Interface
:heavy_check_mark: DO  
- Do class name with PascalCase
- Do class name with `I` Prefix. For example
  - `IComponent` (descriptive noun),
  - `ICustomAttributeProvider` (noun phrase)
  - `IPersistable` (adjective) are appropriate interface names.
- DO name interfaces with adjective phrases, or occasionally with nouns or noun phrases.
- DO method name with verb phrases  
- DO ensure that the names differ only by the `I` prefix on the interface name when you are defining a class–interface pair. For example
  - interface `IComponent`, class `Component`
  - interface `ICustomAttributeProvider`, class `CustomAttributeProvider`
  - interface `IPersistable`, class `Persistable`

:x: DON'T
- avoid abbreviations

### Abstract
### struct
### record
### Enumerations
Names of enumeration types (also called enums) in general should follow the standard type-naming rules (PascalCasing, etc.). However, there are additional guidelines that apply specifically to enums.

✔️ DO use a singular type name for an enumeration unless its values are bit fields.

✔️ DO use a plural type name for an enumeration with bit fields as values, also called flags enum.

❌ DO NOT use an "Enum" suffix in enum type names.

❌ DO NOT use "Flag" or "Flags" suffixes in enum type names.

❌ DO NOT use a prefix on enumeration value names (e.g., "ad" for ADO enums, "rtf" for rich text enums, etc.).
### Names of Generic Type Parameters
Generics were added to .NET Framework 2.0. The feature introduced a new kind of identifier called type parameter.

✔️ DO name generic type parameters with descriptive names unless a single-letter name is completely self-explanatory and a descriptive name would not add value.

✔️ CONSIDER using T as the type parameter name for types with one single-letter type parameter.

C#

Copy
public int IComparer<T> { ... }
public delegate bool Predicate<T>(T item);
public struct Nullable<T> where T:struct { ... }
✔️ DO prefix descriptive type parameter names with T.

C#

Copy
public interface ISessionChannel<TSession> where TSession : ISession {
    TSession Session { get; }
}
✔️ CONSIDER indicating constraints placed on a type parameter in the name of the parameter.

For example, a parameter constrained to ISession might be called TSession.
### Names of Common Types
✔️ DO follow the guidelines described in the following table when naming types derived from or implementing certain .NET Framework types.

| Base Type	| Derived/Implementing Type Guideline |
| --- | --- |
| System.Attribute	| ✔️ DO add the suffix "Attribute" to names of custom attribute classes.
| System.Delegate	| ✔️ DO add the suffix "EventHandler" to names of delegates that are used in events.
|                   | ✔️ DO add the suffix "Callback" to names of delegates other than those used as event handlers.
|                   | ❌ DO NOT add the suffix "Delegate" to a delegate.
| System.EventArgs	| ✔️ DO add the suffix "EventArgs."
| System.Enum	    | ❌ DO NOT derive from this class; use the keyword supported by your language instead; for example, in C#, use the enum keyword.
|                   |❌ DO NOT add the suffix "Enum" or "Flag."
| System.Exception	| ✔️ DO add the suffix "Exception."
| `IDictionary` `IDictionary<TKey,TValue>` | 	✔️ DO add the suffix "Dictionary." Note that IDictionary is a specific type of collection, but this guideline takes precedence over the more general collections guideline that follows.
| ` IEnumerable
ICollection
IList
IEnumerable<T>
ICollection<T>
IList<T>`           |✔️ DO add the suffix "Collection."
System.IO.Stream	✔️ DO add the suffix "Stream."
CodeAccessPermission IPermission	✔️ DO add the suffix "Permission."



### Naming Enumerations
### Names of Type Members
#### Methods
:heavy_check_mark: DO  
- DO give methods names that are verbs or verb phrases, because methods are the means of taking action
#### Properties
:heavy_check_mark: DO  
- DO name properties using a noun, noun phrase, or adjective, because a property refers to data, and the name of the property reflects that.
- DO name collection properties with a plural phrase. For example
  - `public List<Customer> Customers { get; set; }`
- DO name Boolean properties with an affirmative phrase (CanSeek instead of CantSeek). Optionally, you can also prefix Boolean properties with "Is", "Can", or "Has", but only where it adds value.
- CONSIDER giving a property the same name as its type. For example, the following property correctly gets and sets an enum value named Color, so the property is named Color:

:x: DON'T
- DO NOT have properties that match the name of "Get" methods as in the following example:  
`public string TextWriter { get {...} set {...} }` `public string GetTextWriter(int value) { ... }`
- DO NOT name collection properties with using a singular phrase followed by "List" or "Collection". For example
  - `CustomerList`
#### Events
DO name events with a verb or a verb phrase.

Examples include Clicked, Painting, DroppedDown, and so on.

✔️ DO give events names with a concept of before and after, using the present and past tenses.

For example, a close event that is raised before a window is closed would be called Closing, and one that is raised after the window is closed would be called Closed.

❌ DO NOT use "Before" or "After" prefixes or postfixes to indicate pre- and post-events. Use present and past tenses as just described.

✔️ DO name event handlers (delegates used as types of events) with the "EventHandler" suffix, as shown in the following example:

public delegate void ClickedEventHandler(object sender, ClickedEventArgs e);

✔️ DO use two parameters named sender and e in event handlers.

The sender parameter represents the object that raised the event. The sender parameter is typically of type object, even if it is possible to employ a more specific type.

✔️ DO name event argument classes with the "EventArgs" suffix.
#### Fields
The field-naming guidelines apply to static public and protected fields. Internal and private fields are not covered by guidelines, and public or protected instance fields are not allowed by the member design guidelines.

✔️ DO use PascalCasing in field names.

✔️ DO name fields using a noun, noun phrase, or adjective.

❌ DO NOT use a prefix for field names.

For example, do not use "g_" or "s_" to indicate static fields.

https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/naming-rules
https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions

https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md
https://www.akadia.com/services/naming_conventions.html
https://google.github.io/styleguide/csharp-style.
https://www.freecodecamp.org/news/coding-best-practices-in-c-sharp/
https://www.jetbrains.com/help/resharper/Coding_Assistance__Naming_Style.html
https://www.ssw.com.au/rules/rules-to-better-naming-conventions/
https://github.com/SonarSource/sonar-dotnet/blob/master/docs/coding-style.md
https://rules.sonarsource.com/csharp/tag/convention/