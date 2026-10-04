// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public sealed class UTF32Encoding : Encoding // TypeDefIndex: 10043
{
	// Fields
	internal static readonly UTF32Encoding s_default; // 0x0
	internal static readonly UTF32Encoding s_bigEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	private bool _emitUTF32ByteOrderMark; // 0x38
	private bool _isThrowException; // 0x39
	private bool _bigEndian; // 0x3A

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x2E8F604 Offset: 0x2E8B604 VA: 0x2E8F604
	public void .ctor() { }

	// RVA: 0x2E8F698 Offset: 0x2E8B698 VA: 0x2E8F698
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x2E8F62C Offset: 0x2E8B62C VA: 0x2E8F62C
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x2E8F6D4 Offset: 0x2E8B6D4 VA: 0x2E8F6D4 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x2E8F7C0 Offset: 0x2E8B7C0 VA: 0x2E8F7C0 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x2E8F938 Offset: 0x2E8B938 VA: 0x2E8F938 Slot: 12
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x2E8F9C4 Offset: 0x2E8B9C4 VA: 0x2E8F9C4 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x2E8FA94 Offset: 0x2E8BA94 VA: 0x2E8FA94 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2E8FCDC Offset: 0x2E8BCDC VA: 0x2E8FCDC Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x2E8FF40 Offset: 0x2E8BF40 VA: 0x2E8FF40 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2E90038 Offset: 0x2E8C038 VA: 0x2E90038 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x2E901B0 Offset: 0x2E8C1B0 VA: 0x2E901B0 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2E90280 Offset: 0x2E8C280 VA: 0x2E90280 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x2E904E4 Offset: 0x2E8C4E4 VA: 0x2E904E4 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2E905DC Offset: 0x2E8C5DC VA: 0x2E905DC Slot: 36
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2E90798 Offset: 0x2E8C798 VA: 0x2E90798 Slot: 15
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2E90A64 Offset: 0x2E8CA64 VA: 0x2E90A64 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x2E90E44 Offset: 0x2E8CE44 VA: 0x2E90E44 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x2E9117C Offset: 0x2E8D17C VA: 0x2E9117C Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x2E90E28 Offset: 0x2E8CE28 VA: 0x2E90E28
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x2E91570 Offset: 0x2E8D570 VA: 0x2E91570
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x2E91584 Offset: 0x2E8D584 VA: 0x2E91584
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x2E91590 Offset: 0x2E8D590 VA: 0x2E91590 Slot: 31
	public override Decoder GetDecoder() { }

	// RVA: 0x2E915F4 Offset: 0x2E8D5F4 VA: 0x2E915F4 Slot: 32
	public override Encoder GetEncoder() { }

	// RVA: 0x2E91650 Offset: 0x2E8D650 VA: 0x2E91650 Slot: 33
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2E91750 Offset: 0x2E8D750 VA: 0x2E91750 Slot: 34
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2E9181C Offset: 0x2E8D81C VA: 0x2E9181C Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x2E91930 Offset: 0x2E8D930 VA: 0x2E91930 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x2E91AB0 Offset: 0x2E8DAB0 VA: 0x2E91AB0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2E91B74 Offset: 0x2E8DB74 VA: 0x2E91B74 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E91BF0 Offset: 0x2E8DBF0 VA: 0x2E91BF0
	private static void .cctor() { }
}
