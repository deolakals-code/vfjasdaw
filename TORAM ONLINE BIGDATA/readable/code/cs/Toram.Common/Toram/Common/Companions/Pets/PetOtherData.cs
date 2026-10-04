// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions.Pets
public class PetOtherData : UnityHashBase // TypeDefIndex: 12958
{
	// Fields
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetModelData <Model>k__BackingField; // 0x28
	[CompilerGenerated]
	private PetSkillData[] <SkillList>k__BackingField; // 0x30

	// Properties
	public int MonsterUuid { get; set; }
	public string Name { get; set; }
	[UnityHash(Code = 199, IsOptional = True)]
	public PetModelData Model { get; set; }
	[UnityHash(Code = 102, IsOptional = True)]
	public PetSkillData[] SkillList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3681EF4 Offset: 0x367DEF4 VA: 0x3681EF4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3681EFC Offset: 0x367DEFC VA: 0x3681EFC
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x3681F04 Offset: 0x367DF04 VA: 0x3681F04
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3681F0C Offset: 0x367DF0C VA: 0x3681F0C
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3681F14 Offset: 0x367DF14 VA: 0x3681F14
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3681F1C Offset: 0x367DF1C VA: 0x3681F1C
	public PetModelData get_Model() { }

	[CompilerGenerated]
	// RVA: 0x3681F24 Offset: 0x367DF24 VA: 0x3681F24
	public void set_Model(PetModelData value) { }

	[CompilerGenerated]
	// RVA: 0x3681F2C Offset: 0x367DF2C VA: 0x3681F2C
	public PetSkillData[] get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x3681F34 Offset: 0x367DF34 VA: 0x3681F34
	public void set_SkillList(PetSkillData[] value) { }

	// RVA: 0x3681F3C Offset: 0x367DF3C VA: 0x3681F3C
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x3682134 Offset: 0x367E134 VA: 0x3682134
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x368224C Offset: 0x367E24C VA: 0x368224C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3682254 Offset: 0x367E254 VA: 0x3682254 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36824A8 Offset: 0x367E4A8 VA: 0x36824A8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
