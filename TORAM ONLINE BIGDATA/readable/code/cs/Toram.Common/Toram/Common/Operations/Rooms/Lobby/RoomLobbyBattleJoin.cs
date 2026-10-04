// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Lobby
public class RoomLobbyBattleJoin : OperationRequestBase // TypeDefIndex: 11772
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x30

	// Properties
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public EmergencyPositionData EmergencyPositionData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3747438 Offset: 0x3743438 VA: 0x3747438
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3747440 Offset: 0x3743440 VA: 0x3747440
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3747448 Offset: 0x3743448 VA: 0x3747448
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3747450 Offset: 0x3743450 VA: 0x3747450
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3747458 Offset: 0x3743458 VA: 0x3747458
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3747460 Offset: 0x3743460 VA: 0x3747460
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x3747468 Offset: 0x3743468 VA: 0x3747468
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	// RVA: 0x3747470 Offset: 0x3743470 VA: 0x3747470 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3747478 Offset: 0x3743478 VA: 0x3747478 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3747480 Offset: 0x3743480 VA: 0x3747480 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3747720 Offset: 0x3743720 VA: 0x3747720 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
