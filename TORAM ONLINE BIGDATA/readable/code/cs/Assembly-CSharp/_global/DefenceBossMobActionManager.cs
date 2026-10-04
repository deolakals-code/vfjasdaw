// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class DefenceBossMobActionManager : DefenceMobActionManagerBase // TypeDefIndex: 864
{
	// Fields
	private Dictionary<byte, MobPartsStatus> mobPartsStatus; // 0x180
	protected DefenceBossBattleStatus battleStatus; // 0x188
	private int mobLevel; // 0x190

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1ED1438 Offset: 0x1ECD438 VA: 0x1ED1438 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1ED1440 Offset: 0x1ECD440 VA: 0x1ED1440 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1ED1448 Offset: 0x1ECD448 VA: 0x1ED1448 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1ED14E4 Offset: 0x1ECD4E4 VA: 0x1ED14E4 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1ED17E0 Offset: 0x1ECD7E0 VA: 0x1ED17E0
	public void SetPartsMaster(byte id, MobStatusMaster master, int hp) { }

	// RVA: 0x1ED1908 Offset: 0x1ECD908 VA: 0x1ED1908
	public MobPartsStatus GetPartsStatus(byte id) { }

	// RVA: 0x1ED199C Offset: 0x1ECD99C VA: 0x1ED199C
	public void ResetPartsHp(byte id) { }

	// RVA: 0x1ED1A38 Offset: 0x1ECDA38 VA: 0x1ED1A38
	public void UpdatePartsHp(byte id, int hp) { }

	// RVA: 0x1ED1AE8 Offset: 0x1ECDAE8 VA: 0x1ED1AE8 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1ED2200 Offset: 0x1ECE200 VA: 0x1ED2200
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1ED2284 Offset: 0x1ECE284 VA: 0x1ED2284
	private void Start() { }

	// RVA: 0x1ED234C Offset: 0x1ECE34C VA: 0x1ED234C Slot: 73
	protected override void Update() { }

	// RVA: 0x1ED258C Offset: 0x1ECE58C VA: 0x1ED258C Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1ED26C8 Offset: 0x1ECE6C8 VA: 0x1ED26C8 Slot: 99
	public override void ReceiveMove(Vector3 pos, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1ED2A4C Offset: 0x1ECEA4C VA: 0x1ED2A4C Slot: 107
	public override void ChangeDefenceAI() { }

	// RVA: 0x1ED2C30 Offset: 0x1ECEC30 VA: 0x1ED2C30 Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1ED2DD8 Offset: 0x1ECEDD8 VA: 0x1ED2DD8 Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1ED2FB8 Offset: 0x1ECEFB8 VA: 0x1ED2FB8 Slot: 97
	public override void ChangeTargetObject(int crystalId) { }

	// RVA: 0x1ED29B0 Offset: 0x1ECE9B0 VA: 0x1ED29B0
	private bool IsDistanceApart(Vector3 p1, Vector3 p2, float distance) { }

	// RVA: 0x1ED30DC Offset: 0x1ECF0DC VA: 0x1ED30DC Slot: 89
	public override bool MobToEnemy() { }

	// RVA: 0x1ED32F4 Offset: 0x1ECF2F4 VA: 0x1ED32F4 Slot: 108
	public override void SetMobLevel(int level) { }

	// RVA: 0x1ED32FC Offset: 0x1ECF2FC VA: 0x1ED32FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1ED3384 Offset: 0x1ECF384 VA: 0x1ED3384
	private void <AddAbnormalState>b__14_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1ED33D4 Offset: 0x1ECF3D4 VA: 0x1ED33D4
	private void <AddAbnormalState>b__14_1(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1ED3424 Offset: 0x1ECF424 VA: 0x1ED3424
	private int <ChangeBattleAI>b__21_0(int guard) { }
}
