// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameSceneSetEventReconnectionData : IReconnectionSubData // TypeDefIndex: 4865
{
	// Fields
	private GameEventType gameEventType; // 0x10
	private Dictionary<byte, object> data; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EBC9C Offset: 0x25E7C9C VA: 0x25EBC9C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EBCA4 Offset: 0x25E7CA4 VA: 0x25EBCA4 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EBCAC Offset: 0x25E7CAC VA: 0x25EBCAC
	public void .ctor(GameEventType gameEventType, Dictionary<byte, object> data) { }

	// RVA: 0x25EBCE4 Offset: 0x25E7CE4 VA: 0x25EBCE4 Slot: 6
	public void Reconnection(Game engine) { }
}
