// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class NpcArchetype : Archetype // TypeDefIndex: 15156
{
	// Fields
	private INpcListener listener; // 0x50

	// Properties
	public override bool IsMine { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x35B0664 Offset: 0x35AC664 VA: 0x35B0664
	public void .ctor(Game game, int id, byte type) { }

	// RVA: 0x35B0674 Offset: 0x35AC674 VA: 0x35B0674 Slot: 5
	public override bool get_IsMine() { }

	// RVA: 0x35B067C Offset: 0x35AC67C VA: 0x35B067C
	public void SetListener(INpcListener listener) { }

	// RVA: 0x35B0684 Offset: 0x35AC684 VA: 0x35B0684 Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35B0778 Offset: 0x35AC778 VA: 0x35B0778 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35B0E6C Offset: 0x35ACE6C VA: 0x35B0E6C Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
