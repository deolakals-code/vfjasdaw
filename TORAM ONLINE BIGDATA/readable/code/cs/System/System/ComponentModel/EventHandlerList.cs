// Assembly: System.dll
// Namespace: System.ComponentModel
[DefaultMember("Item")]
public sealed class EventHandlerList // TypeDefIndex: 14170
{
	// Fields
	private EventHandlerList.ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Properties
	public Delegate Item { get; }

	// Methods

	// RVA: 0x349E5B0 Offset: 0x349A5B0 VA: 0x349E5B0
	public Delegate get_Item(object key) { }

	// RVA: 0x349E610 Offset: 0x349A610 VA: 0x349E610
	private EventHandlerList.ListEntry Find(object key) { }
}
