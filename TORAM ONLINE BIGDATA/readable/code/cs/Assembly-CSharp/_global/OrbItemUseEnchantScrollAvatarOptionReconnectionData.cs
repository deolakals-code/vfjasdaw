// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbItemUseEnchantScrollAvatarOptionReconnectionData : IReconnectionSubData // TypeDefIndex: 4947
{
	// Fields
	private int useItemId; // 0x10
	private int targetItemUuid; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED610 Offset: 0x25E9610 VA: 0x25ED610 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED618 Offset: 0x25E9618 VA: 0x25ED618 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED620 Offset: 0x25E9620 VA: 0x25ED620
	public void .ctor(int useItemId, int targetItemUuid) { }

	// RVA: 0x25ED64C Offset: 0x25E964C VA: 0x25ED64C Slot: 6
	public void Reconnection(Game engine) { }
}
