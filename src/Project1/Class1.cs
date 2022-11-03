using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Project2")]
[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("TestProject2")]
namespace Dayton.Tests;

public sealed class Class1
{
	public bool ReturnTrue() =>
		true;
}

public static class Class1PublicEx
{
	public static long ReturnLong(this Class1 @this) =>
		Convert.ToInt64(@this.ReturnInt());
}

internal static class Class1Ex
{
	public static int ReturnInt(this Class1 @this) =>
		@this.ReturnTrue() ? 123 : 321;
}

internal static class SomethingUtils
{
	public static int GenerateRandomInt(in int seed)
	{
		return seed + 1;
	}
}
