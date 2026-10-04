// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 10052
{
	// Fields
	internal static readonly UTF8Encoding.UTF8EncodingSealed s_default; // 0x0
	internal static readonly byte[] s_preamble; // 0x8
	internal readonly bool _emitUTF8Identifier; // 0x38
	private bool _isThrowException; // 0x39

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x2E93D84 Offset: 0x2E8FD84 VA: 0x2E93D84
	public void .ctor() { }

	// RVA: 0x2E93DA4 Offset: 0x2E8FDA4 VA: 0x2E93DA4
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x2E93DD4 Offset: 0x2E8FDD4 VA: 0x2E93DD4
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x2E93E34 Offset: 0x2E8FE34 VA: 0x2E93E34 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x2E93F20 Offset: 0x2E8FF20 VA: 0x2E93F20 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x2E94098 Offset: 0x2E90098 VA: 0x2E94098 Slot: 12
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x2E94124 Offset: 0x2E90124 VA: 0x2E94124 Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x2E941F4 Offset: 0x2E901F4 VA: 0x2E941F4 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2E9443C Offset: 0x2E9043C VA: 0x2E9443C Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x2E946A0 Offset: 0x2E906A0 VA: 0x2E946A0 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2E94798 Offset: 0x2E90798 VA: 0x2E94798 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x2E94910 Offset: 0x2E90910 VA: 0x2E94910 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2E949E0 Offset: 0x2E909E0 VA: 0x2E949E0 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x2E94C44 Offset: 0x2E90C44 VA: 0x2E94C44 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2E94D3C Offset: 0x2E90D3C VA: 0x2E94D3C Slot: 36
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2E94EF8 Offset: 0x2E90EF8 VA: 0x2E94EF8 Slot: 15
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x2E954BC Offset: 0x2E914BC VA: 0x2E954BC
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x2E954C8 Offset: 0x2E914C8 VA: 0x2E954C8
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x2E954A8 Offset: 0x2E914A8 VA: 0x2E954A8
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x2E954D0 Offset: 0x2E914D0 VA: 0x2E954D0 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x2E95BC0 Offset: 0x2E91BC0 VA: 0x2E95BC0 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x2E960A4 Offset: 0x2E920A4 VA: 0x2E960A4 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x2E96744 Offset: 0x2E92744 VA: 0x2E96744
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x2E96064 Offset: 0x2E92064 VA: 0x2E96064
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x2E967B0 Offset: 0x2E927B0 VA: 0x2E967B0
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x2E969A4 Offset: 0x2E929A4 VA: 0x2E969A4 Slot: 31
	public override Decoder GetDecoder() { }

	// RVA: 0x2E96A08 Offset: 0x2E92A08 VA: 0x2E96A08 Slot: 32
	public override Encoder GetEncoder() { }

	// RVA: 0x2E96A6C Offset: 0x2E92A6C VA: 0x2E96A6C Slot: 33
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2E96B6C Offset: 0x2E92B6C VA: 0x2E96B6C Slot: 34
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2E96C6C Offset: 0x2E92C6C VA: 0x2E96C6C Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x2E96D50 Offset: 0x2E92D50 VA: 0x2E96D50 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x2E96EC0 Offset: 0x2E92EC0 VA: 0x2E96EC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2E96F90 Offset: 0x2E92F90 VA: 0x2E96F90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E96FF0 Offset: 0x2E92FF0 VA: 0x2E96FF0
	private static void .cctor() { }
}
