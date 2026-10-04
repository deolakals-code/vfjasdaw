// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class SaveRespawnPosition : PacketBase // TypeDefIndex: 12085
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }

	// Methods

	// RVA: 0x3784298 Offset: 0x3780298 VA: 0x3784298
	public void .ctor() { }

	// RVA: 0x37842A0 Offset: 0x37802A0 VA: 0x37842A0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37842A8 Offset: 0x37802A8 VA: 0x37842A8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37842B0 Offset: 0x37802B0 VA: 0x37842B0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37842B8 Offset: 0x37802B8 VA: 0x37842B8
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x37842C0 Offset: 0x37802C0 VA: 0x37842C0
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37842C8 Offset: 0x37802C8 VA: 0x37842C8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x37842D0 Offset: 0x37802D0 VA: 0x37842D0
	public void set_Position(short[] value) { }

	// RVA: 0x37842D8 Offset: 0x37802D8 VA: 0x37842D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37844D4 Offset: 0x37804D4 VA: 0x37844D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
