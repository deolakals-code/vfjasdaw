// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class MercenaryArchetype : Archetype // TypeDefIndex: 15154
{
	// Fields
	private IArchetypeListener listener; // 0x50
	[CompilerGenerated]
	private MercenaryData <MercenaryData>k__BackingField; // 0x58

	// Properties
	public override bool IsMine { get; }
	public MercenaryData MercenaryData { get; set; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x35ABD04 Offset: 0x35A7D04 VA: 0x35ABD04
	public void .ctor(Game game, CompanionData companionData) { }

	// RVA: 0x35AF18C Offset: 0x35AB18C VA: 0x35AF18C Slot: 5
	public override bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x35AF194 Offset: 0x35AB194 VA: 0x35AF194
	public MercenaryData get_MercenaryData() { }

	[CompilerGenerated]
	// RVA: 0x35AF19C Offset: 0x35AB19C VA: 0x35AF19C
	private void set_MercenaryData(MercenaryData value) { }

	// RVA: 0x35AF1A4 Offset: 0x35AB1A4 VA: 0x35AF1A4
	public bool MoveAbsolute(short[] clientPosition, float clientRotation, bool isReliable) { }

	// RVA: 0x35AF230 Offset: 0x35AB230 VA: 0x35AF230
	public void SetListener(IArchetypeListener listener) { }

	// RVA: 0x35AF238 Offset: 0x35AB238 VA: 0x35AF238 Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35AF324 Offset: 0x35AB324 VA: 0x35AF324 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35AF414 Offset: 0x35AB414 VA: 0x35AF414 Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
