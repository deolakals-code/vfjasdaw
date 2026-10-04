// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CallGolemMember : AutoMember, IArchetypeListener // TypeDefIndex: 536
{
	// Fields
	private CallGolemMemberSettingBase setting; // 0xB8
	private CallGolemActionManager golemActionManager; // 0xC0

	// Methods

	// RVA: 0x18343A0 Offset: 0x18303A0 VA: 0x18343A0
	public void Initialize(Archetype archetype, CallGolemMemberSettingBase setting) { }

	// RVA: 0x183216C Offset: 0x182E16C VA: 0x183216C
	public void Remove(bool force) { }

	// RVA: 0x18344DC Offset: 0x18304DC VA: 0x18344DC
	public void OwnerDead() { }

	// RVA: 0x1834508 Offset: 0x1830508 VA: 0x1834508 Slot: 52
	public override void Initialize(Archetype archetype) { }

	// RVA: 0x18345C0 Offset: 0x18305C0 VA: 0x18345C0 Slot: 53
	public override bool CheckHitType(MobPatternBase pattern) { }

	// RVA: 0x18345C8 Offset: 0x18305C8 VA: 0x18345C8 Slot: 60
	public void OnActionEvent(ArchetypeActionEvent action) { }

	// RVA: 0x18345CC Offset: 0x18305CC VA: 0x18345CC Slot: 59
	public void OnEvent(PacketBase events) { }

	// RVA: 0x18345D0 Offset: 0x18305D0 VA: 0x18345D0 Slot: 58
	public void OnOperation(PacketBase opeation) { }

	// RVA: 0x18345D4 Offset: 0x18305D4 VA: 0x18345D4
	public void .ctor() { }
}
