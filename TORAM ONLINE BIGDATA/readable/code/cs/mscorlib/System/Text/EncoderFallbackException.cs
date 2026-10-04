// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 10030
{
	// Fields
	private char _charUnknown; // 0x98
	private char _charUnknownHigh; // 0x9A
	private char _charUnknownLow; // 0x9C
	private int _index; // 0xA0

	// Methods

	// RVA: 0x306ADF8 Offset: 0x3066DF8 VA: 0x306ADF8
	public void .ctor() { }

	// RVA: 0x306A970 Offset: 0x3066970 VA: 0x306A970
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x306ABF0 Offset: 0x3066BF0 VA: 0x306ABF0
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x306AE54 Offset: 0x3066E54 VA: 0x306AE54
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}
