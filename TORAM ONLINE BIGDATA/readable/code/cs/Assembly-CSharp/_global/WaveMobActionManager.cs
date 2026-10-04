// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class WaveMobActionManager : WaveMobActionManagerBase // TypeDefIndex: 1160
{
	// Fields
	protected WaveMobBattleStatus battleStatus; // 0x170
	private bool isAroundCrystal; // 0x178
	private float updateTime; // 0x17C
	private Vector3[] targetsPos; // 0x180

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1F701C4 Offset: 0x1F6C1C4 VA: 0x1F701C4 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F701CC Offset: 0x1F6C1CC VA: 0x1F701CC Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F701D4 Offset: 0x1F6C1D4 VA: 0x1F701D4 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1F70278 Offset: 0x1F6C278 VA: 0x1F70278 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F70280 Offset: 0x1F6C280 VA: 0x1F70280 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F7037C Offset: 0x1F6C37C VA: 0x1F7037C Slot: 73
	protected override void Update() { }

	// RVA: 0x1F70528 Offset: 0x1F6C528 VA: 0x1F70528 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F70EF8 Offset: 0x1F6CEF8 VA: 0x1F70EF8
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F70F7C Offset: 0x1F6CF7C VA: 0x1F70F7C Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1F71058 Offset: 0x1F6D058 VA: 0x1F71058 Slot: 104
	public override void ActionEnd() { }

	// RVA: 0x1F7116C Offset: 0x1F6D16C VA: 0x1F7116C Slot: 99
	public override void ReceiveMove(Vector3 pos, float updateTime, bool isReconnect) { }

	// RVA: 0x1F719A0 Offset: 0x1F6D9A0 VA: 0x1F719A0 Slot: 89
	public override bool MobToEnemy() { }

	// RVA: 0x1F71B64 Offset: 0x1F6DB64 VA: 0x1F71B64 Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1F71DC4 Offset: 0x1F6DDC4 VA: 0x1F71DC4 Slot: 97
	public override void ChangeTargetObject(int targetId) { }

	// RVA: 0x1F71DC8 Offset: 0x1F6DDC8 VA: 0x1F71DC8 Slot: 105
	public override void UnmanagedEnemey(GameObject actor) { }

	// RVA: 0x1F71F98 Offset: 0x1F6DF98 VA: 0x1F71F98 Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1F72070 Offset: 0x1F6E070 VA: 0x1F72070 Slot: 107
	public override void TargetAroundWarp() { }

	// RVA: 0x1F71900 Offset: 0x1F6D900 VA: 0x1F71900
	private float Distance(Vector3 v1, Vector3 v2) { }

	// RVA: 0x1F72694 Offset: 0x1F6E694 VA: 0x1F72694 Slot: 106
	public override void ChangeTargetAttackAI() { }

	// RVA: 0x1F717B8 Offset: 0x1F6D7B8 VA: 0x1F717B8
	private void GetTargetsPos() { }

	// RVA: 0x1F72738 Offset: 0x1F6E738 VA: 0x1F72738
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F72748 Offset: 0x1F6E748 VA: 0x1F72748
	private void <AddAbnormalState>b__13_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F72798 Offset: 0x1F6E798 VA: 0x1F72798
	private void <AddAbnormalState>b__13_1(AbnormalData data) { }
}
