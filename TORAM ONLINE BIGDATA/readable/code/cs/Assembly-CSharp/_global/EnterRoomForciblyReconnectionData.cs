// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnterRoomForciblyReconnectionData : IReconnectionData // TypeDefIndex: 4849
{
	// Fields
	private int fieldId; // 0x10
	private byte roomType; // 0x14
	private byte roomId; // 0x15
	private short[] pos; // 0x18
	private float angle; // 0x20
	private EmergencyPositionData emergency; // 0x28
	private short areaLevel; // 0x30

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EB2F4 Offset: 0x25E72F4 VA: 0x25EB2F4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB2FC Offset: 0x25E72FC VA: 0x25EB2FC
	public void .ctor(int fieldId, byte roomType, byte roomId, short[] pos, float angle, EmergencyPositionData emergency) { }

	// RVA: 0x25EB308 Offset: 0x25E7308 VA: 0x25EB308
	public void .ctor(int fieldId, byte roomType, byte roomId, short[] pos, float angle, short areaLevel, EmergencyPositionData emergency) { }

	// RVA: 0x25EB390 Offset: 0x25E7390 VA: 0x25EB390 Slot: 5
	public void Reconnection(Game engine) { }
}
