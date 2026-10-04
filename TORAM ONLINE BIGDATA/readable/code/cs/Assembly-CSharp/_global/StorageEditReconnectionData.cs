// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageEditReconnectionData : IReconnectionSubData // TypeDefIndex: 8581
{
	// Fields
	private byte storageNo; // 0x10
	private string storageName; // 0x18
	private string storageInfo; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x1DB2224 Offset: 0x1DAE224 VA: 0x1DB2224 Slot: 4
	public byte get_Code() { }

	// RVA: 0x1DB222C Offset: 0x1DAE22C VA: 0x1DB222C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x1DB2234 Offset: 0x1DAE234 VA: 0x1DB2234
	public void .ctor(byte storageNo, string storageName, string storageInfo) { }

	// RVA: 0x1DB22E4 Offset: 0x1DAE2E4 VA: 0x1DB22E4 Slot: 6
	public void Reconnection(Game engine) { }
}
