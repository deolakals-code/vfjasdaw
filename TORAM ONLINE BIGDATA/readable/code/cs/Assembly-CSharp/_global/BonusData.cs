// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class BonusData // TypeDefIndex: 1729
{
	// Fields
	private static readonly List<BonusType> Bonus; // 0x0
	private static readonly List<BonusType> Duration; // 0x8
	private static readonly List<BonusType> Script; // 0x10
	private static readonly List<BonusType> EqLimit; // 0x18
	private static readonly List<BonusType> EquipmentBuff; // 0x20
	private static readonly List<BonusType> Debuff; // 0x28
	private static readonly Dictionary<BonusData.BonusCategoryType, List<BonusType>> BonusCategory; // 0x30
	private BonusScriptData scriptData; // 0x10
	private List<BonusType> bonusTypeList; // 0x18
	private List<ReflectionBonusParameter> bonusList; // 0x20
	private List<BonusType> buffTypeList; // 0x28
	private List<BonusParameter> buffList; // 0x30
	private List<BonusParameter> debuffList; // 0x38
	[CompilerGenerated]
	private bool <HasScript>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <EqLimitScript>k__BackingField; // 0x41
	[CompilerGenerated]
	private BonusType <DurationBonusType>k__BackingField; // 0x44
	[CompilerGenerated]
	private bool <IsAvatarSkill>k__BackingField; // 0x48
	[CompilerGenerated]
	private BonusParameter <AvatarSkillData>k__BackingField; // 0x50

	// Properties
	public bool HasScript { get; set; }
	public bool EqLimitScript { get; set; }
	public BonusScriptData ScriptData { get; }
	public List<ReflectionBonusParameter> BonusDataList { get; }
	public List<BonusType> BonusTypeList { get; }
	public BonusType DurationBonusType { get; set; }
	public List<BonusParameter> BuffList { get; }
	public List<BonusParameter> DebuffList { get; }
	public bool IsAvatarSkill { get; set; }
	public BonusParameter AvatarSkillData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20AFE0C Offset: 0x20ABE0C VA: 0x20AFE0C
	public bool get_HasScript() { }

	[CompilerGenerated]
	// RVA: 0x20AFE14 Offset: 0x20ABE14 VA: 0x20AFE14
	private void set_HasScript(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20AFE20 Offset: 0x20ABE20 VA: 0x20AFE20
	public bool get_EqLimitScript() { }

	[CompilerGenerated]
	// RVA: 0x20AFE28 Offset: 0x20ABE28 VA: 0x20AFE28
	private void set_EqLimitScript(bool value) { }

	// RVA: 0x20AFE34 Offset: 0x20ABE34 VA: 0x20AFE34
	public BonusScriptData get_ScriptData() { }

	// RVA: 0x20AFE3C Offset: 0x20ABE3C VA: 0x20AFE3C
	public List<ReflectionBonusParameter> get_BonusDataList() { }

	// RVA: 0x20AFE44 Offset: 0x20ABE44 VA: 0x20AFE44
	public List<BonusType> get_BonusTypeList() { }

	[CompilerGenerated]
	// RVA: 0x20AFE4C Offset: 0x20ABE4C VA: 0x20AFE4C
	public BonusType get_DurationBonusType() { }

	[CompilerGenerated]
	// RVA: 0x20AFE54 Offset: 0x20ABE54 VA: 0x20AFE54
	private void set_DurationBonusType(BonusType value) { }

	// RVA: 0x20AFE5C Offset: 0x20ABE5C VA: 0x20AFE5C
	public List<BonusParameter> get_BuffList() { }

	// RVA: 0x20AFE64 Offset: 0x20ABE64 VA: 0x20AFE64
	public List<BonusParameter> get_DebuffList() { }

	[CompilerGenerated]
	// RVA: 0x20AFE6C Offset: 0x20ABE6C VA: 0x20AFE6C
	public bool get_IsAvatarSkill() { }

	[CompilerGenerated]
	// RVA: 0x20AFE74 Offset: 0x20ABE74 VA: 0x20AFE74
	private void set_IsAvatarSkill(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20AFE80 Offset: 0x20ABE80 VA: 0x20AFE80
	public BonusParameter get_AvatarSkillData() { }

	[CompilerGenerated]
	// RVA: 0x20AFE88 Offset: 0x20ABE88 VA: 0x20AFE88
	private void set_AvatarSkillData(BonusParameter value) { }

	// RVA: 0x20AFE90 Offset: 0x20ABE90 VA: 0x20AFE90
	public void .ctor(IList<BonusParameter> bonusLines) { }

	// RVA: 0x20B07A8 Offset: 0x20AC7A8 VA: 0x20B07A8
	public void ClearScript() { }

	// RVA: 0x20B07B4 Offset: 0x20AC7B4 VA: 0x20B07B4
	public void UpdateBonusList() { }

	// RVA: 0x20B0C58 Offset: 0x20ACC58 VA: 0x20B0C58
	private static void .cctor() { }
}
