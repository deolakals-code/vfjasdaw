// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IBossParts // TypeDefIndex: 898
{
	// Properties
	public abstract Dictionary<byte, MobPartsStatus> UsePartsList { get; }
	public abstract float PartsAttackTime { get; }
	public abstract bool EnablePartsAttack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Dictionary<byte, MobPartsStatus> get_UsePartsList();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_PartsAttackTime();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_EnablePartsAttack();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetPartsMaster(byte id, MobStatusMaster master, int hp);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MobPartsStatus GetPartsStatus(byte id);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void UpdatePartsHp(byte id, int hp);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetPartAttackTime(float time);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ClearParts();
}
