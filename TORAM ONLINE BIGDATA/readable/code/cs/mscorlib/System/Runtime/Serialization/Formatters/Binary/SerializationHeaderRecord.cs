// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerializationHeaderRecord // TypeDefIndex: 10391
{
	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x2F07DE8 Offset: 0x2F03DE8 VA: 0x2F07DE8
	internal void .ctor() { }

	// RVA: 0x2F07DF8 Offset: 0x2F03DF8 VA: 0x2F07DF8
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x2F07E50 Offset: 0x2F03E50 VA: 0x2F07E50 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F07F00 Offset: 0x2F03F00 VA: 0x2F07F00
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x2F07F74 Offset: 0x2F03F74 VA: 0x2F07F74 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x2F080F0 Offset: 0x2F040F0 VA: 0x2F080F0
	public void Dump() { }
}
