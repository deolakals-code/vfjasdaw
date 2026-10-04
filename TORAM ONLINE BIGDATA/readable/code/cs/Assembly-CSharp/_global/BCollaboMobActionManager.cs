// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class BCollaboMobActionManager : EnemyMobActionManagerBase, IMobLevelFluctuation, IRoomEndMobActionManager // TypeDefIndex: 845
{
	// Fields
	private bool isBoss; // 0x152
	private BCollaboMobBattleStatus battleStatus; // 0x158
	private int mobLevel; // 0x160
	private bool isRoomEnd; // 0x164

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1EC8F24 Offset: 0x1EC4F24 VA: 0x1EC8F24 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EC8F2C Offset: 0x1EC4F2C VA: 0x1EC8F2C Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EC5A5C Offset: 0x1EC1A5C VA: 0x1EC5A5C Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1EC5C80 Offset: 0x1EC1C80 VA: 0x1EC5C80 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1EC5D04 Offset: 0x1EC1D04 VA: 0x1EC5D04 Slot: 73
	protected override void Update() { }

	// RVA: 0x1EC8F50 Offset: 0x1EC4F50 VA: 0x1EC8F50 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EC9080 Offset: 0x1EC5080 VA: 0x1EC9080 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1EC9A78 Offset: 0x1EC5A78 VA: 0x1EC9A78 Slot: 97
	protected virtual void EndAbnormalFixAutoLookTarget(AbnormalData abnormalData) { }

	// RVA: 0x1EC9AFC Offset: 0x1EC5AFC VA: 0x1EC9AFC Slot: 95
	public void SetMobLevel(int level) { }

	// RVA: 0x1EC9B04 Offset: 0x1EC5B04 VA: 0x1EC9B04 Slot: 96
	public void ActionEnd() { }

	// RVA: 0x1EC846C Offset: 0x1EC446C VA: 0x1EC846C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1EC9C08 Offset: 0x1EC5C08 VA: 0x1EC9C08
	private void <AddAbnormalState>b__13_1(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1EC9C64 Offset: 0x1EC5C64 VA: 0x1EC9C64
	private void <AddAbnormalState>b__13_0(AbnormalData data) { }
}
