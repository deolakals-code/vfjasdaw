// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CommonArchtypeListener : IArchetypeListener // TypeDefIndex: 680
{
	// Fields
	private AutoMember member; // 0x10
	private List<IReceiver<PacketBase>> eventHandler; // 0x18
	private List<IReceiver<ArchetypeActionEvent>> actionEventHandler; // 0x20
	private List<IReceiver<OperationResponseBase>> operationHandler; // 0x28

	// Methods

	// RVA: -1 Offset: -1
	public MercenaryEventReceiver<T> AddEventHandler<T>(out Action removeAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1264 Offset: 0x27DD264 VA: 0x27E1264
	|-CommonArchtypeListener.AddEventHandler<object>
	*/

	// RVA: -1 Offset: -1
	public MercenaryActionEventReceiver<T> AddActionEventHandler<T>(out Action removeAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E10E4 Offset: 0x27DD0E4 VA: 0x27E10E4
	|-CommonArchtypeListener.AddActionEventHandler<object>
	*/

	// RVA: -1 Offset: -1
	public OperationReceiver<T> AddOperationHandler<T>(out Action removeAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E13E4 Offset: 0x27DD3E4 VA: 0x27E13E4
	|-CommonArchtypeListener.AddOperationHandler<object>
	*/

	// RVA: 0x1ABBFB4 Offset: 0x1AB7FB4 VA: 0x1ABBFB4
	public void ClearHandler() { }

	// RVA: 0x1ABC05C Offset: 0x1AB805C VA: 0x1ABC05C
	public void .ctor() { }

	// RVA: 0x1ABC18C Offset: 0x1AB818C VA: 0x1ABC18C Slot: 6
	public void OnActionEvent(ArchetypeActionEvent action) { }

	// RVA: 0x1ABC5FC Offset: 0x1AB85FC VA: 0x1ABC5FC Slot: 5
	public void OnEvent(PacketBase events) { }

	// RVA: 0x1ABCA6C Offset: 0x1AB8A6C VA: 0x1ABCA6C Slot: 4
	public void OnOperation(PacketBase opeation) { }
}
