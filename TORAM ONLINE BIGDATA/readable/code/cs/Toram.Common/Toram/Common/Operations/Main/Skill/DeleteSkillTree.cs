// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class DeleteSkillTree : PacketBase // TypeDefIndex: 12107
{
	// Fields
	[CompilerGenerated]
	private byte <SkillTreeType>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 103)]
	public byte SkillTreeType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37886F4 Offset: 0x37846F4 VA: 0x37886F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37886FC Offset: 0x37846FC VA: 0x37886FC
	public byte get_SkillTreeType() { }

	[CompilerGenerated]
	// RVA: 0x3788704 Offset: 0x3784704 VA: 0x3788704
	public void set_SkillTreeType(byte value) { }

	// RVA: 0x378870C Offset: 0x378470C VA: 0x378870C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3788714 Offset: 0x3784714 VA: 0x3788714 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3788834 Offset: 0x3784834 VA: 0x3788834 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
