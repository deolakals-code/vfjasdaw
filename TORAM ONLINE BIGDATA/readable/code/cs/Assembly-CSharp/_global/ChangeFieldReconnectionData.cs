// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChangeFieldReconnectionData : IReconnectionData // TypeDefIndex: 4848
{
	// Fields
	private int fieldId; // 0x10
	private byte roomType; // 0x14
	private byte roomId; // 0x15
	private short[] pos; // 0x18
	private float angle; // 0x20
	private float cameraRot; // 0x24
	private EmergencyPositionData emergency; // 0x28

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EB218 Offset: 0x25E7218 VA: 0x25EB218 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB220 Offset: 0x25E7220 VA: 0x25EB220
	public void .ctor(int fieldId, byte roomType, byte roomId, short[] pos, float angle, float cameraRot, EmergencyPositionData emergency) { }

	// RVA: 0x25EB2A0 Offset: 0x25E72A0 VA: 0x25EB2A0 Slot: 5
	public void Reconnection(Game engine) { }
}
