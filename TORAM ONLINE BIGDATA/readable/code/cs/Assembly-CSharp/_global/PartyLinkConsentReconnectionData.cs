// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyLinkConsentReconnectionData : IReconnectionSubData // TypeDefIndex: 5091
{
	// Fields
	private PartyLinkInviteData invite; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F0274 Offset: 0x25EC274 VA: 0x25F0274 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F027C Offset: 0x25EC27C VA: 0x25F027C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F0284 Offset: 0x25EC284 VA: 0x25F0284
	public void .ctor(PartyLinkInviteData invite) { }

	// RVA: 0x25F02B4 Offset: 0x25EC2B4 VA: 0x25F02B4 Slot: 6
	public void Reconnection(Game engine) { }
}
