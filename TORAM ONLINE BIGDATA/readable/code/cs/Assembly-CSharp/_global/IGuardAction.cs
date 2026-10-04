// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IGuardAction // TypeDefIndex: 337
{
	// Properties
	public abstract bool IsGuard { get; }
	public abstract GuardType GuardType { get; }
	public abstract GuardActionManager GuardManager { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsGuard();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract GuardType get_GuardType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract GuardActionManager get_GuardManager();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void InitializeGuard();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool CheckGuard(MobActionManagerBase mobAction, MobAttackBase action, int damage, out SkillHitReactionType guardType, out bool justGuard);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GuardEnd(bool forceEnd);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnGuard(GameObject actor, SkillDamageData damageData);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int CalcGuard(int damage, out int guardPower);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void GuardEndNextAttackDelay();
}
