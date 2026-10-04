// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class FamiliaArchetype : Archetype // TypeDefIndex: 15147
{
	// Fields
	[CompilerGenerated]
	private FamiliaData <FamiliaData>k__BackingField; // 0x50
	private IArchetypeListener listener; // 0x58

	// Properties
	public FamiliaData FamiliaData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x35AC408 Offset: 0x35A8408 VA: 0x35AC408
	public FamiliaData get_FamiliaData() { }

	[CompilerGenerated]
	// RVA: 0x35AC410 Offset: 0x35A8410 VA: 0x35AC410
	private void set_FamiliaData(FamiliaData value) { }

	[CLSCompliant(False)]
	// RVA: 0x35ABE74 Offset: 0x35A7E74 VA: 0x35ABE74
	public void .ctor(Game game, CompanionData companionData) { }

	// RVA: 0x35AC418 Offset: 0x35A8418 VA: 0x35AC418
	public bool MoveAbsolute(short[] clientPosition, float clientRotation, bool isReliable) { }

	// RVA: 0x35AC4A4 Offset: 0x35A84A4 VA: 0x35AC4A4
	public void SetListener(IArchetypeListener listener) { }

	// RVA: 0x35AC4AC Offset: 0x35A84AC VA: 0x35AC4AC Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35AC598 Offset: 0x35A8598 VA: 0x35AC598 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35AC688 Offset: 0x35A8688 VA: 0x35AC688 Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
