// Assembly: mscorlib.dll
// Namespace: System.Text
public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 10029
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x306A850 Offset: 0x3066850 VA: 0x306A850
	public void .ctor() { }

	// RVA: 0x306A8C4 Offset: 0x30668C4 VA: 0x306A8C4 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x306A9A0 Offset: 0x30669A0 VA: 0x306A9A0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x306ADE0 Offset: 0x3066DE0 VA: 0x306ADE0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x306ADE8 Offset: 0x3066DE8 VA: 0x306ADE8 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x306ADF0 Offset: 0x3066DF0 VA: 0x306ADF0 Slot: 8
	public override int get_Remaining() { }
}
