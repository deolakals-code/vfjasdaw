// Assembly: System.Core.dll
// Namespace: System.Threading
internal class ReaderWriterCount // TypeDefIndex: 15808
{
	// Fields
	public long lockID; // 0x10
	public int readercount; // 0x18
	public int writercount; // 0x1C
	public int upgradecount; // 0x20
	public ReaderWriterCount next; // 0x28

	// Methods

	// RVA: 0x318E058 Offset: 0x318A058 VA: 0x318E058
	public void .ctor() { }
}
