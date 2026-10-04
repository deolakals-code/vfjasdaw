// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyMemberInvitedCancelReconnectionData : IReconnectionData // TypeDefIndex: 5013
{
	// Fields
	private int targetId; // 0x10
	private string targetName; // 0x18

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE954 Offset: 0x25EA954 VA: 0x25EE954 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE95C Offset: 0x25EA95C VA: 0x25EE95C
	public void .ctor(int targetId, string targetName) { }

	// RVA: 0x25EE994 Offset: 0x25EA994 VA: 0x25EE994 Slot: 5
	public void Reconnection(Game engine) { }
}
