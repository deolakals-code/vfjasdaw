// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AttachReinforceCristaReconnectionData : IReconnectionData // TypeDefIndex: 5050
{
	// Fields
	private int itemUid; // 0x10
	private byte slotId; // 0x14
	private int cristaId; // 0x18
	private byte type; // 0x1C
	private int value; // 0x20

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EF4F4 Offset: 0x25EB4F4 VA: 0x25EF4F4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF4FC Offset: 0x25EB4FC VA: 0x25EF4FC
	public void .ctor(int itemUid, byte slotId, int cristaId, byte type, int value) { }

	// RVA: 0x25EF554 Offset: 0x25EB554 VA: 0x25EF554 Slot: 5
	public void Reconnection(Game engine) { }
}
