// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public interface IArchetypeListener // TypeDefIndex: 15151
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnOperation(PacketBase opeation);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEvent(PacketBase events);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnActionEvent(ArchetypeActionEvent action);
}
