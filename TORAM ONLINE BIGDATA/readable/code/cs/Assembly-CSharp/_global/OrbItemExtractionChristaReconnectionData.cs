// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbItemExtractionChristaReconnectionData : IReconnectionSubData // TypeDefIndex: 4941
{
	// Fields
	private int orbItemId; // 0x10
	private int targetItemUid; // 0x14
	private byte slotNo; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED434 Offset: 0x25E9434 VA: 0x25ED434 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED43C Offset: 0x25E943C VA: 0x25ED43C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED444 Offset: 0x25E9444 VA: 0x25ED444
	public void .ctor(int orbItemId, int targetItemUid, byte slotNo) { }

	// RVA: 0x25ED480 Offset: 0x25E9480 VA: 0x25ED480 Slot: 6
	public void Reconnection(Game engine) { }
}
