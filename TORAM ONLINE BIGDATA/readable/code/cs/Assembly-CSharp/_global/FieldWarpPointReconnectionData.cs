// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldWarpPointReconnectionData : IReconnectionData // TypeDefIndex: 4851
{
	// Fields
	private byte pointId; // 0x10
	private byte roomType; // 0x11
	private byte roomId; // 0x12
	private short[] pos; // 0x18
	private EmergencyPositionData emergency; // 0x20

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EB494 Offset: 0x25E7494 VA: 0x25EB494 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB49C Offset: 0x25E749C VA: 0x25EB49C
	public void .ctor(byte pointId, byte roomType, byte roomId, short[] pos, EmergencyPositionData emergency) { }

	// RVA: 0x25EB508 Offset: 0x25E7508 VA: 0x25EB508 Slot: 5
	public void Reconnection(Game engine) { }
}
