// Assembly: mscorlib.dll
// Namespace: System.IO
internal class CStreamReader : StreamReader // TypeDefIndex: 10748
{
	// Fields
	private TermInfoDriver driver; // 0x60

	// Methods

	// RVA: 0x2F5C750 Offset: 0x2F58750 VA: 0x2F5C750
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x2F5C870 Offset: 0x2F58870 VA: 0x2F5C870 Slot: 9
	public override int Peek() { }

	// RVA: 0x2F5C8F8 Offset: 0x2F588F8 VA: 0x2F5C8F8 Slot: 10
	public override int Read() { }

	// RVA: 0x2F5C9C8 Offset: 0x2F589C8 VA: 0x2F5C9C8 Slot: 11
	public override int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x2F5CB68 Offset: 0x2F58B68 VA: 0x2F5CB68 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x2F5CC00 Offset: 0x2F58C00 VA: 0x2F5CC00 Slot: 12
	public override string ReadToEnd() { }
}
