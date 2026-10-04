// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LeaveRoomReconnectionData : IReconnectionData // TypeDefIndex: 4850
{
	// Fields
	private int fieldId; // 0x10
	private byte roomType; // 0x14
	private byte roomId; // 0x15
	private short[] pos; // 0x18
	private float angle; // 0x20

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EB404 Offset: 0x25E7404 VA: 0x25EB404 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB40C Offset: 0x25E740C VA: 0x25EB40C
	public void .ctor(int fieldId, byte roomType, byte roomId, short[] pos, float angle) { }

	// RVA: 0x25EB470 Offset: 0x25E7470 VA: 0x25EB470 Slot: 5
	public void Reconnection(Game engine) { }
}
