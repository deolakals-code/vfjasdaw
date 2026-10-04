// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CristaAttachReconnectionData : IReconnectionData // TypeDefIndex: 5048
{
	// Fields
	private int itemUid; // 0x10
	private byte slotId; // 0x14
	private int cristaId; // 0x18

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EF440 Offset: 0x25EB440 VA: 0x25EF440 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF448 Offset: 0x25EB448 VA: 0x25EF448
	public void .ctor(int itemUid, byte slotId, int cristaId) { }

	// RVA: 0x25EF488 Offset: 0x25EB488 VA: 0x25EF488 Slot: 5
	public void Reconnection(Game engine) { }
}
