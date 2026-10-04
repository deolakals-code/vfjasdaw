// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class DeleteSkillTreeResponse : PacketBase // TypeDefIndex: 12108
{
	// Fields
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 102, IsOptional = True)]
	public Dictionary<short, byte> SkillList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3788908 Offset: 0x3784908 VA: 0x3788908
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3788910 Offset: 0x3784910 VA: 0x3788910
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x3788918 Offset: 0x3784918 VA: 0x3788918
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x3788920 Offset: 0x3784920 VA: 0x3788920 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3788928 Offset: 0x3784928 VA: 0x3788928 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3788A8C Offset: 0x3784A8C VA: 0x3788A8C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
