// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Npcs
public class NpcData : UnityHashBase // TypeDefIndex: 11153
{
	// Fields
	[CompilerGenerated]
	private int <NpcId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private NpcStatusData <NpcStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private NpcEquipData <NpcEquip>k__BackingField; // 0x28
	[CompilerGenerated]
	private NpcSettingData <NpcSetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private NpcMotionData[] <NpcMotionList>k__BackingField; // 0x38
	[CompilerGenerated]
	private NpcSkillData[] <NpcSkillList>k__BackingField; // 0x40
	[CompilerGenerated]
	private NpcPatternData[] <NpcPatternList>k__BackingField; // 0x48

	// Properties
	[UnityHash(Code = 74)]
	public int NpcId { get; set; }
	[UnityHash(Code = 181, IsOptional = True)]
	public NpcStatusData NpcStatus { get; set; }
	[UnityHash(Code = 71, IsOptional = True)]
	public NpcEquipData NpcEquip { get; set; }
	[UnityHash(Code = 127, IsOptional = True)]
	public NpcSettingData NpcSetting { get; set; }
	[UnityHash(Code = 143, IsOptional = True)]
	public NpcMotionData[] NpcMotionList { get; set; }
	[UnityHash(Code = 102, IsOptional = True)]
	public NpcSkillData[] NpcSkillList { get; set; }
	[UnityHash(Code = 213, IsOptional = True)]
	public NpcPatternData[] NpcPatternList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35CA424 Offset: 0x35C6424 VA: 0x35CA424
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35CA42C Offset: 0x35C642C VA: 0x35CA42C
	public int get_NpcId() { }

	[CompilerGenerated]
	// RVA: 0x35CA434 Offset: 0x35C6434 VA: 0x35CA434
	public void set_NpcId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CA43C Offset: 0x35C643C VA: 0x35CA43C
	public NpcStatusData get_NpcStatus() { }

	[CompilerGenerated]
	// RVA: 0x35CA444 Offset: 0x35C6444 VA: 0x35CA444
	public void set_NpcStatus(NpcStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35CA44C Offset: 0x35C644C VA: 0x35CA44C
	public NpcEquipData get_NpcEquip() { }

	[CompilerGenerated]
	// RVA: 0x35CA454 Offset: 0x35C6454 VA: 0x35CA454
	public void set_NpcEquip(NpcEquipData value) { }

	[CompilerGenerated]
	// RVA: 0x35CA45C Offset: 0x35C645C VA: 0x35CA45C
	public NpcSettingData get_NpcSetting() { }

	[CompilerGenerated]
	// RVA: 0x35CA464 Offset: 0x35C6464 VA: 0x35CA464
	public void set_NpcSetting(NpcSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x35CA46C Offset: 0x35C646C VA: 0x35CA46C
	public NpcMotionData[] get_NpcMotionList() { }

	[CompilerGenerated]
	// RVA: 0x35CA474 Offset: 0x35C6474 VA: 0x35CA474
	public void set_NpcMotionList(NpcMotionData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35CA47C Offset: 0x35C647C VA: 0x35CA47C
	public NpcSkillData[] get_NpcSkillList() { }

	[CompilerGenerated]
	// RVA: 0x35CA484 Offset: 0x35C6484 VA: 0x35CA484
	public void set_NpcSkillList(NpcSkillData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35CA48C Offset: 0x35C648C VA: 0x35CA48C
	public NpcPatternData[] get_NpcPatternList() { }

	[CompilerGenerated]
	// RVA: 0x35CA494 Offset: 0x35C6494 VA: 0x35CA494
	public void set_NpcPatternList(NpcPatternData[] value) { }

	// RVA: 0x35CA49C Offset: 0x35C649C VA: 0x35CA49C
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CA9A0 Offset: 0x35C69A0 VA: 0x35CA9A0
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CAC10 Offset: 0x35C6C10 VA: 0x35CAC10 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35CAC18 Offset: 0x35C6C18 VA: 0x35CAC18 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35CAD78 Offset: 0x35C6D78 VA: 0x35CAD78 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
