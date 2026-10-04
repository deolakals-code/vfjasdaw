// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IPetBreedData // TypeDefIndex: 1289
{
	// Properties
	public abstract int Affinity { get; }
	public abstract int Stamina { get; }
	public abstract PetHungerType Hunger { get; }
	public abstract bool IsGroggy { get; }
	public abstract byte FeedEffect { get; }
	public abstract short Train { get; }
	public abstract bool NotLimitUp { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Affinity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Stamina();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PetHungerType get_Hunger();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsGroggy();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_FeedEffect();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract short get_Train();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_NotLimitUp();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetServerData(PetBreedStatusData data);
}
