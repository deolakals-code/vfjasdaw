// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class HuntingOneArchetype : Archetype // TypeDefIndex: 15149
{
	// Fields
	private IArchetypeListener listener; // 0x50
	[CompilerGenerated]
	private HuntingOneData <HuntingOneData>k__BackingField; // 0x58

	// Properties
	public HuntingOneData HuntingOneData { get; set; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x35ABF20 Offset: 0x35A7F20 VA: 0x35ABF20
	public void .ctor(Game game, CompanionData companionData) { }

	[CompilerGenerated]
	// RVA: 0x35AEEA8 Offset: 0x35AAEA8 VA: 0x35AEEA8
	public HuntingOneData get_HuntingOneData() { }

	[CompilerGenerated]
	// RVA: 0x35AEEB0 Offset: 0x35AAEB0 VA: 0x35AEEB0
	private void set_HuntingOneData(HuntingOneData value) { }

	// RVA: 0x35AEEB8 Offset: 0x35AAEB8 VA: 0x35AEEB8
	public void SetListener(IArchetypeListener listener) { }

	// RVA: 0x35AEEC0 Offset: 0x35AAEC0 VA: 0x35AEEC0 Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35AEFAC Offset: 0x35AAFAC VA: 0x35AEFAC Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35AF09C Offset: 0x35AB09C VA: 0x35AF09C Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
