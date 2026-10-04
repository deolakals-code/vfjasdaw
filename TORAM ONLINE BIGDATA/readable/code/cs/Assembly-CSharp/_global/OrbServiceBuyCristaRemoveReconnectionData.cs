// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceBuyCristaRemoveReconnectionData : IReconnectionSubData // TypeDefIndex: 4954
{
	// Fields
	private int orbNum; // 0x10
	private int targetItemUid; // 0x14
	private byte slotNo; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED83C Offset: 0x25E983C VA: 0x25ED83C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED844 Offset: 0x25E9844 VA: 0x25ED844 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED84C Offset: 0x25E984C VA: 0x25ED84C
	public void .ctor(int orbNum, int targetItemUid, byte slotNo) { }

	// RVA: 0x25ED888 Offset: 0x25E9888 VA: 0x25ED888 Slot: 6
	public void Reconnection(Game engine) { }
}
