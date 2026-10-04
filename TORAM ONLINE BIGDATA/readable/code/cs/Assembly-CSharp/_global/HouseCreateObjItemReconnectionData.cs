// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseCreateObjItemReconnectionData : IReconnectionSubData // TypeDefIndex: 4900
{
	// Fields
	private int objId; // 0x10
	private int num; // 0x14
	private bool direct; // 0x18
	private int orbNum; // 0x1C
	private int useOrb; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC93C Offset: 0x25E893C VA: 0x25EC93C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC944 Offset: 0x25E8944 VA: 0x25EC944 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC94C Offset: 0x25E894C VA: 0x25EC94C
	public void .ctor(int objId, int num, bool direct, int orbNum, int useOrb) { }

	// RVA: 0x25EC99C Offset: 0x25E899C VA: 0x25EC99C Slot: 6
	public void Reconnection(Game engine) { }
}
