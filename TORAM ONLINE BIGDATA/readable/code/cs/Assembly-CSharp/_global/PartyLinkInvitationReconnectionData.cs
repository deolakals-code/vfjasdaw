// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyLinkInvitationReconnectionData : IReconnectionSubData // TypeDefIndex: 5088
{
	// Fields
	private int targetId; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F01B0 Offset: 0x25EC1B0 VA: 0x25F01B0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F01B8 Offset: 0x25EC1B8 VA: 0x25F01B8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F01C0 Offset: 0x25EC1C0 VA: 0x25F01C0
	public void .ctor(int targetId) { }

	// RVA: 0x25F01E8 Offset: 0x25EC1E8 VA: 0x25F01E8 Slot: 6
	public void Reconnection(Game engine) { }
}
