// Assembly: mscorlib.dll
// Namespace: System.Threading
[ComVisible(True)]
public class EventWaitHandle : WaitHandle // TypeDefIndex: 9896
{
	// Methods

	// RVA: 0x3047284 Offset: 0x3043284 VA: 0x3047284
	public void .ctor(bool initialState, EventResetMode mode) { }

	// RVA: 0x304E63C Offset: 0x304A63C VA: 0x304E63C
	public void .ctor(bool initialState, EventResetMode mode, string name) { }

	// RVA: 0x304C564 Offset: 0x3048564 VA: 0x304C564
	public bool Reset() { }

	// RVA: 0x3048D30 Offset: 0x3044D30 VA: 0x3048D30
	public bool Set() { }
}
