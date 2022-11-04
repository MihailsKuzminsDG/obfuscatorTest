namespace Dayton.Tests;

internal sealed class DtoClass
{
	public int Id { get; init; } = 123;
}

internal sealed record DtoRecord
{
	public long Id { get; set; }

	public string IpAddress { get; init; } = string.Empty;

	public string BusAddresses { get; init; } = string.Empty;

	public string ModelString { get; init; } = string.Empty;
}
