// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureHuntOpenReconnectionData : IReconnectionSubData // TypeDefIndex: 5106
{
	// Fields
	private int fieldId; // 0x10
	private byte treasureNo; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F0730 Offset: 0x25EC730 VA: 0x25F0730 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F0738 Offset: 0x25EC738 VA: 0x25F0738 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F0740 Offset: 0x25EC740 VA: 0x25F0740
	public void .ctor(int fieldId, byte treasureNo) { }

	// RVA: 0x25F0770 Offset: 0x25EC770 VA: 0x25F0770 Slot: 6
	public void Reconnection(Game engine) { }
}
