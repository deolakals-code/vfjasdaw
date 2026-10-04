// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IBossPartsStatus // TypeDefIndex: 899
{
	// Properties
	public abstract Dictionary<int, MobPartsStatus> PartsStatus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Dictionary<int, MobPartsStatus> get_PartsStatus();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetPartsMaster(int id, MobPartsStatus parts);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ClearParts();
}
