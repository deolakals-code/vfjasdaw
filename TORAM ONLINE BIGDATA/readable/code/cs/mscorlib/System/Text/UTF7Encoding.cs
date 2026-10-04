// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 10048
{
	// Fields
	internal static readonly UTF7Encoding s_default; // 0x0
	private byte[] _base64Bytes; // 0x38
	private sbyte[] _base64Values; // 0x40
	private bool[] _directEncode; // 0x48
	private bool _allowOptionals; // 0x50

	// Methods

	// RVA: 0x2E91D7C Offset: 0x2E8DD7C VA: 0x2E91D7C
	public void .ctor() { }

	// RVA: 0x2E91DA0 Offset: 0x2E8DDA0 VA: 0x2E91DA0
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x2E91DD0 Offset: 0x2E8DDD0 VA: 0x2E91DD0
	private void MakeTables() { }

	// RVA: 0x2E92068 Offset: 0x2E8E068 VA: 0x2E92068 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x2E92134 Offset: 0x2E8E134 VA: 0x2E92134 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2E92204 Offset: 0x2E8E204 VA: 0x2E92204 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E92270 Offset: 0x2E8E270 VA: 0x2E92270 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x2E923E8 Offset: 0x2E8E3E8 VA: 0x2E923E8 Slot: 12
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x2E92474 Offset: 0x2E8E474 VA: 0x2E92474 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x2E92544 Offset: 0x2E8E544 VA: 0x2E92544 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2E9278C Offset: 0x2E8E78C VA: 0x2E9278C Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x2E929F0 Offset: 0x2E8E9F0 VA: 0x2E929F0 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2E92AE8 Offset: 0x2E8EAE8 VA: 0x2E92AE8 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x2E92C60 Offset: 0x2E8EC60 VA: 0x2E92C60 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2E92D30 Offset: 0x2E8ED30 VA: 0x2E92D30 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x2E92F94 Offset: 0x2E8EF94 VA: 0x2E92F94 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2E9308C Offset: 0x2E8F08C VA: 0x2E9308C Slot: 36
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2E93248 Offset: 0x2E8F248 VA: 0x2E93248 Slot: 15
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x2E93264 Offset: 0x2E8F264 VA: 0x2E93264 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x2E93600 Offset: 0x2E8F600 VA: 0x2E93600 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x2E9361C Offset: 0x2E8F61C VA: 0x2E9361C Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x2E938D0 Offset: 0x2E8F8D0 VA: 0x2E938D0 Slot: 31
	public override Decoder GetDecoder() { }

	// RVA: 0x2E93934 Offset: 0x2E8F934 VA: 0x2E93934 Slot: 32
	public override Encoder GetEncoder() { }

	// RVA: 0x2E93998 Offset: 0x2E8F998 VA: 0x2E93998 Slot: 33
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2E93A58 Offset: 0x2E8FA58 VA: 0x2E93A58 Slot: 34
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2E93ACC Offset: 0x2E8FACC VA: 0x2E93ACC
	private static void .cctor() { }
}
