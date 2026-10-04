// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyInvitationCancelReconnectionData : IReconnectionData // TypeDefIndex: 5012
{
	// Fields
	private int senderId; // 0x10
	private int partyId; // 0x14

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE90C Offset: 0x25EA90C VA: 0x25EE90C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE914 Offset: 0x25EA914 VA: 0x25EE914
	public void .ctor(int senderId, int partyId) { }

	// RVA: 0x25EE940 Offset: 0x25EA940 VA: 0x25EE940 Slot: 5
	public void Reconnection(Game engine) { }
}
