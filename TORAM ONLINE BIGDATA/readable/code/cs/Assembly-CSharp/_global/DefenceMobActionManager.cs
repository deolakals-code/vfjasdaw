// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class DefenceMobActionManager : DefenceMobActionManagerBase // TypeDefIndex: 867
{
	// Fields
	protected DefenceMobBattleStatus battleStatus; // 0x180
	protected bool bossFlag; // 0x188
	private bool isAroundCrystal; // 0x189
	private float updateTime; // 0x18C
	private int mobLevel; // 0x190

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1EE2838 Offset: 0x1EDE838 VA: 0x1EE2838 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EE2840 Offset: 0x1EDE840 VA: 0x1EE2840 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EE2848 Offset: 0x1EDE848 VA: 0x1EE2848 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1EE28EC Offset: 0x1EDE8EC VA: 0x1EE28EC Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EE2A68 Offset: 0x1EDEA68 VA: 0x1EE2A68 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1EE3114 Offset: 0x1EDF114 VA: 0x1EE3114
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1EE31D8 Offset: 0x1EDF1D8 VA: 0x1EE31D8 Slot: 79
	public override void UpdateHp(int hp) { }

	// RVA: 0x1EE3228 Offset: 0x1EDF228 VA: 0x1EE3228 Slot: 73
	protected override void Update() { }

	// RVA: 0x1EE3828 Offset: 0x1EDF828 VA: 0x1EE3828 Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1EE3CF0 Offset: 0x1EDFCF0 VA: 0x1EE3CF0 Slot: 107
	public override void ChangeDefenceAI() { }

	// RVA: 0x1EE42A8 Offset: 0x1EE02A8 VA: 0x1EE42A8 Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1EE4450 Offset: 0x1EE0450 VA: 0x1EE4450 Slot: 99
	public override void ReceiveMove(Vector3 pos, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1EE407C Offset: 0x1EE007C VA: 0x1EE407C
	private void MoveAroundCrystal(float time, bool moveSkip, Action callBack) { }

	// RVA: 0x1EE48DC Offset: 0x1EE08DC VA: 0x1EE48DC Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1EE4ABC Offset: 0x1EE0ABC VA: 0x1EE4ABC Slot: 97
	public override void ChangeTargetObject(int crystalId) { }

	// RVA: 0x1EE4840 Offset: 0x1EE0840 VA: 0x1EE4840
	private bool IsDistanceApart(Vector3 p1, Vector3 p2, float distance) { }

	// RVA: 0x1EE4BE8 Offset: 0x1EE0BE8 VA: 0x1EE4BE8 Slot: 89
	public override bool MobToEnemy() { }

	// RVA: 0x1EE4EBC Offset: 0x1EE0EBC VA: 0x1EE4EBC Slot: 108
	public override void SetMobLevel(int level) { }

	// RVA: 0x1EE4EC4 Offset: 0x1EE0EC4 VA: 0x1EE4EC4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1EE4ED4 Offset: 0x1EE0ED4 VA: 0x1EE4ED4
	private void <AddAbnormalState>b__12_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1EE4F30 Offset: 0x1EE0F30 VA: 0x1EE4F30
	private void <AddAbnormalState>b__12_1(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1EE4F8C Offset: 0x1EE0F8C VA: 0x1EE4F8C
	private int <ChangeBattleAI>b__18_0(int guard) { }

	[CompilerGenerated]
	// RVA: 0x1EE4FB8 Offset: 0x1EE0FB8 VA: 0x1EE4FB8
	private void <ReceiveMove>b__19_0() { }
}
