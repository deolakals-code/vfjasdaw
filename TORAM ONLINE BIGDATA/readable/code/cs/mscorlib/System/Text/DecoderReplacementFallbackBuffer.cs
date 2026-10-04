// Assembly: mscorlib.dll
// Namespace: System.Text
public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 10024
{
	// Fields
	private string _strDefault; // 0x20
	private int _fallbackCount; // 0x28
	private int _fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x3069604 Offset: 0x3065604 VA: 0x3069604
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x3069700 Offset: 0x3065700 VA: 0x3069700 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x3069740 Offset: 0x3065740 VA: 0x3069740 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x3069790 Offset: 0x3065790 VA: 0x3069790 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x306979C Offset: 0x306579C VA: 0x306979C Slot: 7
	public override void Reset() { }

	// RVA: 0x30697AC Offset: 0x30657AC VA: 0x30697AC Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}
