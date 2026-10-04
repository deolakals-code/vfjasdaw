// Assembly: System.dll
// Namespace: System.ComponentModel
public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 14186
{
	// Fields
	[CompilerGenerated]
	private readonly CollectionChangeAction <Action>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly object <Element>k__BackingField; // 0x18

	// Properties
	public virtual CollectionChangeAction Action { get; }
	public virtual object Element { get; }

	// Methods

	// RVA: 0x34A0E38 Offset: 0x349CE38 VA: 0x34A0E38
	public void .ctor(CollectionChangeAction action, object element) { }

	[CompilerGenerated]
	// RVA: 0x34A0EB4 Offset: 0x349CEB4 VA: 0x34A0EB4 Slot: 4
	public virtual CollectionChangeAction get_Action() { }

	[CompilerGenerated]
	// RVA: 0x34A0EBC Offset: 0x349CEBC VA: 0x34A0EBC Slot: 5
	public virtual object get_Element() { }
}
