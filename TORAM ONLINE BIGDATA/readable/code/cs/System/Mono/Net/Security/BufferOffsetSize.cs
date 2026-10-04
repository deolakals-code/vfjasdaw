// Assembly: System.dll
// Namespace: Mono.Net.Security
internal class BufferOffsetSize // TypeDefIndex: 13982
{
	// Fields
	public byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Size; // 0x1C
	public int TotalBytes; // 0x20
	public bool Complete; // 0x24

	// Properties
	public int EndOffset { get; }
	public int Remaining { get; }

	// Methods

	// RVA: 0x31974A8 Offset: 0x31934A8 VA: 0x31974A8
	public int get_EndOffset() { }

	// RVA: 0x31974B4 Offset: 0x31934B4 VA: 0x31974B4
	public int get_Remaining() { }

	// RVA: 0x31974DC Offset: 0x31934DC VA: 0x31974DC
	public void .ctor(byte[] buffer, int offset, int size) { }

	// RVA: 0x31975E0 Offset: 0x31935E0 VA: 0x31975E0 Slot: 3
	public override string ToString() { }
}
