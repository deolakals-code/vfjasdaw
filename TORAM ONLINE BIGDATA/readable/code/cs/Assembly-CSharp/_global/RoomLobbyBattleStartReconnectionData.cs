// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoomLobbyBattleStartReconnectionData : IReconnectionSubData // TypeDefIndex: 4860
{
	// Fields
	private short[] position; // 0x10
	private float rotation; // 0x18
	private EmergencyPositionData emergencyPositionData; // 0x20
	private byte[] bonusList; // 0x28
	private int[] supportItems; // 0x30
	private int[] supportOrbItems; // 0x38
	private bool isHighRaid; // 0x40

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EB8E4 Offset: 0x25E78E4 VA: 0x25EB8E4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB8EC Offset: 0x25E78EC VA: 0x25EB8EC Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EB8F4 Offset: 0x25E78F4 VA: 0x25EB8F4
	public void .ctor(short[] position, float rotation, EmergencyPositionData emergencyPositionData) { }

	// RVA: 0x25EB948 Offset: 0x25E7948 VA: 0x25EB948
	public void .ctor(short[] position, float rotation, EmergencyPositionData emergencyPositionData, byte[] bonusList) { }

	// RVA: 0x25EB9B8 Offset: 0x25E79B8 VA: 0x25EB9B8
	public void .ctor(short[] position, float rotation, EmergencyPositionData emergencyPositionData, byte[] bonusList, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x25EBA58 Offset: 0x25E7A58 VA: 0x25EBA58
	public void .ctor(short[] position, float rotation, EmergencyPositionData emergencyPositionData, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x25EBAE8 Offset: 0x25E7AE8 VA: 0x25EBAE8 Slot: 6
	public void Reconnection(Game engine) { }
}
