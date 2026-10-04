// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
internal abstract class EncodingNLS : Encoding // TypeDefIndex: 10036
{
	// Methods

	// RVA: 0x2E8952C Offset: 0x2E8552C VA: 0x2E8952C
	protected void .ctor(int codePage) { }

	// RVA: 0x2E89534 Offset: 0x2E85534 VA: 0x2E89534 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x2E896AC Offset: 0x2E856AC VA: 0x2E896AC Slot: 12
	public override int GetByteCount(string s) { }

	// RVA: 0x2E89738 Offset: 0x2E85738 VA: 0x2E89738 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x2E89808 Offset: 0x2E85808 VA: 0x2E89808 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2E89A50 Offset: 0x2E85A50 VA: 0x2E89A50 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2E89CB4 Offset: 0x2E85CB4 VA: 0x2E89CB4 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2E89DAC Offset: 0x2E85DAC VA: 0x2E89DAC Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2E89F24 Offset: 0x2E85F24 VA: 0x2E89F24 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2E89FF4 Offset: 0x2E85FF4 VA: 0x2E89FF4 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2E8A258 Offset: 0x2E86258 VA: 0x2E8A258 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2E8A350 Offset: 0x2E86350 VA: 0x2E8A350 Slot: 36
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2E8A50C Offset: 0x2E8650C VA: 0x2E8A50C Slot: 31
	public override Decoder GetDecoder() { }

	// RVA: 0x2E8A568 Offset: 0x2E86568 VA: 0x2E8A568 Slot: 32
	public override Encoder GetEncoder() { }
}
