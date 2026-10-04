// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IAICentral // TypeDefIndex: 608
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<string> GetParam();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IStateData SetStateData(AIStateType type);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IStateData ForcingStateChange(AIStateType type);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Stop();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AIStart();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Init(IStateData defaultTransition, Func<AIStateType, IStateData> factory);
}
