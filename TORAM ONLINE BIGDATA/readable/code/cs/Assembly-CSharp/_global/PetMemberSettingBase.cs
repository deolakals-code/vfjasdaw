// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetMemberSettingBase : NPCPartySettingBase // TypeDefIndex: 502
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x90
	[CompilerGenerated]
	private float <Height>k__BackingField; // 0x98
	[CompilerGenerated]
	private PetPersonalityType <Personal>k__BackingField; // 0x9C
	[CompilerGenerated]
	private PetType <Type>k__BackingField; // 0xA0
	[CompilerGenerated]
	private short <TamedPoint>k__BackingField; // 0xA4
	[CompilerGenerated]
	private short <Stamina>k__BackingField; // 0xA6
	[CompilerGenerated]
	private int <ColorR>k__BackingField; // 0xA8
	[CompilerGenerated]
	private int <ColorG>k__BackingField; // 0xAC
	[CompilerGenerated]
	private int <ColorB>k__BackingField; // 0xB0
	[CompilerGenerated]
	private SkillId <DefaultAttackID>k__BackingField; // 0xB4
	[CompilerGenerated]
	private PetAttackPatternData <PetAttackPatternData>k__BackingField; // 0xB8
	[CompilerGenerated]
	private PetBattleStatusData <BattleStatus>k__BackingField; // 0xC0
	[CompilerGenerated]
	private PetPotentialData <Potential>k__BackingField; // 0xC8
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0xD0
	[CompilerGenerated]
	private short <WeaponAtk>k__BackingField; // 0xD8
	[CompilerGenerated]
	private PetFoodEffectCalculator <FoodCalculator>k__BackingField; // 0xE0

	// Properties
	public string Name { get; set; }
	public float Height { get; set; }
	public PetPersonalityType Personal { get; set; }
	public PetType Type { get; set; }
	public short TamedPoint { get; set; }
	public short Stamina { get; set; }
	public int ColorR { get; set; }
	public int ColorG { get; set; }
	public int ColorB { get; set; }
	public SkillId DefaultAttackID { get; set; }
	public PetAttackPatternData PetAttackPatternData { get; set; }
	public PetBattleStatusData BattleStatus { get; set; }
	public PetPotentialData Potential { get; set; }
	public long PetUuid { get; set; }
	public short WeaponAtk { get; set; }
	public short LimitWeaponAtk { get; }
	public PetFoodEffectId FeedEffect { get; }
	public PetFoodEffectCalculator FoodCalculator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x182ABD0 Offset: 0x1826BD0 VA: 0x182ABD0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x182ABD8 Offset: 0x1826BD8 VA: 0x182ABD8
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x182ABE0 Offset: 0x1826BE0 VA: 0x182ABE0
	public float get_Height() { }

	[CompilerGenerated]
	// RVA: 0x182ABE8 Offset: 0x1826BE8 VA: 0x182ABE8
	public void set_Height(float value) { }

	[CompilerGenerated]
	// RVA: 0x182ABF0 Offset: 0x1826BF0 VA: 0x182ABF0
	public PetPersonalityType get_Personal() { }

	[CompilerGenerated]
	// RVA: 0x182ABF8 Offset: 0x1826BF8 VA: 0x182ABF8
	public void set_Personal(PetPersonalityType value) { }

	[CompilerGenerated]
	// RVA: 0x182AC00 Offset: 0x1826C00 VA: 0x182AC00
	public PetType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x182AC08 Offset: 0x1826C08 VA: 0x182AC08
	public void set_Type(PetType value) { }

	[CompilerGenerated]
	// RVA: 0x182AC10 Offset: 0x1826C10 VA: 0x182AC10
	public short get_TamedPoint() { }

	[CompilerGenerated]
	// RVA: 0x182AC18 Offset: 0x1826C18 VA: 0x182AC18
	public void set_TamedPoint(short value) { }

	[CompilerGenerated]
	// RVA: 0x182AC20 Offset: 0x1826C20 VA: 0x182AC20
	public short get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x182AC28 Offset: 0x1826C28 VA: 0x182AC28
	public void set_Stamina(short value) { }

	[CompilerGenerated]
	// RVA: 0x182AC30 Offset: 0x1826C30 VA: 0x182AC30
	public int get_ColorR() { }

	[CompilerGenerated]
	// RVA: 0x182AC38 Offset: 0x1826C38 VA: 0x182AC38
	public void set_ColorR(int value) { }

	[CompilerGenerated]
	// RVA: 0x182AC40 Offset: 0x1826C40 VA: 0x182AC40
	public int get_ColorG() { }

	[CompilerGenerated]
	// RVA: 0x182AC48 Offset: 0x1826C48 VA: 0x182AC48
	public void set_ColorG(int value) { }

	[CompilerGenerated]
	// RVA: 0x182AC50 Offset: 0x1826C50 VA: 0x182AC50
	public int get_ColorB() { }

	[CompilerGenerated]
	// RVA: 0x182AC58 Offset: 0x1826C58 VA: 0x182AC58
	public void set_ColorB(int value) { }

	[CompilerGenerated]
	// RVA: 0x182AC60 Offset: 0x1826C60 VA: 0x182AC60
	public SkillId get_DefaultAttackID() { }

	[CompilerGenerated]
	// RVA: 0x182AC68 Offset: 0x1826C68 VA: 0x182AC68
	public void set_DefaultAttackID(SkillId value) { }

	[CompilerGenerated]
	// RVA: 0x182AC70 Offset: 0x1826C70 VA: 0x182AC70
	public PetAttackPatternData get_PetAttackPatternData() { }

	[CompilerGenerated]
	// RVA: 0x182AC78 Offset: 0x1826C78 VA: 0x182AC78
	private void set_PetAttackPatternData(PetAttackPatternData value) { }

	[CompilerGenerated]
	// RVA: 0x182AC80 Offset: 0x1826C80 VA: 0x182AC80
	public PetBattleStatusData get_BattleStatus() { }

	[CompilerGenerated]
	// RVA: 0x182AC88 Offset: 0x1826C88 VA: 0x182AC88
	private void set_BattleStatus(PetBattleStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x182AC90 Offset: 0x1826C90 VA: 0x182AC90
	public PetPotentialData get_Potential() { }

	[CompilerGenerated]
	// RVA: 0x182AC98 Offset: 0x1826C98 VA: 0x182AC98
	private void set_Potential(PetPotentialData value) { }

	[CompilerGenerated]
	// RVA: 0x182ACA0 Offset: 0x1826CA0 VA: 0x182ACA0
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x182ACA8 Offset: 0x1826CA8 VA: 0x182ACA8
	private void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x182ACB0 Offset: 0x1826CB0 VA: 0x182ACB0
	public short get_WeaponAtk() { }

	[CompilerGenerated]
	// RVA: 0x182ACB8 Offset: 0x1826CB8 VA: 0x182ACB8
	public void set_WeaponAtk(short value) { }

	// RVA: 0x182ACC0 Offset: 0x1826CC0 VA: 0x182ACC0
	public short get_LimitWeaponAtk() { }

	// RVA: 0x182AD68 Offset: 0x1826D68 VA: 0x182AD68
	public PetFoodEffectId get_FeedEffect() { }

	[CompilerGenerated]
	// RVA: 0x182AD84 Offset: 0x1826D84 VA: 0x182AD84
	public PetFoodEffectCalculator get_FoodCalculator() { }

	[CompilerGenerated]
	// RVA: 0x182AD8C Offset: 0x1826D8C VA: 0x182AD8C
	private void set_FoodCalculator(PetFoodEffectCalculator value) { }

	// RVA: 0x182AD94 Offset: 0x1826D94 VA: 0x182AD94
	public void .ctor(PetArchetype response) { }

	// RVA: 0x182C578 Offset: 0x1828578 VA: 0x182C578
	public float GetPersonalEffectBonus(bool useFeedEffect) { }

	// RVA: 0x182BAC0 Offset: 0x1827AC0 VA: 0x182BAC0
	private static List<NPCPartySettingBase.Pattern> CreateLoopPattern(IEnumerable<NpcSkillData> notNormalSkill, PetPersonalityType Personal) { }

	// RVA: 0x182C01C Offset: 0x182801C VA: 0x182C01C
	private static List<NPCPartySettingBase.Pattern> CreateTacticalPattern(IEnumerable<NpcSkillData> notNormalSkill, PetPersonalityType Personal) { }

	// RVA: 0x182C5BC Offset: 0x18285BC VA: 0x182C5BC
	private float GetFeedEffectBonusRate() { }

	// RVA: 0x182BA20 Offset: 0x1827A20 VA: 0x182BA20
	private int GetRetreatFlag(byte persnal) { }
}
