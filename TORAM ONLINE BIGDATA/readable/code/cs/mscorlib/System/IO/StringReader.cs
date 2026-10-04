// Assembly: mscorlib.dll
// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class StringReader : TextReader // TypeDefIndex: 10734
{
	// Fields
	private string _s; // 0x18
	private int _pos; // 0x20
	private int _length; // 0x24

	// Methods

	// RVA: 0x2F53164 Offset: 0x2F4F164 VA: 0x2F53164
	public void .ctor(string s) { }

	// RVA: 0x2F53230 Offset: 0x2F4F230 VA: 0x2F53230 Slot: 7
	public override void Close() { }

	// RVA: 0x2F53240 Offset: 0x2F4F240 VA: 0x2F53240 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F53278 Offset: 0x2F4F278 VA: 0x2F53278 Slot: 9
	public override int Peek() { }

	// RVA: 0x2F532B4 Offset: 0x2F4F2B4 VA: 0x2F532B4 Slot: 10
	public override int Read() { }

	// RVA: 0x2F532F8 Offset: 0x2F4F2F8 VA: 0x2F532F8 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x2F534A0 Offset: 0x2F4F4A0 VA: 0x2F534A0 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x2F534DC Offset: 0x2F4F4DC VA: 0x2F534DC Slot: 13
	public override string ReadLine() { }
}
