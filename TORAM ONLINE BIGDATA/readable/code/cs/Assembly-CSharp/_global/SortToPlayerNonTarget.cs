// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SortToPlayerNonTarget : IAITargetSortOrder // TypeDefIndex: 659
{
	// Fields
	private EnemyMobActionManagerBase mainTarget; // 0x10
	private PlayerDataManager playerDataManager; // 0x18

	// Properties
	public TargetOrderType OrderType { get; }
	public GameObject Target { get; }

	// Methods

	// RVA: 0x19E8D78 Offset: 0x19E4D78 VA: 0x19E8D78
	public TargetOrderType get_OrderType() { }

	// RVA: 0x19E8D80 Offset: 0x19E4D80 VA: 0x19E8D80 Slot: 4
	public GameObject get_Target() { }

	// RVA: 0x19DF7E0 Offset: 0x19DB7E0 VA: 0x19DF7E0
	public void .ctor(PlayerDataManager playerDataManager) { }

	// RVA: 0x19E8E34 Offset: 0x19E4E34 VA: 0x19E8E34 Slot: 5
	public void SortOrder(EnemyMobActionManagerBase[] materialData) { }
}
