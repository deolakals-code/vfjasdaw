// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseRhythmEnterReconnectionData : IReconnectionSubData // TypeDefIndex: 4908
{
	// Fields
	private int objId; // 0x10
	private bool isEveryone; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECBD4 Offset: 0x25E8BD4 VA: 0x25ECBD4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECBDC Offset: 0x25E8BDC VA: 0x25ECBDC Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECBE4 Offset: 0x25E8BE4 VA: 0x25ECBE4
	public void .ctor(int objId, bool isEveryone) { }

	// RVA: 0x25ECC14 Offset: 0x25E8C14 VA: 0x25ECC14 Slot: 6
	public void Reconnection(Game engine) { }
}
