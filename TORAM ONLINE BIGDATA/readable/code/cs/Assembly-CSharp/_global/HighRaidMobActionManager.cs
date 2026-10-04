// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobAnimation))]
[RequireComponent(typeof(FadeAnimationManager))]
public class HighRaidMobActionManager : EnemyMobActionManagerBase, IMobLevelFluctuation // TypeDefIndex: 892
{
	// Fields
	protected IMobStatusCalculator battleStatus; // 0x158
	private int mobLevel; // 0x160

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1EFD59C Offset: 0x1EF959C VA: 0x1EFD59C Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EFD5A4 Offset: 0x1EF95A4 VA: 0x1EFD5A4 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EFD5AC Offset: 0x1EF95AC VA: 0x1EFD5AC Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1EFD7D4 Offset: 0x1EF97D4 VA: 0x1EFD7D4 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EFD94C Offset: 0x1EF994C VA: 0x1EFD94C Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1EFDFEC Offset: 0x1EF9FEC VA: 0x1EFDFEC
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1EFE070 Offset: 0x1EFA070 VA: 0x1EFE070 Slot: 95
	public void SetMobLevel(int level) { }

	// RVA: 0x1EFE078 Offset: 0x1EFA078 VA: 0x1EFE078
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1EFE080 Offset: 0x1EFA080 VA: 0x1EFE080
	private void <AddAbnormalState>b__9_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1EFE0D0 Offset: 0x1EFA0D0 VA: 0x1EFE0D0
	private void <AddAbnormalState>b__9_1(AbnormalData data) { }
}
