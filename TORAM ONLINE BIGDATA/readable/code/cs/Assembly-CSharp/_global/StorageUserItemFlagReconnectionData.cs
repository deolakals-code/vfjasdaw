// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageUserItemFlagReconnectionData : IReconnectionSubData // TypeDefIndex: 8587
{
	// Fields
	private StorageItemDatav3 storageItemData; // 0x10
	private byte userItemFlag; // 0x18
	private byte storageNo; // 0x19

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x1DB2510 Offset: 0x1DAE510 VA: 0x1DB2510 Slot: 4
	public byte get_Code() { }

	// RVA: 0x1DB2518 Offset: 0x1DAE518 VA: 0x1DB2518 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x1DB2520 Offset: 0x1DAE520 VA: 0x1DB2520
	public void .ctor(byte storageNo, StorageItemDatav3 storageItemData, byte userItemFlag) { }

	// RVA: 0x1DB255C Offset: 0x1DAE55C VA: 0x1DB255C Slot: 6
	public void Reconnection(Game engine) { }
}
