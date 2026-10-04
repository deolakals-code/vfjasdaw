// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class PutUpSignBoardOfSlotExReconnectionData : IReconnectionSubData // TypeDefIndex: 5094
{
	// Fields
	private ItemSelectData data; // 0x10
	private int cost; // 0x18
	private int requiredItemId; // 0x1C

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F0320 Offset: 0x25EC320 VA: 0x25F0320 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F0328 Offset: 0x25EC328 VA: 0x25F0328 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F0330 Offset: 0x25EC330 VA: 0x25F0330
	public void .ctor(ItemSelectData data, int cost, int requiredItemId) { }

	// RVA: 0x25F0378 Offset: 0x25EC378 VA: 0x25F0378 Slot: 6
	public void Reconnection(Game engine) { }
}
