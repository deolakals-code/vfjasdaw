// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageSortReconnectionData : IReconnectionSubData // TypeDefIndex: 8586
{
	// Fields
	private byte storageNo; // 0x10
	private byte storagePageNo; // 0x11

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x1DB24B8 Offset: 0x1DAE4B8 VA: 0x1DB24B8 Slot: 4
	public byte get_Code() { }

	// RVA: 0x1DB24C0 Offset: 0x1DAE4C0 VA: 0x1DB24C0 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x1DB24C8 Offset: 0x1DAE4C8 VA: 0x1DB24C8
	public void .ctor(byte storageNo, byte storagePageNo) { }

	// RVA: 0x1DB24F8 Offset: 0x1DAE4F8 VA: 0x1DB24F8 Slot: 6
	public void Reconnection(Game engine) { }
}
