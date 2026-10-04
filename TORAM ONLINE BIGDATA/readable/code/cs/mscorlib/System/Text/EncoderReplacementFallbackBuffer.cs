// Assembly: mscorlib.dll
// Namespace: System.Text
public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 10035
{
	// Fields
	private string _strDefault; // 0x30
	private int _fallbackCount; // 0x38
	private int _fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x306C044 Offset: 0x3068044 VA: 0x306C044
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x306C150 Offset: 0x3068150 VA: 0x306C150 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x306C290 Offset: 0x3068290 VA: 0x306C290 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x306C4A0 Offset: 0x30684A0 VA: 0x306C4A0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x306C4F0 Offset: 0x30684F0 VA: 0x306C4F0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x306C520 Offset: 0x3068520 VA: 0x306C520 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x306C52C Offset: 0x306852C VA: 0x306C52C Slot: 9
	public override void Reset() { }
}
