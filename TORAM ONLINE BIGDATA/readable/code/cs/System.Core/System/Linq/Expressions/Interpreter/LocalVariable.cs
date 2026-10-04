// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariable // TypeDefIndex: 15594
{
	// Fields
	public readonly int Index; // 0x10
	private int _flags; // 0x14

	// Properties
	public bool IsBoxed { get; set; }
	public bool InClosure { get; }

	// Methods

	// RVA: 0x316B8E8 Offset: 0x31678E8 VA: 0x316B8E8
	public bool get_IsBoxed() { }

	// RVA: 0x3170ED8 Offset: 0x316CED8 VA: 0x3170ED8
	public void set_IsBoxed(bool value) { }

	// RVA: 0x316B8DC Offset: 0x31678DC VA: 0x316B8DC
	public bool get_InClosure() { }

	// RVA: 0x3170EE8 Offset: 0x316CEE8 VA: 0x3170EE8
	internal void .ctor(int index, bool closure) { }

	// RVA: 0x3170F20 Offset: 0x316CF20 VA: 0x3170F20 Slot: 3
	public override string ToString() { }
}
