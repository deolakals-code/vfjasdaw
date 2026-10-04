// Assembly: mscorlib.dll
// Namespace: 
private class StreamReader.NullStreamReader : StreamReader // TypeDefIndex: 10699
{
	// Properties
	public override Stream BaseStream { get; }
	public override Encoding CurrentEncoding { get; }

	// Methods

	// RVA: 0x2F451F0 Offset: 0x2F411F0 VA: 0x2F451F0
	internal void .ctor() { }

	// RVA: 0x2F4528C Offset: 0x2F4128C VA: 0x2F4528C Slot: 15
	public override Stream get_BaseStream() { }

	// RVA: 0x2F452E4 Offset: 0x2F412E4 VA: 0x2F452E4 Slot: 14
	public override Encoding get_CurrentEncoding() { }

	// RVA: 0x2F452EC Offset: 0x2F412EC VA: 0x2F452EC Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F452F0 Offset: 0x2F412F0 VA: 0x2F452F0 Slot: 9
	public override int Peek() { }

	// RVA: 0x2F452F8 Offset: 0x2F412F8 VA: 0x2F452F8 Slot: 10
	public override int Read() { }

	// RVA: 0x2F45300 Offset: 0x2F41300 VA: 0x2F45300 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x2F45308 Offset: 0x2F41308 VA: 0x2F45308 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x2F45310 Offset: 0x2F41310 VA: 0x2F45310 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x2F45358 Offset: 0x2F41358 VA: 0x2F45358 Slot: 16
	internal override int ReadBuffer() { }
}
