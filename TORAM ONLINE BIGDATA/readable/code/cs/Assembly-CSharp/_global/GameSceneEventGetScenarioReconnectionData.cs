// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameSceneEventGetScenarioReconnectionData : IReconnectionSubData // TypeDefIndex: 4868
{
	// Fields
	private byte gameEventType; // 0x10
	private int version; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EBDE0 Offset: 0x25E7DE0 VA: 0x25EBDE0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EBDE8 Offset: 0x25E7DE8 VA: 0x25EBDE8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EBDF0 Offset: 0x25E7DF0 VA: 0x25EBDF0
	public void .ctor(byte gameEventType, int version) { }

	// RVA: 0x25EBE20 Offset: 0x25E7E20 VA: 0x25EBE20 Slot: 6
	public void Reconnection(Game engine) { }
}
