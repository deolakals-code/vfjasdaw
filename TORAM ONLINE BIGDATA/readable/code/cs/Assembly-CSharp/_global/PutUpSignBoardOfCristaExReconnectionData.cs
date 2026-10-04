// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class PutUpSignBoardOfCristaExReconnectionData : IReconnectionSubData // TypeDefIndex: 5095
{
	// Fields
	private ItemSelectData data; // 0x10
	private int cost; // 0x18
	private int slotNo; // 0x1C

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F0390 Offset: 0x25EC390 VA: 0x25F0390 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F0398 Offset: 0x25EC398 VA: 0x25F0398 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F03A0 Offset: 0x25EC3A0 VA: 0x25F03A0
	public void .ctor(ItemSelectData data, int cost, int slotNo) { }

	// RVA: 0x25F03E8 Offset: 0x25EC3E8 VA: 0x25F03E8 Slot: 6
	public void Reconnection(Game engine) { }
}
