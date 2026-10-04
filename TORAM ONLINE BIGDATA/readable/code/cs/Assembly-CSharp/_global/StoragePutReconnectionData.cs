// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StoragePutReconnectionData : IReconnectionSubData // TypeDefIndex: 8584
{
	// Fields
	private byte storageNo; // 0x10
	private ItemSelectData data; // 0x18
	private byte useType; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x1DB23E0 Offset: 0x1DAE3E0 VA: 0x1DB23E0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x1DB23E8 Offset: 0x1DAE3E8 VA: 0x1DB23E8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x1DB23F0 Offset: 0x1DAE3F0 VA: 0x1DB23F0
	public void .ctor(byte storageNo, ItemSelectData data, byte useType) { }

	// RVA: 0x1DB243C Offset: 0x1DAE43C VA: 0x1DB243C Slot: 6
	public void Reconnection(Game engine) { }
}
