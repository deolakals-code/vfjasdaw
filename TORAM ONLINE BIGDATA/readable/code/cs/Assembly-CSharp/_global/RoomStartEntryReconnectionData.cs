// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoomStartEntryReconnectionData : IReconnectionData // TypeDefIndex: 4858
{
	// Fields
	private short[] position; // 0x10
	private float rotation; // 0x18
	private EmergencyPositionData emergencyPositionData; // 0x20
	private int fieldId; // 0x28
	private byte roomId; // 0x2C
	private byte roomType; // 0x2D
	private RoomGroupSetting groupSetting; // 0x30
	private int[] itemList; // 0x38
	private int[] orbItemList; // 0x40

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EB758 Offset: 0x25E7758 VA: 0x25EB758 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB760 Offset: 0x25E7760 VA: 0x25EB760
	public void .ctor(int fieldId, byte roomType, byte roomId, RoomGroupSetting groupSetting, short[] position, float rotation, EmergencyPositionData emergencyPositionData, int[] itemList, int[] orbItemList) { }

	// RVA: 0x25EB820 Offset: 0x25E7820 VA: 0x25EB820 Slot: 5
	public void Reconnection(Game engine) { }
}
