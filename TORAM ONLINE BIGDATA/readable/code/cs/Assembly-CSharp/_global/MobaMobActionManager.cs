// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class MobaMobActionManager : MobaMobActionManagerBase // TypeDefIndex: 908
{
	// Fields
	private MobaMobBattleStatus battleStatus; // 0x158

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }

	// Methods

	// RVA: 0x1F01378 Offset: 0x1EFD378 VA: 0x1F01378 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F01380 Offset: 0x1EFD380 VA: 0x1F01380 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F01394 Offset: 0x1EFD394 VA: 0x1F01394 Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1F01398 Offset: 0x1EFD398 VA: 0x1F01398 Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1F013E0 Offset: 0x1EFD3E0 VA: 0x1F013E0 Slot: 97
	public override void ChangeTargetObject(int targetId) { }

	// RVA: 0x1F013E4 Offset: 0x1EFD3E4 VA: 0x1F013E4 Slot: 102
	public override bool CheckAssistMove(GameObject target) { }

	// RVA: 0x1F013EC Offset: 0x1EFD3EC VA: 0x1F013EC Slot: 99
	public override void ReceiveMove(Vector3 pos, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1F0151C Offset: 0x1EFD51C VA: 0x1F0151C Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1F01520 Offset: 0x1EFD520 VA: 0x1F01520 Slot: 105
	public override void UnmanagedEnemey(GameObject actor) { }

	// RVA: 0x1F01654 Offset: 0x1EFD654 VA: 0x1F01654 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F017D8 Offset: 0x1EFD7D8 VA: 0x1F017D8 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F01850 Offset: 0x1EFD850 VA: 0x1F01850 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1F01854 Offset: 0x1EFD854 VA: 0x1F01854 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F01F08 Offset: 0x1EFDF08 VA: 0x1F01F08
	public void AbnormalSuction(Vector3 actorPos, float time) { }

	// RVA: 0x1F01FD4 Offset: 0x1EFDFD4 VA: 0x1F01FD4
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F02058 Offset: 0x1EFE058 VA: 0x1F02058
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F02060 Offset: 0x1EFE060 VA: 0x1F02060
	private void <AddAbnormalState>b__15_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F020B0 Offset: 0x1EFE0B0 VA: 0x1F020B0
	private void <AddAbnormalState>b__15_1(AbnormalData abnormalData) { }
}
