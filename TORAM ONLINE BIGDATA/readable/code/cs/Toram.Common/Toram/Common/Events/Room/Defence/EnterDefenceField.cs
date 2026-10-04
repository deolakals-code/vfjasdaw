// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Defence
public class EnterDefenceField : EventSubBase // TypeDefIndex: 12777
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 106)]
	public byte RoomId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365692C Offset: 0x365292C VA: 0x365692C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3656934 Offset: 0x3652934 VA: 0x3656934
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x365693C Offset: 0x365293C VA: 0x365693C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3656944 Offset: 0x3652944 VA: 0x3656944
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x365694C Offset: 0x365294C VA: 0x365694C
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3656954 Offset: 0x3652954 VA: 0x3656954
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x365695C Offset: 0x365295C VA: 0x365695C
	public void set_RoomId(byte value) { }

	// RVA: 0x3656964 Offset: 0x3652964 VA: 0x3656964 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365696C Offset: 0x365296C VA: 0x365696C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3656974 Offset: 0x3652974 VA: 0x3656974 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3656B38 Offset: 0x3652B38 VA: 0x3656B38 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
