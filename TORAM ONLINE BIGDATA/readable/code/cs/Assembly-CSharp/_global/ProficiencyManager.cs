// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ProficiencyManager // TypeDefIndex: 1476
{
	// Fields
	private readonly int DefaultBlackSmithLimit; // 0x10
	private readonly int DefaultAlchemyLimit; // 0x14
	private readonly SkillId[] alchemyAbilityList; // 0x18
	[CompilerGenerated]
	private int <BlackSmith>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Alchemy>k__BackingField; // 0x24

	// Properties
	public int BlackSmith { get; set; }
	public int Alchemy { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x205A2EC Offset: 0x20562EC VA: 0x205A2EC
	public int get_BlackSmith() { }

	[CompilerGenerated]
	// RVA: 0x205A2F4 Offset: 0x20562F4 VA: 0x205A2F4
	private void set_BlackSmith(int value) { }

	[CompilerGenerated]
	// RVA: 0x205A2FC Offset: 0x20562FC VA: 0x205A2FC
	public int get_Alchemy() { }

	[CompilerGenerated]
	// RVA: 0x205A304 Offset: 0x2056304 VA: 0x205A304
	private void set_Alchemy(int value) { }

	// RVA: 0x205A30C Offset: 0x205630C VA: 0x205A30C
	public int GetBlackSmithLimit(SkillManager skillManager) { }

	// RVA: 0x205A3BC Offset: 0x20563BC VA: 0x205A3BC
	public int GetAlchemyLimit(SkillManager skillManager) { }

	// RVA: 0x205A4F0 Offset: 0x20564F0 VA: 0x205A4F0
	public bool IsLimitBlackSmith(SkillManager skillManager) { }

	// RVA: 0x205A50C Offset: 0x205650C VA: 0x205A50C
	public bool IsLimitAlchemy(SkillManager skillManager) { }

	// RVA: 0x205A528 Offset: 0x2056528 VA: 0x205A528
	public bool IsOverBlackSmithLimit(SkillManager skillManager) { }

	// RVA: 0x205A544 Offset: 0x2056544 VA: 0x205A544
	public bool IsOverAlchemyLimit(SkillManager skillManager) { }

	// RVA: 0x205A560 Offset: 0x2056560 VA: 0x205A560
	public int BlackSmithLimitLevel(SkillManager skillManager) { }

	// RVA: 0x205A310 Offset: 0x2056310 VA: 0x205A310
	private int getBlackSmithLimitIncreaseBySkill(SkillManager skillManager) { }

	// RVA: 0x205A3C0 Offset: 0x20563C0 VA: 0x205A3C0
	private int getAlchemyLimitIncreaseBySkill(SkillManager skillManager) { }

	// RVA: 0x205A5B8 Offset: 0x20565B8 VA: 0x205A5B8
	public void Initialize(ProficiencyData proficiency) { }

	// RVA: 0x205A5D4 Offset: 0x20565D4 VA: 0x205A5D4
	public void UpdateBlackSmith(int blackSmith) { }

	// RVA: 0x205A5DC Offset: 0x20565DC VA: 0x205A5DC
	public void UpdateAlchemy(int alchemy) { }

	// RVA: 0x205A5E4 Offset: 0x20565E4 VA: 0x205A5E4
	public void .ctor() { }
}
