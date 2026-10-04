// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class PatyOperationReconectionBase : IReconnectionSubData // TypeDefIndex: 5086
{
	// Properties
	public byte Code { get; }
	public abstract byte SubCode { get; }

	// Methods

	// RVA: 0x25F018C Offset: 0x25EC18C VA: 0x25F018C Slot: 4
	public byte get_Code() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract byte get_SubCode();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Reconnection(Game engine);

	// RVA: 0x25F0110 Offset: 0x25EC110 VA: 0x25F0110
	protected void .ctor() { }
}
