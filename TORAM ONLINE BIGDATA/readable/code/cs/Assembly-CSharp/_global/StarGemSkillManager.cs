// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StarGemSkillManager // TypeDefIndex: 3790
{
	// Fields
	private const int STARJEM_MAX_COST = 10;
	private MasterSkillDataManager masterSkillManager; // 0x10
	private List<SkillData> equipSkillList; // 0x18
	[CompilerGenerated]
	private bool <IsDuplication>k__BackingField; // 0x20

	// Properties
	public int EquipCost { get; }
	public int MaxCost { get; }
	public bool IsOverCost { get; }
	public bool IsDuplication { get; set; }
	public bool IsNoAction { get; }

	// Methods

	// RVA: 0x23E6DC4 Offset: 0x23E2DC4 VA: 0x23E6DC4
	public int get_EquipCost() { }

	// RVA: 0x23E7310 Offset: 0x23E3310 VA: 0x23E7310
	public int get_MaxCost() { }

	// RVA: 0x23E73B4 Offset: 0x23E33B4 VA: 0x23E73B4
	public bool get_IsOverCost() { }

	[CompilerGenerated]
	// RVA: 0x23E73D4 Offset: 0x23E33D4 VA: 0x23E73D4
	public bool get_IsDuplication() { }

	[CompilerGenerated]
	// RVA: 0x23E73DC Offset: 0x23E33DC VA: 0x23E73DC
	private void set_IsDuplication(bool value) { }

	// RVA: 0x23E63DC Offset: 0x23E23DC VA: 0x23E63DC
	public bool get_IsNoAction() { }

	// RVA: 0x23E64D0 Offset: 0x23E24D0 VA: 0x23E64D0
	public void .ctor() { }

	// RVA: 0x23E6618 Offset: 0x23E2618 VA: 0x23E6618
	public void InitializeEquip(StarGemEquipData[] equips) { }

	// RVA: 0x23E73F0 Offset: 0x23E33F0 VA: 0x23E73F0
	public SkillData[] GetAllSkills() { }

	// RVA: 0x23E7464 Offset: 0x23E3464 VA: 0x23E7464
	public SkillData[] GetActiveSkills() { }

	// RVA: 0x23E76E4 Offset: 0x23E36E4 VA: 0x23E76E4
	public SkillData[] GetMasterySkills() { }

	// RVA: 0x23E6F4C Offset: 0x23E2F4C VA: 0x23E6F4C
	public bool Reinforce(SkillId skillId, byte sourceLv, byte destinationLv) { }

	// RVA: 0x23E69DC Offset: 0x23E29DC VA: 0x23E69DC
	public bool EquipSkill(SkillId skillId, byte lv, bool ignoreCost = False, bool isDuplication = False) { }

	// RVA: 0x23E70E0 Offset: 0x23E30E0 VA: 0x23E70E0
	public bool RemoveSkill(SkillId skillId, byte lv) { }

	// RVA: 0x23E6954 Offset: 0x23E2954 VA: 0x23E6954
	public void Clear() { }

	// RVA: 0x23E797C Offset: 0x23E397C VA: 0x23E797C
	public static int CalcMaxCost(int lv) { }
}
