// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CheckWaveRaidRoomReconnectionData : IReconnectionSubData // TypeDefIndex: 5058
{
	// Fields
	private int fieldId; // 0x10
	private byte roomId; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EF884 Offset: 0x25EB884 VA: 0x25EF884 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF88C Offset: 0x25EB88C VA: 0x25EF88C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EF894 Offset: 0x25EB894 VA: 0x25EF894
	public void .ctor(int fieldId, byte roomId) { }

	// RVA: 0x25EF8CC Offset: 0x25EB8CC VA: 0x25EF8CC Slot: 6
	public void Reconnection(Game engine) { }
}
