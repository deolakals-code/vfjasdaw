// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IPlayerControl // TypeDefIndex: 1386
{
	// Properties
	public abstract bool IsInputLock { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsInputLock();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract PlayerActionReturnType OnActionButton(PlayerActionType type, int id);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnLeaveField();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnEnterField();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ClearTarget();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TargetingAction();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void TargetEventArea(GameObject target);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void TargetSideMob(bool right);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void TargetMob(GameObject target);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void TargetPlayer(GameObject target);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void ChangeNearTarget();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ChangeFarTarget();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool ExistsCurrentCobmoSkill(SkillId skillId);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool IsCurrentComboLastSkill(SkillId skillId);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void AttackParts(EnemyMobActionManagerBase mobAction, IBossParts parts, byte id);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnMenuOpen();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnMenuClose();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetDashKey(bool bPush);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SnowballFightAction(int id);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract PlayerActionReturnType HalloweenAction(PlayerActionType type, int id);
}
