// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class PutUpSignboardOfReinforceCristaAttachxReconnectionData : IReconnectionSubData // TypeDefIndex: 5100
{
	// Fields
	private ItemSelectData data; // 0x10
	private int cost; // 0x18
	private int slotNo; // 0x1C
	private ItemSelectData cristaData; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F0510 Offset: 0x25EC510 VA: 0x25F0510 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F0518 Offset: 0x25EC518 VA: 0x25F0518 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F0520 Offset: 0x25EC520 VA: 0x25F0520
	public void .ctor(ItemSelectData data, int cost, int slotNo, ItemSelectData cristaData) { }

	// RVA: 0x25F0578 Offset: 0x25EC578 VA: 0x25F0578 Slot: 6
	public void Reconnection(Game engine) { }
}
