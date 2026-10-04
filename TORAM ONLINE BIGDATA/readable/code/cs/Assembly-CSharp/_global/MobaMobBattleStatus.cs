// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 910
{
	// Fields
	public const int MaxHPRate = 1000000;
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus status; // 0x28
	private int level; // 0x30

	// Properties
	public int MaxHp { get; }
	public int Level { get; }
	public int NecessaryHit { get; }
	public int Def { get; }
	public int MagicDef { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public int GuardProbability { get; }
	public int AvoidProbability { get; }
	public ElementType Element { get; }
	public int MoveSpeed { get; }
	public byte Persona { get; }
	public int PersonaValue { get; }
	public float DamagePercent { get; }
	public float NecessaryFleePercent { get; }
	public float StablePercent { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int ExpDefMagic { get; }
	public MobPropertyManager Property { get; }

	// Methods

	// RVA: 0x1F027D4 Offset: 0x1EFE7D4 VA: 0x1F027D4 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F027E0 Offset: 0x1EFE7E0 VA: 0x1F027E0 Slot: 5
	public int get_Level() { }

	// RVA: 0x1F027E8 Offset: 0x1EFE7E8 VA: 0x1F027E8 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F02804 Offset: 0x1EFE804 VA: 0x1F02804 Slot: 7
	public int get_Def() { }

	// RVA: 0x1F02820 Offset: 0x1EFE820 VA: 0x1F02820 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F0283C Offset: 0x1EFE83C VA: 0x1F0283C Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F02858 Offset: 0x1EFE858 VA: 0x1F02858 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F02874 Offset: 0x1EFE874 VA: 0x1F02874 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F02890 Offset: 0x1EFE890 VA: 0x1F02890 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F028AC Offset: 0x1EFE8AC VA: 0x1F028AC Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F028C8 Offset: 0x1EFE8C8 VA: 0x1F028C8 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F028E4 Offset: 0x1EFE8E4 VA: 0x1F028E4 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F02900 Offset: 0x1EFE900 VA: 0x1F02900 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F0291C Offset: 0x1EFE91C VA: 0x1F0291C Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F029D0 Offset: 0x1EFE9D0 VA: 0x1F029D0 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F02A50 Offset: 0x1EFEA50 VA: 0x1F02A50 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F02AA8 Offset: 0x1EFEAA8 VA: 0x1F02AA8 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F02AC0 Offset: 0x1EFEAC0 VA: 0x1F02AC0 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F02AD8 Offset: 0x1EFEAD8 VA: 0x1F02AD8 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F02AF0 Offset: 0x1EFEAF0 VA: 0x1F02AF0 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F006A0 Offset: 0x1EFC6A0 VA: 0x1F006A0
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager) { }

	// RVA: 0x1F02B0C Offset: 0x1EFEB0C VA: 0x1F02B0C Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F02B28 Offset: 0x1EFEB28 VA: 0x1F02B28 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1F02B44 Offset: 0x1EFEB44 VA: 0x1F02B44 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F02B4C Offset: 0x1EFEB4C VA: 0x1F02B4C
	public void LevelAdjustment(int actorPopAreaNo, int targetPopAreaNo, int targetOwnerLevel, int targetLevel) { }
}
