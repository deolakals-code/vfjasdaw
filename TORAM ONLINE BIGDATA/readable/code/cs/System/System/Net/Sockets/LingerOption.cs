// Assembly: System.dll
// Namespace: System.Net.Sockets
public class LingerOption // TypeDefIndex: 14576
{
	// Fields
	private bool enabled; // 0x10
	private int lingerTime; // 0x14

	// Properties
	public bool Enabled { set; }
	public int LingerTime { set; }

	// Methods

	// RVA: 0x3458D0C Offset: 0x3454D0C VA: 0x3458D0C
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x345DD8C Offset: 0x3459D8C VA: 0x345DD8C
	public void set_Enabled(bool value) { }

	// RVA: 0x345DD98 Offset: 0x3459D98 VA: 0x345DD98
	public void set_LingerTime(int value) { }
}
