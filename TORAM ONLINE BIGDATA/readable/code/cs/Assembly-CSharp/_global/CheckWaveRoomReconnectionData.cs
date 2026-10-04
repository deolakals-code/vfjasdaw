// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CheckWaveRoomReconnectionData : IReconnectionData // TypeDefIndex: 5052
{
	// Fields
	private int fieldId; // 0x10
	private byte roomId; // 0x14
	private short level; // 0x16

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EF614 Offset: 0x25EB614 VA: 0x25EF614 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF61C Offset: 0x25EB61C VA: 0x25EF61C
	public void .ctor(int fieldId, byte roomId, short level) { }

	// RVA: 0x25EF664 Offset: 0x25EB664 VA: 0x25EF664 Slot: 5
	public void Reconnection(Game engine) { }
}
