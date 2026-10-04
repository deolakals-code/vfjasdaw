// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyLinkInvitateCancelReconnectionData : IReconnectionSubData // TypeDefIndex: 5089
{
	// Fields
	private PartyLinkInviteData invite; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F01FC Offset: 0x25EC1FC VA: 0x25F01FC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F0204 Offset: 0x25EC204 VA: 0x25F0204 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F020C Offset: 0x25EC20C VA: 0x25F020C
	public void .ctor(PartyLinkInviteData invite) { }

	// RVA: 0x25F023C Offset: 0x25EC23C VA: 0x25F023C Slot: 6
	public void Reconnection(Game engine) { }
}
