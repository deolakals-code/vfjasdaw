// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class ExeCutesignboardOfBazaarReconnectionData : IReconnectionSubData // TypeDefIndex: 5103
{
	// Fields
	private int targetId; // 0x10
	private byte slotIndex; // 0x14
	private short num; // 0x16
	private bool isNotEnoughCancel; // 0x18
	private int autoLockFlag; // 0x1C
	private DateTime dateTime; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F061C Offset: 0x25EC61C VA: 0x25F061C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F0624 Offset: 0x25EC624 VA: 0x25F0624 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F062C Offset: 0x25EC62C VA: 0x25F062C
	public void .ctor(int targetId, byte slotIndex, int num, bool isNotEnoughCancel, int autoLockFlag, DateTime dateTime) { }

	// RVA: 0x25F068C Offset: 0x25EC68C VA: 0x25F068C Slot: 6
	public void Reconnection(Game engine) { }
}
