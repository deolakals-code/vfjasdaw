// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class StatusUpResponse : PacketBase // TypeDefIndex: 12088
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x3C

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketClass(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }
	[PacketParameter(Code = 25, IsOptional = True)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26, IsOptional = True)]
	public short Mp { get; set; }
	[PacketParameter(Code = 202, IsOptional = True)]
	public int ExHp { get; set; }
	[PacketParameter(Code = 203, IsOptional = True)]
	public short ExMp { get; set; }

	// Methods

	// RVA: 0x3784C20 Offset: 0x3780C20 VA: 0x3784C20
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3784C28 Offset: 0x3780C28 VA: 0x3784C28 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3784C30 Offset: 0x3780C30 VA: 0x3784C30
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3784C38 Offset: 0x3780C38 VA: 0x3784C38
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3784C40 Offset: 0x3780C40 VA: 0x3784C40
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3784C48 Offset: 0x3780C48 VA: 0x3784C48
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3784C50 Offset: 0x3780C50 VA: 0x3784C50
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x3784C58 Offset: 0x3780C58 VA: 0x3784C58
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3784C60 Offset: 0x3780C60 VA: 0x3784C60
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3784C68 Offset: 0x3780C68 VA: 0x3784C68
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3784C70 Offset: 0x3780C70 VA: 0x3784C70
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3784C78 Offset: 0x3780C78 VA: 0x3784C78
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3784C80 Offset: 0x3780C80 VA: 0x3784C80
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3784C88 Offset: 0x3780C88 VA: 0x3784C88
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x3784C90 Offset: 0x3780C90 VA: 0x3784C90
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3784C98 Offset: 0x3780C98 VA: 0x3784C98
	public short get_ExMp() { }

	// RVA: 0x3784CA0 Offset: 0x3780CA0 VA: 0x3784CA0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3785088 Offset: 0x3781088 VA: 0x3785088 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
