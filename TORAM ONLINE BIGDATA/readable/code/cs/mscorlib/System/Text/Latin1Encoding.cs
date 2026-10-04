// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 10038
{
	// Fields
	internal static readonly Latin1Encoding s_default; // 0x0
	private static readonly char[] arrayCharBestFit; // 0x8

	// Methods

	// RVA: 0x2E8A9E8 Offset: 0x2E869E8 VA: 0x2E8A9E8
	public void .ctor() { }

	// RVA: 0x2E8A9F4 Offset: 0x2E869F4 VA: 0x2E8A9F4
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E8AA40 Offset: 0x2E86A40 VA: 0x2E8AA40 Slot: 40
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E8AB28 Offset: 0x2E86B28 VA: 0x2E8AB28 Slot: 15
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x2E8AD20 Offset: 0x2E86D20 VA: 0x2E8AD20 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x2E8B078 Offset: 0x2E87078 VA: 0x2E8B078 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2E8B080 Offset: 0x2E87080 VA: 0x2E8B080 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x2E8B104 Offset: 0x2E87104 VA: 0x2E8B104 Slot: 33
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2E8B204 Offset: 0x2E87204 VA: 0x2E8B204 Slot: 34
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2E8B300 Offset: 0x2E87300 VA: 0x2E8B300 Slot: 37
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2E8B358 Offset: 0x2E87358 VA: 0x2E8B358
	private static void .cctor() { }
}
