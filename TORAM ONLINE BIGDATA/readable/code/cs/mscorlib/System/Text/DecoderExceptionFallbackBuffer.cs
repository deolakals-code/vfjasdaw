// Assembly: mscorlib.dll
// Namespace: System.Text
public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 10018
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x3067EE0 Offset: 0x3063EE0 VA: 0x3067EE0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x30680B4 Offset: 0x30640B4 VA: 0x30680B4 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x30680BC Offset: 0x30640BC VA: 0x30680BC Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x3067EE8 Offset: 0x3063EE8 VA: 0x3067EE8
	private void Throw(byte[] bytesUnknown, int index) { }

	// RVA: 0x3067E6C Offset: 0x3063E6C VA: 0x3067E6C
	public void .ctor() { }
}
