// Assembly: mscorlib.dll
// Namespace: System.IO
internal class CStreamWriter : StreamWriter // TypeDefIndex: 10749
{
	// Fields
	private TermInfoDriver driver; // 0x70

	// Methods

	// RVA: 0x2F5CC98 Offset: 0x2F58C98 VA: 0x2F5CC98
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x2F5CDCC Offset: 0x2F58DCC VA: 0x2F5CDCC Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2F5D114 Offset: 0x2F59114 VA: 0x2F5D114 Slot: 13
	public override void Write(char val) { }

	// RVA: 0x2F5D320 Offset: 0x2F59320 VA: 0x2F5D320
	public void InternalWriteString(string val) { }

	// RVA: 0x2F5D29C Offset: 0x2F5929C VA: 0x2F5D29C
	public void InternalWriteChar(char val) { }

	// RVA: 0x2F5D3A4 Offset: 0x2F593A4 VA: 0x2F5D3A4
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x2F5D430 Offset: 0x2F59430 VA: 0x2F5D430 Slot: 14
	public override void Write(char[] val) { }

	// RVA: 0x2F5D458 Offset: 0x2F59458 VA: 0x2F5D458 Slot: 16
	public override void Write(string val) { }

	// RVA: 0x2F5D524 Offset: 0x2F59524 VA: 0x2F5D524 Slot: 18
	public override void WriteLine(string val) { }
}
