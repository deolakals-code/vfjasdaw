// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationRoomLobbyBattleJoin : OperationRequestBase // TypeDefIndex: 13067
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

	// RVA: 0x369C20C Offset: 0x369820C VA: 0x369C20C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x369C214 Offset: 0x3698214 VA: 0x369C214
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x369C21C Offset: 0x369821C VA: 0x369C21C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x369C224 Offset: 0x3698224 VA: 0x369C224
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x369C22C Offset: 0x369822C VA: 0x369C22C
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x369C234 Offset: 0x3698234 VA: 0x369C234
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x369C23C Offset: 0x369823C VA: 0x369C23C
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	// RVA: 0x369C244 Offset: 0x3698244 VA: 0x369C244 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369C24C Offset: 0x369824C VA: 0x369C24C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369C254 Offset: 0x3698254 VA: 0x369C254 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369C4F4 Offset: 0x36984F4 VA: 0x369C4F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
