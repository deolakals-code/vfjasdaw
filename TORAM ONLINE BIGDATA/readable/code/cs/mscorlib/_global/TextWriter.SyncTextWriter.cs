// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
internal sealed class TextWriter.SyncTextWriter : TextWriter, IDisposable // TypeDefIndex: 10706
{
	// Fields
	private readonly TextWriter _out; // 0x30

	// Properties
	public override Encoding Encoding { get; }
	public override IFormatProvider FormatProvider { get; }
	public override string NewLine { get; }

	// Methods

	// RVA: 0x2F473C4 Offset: 0x2F433C4 VA: 0x2F473C4
	internal void .ctor(TextWriter t) { }

	// RVA: 0x2F47598 Offset: 0x2F43598 VA: 0x2F47598 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2F475B8 Offset: 0x2F435B8 VA: 0x2F475B8 Slot: 7
	public override IFormatProvider get_FormatProvider() { }

	// RVA: 0x2F475D8 Offset: 0x2F435D8 VA: 0x2F475D8 Slot: 12
	public override string get_NewLine() { }

	// RVA: 0x2F475F8 Offset: 0x2F435F8 VA: 0x2F475F8 Slot: 8
	public override void Close() { }

	// RVA: 0x2F47618 Offset: 0x2F43618 VA: 0x2F47618 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F476CC Offset: 0x2F436CC VA: 0x2F476CC Slot: 10
	public override void Flush() { }

	// RVA: 0x2F476EC Offset: 0x2F436EC VA: 0x2F476EC Slot: 13
	public override void Write(char value) { }

	// RVA: 0x2F47710 Offset: 0x2F43710 VA: 0x2F47710 Slot: 14
	public override void Write(char[] buffer) { }

	// RVA: 0x2F47734 Offset: 0x2F43734 VA: 0x2F47734 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2F47758 Offset: 0x2F43758 VA: 0x2F47758 Slot: 16
	public override void Write(string value) { }

	// RVA: 0x2F4777C Offset: 0x2F4377C VA: 0x2F4777C Slot: 17
	public override void WriteLine() { }

	// RVA: 0x2F477A0 Offset: 0x2F437A0 VA: 0x2F477A0 Slot: 18
	public override void WriteLine(string value) { }
}
