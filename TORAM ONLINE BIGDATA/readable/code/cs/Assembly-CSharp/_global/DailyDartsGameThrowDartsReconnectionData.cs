// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DailyDartsGameThrowDartsReconnectionData : IReconnectionSubData // TypeDefIndex: 5029
{
	// Fields
	private byte throwNum; // 0x10
	private short hitId; // 0x12

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EEECC Offset: 0x25EAECC VA: 0x25EEECC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EEED4 Offset: 0x25EAED4 VA: 0x25EEED4 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EEEDC Offset: 0x25EAEDC VA: 0x25EEEDC
	public void .ctor(byte throwNum, short hitId) { }

	// RVA: 0x25EEF0C Offset: 0x25EAF0C VA: 0x25EEF0C Slot: 6
	public void Reconnection(Game engine) { }
}
