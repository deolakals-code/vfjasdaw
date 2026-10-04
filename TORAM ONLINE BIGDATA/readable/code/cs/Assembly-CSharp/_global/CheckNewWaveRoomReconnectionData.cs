// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CheckNewWaveRoomReconnectionData : IReconnectionSubData // TypeDefIndex: 5059
{
	// Fields
	private int fieldId; // 0x10
	private byte roomId; // 0x14
	private bool isForcibly; // 0x15
	private bool isMatching; // 0x16

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EF8E4 Offset: 0x25EB8E4 VA: 0x25EF8E4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF8EC Offset: 0x25EB8EC VA: 0x25EF8EC Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EF8F4 Offset: 0x25EB8F4 VA: 0x25EF8F4
	public void .ctor(int fieldId, byte roomId, bool isForcibly, bool isMatching) { }

	// RVA: 0x25EF944 Offset: 0x25EB944 VA: 0x25EF944 Slot: 6
	public void Reconnection(Game engine) { }
}
