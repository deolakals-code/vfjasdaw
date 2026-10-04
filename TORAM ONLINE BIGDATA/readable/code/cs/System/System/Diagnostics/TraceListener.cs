// Assembly: System.dll
// Namespace: System.Diagnostics
public abstract class TraceListener : MarshalByRefObject, IDisposable // TypeDefIndex: 14102
{
	// Fields
	private int indentLevel; // 0x18
	private int indentSize; // 0x1C
	private bool needIndent; // 0x20
	private string listenerName; // 0x28

	// Properties
	public virtual bool IsThreadSafe { get; }
	public int IndentLevel { set; }
	public int IndentSize { set; }
	protected bool NeedIndent { get; set; }

	// Methods

	// RVA: 0x3488140 Offset: 0x3484140 VA: 0x3488140
	protected void .ctor(string name) { }

	// RVA: 0x3488180 Offset: 0x3484180 VA: 0x3488180 Slot: 7
	public virtual bool get_IsThreadSafe() { }

	// RVA: 0x3488188 Offset: 0x3484188 VA: 0x3488188 Slot: 6
	public void Dispose() { }

	// RVA: 0x34881F4 Offset: 0x34841F4 VA: 0x34881F4 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x34881F8 Offset: 0x34841F8 VA: 0x34881F8 Slot: 9
	public virtual void Flush() { }

	// RVA: 0x3487D18 Offset: 0x3483D18 VA: 0x3487D18
	public void set_IndentLevel(int value) { }

	// RVA: 0x3487D34 Offset: 0x3483D34 VA: 0x3487D34
	public void set_IndentSize(int value) { }

	// RVA: 0x34881FC Offset: 0x34841FC VA: 0x34881FC
	protected bool get_NeedIndent() { }

	// RVA: 0x3488204 Offset: 0x3484204 VA: 0x3488204
	protected void set_NeedIndent(bool value) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Write(string message);

	// RVA: 0x3488210 Offset: 0x3484210 VA: 0x3488210 Slot: 11
	protected virtual void WriteIndent() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteLine(string message);
}
