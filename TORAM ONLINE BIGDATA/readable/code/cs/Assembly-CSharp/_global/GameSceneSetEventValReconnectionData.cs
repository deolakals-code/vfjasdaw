// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameSceneSetEventValReconnectionData : IReconnectionSubData // TypeDefIndex: 4867
{
	// Fields
	private byte gameEventType; // 0x10
	private int version; // 0x14
	private byte flagId; // 0x18
	private byte value; // 0x19

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EBD68 Offset: 0x25E7D68 VA: 0x25EBD68 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EBD70 Offset: 0x25E7D70 VA: 0x25EBD70 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EBD78 Offset: 0x25E7D78 VA: 0x25EBD78
	public void .ctor(byte gameEventType, int version, byte flagId, byte value) { }

	// RVA: 0x25EBDC0 Offset: 0x25E7DC0 VA: 0x25EBDC0 Slot: 6
	public void Reconnection(Game engine) { }
}
