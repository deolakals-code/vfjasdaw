// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceBuyStorageRentReconnectionData : IReconnectionSubData // TypeDefIndex: 4959
{
	// Fields
	private int orbNum; // 0x10
	private byte storageNo; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED9E4 Offset: 0x25E99E4 VA: 0x25ED9E4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED9EC Offset: 0x25E99EC VA: 0x25ED9EC Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED9F4 Offset: 0x25E99F4 VA: 0x25ED9F4
	public void .ctor(int orbNum, byte storageNo) { }

	// RVA: 0x25EDA24 Offset: 0x25E9A24 VA: 0x25EDA24 Slot: 6
	public void Reconnection(Game engine) { }
}
