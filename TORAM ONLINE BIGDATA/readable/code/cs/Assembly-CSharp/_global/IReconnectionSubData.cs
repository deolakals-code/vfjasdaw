// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IReconnectionSubData // TypeDefIndex: 4916
{
	// Properties
	public abstract byte Code { get; }
	public abstract byte SubCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte get_Code();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte get_SubCode();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reconnection(Game engine);
}
