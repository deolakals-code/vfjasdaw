// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class PartnerArchetype : Archetype // TypeDefIndex: 15157
{
	// Fields
	private IArchetypeListener listener; // 0x50
	[CompilerGenerated]
	private PartnerData <PartnerData>k__BackingField; // 0x58

	// Properties
	public override bool IsMine { get; }
	public PartnerData PartnerData { get; set; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x35ABC58 Offset: 0x35A7C58 VA: 0x35ABC58
	public void .ctor(Game game, CompanionData companionData) { }

	// RVA: 0x35B0F70 Offset: 0x35ACF70 VA: 0x35B0F70 Slot: 5
	public override bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x35B0F78 Offset: 0x35ACF78 VA: 0x35B0F78
	public PartnerData get_PartnerData() { }

	[CompilerGenerated]
	// RVA: 0x35B0F80 Offset: 0x35ACF80 VA: 0x35B0F80
	private void set_PartnerData(PartnerData value) { }

	// RVA: 0x35B0F88 Offset: 0x35ACF88 VA: 0x35B0F88
	public bool MoveAbsolute(short[] clientPosition, float clientRotation, bool isReliable) { }

	// RVA: 0x35B1014 Offset: 0x35AD014 VA: 0x35B1014
	public void SetListener(IArchetypeListener listener) { }

	// RVA: 0x35B101C Offset: 0x35AD01C VA: 0x35B101C Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35B1108 Offset: 0x35AD108 VA: 0x35B1108 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35B11F8 Offset: 0x35AD1F8 VA: 0x35B11F8 Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
