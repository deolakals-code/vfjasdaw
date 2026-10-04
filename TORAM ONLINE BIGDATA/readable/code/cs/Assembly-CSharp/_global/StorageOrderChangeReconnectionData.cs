// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageOrderChangeReconnectionData : IReconnectionSubData // TypeDefIndex: 8588
{
	// Fields
	private byte[] orderList; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x1DB2578 Offset: 0x1DAE578 VA: 0x1DB2578 Slot: 4
	public byte get_Code() { }

	// RVA: 0x1DB2580 Offset: 0x1DAE580 VA: 0x1DB2580 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x1DB2588 Offset: 0x1DAE588 VA: 0x1DB2588
	public void .ctor(byte[] orderList) { }

	// RVA: 0x1DB25B8 Offset: 0x1DAE5B8 VA: 0x1DB25B8 Slot: 6
	public void Reconnection(Game engine) { }
}
