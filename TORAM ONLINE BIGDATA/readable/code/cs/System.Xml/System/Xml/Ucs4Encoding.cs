// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class Ucs4Encoding : Encoding // TypeDefIndex: 13454
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0x33DEC8C Offset: 0x33DAC8C VA: 0x33DEC8C Slot: 10
	public override string get_WebName() { }

	// RVA: 0x33DEC98 Offset: 0x33DAC98 VA: 0x33DEC98 Slot: 31
	public override Decoder GetDecoder() { }

	// RVA: 0x33DECA0 Offset: 0x33DACA0 VA: 0x33DECA0 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x33DED00 Offset: 0x33DAD00 VA: 0x33DED00 Slot: 18
	public override byte[] GetBytes(string s) { }

	// RVA: 0x33DED08 Offset: 0x33DAD08 VA: 0x33DED08 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x33DED10 Offset: 0x33DAD10 VA: 0x33DED10 Slot: 33
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x33DED18 Offset: 0x33DAD18 VA: 0x33DED18 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x33DED38 Offset: 0x33DAD38 VA: 0x33DED38 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x33DED58 Offset: 0x33DAD58 VA: 0x33DED58 Slot: 34
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x33DED70 Offset: 0x33DAD70 VA: 0x33DED70 Slot: 30
	public override int get_CodePage() { }

	// RVA: 0x33DED78 Offset: 0x33DAD78 VA: 0x33DED78 Slot: 32
	public override Encoder GetEncoder() { }

	// RVA: 0x33DED80 Offset: 0x33DAD80 VA: 0x33DED80
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x33DEE38 Offset: 0x33DAE38 VA: 0x33DEE38
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x33DEEF0 Offset: 0x33DAEF0 VA: 0x33DEEF0
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x33DEFA8 Offset: 0x33DAFA8 VA: 0x33DEFA8
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x33DF060 Offset: 0x33DB060 VA: 0x33DF060
	public void .ctor() { }
}
