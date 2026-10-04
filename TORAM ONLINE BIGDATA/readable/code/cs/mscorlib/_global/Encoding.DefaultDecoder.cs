// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 10058
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x2E9E70C Offset: 0x2E9A70C VA: 0x2E9E70C
	public void .ctor(Encoding encoding) { }

	// RVA: 0x2E9F5B8 Offset: 0x2E9B5B8 VA: 0x2E9F5B8
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E9F8BC Offset: 0x2E9B8BC VA: 0x2E9F8BC Slot: 15
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x2E9F910 Offset: 0x2E9B910 VA: 0x2E9F910 Slot: 14
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E9F9B0 Offset: 0x2E9B9B0 VA: 0x2E9F9B0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2E9F9C0 Offset: 0x2E9B9C0 VA: 0x2E9F9C0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2E9F9E4 Offset: 0x2E9B9E4 VA: 0x2E9F9E4 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x2E9FA08 Offset: 0x2E9BA08 VA: 0x2E9FA08 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2E9FA18 Offset: 0x2E9BA18 VA: 0x2E9FA18 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x2E9FA3C Offset: 0x2E9BA3C VA: 0x2E9FA3C Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }
}
