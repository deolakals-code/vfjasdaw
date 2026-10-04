// Assembly: mscorlib.dll
// Namespace: System.Text
[ComVisible(True)]
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 10061
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Dictionary<int, Encoding> encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x21
	[OptionalField(VersionAdded = 2)]
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalField(VersionAdded = 2)]
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual ReadOnlySpan<byte> Preamble { get; }
	public virtual string EncodingName { get; }
	public virtual string HeaderName { get; }
	public virtual string WebName { get; }
	[ComVisible(False)]
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisible(False)]
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisible(False)]
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x2E9B640 Offset: 0x2E97640 VA: 0x2E9B640
	protected void .ctor() { }

	// RVA: 0x2E9B670 Offset: 0x2E97670 VA: 0x2E9B670
	protected void .ctor(int codePage) { }

	// RVA: 0x2E9B6F8 Offset: 0x2E976F8 VA: 0x2E9B6F8 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x2E9B7A0 Offset: 0x2E977A0 VA: 0x2E9B7A0
	internal void OnDeserializing() { }

	// RVA: 0x2E9B7D4 Offset: 0x2E977D4 VA: 0x2E9B7D4
	internal void OnDeserialized() { }

	[OnDeserializing]
	// RVA: 0x2E9B818 Offset: 0x2E97818 VA: 0x2E9B818
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x2E9B84C Offset: 0x2E9784C VA: 0x2E9B84C
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x2E9B850 Offset: 0x2E97850 VA: 0x2E9B850
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2E9B85C Offset: 0x2E9785C VA: 0x2E9B85C
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E9BC9C Offset: 0x2E97C9C VA: 0x2E9BC9C
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E9BE44 Offset: 0x2E97E44 VA: 0x2E9BE44
	private static object get_InternalSyncObject() { }

	// RVA: 0x2E9BEDC Offset: 0x2E97EDC VA: 0x2E9BEDC
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x2E9D34C Offset: 0x2E9934C VA: 0x2E9D34C
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x2E9D5C8 Offset: 0x2E995C8 VA: 0x2E9D5C8
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x2E9D664 Offset: 0x2E99664 VA: 0x2E9D664 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x2E9D6BC Offset: 0x2E996BC VA: 0x2E9D6BC Slot: 7
	public virtual ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x2E9D710 Offset: 0x2E99710 VA: 0x2E9D710
	private void GetDataItem() { }

	// RVA: 0x2E9D84C Offset: 0x2E9984C VA: 0x2E9D84C Slot: 8
	public virtual string get_EncodingName() { }

	// RVA: 0x2E9D858 Offset: 0x2E99858 VA: 0x2E9D858 Slot: 9
	public virtual string get_HeaderName() { }

	// RVA: 0x2E9D888 Offset: 0x2E99888 VA: 0x2E9D888 Slot: 10
	public virtual string get_WebName() { }

	// RVA: 0x2E9D8B8 Offset: 0x2E998B8 VA: 0x2E9D8B8
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x2E9D450 Offset: 0x2E99450 VA: 0x2E9D450
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x2E9D8C0 Offset: 0x2E998C0 VA: 0x2E9D8C0
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x2E9D50C Offset: 0x2E9950C VA: 0x2E9D50C
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisible(False)]
	// RVA: 0x2E9D8C8 Offset: 0x2E998C8 VA: 0x2E9D8C8 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x2E9D950 Offset: 0x2E99950 VA: 0x2E9D950
	public bool get_IsReadOnly() { }

	// RVA: 0x2E9CAF4 Offset: 0x2E98AF4 VA: 0x2E9CAF4
	public static Encoding get_ASCII() { }

	// RVA: 0x2E9CB98 Offset: 0x2E98B98 VA: 0x2E9CB98
	private static Encoding get_Latin1() { }

	// RVA: 0x2E9D958 Offset: 0x2E99958 VA: 0x2E9D958 Slot: 12
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetByteCount(char[] chars, int index, int count);

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x2E9D9E4 Offset: 0x2E999E4 VA: 0x2E9D9E4 Slot: 14
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x2E9DB54 Offset: 0x2E99B54 VA: 0x2E9DB54 Slot: 15
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2E9DB64 Offset: 0x2E99B64 VA: 0x2E9DB64 Slot: 16
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x2E9DC20 Offset: 0x2E99C20 VA: 0x2E9DC20 Slot: 18
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x2E9DD20 Offset: 0x2E99D20 VA: 0x2E9DD20 Slot: 19
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2E9DDCC Offset: 0x2E99DCC VA: 0x2E9DDCC Slot: 20
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x2E9DDDC Offset: 0x2E99DDC VA: 0x2E9DDDC Slot: 21
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x2E9DFF8 Offset: 0x2E99FF8 VA: 0x2E9DFF8 Slot: 23
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2E9E168 Offset: 0x2E9A168 VA: 0x2E9E168 Slot: 24
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2E9E178 Offset: 0x2E9A178 VA: 0x2E9E178 Slot: 25
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x2E9E234 Offset: 0x2E9A234 VA: 0x2E9E234 Slot: 27
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2E9E450 Offset: 0x2E9A450 VA: 0x2E9E450 Slot: 28
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x2E9E460 Offset: 0x2E9A460 VA: 0x2E9E460
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x2E9E544 Offset: 0x2E9A544 VA: 0x2E9E544 Slot: 29
	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars) { }

	// RVA: 0x2E9E618 Offset: 0x2E9A618 VA: 0x2E9E618
	public string GetString(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x2E9E694 Offset: 0x2E9A694 VA: 0x2E9E694 Slot: 30
	public virtual int get_CodePage() { }

	// RVA: 0x2E9E69C Offset: 0x2E9A69C VA: 0x2E9E69C Slot: 31
	public virtual Decoder GetDecoder() { }

	// RVA: 0x2E9E748 Offset: 0x2E9A748 VA: 0x2E9E748
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x2E9E924 Offset: 0x2E9A924 VA: 0x2E9E924
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x2E9C7C0 Offset: 0x2E987C0 VA: 0x2E9C7C0
	public static Encoding get_Default() { }

	// RVA: 0x2E9E930 Offset: 0x2E9A930 VA: 0x2E9E930 Slot: 32
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x2E9E9DC Offset: 0x2E9A9DC VA: 0x2E9E9DC Slot: 35
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x2E9EA6C Offset: 0x2E9AA6C VA: 0x2E9EA6C Slot: 36
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2E9C84C Offset: 0x2E9884C VA: 0x2E9C84C
	public static Encoding get_Unicode() { }

	// RVA: 0x2E9C8F8 Offset: 0x2E988F8 VA: 0x2E9C8F8
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x2E9C9A4 Offset: 0x2E989A4 VA: 0x2E9C9A4
	public static Encoding get_UTF7() { }

	// RVA: 0x2E9B4A4 Offset: 0x2E974A4 VA: 0x2E9B4A4
	public static Encoding get_UTF8() { }

	// RVA: 0x2E9CA48 Offset: 0x2E98A48 VA: 0x2E9CA48
	public static Encoding get_UTF32() { }

	// RVA: 0x2E9EA94 Offset: 0x2E9AA94 VA: 0x2E9EA94 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2E9EB64 Offset: 0x2E9AB64 VA: 0x2E9EB64 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E9EBBC Offset: 0x2E9ABBC VA: 0x2E9EBBC Slot: 37
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2E9EC14 Offset: 0x2E9AC14 VA: 0x2E9EC14 Slot: 38
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x2E9EC6C Offset: 0x2E9AC6C VA: 0x2E9EC6C
	internal void ThrowBytesOverflow() { }

	// RVA: 0x2E9ED70 Offset: 0x2E9AD70 VA: 0x2E9ED70
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x2E9EDE8 Offset: 0x2E9ADE8 VA: 0x2E9EDE8
	internal void ThrowCharsOverflow() { }

	// RVA: 0x2E9EEEC Offset: 0x2E9AEEC VA: 0x2E9EEEC
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

	// RVA: 0x2E9EF64 Offset: 0x2E9AF64 VA: 0x2E9EF64 Slot: 39
	public virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes) { }
}
