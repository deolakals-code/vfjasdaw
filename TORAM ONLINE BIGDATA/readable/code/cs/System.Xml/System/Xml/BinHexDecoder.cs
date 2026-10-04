// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 13257
{
	// Fields
	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x32AAA60 Offset: 0x32A6A60 VA: 0x32AAA60 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x32AAA70 Offset: 0x32A6A70 VA: 0x32AAA70 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x32AAD84 Offset: 0x32A6D84 VA: 0x32AAD84
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x32AABBC Offset: 0x32A6BBC VA: 0x32AABBC
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }
}
