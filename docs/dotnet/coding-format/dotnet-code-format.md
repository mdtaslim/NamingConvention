# Dotnet Code format
✅ Must format your code and follow a single pattern for a team.  
✅ DO use indentation  
✅ DO use tab for indentation  
✅ DO not use alignment without tab indentation  
✅ DO use format before save your file.  
✅ DO use empty new line before your return block.  
✅ DO use format tool. eg. Visual Studio formatter, dotnet formatter  
✅ DO use max 80/120 character length for your line margin.  
✅ DO use break your code whenever your line margin exceeds.  
✅ DO use break your code properly, not partially.  


❌ DO not use extra whitespace.  
❌ DO not use multiple empty line in your code.  
❌ DO not break your code in any place

```cs
namespace MyApp.Core
{
  public class Calculator{ 
    
    public readonly Calculator Calculator;

    public CalculatorTest(){
      Calculator = new Calculator();
    }
  }
}
```