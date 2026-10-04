// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class ExecuteSignboardOfSlotExReconnectionData : IReconnectionSubData // TypeDefIndex: 5098
{
	// Fields
	private int targetId; // 0x10
	private int itemId; // 0x14
	private DateTime dateTime; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F0448 Offset: 0x25EC448 VA: 0x25F0448 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F0450 Offset: 0x25EC450 VA: 0x25F0450 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F0458 Offset: 0x25EC458 VA: 0x25F0458
	public void .ctor(int targetId, int itemId, DateTime dateTime) { }

	// RVA: 0x25F0494 Offset: 0x25EC494 VA: 0x25F0494 Slot: 6
	public void Reconnection(Game engine) { }
}
