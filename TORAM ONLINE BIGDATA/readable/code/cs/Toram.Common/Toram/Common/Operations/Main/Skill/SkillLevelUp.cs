// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class SkillLevelUp : PacketBase // TypeDefIndex: 12113
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

	// Methods

	// RVA: 0x378986C Offset: 0x378586C VA: 0x378986C
	public void .ctor() { }

	// RVA: 0x3789874 Offset: 0x3785874 VA: 0x3789874 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x378987C Offset: 0x378587C VA: 0x378987C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3789884 Offset: 0x3785884 VA: 0x3789884
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378988C Offset: 0x378588C VA: 0x378988C
	public byte get_SkillTreeType() { }

	[CompilerGenerated]
	// RVA: 0x3789894 Offset: 0x3785894 VA: 0x3789894
	public void set_SkillTreeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378989C Offset: 0x378589C VA: 0x378989C
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x37898A4 Offset: 0x37858A4 VA: 0x37898A4
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x37898AC Offset: 0x37858AC VA: 0x37898AC
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x37898B4 Offset: 0x37858B4 VA: 0x37898B4
	public void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37898BC Offset: 0x37858BC VA: 0x37898BC
	public short get_SkillPoint() { }

	[CompilerGenerated]
	// RVA: 0x37898C4 Offset: 0x37858C4 VA: 0x37898C4
	public void set_SkillPoint(short value) { }

	// RVA: 0x37898CC Offset: 0x37858CC VA: 0x37898CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3789B2C Offset: 0x3785B2C VA: 0x3789B2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
