// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IAvoidAction // TypeDefIndex: 336
{
	// Properties
	public abstract bool IsAvoid { get; }
	public abstract AvoidType AvoidType { get; }
	public abstract AvoidActionManager AvoidManager { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsAvoid();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AvoidType get_AvoidType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract AvoidActionManager get_AvoidManager();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void InitializeAvoid();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool CheckAvoid(MobActionManagerBase mobAction, MobAttackBase mobAttack);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AvoidEnd(bool forceEnd);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnAvoid(GameObject actor);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void DamagedAvoid(int damage);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ReceiveAvoid(int param);
}
