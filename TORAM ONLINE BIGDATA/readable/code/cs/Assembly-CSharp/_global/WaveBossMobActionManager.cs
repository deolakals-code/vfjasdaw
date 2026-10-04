// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobAnimation))]
[RequireComponent(typeof(FadeAnimationManager))]
public class WaveBossMobActionManager : WaveMobActionManagerBase // TypeDefIndex: 1157
{
	// Fields
	protected WaveBossMobBattleStatus battleStatus; // 0x170
	private Dictionary<byte, MobPartsStatus> mobPartsStatus; // 0x178
	private bool isAroundCrystal; // 0x180
	private float updateTime; // 0x184
	private Vector3[] targetsPos; // 0x188
	private float partAttackTime; // 0x190

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1F6C234 Offset: 0x1F68234 VA: 0x1F6C234 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F6C23C Offset: 0x1F6823C VA: 0x1F6C23C Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F6C244 Offset: 0x1F68244 VA: 0x1F6C244 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1F6C2E8 Offset: 0x1F682E8 VA: 0x1F6C2E8 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F6C2F0 Offset: 0x1F682F0 VA: 0x1F6C2F0 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F6C570 Offset: 0x1F68570 VA: 0x1F6C570 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F6C750 Offset: 0x1F68750 VA: 0x1F6C750 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F6D208 Offset: 0x1F69208 VA: 0x1F6D208
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F6D28C Offset: 0x1F6928C VA: 0x1F6D28C Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1F6D368 Offset: 0x1F69368 VA: 0x1F6D368 Slot: 104
	public override void ActionEnd() { }

	// RVA: 0x1F6D47C Offset: 0x1F6947C VA: 0x1F6D47C Slot: 99
	public override void ReceiveMove(Vector3 pos, float updateTime, bool isReconnect) { }

	// RVA: 0x1F6DCC8 Offset: 0x1F69CC8 VA: 0x1F6DCC8 Slot: 89
	public override bool MobToEnemy() { }

	// RVA: 0x1F6DE8C Offset: 0x1F69E8C VA: 0x1F6DE8C Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1F6E0EC Offset: 0x1F6A0EC VA: 0x1F6E0EC Slot: 97
	public override void ChangeTargetObject(int targetId) { }

	// RVA: 0x1F6E0F0 Offset: 0x1F6A0F0 VA: 0x1F6E0F0 Slot: 105
	public override void UnmanagedEnemey(GameObject actor) { }

	// RVA: 0x1F6E2C0 Offset: 0x1F6A2C0 VA: 0x1F6E2C0 Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1F6E398 Offset: 0x1F6A398 VA: 0x1F6E398 Slot: 107
	public override void TargetAroundWarp() { }

	// RVA: 0x1F6DC28 Offset: 0x1F69C28 VA: 0x1F6DC28
	private float Distance(Vector3 v1, Vector3 v2) { }

	// RVA: 0x1F6E9BC Offset: 0x1F6A9BC VA: 0x1F6E9BC Slot: 106
	public override void ChangeTargetAttackAI() { }

	// RVA: 0x1F6DAE0 Offset: 0x1F69AE0 VA: 0x1F6DAE0
	private void GetTargetsPos() { }

	// RVA: 0x1F6EA60 Offset: 0x1F6AA60 VA: 0x1F6EA60
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F6EAE8 Offset: 0x1F6AAE8 VA: 0x1F6EAE8
	private void <AddAbnormalState>b__15_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F6EB38 Offset: 0x1F6AB38 VA: 0x1F6EB38
	private void <AddAbnormalState>b__15_1(AbnormalData data) { }
}
