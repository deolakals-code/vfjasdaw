// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 13275
{
	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x32B7608 Offset: 0x32B3608 VA: 0x32B7608
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x32B7748 Offset: 0x32B3748 VA: 0x32B7748 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x32B7950 Offset: 0x32B3950 VA: 0x32B7950 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x32B7BF8 Offset: 0x32B3BF8 VA: 0x32B7BF8 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x32B7C50 Offset: 0x32B3C50 VA: 0x32B7C50 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x32B7C6C Offset: 0x32B3C6C VA: 0x32B7C6C Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x32B7CA0 Offset: 0x32B3CA0 VA: 0x32B7CA0 Slot: 9
	public override void Reset() { }

	// RVA: 0x32B7BE8 Offset: 0x32B3BE8 VA: 0x32B7BE8
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }
}
