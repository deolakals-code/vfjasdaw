// Assembly: System.Xml.dll
// Namespace: System.Xml
internal abstract class Base64Encoder // TypeDefIndex: 13254
{
	// Fields
	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20

	// Methods

	// RVA: 0x32AA564 Offset: 0x32A6564 VA: 0x32AA564
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteChars(char[] chars, int index, int count);

	// RVA: 0x32AA5C8 Offset: 0x32A65C8 VA: 0x32AA5C8
	internal void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x32AA920 Offset: 0x32A6920 VA: 0x32AA920
	internal void Flush() { }
}
