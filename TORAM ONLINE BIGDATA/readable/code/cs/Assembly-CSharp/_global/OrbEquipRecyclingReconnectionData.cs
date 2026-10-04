// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbEquipRecyclingReconnectionData : IReconnectionSubData // TypeDefIndex: 4944
{
	// Fields
	private int orbItemId; // 0x10
	private int orbItemUuid; // 0x14
	private OrbRecycleType recycleType; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED50C Offset: 0x25E950C VA: 0x25ED50C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED514 Offset: 0x25E9514 VA: 0x25ED514 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED51C Offset: 0x25E951C VA: 0x25ED51C
	public void .ctor(int orbItemId, int orbItemUuid, OrbRecycleType recycleType) { }

	// RVA: 0x25ED558 Offset: 0x25E9558 VA: 0x25ED558 Slot: 6
	public void Reconnection(Game engine) { }
}
