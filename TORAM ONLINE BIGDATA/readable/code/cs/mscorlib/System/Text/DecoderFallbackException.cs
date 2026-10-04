// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public sealed class DecoderFallbackException : ArgumentException // TypeDefIndex: 10019
{
	// Fields
	private byte[] _bytesUnknown; // 0x98
	private int _index; // 0xA0

	// Methods

	// RVA: 0x3068100 Offset: 0x3064100 VA: 0x3068100
	public void .ctor() { }

	// RVA: 0x30680C4 Offset: 0x30640C4 VA: 0x30680C4
	public void .ctor(string message, byte[] bytesUnknown, int index) { }

	// RVA: 0x306815C Offset: 0x306415C VA: 0x306815C
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}
