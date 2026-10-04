// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbItemUseEnchantReconnectionData : IReconnectionSubData // TypeDefIndex: 4948
{
	// Fields
	private int useItemId; // 0x10
	private int targetItemUuid; // 0x14
	private EquipType type; // 0x18
	private byte index; // 0x1C

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED660 Offset: 0x25E9660 VA: 0x25ED660 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED668 Offset: 0x25E9668 VA: 0x25ED668 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED670 Offset: 0x25E9670 VA: 0x25ED670
	public void .ctor(int useItemId, int targetItemUuid, EquipType type, byte index) { }

	// RVA: 0x25ED6B4 Offset: 0x25E96B4 VA: 0x25ED6B4 Slot: 6
	public void Reconnection(Game engine) { }
}
