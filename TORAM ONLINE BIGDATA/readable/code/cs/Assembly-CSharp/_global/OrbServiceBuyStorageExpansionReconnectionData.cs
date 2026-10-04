// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceBuyStorageExpansionReconnectionData : IReconnectionSubData // TypeDefIndex: 4958
{
	// Fields
	private int orbNum; // 0x10
	private byte storageNo; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED98C Offset: 0x25E998C VA: 0x25ED98C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED994 Offset: 0x25E9994 VA: 0x25ED994 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED99C Offset: 0x25E999C VA: 0x25ED99C
	public void .ctor(int orbNum, byte storageNo) { }

	// RVA: 0x25ED9CC Offset: 0x25E99CC VA: 0x25ED9CC Slot: 6
	public void Reconnection(Game engine) { }
}
