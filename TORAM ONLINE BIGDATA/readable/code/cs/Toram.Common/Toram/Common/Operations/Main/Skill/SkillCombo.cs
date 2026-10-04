// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class SkillCombo : PacketBase // TypeDefIndex: 12112
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private SkillComboData[] <ComboData>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 199, IsOptional = True)]
	public SkillComboData[] ComboData { get; set; }

	// Methods

	// RVA: 0x3789558 Offset: 0x3785558 VA: 0x3789558
	public void .ctor() { }

	// RVA: 0x3789560 Offset: 0x3785560 VA: 0x3789560 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3789568 Offset: 0x3785568 VA: 0x3789568
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3789570 Offset: 0x3785570 VA: 0x3789570
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3789578 Offset: 0x3785578 VA: 0x3789578
	public SkillComboData[] get_ComboData() { }

	[CompilerGenerated]
	// RVA: 0x3789580 Offset: 0x3785580 VA: 0x3789580
	public void set_ComboData(SkillComboData[] value) { }

	// RVA: 0x3789588 Offset: 0x3785588 VA: 0x3789588 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3789760 Offset: 0x3785760 VA: 0x3789760 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
