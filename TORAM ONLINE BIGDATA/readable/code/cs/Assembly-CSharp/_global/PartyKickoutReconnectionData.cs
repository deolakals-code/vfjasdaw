// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyKickoutReconnectionData : IReconnectionData // TypeDefIndex: 5008
{
	// Fields
	private byte targetType; // 0x10
	private int targetId; // 0x14

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE80C Offset: 0x25EA80C VA: 0x25EE80C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE814 Offset: 0x25EA814 VA: 0x25EE814
	public void .ctor(byte targetType, int targetId) { }

	// RVA: 0x25EE844 Offset: 0x25EA844 VA: 0x25EE844 Slot: 5
	public void Reconnection(Game engine) { }
}
