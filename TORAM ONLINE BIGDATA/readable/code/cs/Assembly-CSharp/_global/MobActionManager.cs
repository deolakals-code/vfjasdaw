// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class MobActionManager : EnemyMobActionManagerBase // TypeDefIndex: 914
{
	// Fields
	protected IMobStatusCalculator battleStatus; // 0x158
	protected bool bossFlag; // 0x160

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1F037D0 Offset: 0x1EFF7D0 VA: 0x1F037D0 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F037D8 Offset: 0x1EFF7D8 VA: 0x1F037D8 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F037E0 Offset: 0x1EFF7E0 VA: 0x1F037E0 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1F03A08 Offset: 0x1EFFA08 VA: 0x1F03A08 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F03BF4 Offset: 0x1EFFBF4 VA: 0x1F03BF4 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F04348 Offset: 0x1F00348 VA: 0x1F04348
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F043CC Offset: 0x1F003CC VA: 0x1F043CC Slot: 79
	public override void UpdateHp(int hp) { }

	// RVA: 0x1F044E4 Offset: 0x1F004E4 VA: 0x1F044E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F044EC Offset: 0x1F004EC VA: 0x1F044EC
	private void <AddAbnormalState>b__9_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F0453C Offset: 0x1F0053C VA: 0x1F0453C
	private void <AddAbnormalState>b__9_1(AbnormalData data) { }
}
