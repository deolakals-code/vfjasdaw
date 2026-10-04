// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomBattleJoin : PacketBase // TypeDefIndex: 11744
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65, IsOptional = True)]
	public short Rotation { get; set; }
	[PacketClass(Code = 107, IsOptional = True)]
	public EmergencyPositionData EmergencyPositionData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37409F8 Offset: 0x373C9F8 VA: 0x37409F8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3740A00 Offset: 0x373CA00 VA: 0x3740A00
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3740A08 Offset: 0x373CA08 VA: 0x3740A08
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3740A10 Offset: 0x373CA10 VA: 0x3740A10
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3740A18 Offset: 0x373CA18 VA: 0x3740A18
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3740A20 Offset: 0x373CA20 VA: 0x3740A20
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x3740A28 Offset: 0x373CA28 VA: 0x3740A28
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	// RVA: 0x3740A30 Offset: 0x373CA30 VA: 0x3740A30
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3740B50 Offset: 0x373CB50 VA: 0x3740B50
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3740BCC Offset: 0x373CBCC VA: 0x3740BCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3740BD4 Offset: 0x373CBD4 VA: 0x3740BD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3740DBC Offset: 0x373CDBC VA: 0x3740DBC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
