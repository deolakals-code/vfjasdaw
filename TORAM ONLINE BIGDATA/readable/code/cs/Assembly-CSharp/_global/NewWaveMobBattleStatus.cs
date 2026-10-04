// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewWaveMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 1050
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x30

	// Properties
	public int AvoidProbability { get; }
	public int GuardProbability { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public float DamagePercent { get; }
	public int Def { get; }
	public int MagicDef { get; }
	public ElementType Element { get; }
	public int Level { get; set; }
	public int MaxHp { get; }
	public int MoveSpeed { get; }
	public float NecessaryFleePercent { get; }
	public int NecessaryHit { get; }
	public byte Persona { get; }
	public int PersonaValue { get; }
	public float StablePercent { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int ExpDefMagic { get; }
	public MobPropertyManager Property { get; }

	// Methods

	// RVA: 0x1F3E2E0 Offset: 0x1F3A2E0 VA: 0x1F3E2E0 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F3E348 Offset: 0x1F3A348 VA: 0x1F3E348 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F3E428 Offset: 0x1F3A428 VA: 0x1F3E428 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F3E470 Offset: 0x1F3A470 VA: 0x1F3E470 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F3E4B8 Offset: 0x1F3A4B8 VA: 0x1F3E4B8 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F3E56C Offset: 0x1F3A56C VA: 0x1F3E56C Slot: 7
	public int get_Def() { }

	// RVA: 0x1F3E658 Offset: 0x1F3A658 VA: 0x1F3E658 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F3E780 Offset: 0x1F3A780 VA: 0x1F3E780 Slot: 13
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1F3E79C Offset: 0x1F3A79C VA: 0x1F3E79C Slot: 5
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1F3E7A4 Offset: 0x1F3A7A4 VA: 0x1F3E7A4
	private void set_Level(int value) { }

	// RVA: 0x1F3E7AC Offset: 0x1F3A7AC VA: 0x1F3E7AC Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F3CC9C Offset: 0x1F38C9C VA: 0x1F3CC9C Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F3E834 Offset: 0x1F3A834 VA: 0x1F3E834 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F3E894 Offset: 0x1F3A894 VA: 0x1F3E894 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F3E8EC Offset: 0x1F3A8EC VA: 0x1F3E8EC Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F3E908 Offset: 0x1F3A908 VA: 0x1F3E908 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F3E924 Offset: 0x1F3A924 VA: 0x1F3E924 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F3E958 Offset: 0x1F3A958 VA: 0x1F3E958 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F3E970 Offset: 0x1F3A970 VA: 0x1F3E970 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F3E988 Offset: 0x1F3A988 VA: 0x1F3E988 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F3E9A0 Offset: 0x1F3A9A0 VA: 0x1F3E9A0 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F3D954 Offset: 0x1F39954 VA: 0x1F3D954
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int level) { }

	// RVA: 0x1F3E9BC Offset: 0x1F3A9BC VA: 0x1F3E9BC Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F3E9C4 Offset: 0x1F3A9C4 VA: 0x1F3E9C4 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F3EB08 Offset: 0x1F3AB08 VA: 0x1F3EB08 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
