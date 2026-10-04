// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameSceneGetEventValReconnectionData : IReconnectionSubData // TypeDefIndex: 4866
{
	// Fields
	private byte gameEventType; // 0x10
	private int version; // 0x14
	private byte flagId; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EBCFC Offset: 0x25E7CFC VA: 0x25EBCFC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EBD04 Offset: 0x25E7D04 VA: 0x25EBD04 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EBD0C Offset: 0x25E7D0C VA: 0x25EBD0C
	public void .ctor(byte gameEventType, int version, byte flagId) { }

	// RVA: 0x25EBD4C Offset: 0x25E7D4C VA: 0x25EBD4C Slot: 6
	public void Reconnection(Game engine) { }
}
