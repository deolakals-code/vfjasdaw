// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SortToPlayerTarget : IAITargetSortOrder // TypeDefIndex: 660
{
	// Fields
	private GameObject target; // 0x10
	private PlayerDataManager playerDataManager; // 0x18

	// Properties
	public TargetOrderType OrderType { get; }
	public GameObject Target { get; }

	// Methods

	// RVA: 0x19E9164 Offset: 0x19E5164 VA: 0x19E9164
	public TargetOrderType get_OrderType() { }

	// RVA: 0x19E916C Offset: 0x19E516C VA: 0x19E916C Slot: 4
	public GameObject get_Target() { }

	// RVA: 0x19DF7B0 Offset: 0x19DB7B0 VA: 0x19DF7B0
	public void .ctor(PlayerDataManager playerDataManager) { }

	// RVA: 0x19E9174 Offset: 0x19E5174 VA: 0x19E9174 Slot: 5
	public void SortOrder(EnemyMobActionManagerBase[] materialData) { }
}
