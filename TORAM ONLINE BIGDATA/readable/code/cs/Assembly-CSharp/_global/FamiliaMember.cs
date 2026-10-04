// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FamiliaMember : AutoMember, IArchetypeListener // TypeDefIndex: 580
{
	// Fields
	private FamiliaMemberSettingBase setting; // 0xB8
	private bool escape; // 0xC0

	// Properties
	private FamiliaActionManager actionManager { get; }

	// Methods

	// RVA: 0x1906B98 Offset: 0x1902B98 VA: 0x1906B98
	private FamiliaActionManager get_actionManager() { }

	// RVA: 0x1906C10 Offset: 0x1902C10 VA: 0x1906C10
	private void LateUpdate() { }

	// RVA: 0x1906D40 Offset: 0x1902D40 VA: 0x1906D40 Slot: 52
	public override void Initialize(Archetype archetype) { }

	// RVA: 0x1906DF8 Offset: 0x1902DF8 VA: 0x1906DF8
	public void Initialize(Archetype archetype, FamiliaMemberSettingBase setting) { }

	// RVA: 0x1906F7C Offset: 0x1902F7C VA: 0x1906F7C
	public void Remove(bool force) { }

	// RVA: 0x1906FD4 Offset: 0x1902FD4 VA: 0x1906FD4 Slot: 53
	public override bool CheckHitType(MobPatternBase pattern) { }

	// RVA: 0x1906FDC Offset: 0x1902FDC VA: 0x1906FDC Slot: 54
	public override void UpdateStatus(PlayerStatusData status) { }

	// RVA: 0x19070C8 Offset: 0x19030C8 VA: 0x19070C8 Slot: 58
	public void OnOperation(PacketBase opeation) { }

	// RVA: 0x19070CC Offset: 0x19030CC VA: 0x19070CC Slot: 59
	public void OnEvent(PacketBase events) { }

	// RVA: 0x19070D0 Offset: 0x19030D0 VA: 0x19070D0 Slot: 60
	public void OnActionEvent(ArchetypeActionEvent action) { }

	// RVA: 0x19070D4 Offset: 0x19030D4 VA: 0x19070D4
	public void .ctor() { }
}
