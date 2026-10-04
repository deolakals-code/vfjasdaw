// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
internal sealed class TextReader.SyncTextReader : TextReader // TypeDefIndex: 10703
{
	// Fields
	internal readonly TextReader _in; // 0x18

	// Methods

	// RVA: 0x2F46CA4 Offset: 0x2F42CA4 VA: 0x2F46CA4
	internal void .ctor(TextReader t) { }

	// RVA: 0x2F46DF8 Offset: 0x2F42DF8 VA: 0x2F46DF8 Slot: 7
	public override void Close() { }

	// RVA: 0x2F46E18 Offset: 0x2F42E18 VA: 0x2F46E18 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F46ECC Offset: 0x2F42ECC VA: 0x2F46ECC Slot: 9
	public override int Peek() { }

	// RVA: 0x2F46EEC Offset: 0x2F42EEC VA: 0x2F46EEC Slot: 10
	public override int Read() { }

	// RVA: 0x2F46F0C Offset: 0x2F42F0C VA: 0x2F46F0C Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x2F46F2C Offset: 0x2F42F2C VA: 0x2F46F2C Slot: 13
	public override string ReadLine() { }

	// RVA: 0x2F46F50 Offset: 0x2F42F50 VA: 0x2F46F50 Slot: 12
	public override string ReadToEnd() { }
}
