// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MercenaryOperationReconectionBase : IReconnectionSubData // TypeDefIndex: 4931
{
	// Properties
	public byte Code { get; }
	public abstract byte SubCode { get; }

	// Methods

	// RVA: 0x25ED280 Offset: 0x25E9280 VA: 0x25ED280 Slot: 4
	public byte get_Code() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract byte get_SubCode();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Reconnection(Game engine);

	// RVA: 0x25ED25C Offset: 0x25E925C VA: 0x25ED25C
	protected void .ctor() { }
}
