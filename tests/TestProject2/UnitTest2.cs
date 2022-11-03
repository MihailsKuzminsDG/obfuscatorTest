using Dayton.Tests;

namespace TestProject2;

public class UnitTest2
{
	[Fact]
	public void Test1()
	{
		var result = new Class2()
			.ReturnFalse();

		Assert.False(result);
	}

	[Fact]
	public void Test2()
	{
		var result = new Class2()
			.CreateShort();

		Assert.Equal(123, result);
	}

	[Fact]
	public void Test3()
	{
		var result = new Class2()
			.CreateSomething("123");

		Assert.Equal(true, true);
	}
}
