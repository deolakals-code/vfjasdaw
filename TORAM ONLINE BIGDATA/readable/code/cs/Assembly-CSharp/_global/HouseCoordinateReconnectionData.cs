// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseCoordinateReconnectionData : IReconnectionSubData // TypeDefIndex: 4896
{
	// Fields
	private byte actionType; // 0x10
	private int uid; // 0x14
	private int objId; // 0x18
	private int parentUid; // 0x1C
	private int position; // 0x20
	private byte rotation; // 0x24

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC778 Offset: 0x25E8778 VA: 0x25EC778 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC780 Offset: 0x25E8780 VA: 0x25EC780 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC788 Offset: 0x25E8788 VA: 0x25EC788
	public void .ctor(byte type, int uid, int objId, int parentUid, int position, byte rotation) { }

	// RVA: 0x25EC7E0 Offset: 0x25E87E0 VA: 0x25EC7E0
	public void .ctor(int uid, int objId) { }

	// RVA: 0x25EC814 Offset: 0x25E8814 VA: 0x25EC814 Slot: 6
	public void Reconnection(Game engine) { }
}
