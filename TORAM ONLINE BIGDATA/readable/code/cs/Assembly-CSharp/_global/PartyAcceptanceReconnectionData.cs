// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyAcceptanceReconnectionData : IReconnectionData // TypeDefIndex: 5011
{
	// Fields
	private int senderId; // 0x10
	private int partyId; // 0x14

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE8C4 Offset: 0x25EA8C4 VA: 0x25EE8C4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE8CC Offset: 0x25EA8CC VA: 0x25EE8CC
	public void .ctor(int senderId, int partyId) { }

	// RVA: 0x25EE8F8 Offset: 0x25EA8F8 VA: 0x25EE8F8 Slot: 5
	public void Reconnection(Game engine) { }
}
