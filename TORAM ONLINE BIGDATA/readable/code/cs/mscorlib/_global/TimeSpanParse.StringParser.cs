// Assembly: mscorlib.dll
// Namespace: 
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
private struct TimeSpanParse.StringParser // TypeDefIndex: 10797
{
	// Fields
	private ReadOnlySpan<char> _str; // 0x0
	private char _ch; // 0x10
	private int _pos; // 0x14
	private int _len; // 0x18

	// Methods

	// RVA: 0x2F90274 Offset: 0x2F8C274 VA: 0x2F90274
	internal void NextChar() { }

	// RVA: 0x2F902C0 Offset: 0x2F8C2C0 VA: 0x2F902C0
	internal char NextNonDigit() { }

	// RVA: 0x2F8FD90 Offset: 0x2F8BD90 VA: 0x2F8FD90
	internal bool TryParse(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F9050C Offset: 0x2F8C50C VA: 0x2F9050C
	internal bool ParseInt(int max, out int i, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F9034C Offset: 0x2F8C34C VA: 0x2F9034C
	internal bool ParseTime(out long time, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x2F9031C Offset: 0x2F8C31C VA: 0x2F9031C
	internal void SkipBlanks() { }
}
