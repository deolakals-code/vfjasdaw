// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class SkillLibraryResponse : PacketBase // TypeDefIndex: 12116
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 28)]
	public int Gold { get; set; }
	[PacketClass(Code = 102, IsOptional = True)]
	public Dictionary<short, byte> SkillList { get; set; }

	// Methods

	// RVA: 0x378A8D4 Offset: 0x37868D4 VA: 0x378A8D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x378A8DC Offset: 0x37868DC VA: 0x378A8DC Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x378A8E4 Offset: 0x37868E4 VA: 0x378A8E4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x378A8EC Offset: 0x37868EC VA: 0x378A8EC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378A8F4 Offset: 0x37868F4 VA: 0x378A8F4
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x378A8FC Offset: 0x37868FC VA: 0x378A8FC
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x378A904 Offset: 0x3786904 VA: 0x378A904
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x378A90C Offset: 0x378690C VA: 0x378A90C
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x378A914 Offset: 0x3786914 VA: 0x378A914
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x378A9F0 Offset: 0x37869F0 VA: 0x378A9F0
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x378AA68 Offset: 0x3786A68 VA: 0x378AA68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378ABE4 Offset: 0x3786BE4 VA: 0x378ABE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
