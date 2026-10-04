// Assembly: mscorlib.dll
// Namespace: 
private sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 10047
{
	// Fields
	private char cFallback; // 0x20
	private int iCount; // 0x24
	private int iSize; // 0x28

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x2E93C1C Offset: 0x2E8FC1C VA: 0x2E93C1C
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x2E93C98 Offset: 0x2E8FC98 VA: 0x2E93C98 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x2E93CD4 Offset: 0x2E8FCD4 VA: 0x2E93CD4 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x2E93CF4 Offset: 0x2E8FCF4 VA: 0x2E93CF4 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x2E93D00 Offset: 0x2E8FD00 VA: 0x2E93D00 Slot: 7
	public override void Reset() { }

	// RVA: 0x2E93D10 Offset: 0x2E8FD10 VA: 0x2E93D10 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}
