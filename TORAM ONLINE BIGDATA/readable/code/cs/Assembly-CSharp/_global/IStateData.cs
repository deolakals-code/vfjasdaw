// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IStateData : IDisposable // TypeDefIndex: 610
{
	// Properties
	public abstract IEnumerator State { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<string> GetParam();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerator get_State();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LateUpdate();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetCentral(IAICentral central);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ChackTransition(IAICentral central);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TurnEnd(IAICentral central);
}
