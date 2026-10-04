// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public class UnicodeEncoding : Encoding // TypeDefIndex: 10054
{
	// Fields
	internal static readonly UnicodeEncoding s_bigEndianDefault; // 0x0
	internal static readonly UnicodeEncoding s_littleEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x20

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x2E97288 Offset: 0x2E93288 VA: 0x2E97288
	public void .ctor() { }

	// RVA: 0x2E972BC Offset: 0x2E932BC VA: 0x2E972BC
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x2E97300 Offset: 0x2E93300 VA: 0x2E97300
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	// RVA: 0x2E97374 Offset: 0x2E93374 VA: 0x2E97374 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x2E97460 Offset: 0x2E93460 VA: 0x2E97460 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x2E975D8 Offset: 0x2E935D8 VA: 0x2E975D8 Slot: 12
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x2E97664 Offset: 0x2E93664 VA: 0x2E97664 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x2E97734 Offset: 0x2E93734 VA: 0x2E97734 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2E9797C Offset: 0x2E9397C VA: 0x2E9797C Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x2E97BE0 Offset: 0x2E93BE0 VA: 0x2E97BE0 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2E97CD8 Offset: 0x2E93CD8 VA: 0x2E97CD8 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x2E97E50 Offset: 0x2E93E50 VA: 0x2E97E50 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2E97F20 Offset: 0x2E93F20 VA: 0x2E97F20 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x2E98184 Offset: 0x2E94184 VA: 0x2E98184 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2E9827C Offset: 0x2E9427C VA: 0x2E9827C Slot: 36
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2E98438 Offset: 0x2E94438 VA: 0x2E98438 Slot: 15
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2E98958 Offset: 0x2E94958 VA: 0x2E98958 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x2E99004 Offset: 0x2E95004 VA: 0x2E99004 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x2E99648 Offset: 0x2E95648 VA: 0x2E99648 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x2E99F2C Offset: 0x2E95F2C VA: 0x2E99F2C Slot: 32
	public override Encoder GetEncoder() { }

	// RVA: 0x2E99F88 Offset: 0x2E95F88 VA: 0x2E99F88 Slot: 31
	public override Decoder GetDecoder() { }

	// RVA: 0x2E99FE4 Offset: 0x2E95FE4 VA: 0x2E99FE4 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x2E9A0F0 Offset: 0x2E960F0 VA: 0x2E9A0F0 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x2E9A270 Offset: 0x2E96270 VA: 0x2E9A270 Slot: 33
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2E9A370 Offset: 0x2E96370 VA: 0x2E9A370 Slot: 34
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2E9A474 Offset: 0x2E96474 VA: 0x2E9A474 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2E9A588 Offset: 0x2E96588 VA: 0x2E9A588 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E9A604 Offset: 0x2E96604 VA: 0x2E9A604
	private static void .cctor() { }
}
