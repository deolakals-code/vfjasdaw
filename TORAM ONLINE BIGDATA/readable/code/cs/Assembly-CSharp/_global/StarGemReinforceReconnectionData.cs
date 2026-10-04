// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StarGemReinforceReconnectionData : IReconnectionSubData // TypeDefIndex: 4979
{
	// Fields
	private long reinforceUuid; // 0x10
	private short reinforceNo; // 0x18
	private long materialUuid; // 0x20
	private short materialNo; // 0x28

	// Properties
	public byte SubCode { get; }
	public byte Code { get; }

	// Methods

	// RVA: 0x25EDFA0 Offset: 0x25E9FA0 VA: 0x25EDFA0 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EDFA8 Offset: 0x25E9FA8 VA: 0x25EDFA8 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EDFB0 Offset: 0x25E9FB0 VA: 0x25EDFB0
	public void .ctor(long reinforceUuid, short reinforceNo, long materialUuid, short materialNo) { }

	// RVA: 0x25EDFF8 Offset: 0x25E9FF8 VA: 0x25EDFF8 Slot: 6
	public void Reconnection(Game engine) { }
}
