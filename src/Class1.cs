using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject1")]
namespace ObfuscatorTest;

public sealed class Class1
{
	public bool ReturnTrue() =>
		true;
}

internal static class Class1Ex
{
	public static int ReturnInt(this Class1 @this) =>
		@this.ReturnTrue() ? 123 : 321;
}
