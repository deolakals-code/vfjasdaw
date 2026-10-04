// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbItemUseEnchantScrollAvatarBottomReconnectionData : IReconnectionSubData // TypeDefIndex: 4946
{
	// Fields
	private int useItemId; // 0x10
	private int targetItemUuid; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED5C0 Offset: 0x25E95C0 VA: 0x25ED5C0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED5C8 Offset: 0x25E95C8 VA: 0x25ED5C8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED5D0 Offset: 0x25E95D0 VA: 0x25ED5D0
	public void .ctor(int useItemId, int targetItemUuid) { }

	// RVA: 0x25ED5FC Offset: 0x25E95FC VA: 0x25ED5FC Slot: 6
	public void Reconnection(Game engine) { }
}
