// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonDemonicMember : AutoMember, IArchetypeListener // TypeDefIndex: 1635
{
	// Fields
	private SummonDemonicMemberSettingBase setting; // 0xB8
	private SummonDemonicActionManager summonDemonicActionManager; // 0xC0

	// Properties
	public SummonDemonicActionManager SummonDemonicActionManager { get; }

	// Methods

	// RVA: 0x209ECC0 Offset: 0x209ACC0 VA: 0x209ECC0
	public SummonDemonicActionManager get_SummonDemonicActionManager() { }

	// RVA: 0x209ECC8 Offset: 0x209ACC8 VA: 0x209ECC8
	public void Initialize(Archetype archetype, SummonDemonicMemberSettingBase setting) { }

	// RVA: 0x209EE08 Offset: 0x209AE08 VA: 0x209EE08
	public void Remove(bool force) { }

	// RVA: 0x209EEB4 Offset: 0x209AEB4 VA: 0x209EEB4
	public void OwnerDead() { }

	// RVA: 0x209EED0 Offset: 0x209AED0 VA: 0x209EED0 Slot: 52
	public override void Initialize(Archetype archetype) { }

	// RVA: 0x209EF88 Offset: 0x209AF88 VA: 0x209EF88 Slot: 53
	public override bool CheckHitType(MobPatternBase pattern) { }

	// RVA: 0x209EF90 Offset: 0x209AF90 VA: 0x209EF90 Slot: 60
	public void OnActionEvent(ArchetypeActionEvent action) { }

	// RVA: 0x209EF94 Offset: 0x209AF94 VA: 0x209EF94 Slot: 59
	public void OnEvent(PacketBase events) { }

	// RVA: 0x209EF98 Offset: 0x209AF98 VA: 0x209EF98 Slot: 58
	public void OnOperation(PacketBase opeation) { }

	// RVA: 0x209EF9C Offset: 0x209AF9C VA: 0x209EF9C
	public void .ctor() { }
}
