// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class ScoreAttackMobActionManager : EnemyMobActionManagerBase, IRoomEndMobActionManager // TypeDefIndex: 1129
{
	// Fields
	protected IMobStatusCalculator battleStatus; // 0x158
	private bool isRoomEnd; // 0x160

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1F4ED6C Offset: 0x1F4AD6C VA: 0x1F4ED6C Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F4ED74 Offset: 0x1F4AD74 VA: 0x1F4ED74 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F4ED7C Offset: 0x1F4AD7C VA: 0x1F4ED7C Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1F4EFA4 Offset: 0x1F4AFA4 VA: 0x1F4EFA4 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F4F048 Offset: 0x1F4B048 VA: 0x1F4F048 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F4F1A4 Offset: 0x1F4B1A4 VA: 0x1F4F1A4 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F4F8F0 Offset: 0x1F4B8F0 VA: 0x1F4F8F0
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F4F974 Offset: 0x1F4B974 VA: 0x1F4F974 Slot: 95
	public void ActionEnd() { }

	// RVA: 0x1F4FA78 Offset: 0x1F4BA78 VA: 0x1F4FA78
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F4FA80 Offset: 0x1F4BA80 VA: 0x1F4FA80
	private void <AddAbnormalState>b__10_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F4FAD0 Offset: 0x1F4BAD0 VA: 0x1F4FAD0
	private void <AddAbnormalState>b__10_1(AbnormalData data) { }
}
