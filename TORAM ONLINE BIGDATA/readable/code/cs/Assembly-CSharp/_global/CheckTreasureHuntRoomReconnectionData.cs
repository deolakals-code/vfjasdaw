// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CheckTreasureHuntRoomReconnectionData : IReconnectionSubData // TypeDefIndex: 5006
{
	// Fields
	private int fieldId; // 0x10
	private byte roomId; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EE744 Offset: 0x25EA744 VA: 0x25EE744 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE74C Offset: 0x25EA74C VA: 0x25EE74C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EE754 Offset: 0x25EA754 VA: 0x25EE754
	public void .ctor(int fieldId, byte roomId) { }

	// RVA: 0x25EE78C Offset: 0x25EA78C VA: 0x25EE78C Slot: 6
	public void Reconnection(Game engine) { }
}
