// Assembly: mscorlib.dll
// Namespace: 
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
private struct TimeSpanParse.TimeSpanTokenizer // TypeDefIndex: 10794
{
	// Fields
	private ReadOnlySpan<char> _value; // 0x0
	private int _pos; // 0x10

	// Properties
	internal bool EOL { get; }
	internal char NextChar { get; }

	// Methods

	// RVA: 0x2F8AE2C Offset: 0x2F86E2C VA: 0x2F8AE2C
	internal void .ctor(ReadOnlySpan<char> input) { }

	// RVA: 0x2F8FB28 Offset: 0x2F8BB28 VA: 0x2F8FB28
	internal void .ctor(ReadOnlySpan<char> input, int startPosition) { }

	// RVA: 0x2F8AE84 Offset: 0x2F86E84 VA: 0x2F8AE84
	internal TimeSpanParse.TimeSpanToken GetNextToken() { }

	// RVA: 0x2F8FD1C Offset: 0x2F8BD1C VA: 0x2F8FD1C
	internal bool get_EOL() { }

	// RVA: 0x2F8FD7C Offset: 0x2F8BD7C VA: 0x2F8FD7C
	internal void BackOne() { }

	// RVA: 0x2F8FCBC Offset: 0x2F8BCBC VA: 0x2F8FCBC
	internal char get_NextChar() { }
}
