using ObfuscatorTest;

namespace TestProject1;

public sealed class UnitTest1
{
	[Fact]
	public void Test1()
	{
		var result = new Class1()
			.ReturnTrue();
	
		Assert.True(result);
	}

	[Fact]
	public void Test2()
	{
		var result = new Class1()
			.ReturnInt();

		Assert.Equal(123, result);
	}
}
