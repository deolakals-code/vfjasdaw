// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SortToLowHate : IAITargetSortOrder // TypeDefIndex: 658
{
	// Fields
	private EnemyMobActionManagerBase mainTarget; // 0x10
	private PlayerDataManager playerDataManager; // 0x18
	private PartyMemberData[] partyMemberDatas; // 0x20

	// Properties
	public TargetOrderType OrderType { get; }
	public GameObject Target { get; }

	// Methods

	// RVA: 0x19E8704 Offset: 0x19E4704 VA: 0x19E8704
	public TargetOrderType get_OrderType() { }

	// RVA: 0x19E870C Offset: 0x19E470C VA: 0x19E870C Slot: 4
	public GameObject get_Target() { }

	// RVA: 0x19DF810 Offset: 0x19DB810 VA: 0x19DF810
	public void .ctor(PlayerDataManager playerDataManager, PartyMemberData[] partyMemberData) { }

	// RVA: 0x19E87C0 Offset: 0x19E47C0 VA: 0x19E87C0 Slot: 5
	public void SortOrder(EnemyMobActionManagerBase[] materialData) { }
}
