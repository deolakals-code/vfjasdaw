// Assembly: System.Xml.dll
// Namespace: System.Xml
internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 13459
{
	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x33DF350 Offset: 0x33DB350 VA: 0x33DF350 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x33DF36C Offset: 0x33DB36C VA: 0x33DF36C Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x33DF514 Offset: 0x33DB514 VA: 0x33DF514 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x33DF728 Offset: 0x33DB728 VA: 0x33DF728
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0x33DF780 Offset: 0x33DB780 VA: 0x33DF780
	protected void .ctor() { }
}
