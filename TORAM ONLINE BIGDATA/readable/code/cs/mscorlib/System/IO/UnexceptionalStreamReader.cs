// Assembly: mscorlib.dll
// Namespace: System.IO
internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 10746
{
	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x2F5BCE4 Offset: 0x2F57CE4 VA: 0x2F5BCE4
	private static void .cctor() { }

	// RVA: 0x2F5BD94 Offset: 0x2F57D94 VA: 0x2F5BD94
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x2F5BE04 Offset: 0x2F57E04 VA: 0x2F5BE04 Slot: 9
	public override int Peek() { }

	// RVA: 0x2F5BE8C Offset: 0x2F57E8C VA: 0x2F5BE8C Slot: 10
	public override int Read() { }

	// RVA: 0x2F5BF14 Offset: 0x2F57F14 VA: 0x2F5BF14 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x2F5C19C Offset: 0x2F5819C VA: 0x2F5C19C
	private bool CheckEOL(char current) { }

	// RVA: 0x2F5C334 Offset: 0x2F58334 VA: 0x2F5C334 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x2F5C3BC Offset: 0x2F583BC VA: 0x2F5C3BC Slot: 12
	public override string ReadToEnd() { }
}
