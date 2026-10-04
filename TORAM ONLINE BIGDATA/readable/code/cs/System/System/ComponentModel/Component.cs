// Assembly: System.dll
// Namespace: System.ComponentModel
[ClassInterface(1)]
[ComVisible(True)]
[DesignerCategory("Component")]
public class Component : MarshalByRefObject // TypeDefIndex: 14249
{
	// Fields
	private static readonly object EventDisposed; // 0x0

	// Properties
	protected virtual bool CanRaiseEvents { get; }
	internal bool CanRaiseEventsInternal { get; }

	// Methods

	// RVA: 0x34B4474 Offset: 0x34B0474 VA: 0x34B4474 Slot: 6
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x34B447C Offset: 0x34B047C VA: 0x34B447C
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x34B4488 Offset: 0x34B0488 VA: 0x34B4488
	private static void .cctor() { }
}
