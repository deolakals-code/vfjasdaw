// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyInvitationReconnectionData : IReconnectionData // TypeDefIndex: 5007
{
	// Fields
	private byte targetType; // 0x10
	private int targetId; // 0x14
	private string message; // 0x18

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE7A4 Offset: 0x25EA7A4 VA: 0x25EE7A4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE7AC Offset: 0x25EA7AC VA: 0x25EE7AC
	public void .ctor(byte targetType, int targetId, string message) { }

	// RVA: 0x25EE7F4 Offset: 0x25EA7F4 VA: 0x25EE7F4 Slot: 5
	public void Reconnection(Game engine) { }
}
