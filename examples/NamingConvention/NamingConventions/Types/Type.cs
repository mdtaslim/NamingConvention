namespace NamingConvention.NamingConventions.Types
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
}
