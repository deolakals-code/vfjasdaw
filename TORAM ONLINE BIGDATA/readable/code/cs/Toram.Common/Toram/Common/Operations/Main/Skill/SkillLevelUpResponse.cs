// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class SkillLevelUpResponse : PacketBase // TypeDefIndex: 12114
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SkillTreeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x26
	[CompilerGenerated]
	private byte <SkillLv>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <SkillPoint>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x38

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 103)]
	public byte SkillTreeType { get; set; }
	[PacketParameter(Code = 90)]
	public short SkillId { get; set; }
	[PacketParameter(Code = 101)]
	public byte SkillLv { get; set; }
	[PacketParameter(Code = 40)]
	public short SkillPoint { get; set; }
	[PacketParameter(Code = 25, IsOptional = True)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26, IsOptional = True)]
	public short Mp { get; set; }
	[PacketParameter(Code = 202, IsOptional = True)]
	public int ExHp { get; set; }
	[PacketParameter(Code = 203, IsOptional = True)]
	public short ExMp { get; set; }

	// Methods

	// RVA: 0x3789CC8 Offset: 0x3785CC8 VA: 0x3789CC8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3789CD0 Offset: 0x3785CD0 VA: 0x3789CD0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3789CD8 Offset: 0x3785CD8 VA: 0x3789CD8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3789CE0 Offset: 0x3785CE0 VA: 0x3789CE0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3789CE8 Offset: 0x3785CE8 VA: 0x3789CE8
	public byte get_SkillTreeType() { }

	[CompilerGenerated]
	// RVA: 0x3789CF0 Offset: 0x3785CF0 VA: 0x3789CF0
	public void set_SkillTreeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3789CF8 Offset: 0x3785CF8 VA: 0x3789CF8
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x3789D00 Offset: 0x3785D00 VA: 0x3789D00
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3789D08 Offset: 0x3785D08 VA: 0x3789D08
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x3789D10 Offset: 0x3785D10 VA: 0x3789D10
	public void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3789D18 Offset: 0x3785D18 VA: 0x3789D18
	public short get_SkillPoint() { }

	[CompilerGenerated]
	// RVA: 0x3789D20 Offset: 0x3785D20 VA: 0x3789D20
	public void set_SkillPoint(short value) { }

	[CompilerGenerated]
	// RVA: 0x3789D28 Offset: 0x3785D28 VA: 0x3789D28
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3789D30 Offset: 0x3785D30 VA: 0x3789D30
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3789D38 Offset: 0x3785D38 VA: 0x3789D38
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3789D40 Offset: 0x3785D40 VA: 0x3789D40
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3789D48 Offset: 0x3785D48 VA: 0x3789D48
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3789D50 Offset: 0x3785D50 VA: 0x3789D50
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x3789D58 Offset: 0x3785D58 VA: 0x3789D58
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3789D60 Offset: 0x3785D60 VA: 0x3789D60
	public short get_ExMp() { }

	// RVA: 0x3789D68 Offset: 0x3785D68 VA: 0x3789D68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378A154 Offset: 0x3786154 VA: 0x378A154 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
