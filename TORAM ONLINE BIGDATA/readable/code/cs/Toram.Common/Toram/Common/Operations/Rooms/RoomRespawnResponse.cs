// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomRespawnResponse : OperationResponseBase // TypeDefIndex: 11755
{
	// Fields
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 25)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26)]
	public short Mp { get; set; }
	[PacketParameter(Code = 202, IsOptional = True)]
	public int ExHp { get; set; }
	[PacketParameter(Code = 203, IsOptional = True)]
	public short ExMp { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65, IsOptional = True)]
	public short Rotation { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37428A0 Offset: 0x373E8A0 VA: 0x37428A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37428A8 Offset: 0x373E8A8 VA: 0x37428A8
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x37428B0 Offset: 0x373E8B0 VA: 0x37428B0
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x37428B8 Offset: 0x373E8B8 VA: 0x37428B8
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x37428C0 Offset: 0x373E8C0 VA: 0x37428C0
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x37428C8 Offset: 0x373E8C8 VA: 0x37428C8
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x37428D0 Offset: 0x373E8D0 VA: 0x37428D0
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x37428D8 Offset: 0x373E8D8 VA: 0x37428D8
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x37428E0 Offset: 0x373E8E0 VA: 0x37428E0
	public short get_ExMp() { }

	[CompilerGenerated]
	// RVA: 0x37428E8 Offset: 0x373E8E8 VA: 0x37428E8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x37428F0 Offset: 0x373E8F0 VA: 0x37428F0
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x37428F8 Offset: 0x373E8F8 VA: 0x37428F8
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3742900 Offset: 0x373E900 VA: 0x3742900
	public void set_Rotation(short value) { }

	// RVA: 0x3742908 Offset: 0x373E908 VA: 0x3742908 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3742910 Offset: 0x373E910 VA: 0x3742910 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3742918 Offset: 0x373E918 VA: 0x3742918 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3742C44 Offset: 0x373EC44 VA: 0x3742C44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
