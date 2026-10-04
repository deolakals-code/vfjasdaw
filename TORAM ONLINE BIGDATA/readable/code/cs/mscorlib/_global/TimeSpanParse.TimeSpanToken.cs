// Assembly: mscorlib.dll
// Namespace: 
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
private struct TimeSpanParse.TimeSpanToken // TypeDefIndex: 10793
{
	// Fields
	internal TimeSpanParse.TTT _ttt; // 0x0
	internal int _num; // 0x4
	internal int _zeroes; // 0x8
	internal ReadOnlySpan<char> _sep; // 0x10

	// Methods

	// RVA: 0x2F8FF64 Offset: 0x2F8BF64 VA: 0x2F8FF64
	public void .ctor(TimeSpanParse.TTT type) { }

	// RVA: 0x2F8DBD8 Offset: 0x2F89BD8 VA: 0x2F8DBD8
	public void .ctor(int number) { }

	// RVA: 0x2F8FD68 Offset: 0x2F8BD68 VA: 0x2F8FD68
	public void .ctor(int number, int leadingZeroes) { }

	// RVA: 0x2F8FF74 Offset: 0x2F8BF74 VA: 0x2F8FF74
	public void .ctor(TimeSpanParse.TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator) { }

	// RVA: 0x2F8A8EC Offset: 0x2F868EC VA: 0x2F8A8EC
	public bool IsInvalidFraction() { }
}
