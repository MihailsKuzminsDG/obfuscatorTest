using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject2")]
namespace Dayton.Tests;

public sealed class Class2
{
	public bool ReturnFalse() =>
		false;

	public string CreateSomething(in string value)
	{
		var boolVal = true & false & true ^ false | true;
		var intVal = CreateInt(value.Length << 2);

		return string.Concat(boolVal, intVal);
	}

	private int CreateInt(in int value)
	{
		var result = SomethingUtils.GenerateRandomInt(value);
		return result * 2;
	}
}

internal static class Class2Ex
{
	public static short CreateShort(this Class2 @this)
	{
		return 123;
	}
}
