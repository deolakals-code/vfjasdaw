// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SupportEventResponseData : PacketBase // TypeDefIndex: 13205
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <TargetArchetypeType>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <TargetArchetypeId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <SkillLv>k__BackingField; // 0x32
	[CompilerGenerated]
	private SupportResultData <SupportResultData>k__BackingField; // 0x38

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 164)]
	public byte TargetArchetypeType { get; set; }
	[PacketParameter(Code = 96)]
	public int TargetArchetypeId { get; set; }
	[PacketParameter(Code = 90)]
	public short SkillId { get; set; }
	[PacketParameter(Code = 101)]
	public byte SkillLv { get; set; }
	[PacketParameter(Code = 198)]
	public SupportResultData SupportResultData { get; set; }

	// Methods

	// RVA: 0x36C8F90 Offset: 0x36C4F90 VA: 0x36C8F90
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36C8F98 Offset: 0x36C4F98 VA: 0x36C8F98 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36C8FA0 Offset: 0x36C4FA0 VA: 0x36C8FA0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36C8FA8 Offset: 0x36C4FA8 VA: 0x36C8FA8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C8FB0 Offset: 0x36C4FB0 VA: 0x36C8FB0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36C8FB8 Offset: 0x36C4FB8 VA: 0x36C8FB8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C8FC0 Offset: 0x36C4FC0 VA: 0x36C8FC0
	public byte get_TargetArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36C8FC8 Offset: 0x36C4FC8 VA: 0x36C8FC8
	public void set_TargetArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C8FD0 Offset: 0x36C4FD0 VA: 0x36C8FD0
	public int get_TargetArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36C8FD8 Offset: 0x36C4FD8 VA: 0x36C8FD8
	public void set_TargetArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C8FE0 Offset: 0x36C4FE0 VA: 0x36C8FE0
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C8FE8 Offset: 0x36C4FE8 VA: 0x36C8FE8
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C8FF0 Offset: 0x36C4FF0 VA: 0x36C8FF0
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x36C8FF8 Offset: 0x36C4FF8 VA: 0x36C8FF8
	public void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C9000 Offset: 0x36C5000 VA: 0x36C9000
	public SupportResultData get_SupportResultData() { }

	[CompilerGenerated]
	// RVA: 0x36C9008 Offset: 0x36C5008 VA: 0x36C9008
	public void set_SupportResultData(SupportResultData value) { }

	// RVA: 0x36C9010 Offset: 0x36C5010 VA: 0x36C9010 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36C9364 Offset: 0x36C5364 VA: 0x36C9364 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
