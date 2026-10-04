// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseLandPurchaseReconnectionData : IReconnectionSubData // TypeDefIndex: 4891
{
	// Fields
	private int gold; // 0x10
	private byte buyArea; // 0x14
	private byte w; // 0x15
	private byte h; // 0x16
	private int orb; // 0x18
	private bool direct; // 0x1C

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC594 Offset: 0x25E8594 VA: 0x25EC594 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC59C Offset: 0x25E859C VA: 0x25EC59C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC5A4 Offset: 0x25E85A4 VA: 0x25EC5A4
	public void .ctor(byte buyArea, int gold, byte w, byte h, int orb, bool direct) { }

	// RVA: 0x25EC604 Offset: 0x25E8604 VA: 0x25EC604 Slot: 6
	public void Reconnection(Game engine) { }
}
