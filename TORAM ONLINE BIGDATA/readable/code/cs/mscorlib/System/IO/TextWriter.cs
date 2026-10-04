// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 10707
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static readonly char[] s_coreNewLine; // 0x8
	protected char[] CoreNewLine; // 0x18
	private string CoreNewLineStr; // 0x20
	private IFormatProvider _internalFormatProvider; // 0x28

	// Properties
	public virtual IFormatProvider FormatProvider { get; }
	public abstract Encoding Encoding { get; }
	public virtual string NewLine { get; }

	// Methods

	// RVA: 0x2F45C8C Offset: 0x2F41C8C VA: 0x2F45C8C
	protected void .ctor() { }

	// RVA: 0x2F45524 Offset: 0x2F41524 VA: 0x2F45524
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x2F46F70 Offset: 0x2F42F70 VA: 0x2F46F70 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x2F46FD8 Offset: 0x2F42FD8 VA: 0x2F46FD8 Slot: 8
	public virtual void Close() { }

	// RVA: 0x2F47044 Offset: 0x2F43044 VA: 0x2F47044 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2F47048 Offset: 0x2F43048 VA: 0x2F47048 Slot: 6
	public void Dispose() { }

	// RVA: 0x2F470B4 Offset: 0x2F430B4 VA: 0x2F470B4 Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x2F470B8 Offset: 0x2F430B8 VA: 0x2F470B8 Slot: 12
	public virtual string get_NewLine() { }

	// RVA: 0x2F470C0 Offset: 0x2F430C0 VA: 0x2F470C0 Slot: 13
	public virtual void Write(char value) { }

	// RVA: 0x2F470C4 Offset: 0x2F430C4 VA: 0x2F470C4 Slot: 14
	public virtual void Write(char[] buffer) { }

	// RVA: 0x2F470E4 Offset: 0x2F430E4 VA: 0x2F470E4 Slot: 15
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2F47288 Offset: 0x2F43288 VA: 0x2F47288 Slot: 16
	public virtual void Write(string value) { }

	// RVA: 0x2F472C0 Offset: 0x2F432C0 VA: 0x2F472C0 Slot: 17
	public virtual void WriteLine() { }

	// RVA: 0x2F472D4 Offset: 0x2F432D4 VA: 0x2F472D4 Slot: 18
	public virtual void WriteLine(string value) { }

	// RVA: 0x2F47310 Offset: 0x2F43310 VA: 0x2F47310
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x2F47448 Offset: 0x2F43448 VA: 0x2F47448
	private static void .cctor() { }
}
