// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IActionReconnectionData // TypeDefIndex: 4824
{
	// Properties
	public abstract ActionCode Type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ActionCode get_Type();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Invoke(Game engine);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Cancel();
}
