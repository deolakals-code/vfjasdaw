// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 10057
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x2E9E9A0 Offset: 0x2E9A9A0 VA: 0x2E9E9A0
	public void .ctor(Encoding encoding) { }

	// RVA: 0x2E9F038 Offset: 0x2E9B038 VA: 0x2E9F038
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E9F3C0 Offset: 0x2E9B3C0 VA: 0x2E9F3C0 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x2E9F488 Offset: 0x2E9B488 VA: 0x2E9F488 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E9F528 Offset: 0x2E9B528 VA: 0x2E9F528 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x2E9F54C Offset: 0x2E9B54C VA: 0x2E9F54C Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x2E9F570 Offset: 0x2E9B570 VA: 0x2E9F570 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x2E9F594 Offset: 0x2E9B594 VA: 0x2E9F594 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }
}
