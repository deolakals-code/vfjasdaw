// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureOpenReconnectionData : IReconnectionSubData // TypeDefIndex: 5105
{
	// Fields
	private int fieldId; // 0x10
	private byte treasureNo; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F06D8 Offset: 0x25EC6D8 VA: 0x25F06D8 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F06E0 Offset: 0x25EC6E0 VA: 0x25F06E0 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F06E8 Offset: 0x25EC6E8 VA: 0x25F06E8
	public void .ctor(int fieldId, byte treasureNo) { }

	// RVA: 0x25F0718 Offset: 0x25EC718 VA: 0x25F0718 Slot: 6
	public void Reconnection(Game engine) { }
}
