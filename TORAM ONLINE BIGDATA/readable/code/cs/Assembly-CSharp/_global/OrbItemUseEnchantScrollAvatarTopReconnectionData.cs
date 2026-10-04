// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbItemUseEnchantScrollAvatarTopReconnectionData : IReconnectionSubData // TypeDefIndex: 4945
{
	// Fields
	private int useItemId; // 0x10
	private int targetItemUuid; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED570 Offset: 0x25E9570 VA: 0x25ED570 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED578 Offset: 0x25E9578 VA: 0x25ED578 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED580 Offset: 0x25E9580 VA: 0x25ED580
	public void .ctor(int useItemId, int targetItemUuid) { }

	// RVA: 0x25ED5AC Offset: 0x25E95AC VA: 0x25ED5AC Slot: 6
	public void Reconnection(Game engine) { }
}
