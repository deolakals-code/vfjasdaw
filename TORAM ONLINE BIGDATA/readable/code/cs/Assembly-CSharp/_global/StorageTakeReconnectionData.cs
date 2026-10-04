// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageTakeReconnectionData : IReconnectionSubData // TypeDefIndex: 8583
{
	// Fields
	private byte storageNo; // 0x10
	private byte bagId; // 0x11
	private byte type; // 0x12
	private StorageItemDatav3 storageItem; // 0x18
	private short num; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x1DB2348 Offset: 0x1DAE348 VA: 0x1DB2348 Slot: 4
	public byte get_Code() { }

	// RVA: 0x1DB2350 Offset: 0x1DAE350 VA: 0x1DB2350 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x1DB2358 Offset: 0x1DAE358 VA: 0x1DB2358
	public void .ctor(byte storageNo, byte bagId, StorageItemDatav3 storageItem, byte type, short num) { }

	// RVA: 0x1DB23BC Offset: 0x1DAE3BC VA: 0x1DB23BC Slot: 6
	public void Reconnection(Game engine) { }
}
