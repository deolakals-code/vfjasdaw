// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageDiscardReconnectionData : IReconnectionSubData // TypeDefIndex: 8585
{
	// Fields
	private byte storageNo; // 0x10
	private StorageItemDatav3 storageItem; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x1DB2458 Offset: 0x1DAE458 VA: 0x1DB2458 Slot: 4
	public byte get_Code() { }

	// RVA: 0x1DB2460 Offset: 0x1DAE460 VA: 0x1DB2460 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x1DB2468 Offset: 0x1DAE468 VA: 0x1DB2468
	public void .ctor(byte storageNo, StorageItemDatav3 storageItem) { }

	// RVA: 0x1DB24A0 Offset: 0x1DAE4A0 VA: 0x1DB24A0 Slot: 6
	public void Reconnection(Game engine) { }
}
