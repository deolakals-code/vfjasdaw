// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameSceneGetEventReconnectionData : IReconnectionSubData // TypeDefIndex: 4864
{
	// Fields
	private GameEventType gameEventType; // 0x10
	private Dictionary<byte, object> data; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EBC3C Offset: 0x25E7C3C VA: 0x25EBC3C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EBC44 Offset: 0x25E7C44 VA: 0x25EBC44 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EBC4C Offset: 0x25E7C4C VA: 0x25EBC4C
	public void .ctor(GameEventType gameEventType, Dictionary<byte, object> data) { }

	// RVA: 0x25EBC84 Offset: 0x25E7C84 VA: 0x25EBC84 Slot: 6
	public void Reconnection(Game engine) { }
}
