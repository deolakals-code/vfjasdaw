// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class UTF16Decoder : Decoder // TypeDefIndex: 13452
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x33DE724 Offset: 0x33DA724 VA: 0x33DE724
	public void .ctor(bool bigEndian) { }

	// RVA: 0x33DE754 Offset: 0x33DA754 VA: 0x33DE754 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x33DE764 Offset: 0x33DA764 VA: 0x33DE764 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x33DE848 Offset: 0x33DA848 VA: 0x33DE848 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x33DE9BC Offset: 0x33DA9BC VA: 0x33DE9BC Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}
