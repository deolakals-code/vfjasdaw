// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class PetArchetype : Archetype // TypeDefIndex: 15158
{
	// Fields
	private IArchetypeListener listener; // 0x50
	[CompilerGenerated]
	private PetData <PetData>k__BackingField; // 0x58

	// Properties
	public override bool IsMine { get; }
	public PetData PetData { get; set; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x35ABDC8 Offset: 0x35A7DC8 VA: 0x35ABDC8
	public void .ctor(Game game, CompanionData companionData) { }

	// RVA: 0x35B12E8 Offset: 0x35AD2E8 VA: 0x35B12E8 Slot: 5
	public override bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x35B12F0 Offset: 0x35AD2F0 VA: 0x35B12F0
	public PetData get_PetData() { }

	[CompilerGenerated]
	// RVA: 0x35B12F8 Offset: 0x35AD2F8 VA: 0x35B12F8
	private void set_PetData(PetData value) { }

	// RVA: 0x35B1300 Offset: 0x35AD300 VA: 0x35B1300
	public bool MoveAbsolute(short[] clientPosition, float clientRotation, bool isReliable) { }

	// RVA: 0x35B138C Offset: 0x35AD38C VA: 0x35B138C
	public void SetListener(IArchetypeListener listener) { }

	// RVA: 0x35B1394 Offset: 0x35AD394 VA: 0x35B1394 Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35B1480 Offset: 0x35AD480 VA: 0x35B1480 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35B1570 Offset: 0x35AD570 VA: 0x35B1570 Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
