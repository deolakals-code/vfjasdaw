// Assembly: mscorlib.dll
// Namespace: System.Text
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct ValueUtf8Converter // TypeDefIndex: 10056
{
	// Fields
	private byte[] _arrayToReturnToPool; // 0x0
	private Span<byte> _bytes; // 0x8

	// Methods

	// RVA: 0x2E9B2A8 Offset: 0x2E972A8 VA: 0x2E9B2A8
	public void .ctor(Span<byte> initialBuffer) { }

	// RVA: 0x2E9B2B4 Offset: 0x2E972B4 VA: 0x2E9B2B4
	public Span<byte> ConvertAndTerminateString(ReadOnlySpan<char> value) { }

	// RVA: 0x2E9B54C Offset: 0x2E9754C VA: 0x2E9B54C
	public void Dispose() { }
}
