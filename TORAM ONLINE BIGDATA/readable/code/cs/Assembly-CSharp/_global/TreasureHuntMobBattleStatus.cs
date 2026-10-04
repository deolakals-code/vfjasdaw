// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureHuntMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 1155
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28

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

	// RVA: 0x1F69A84 Offset: 0x1F65A84 VA: 0x1F69A84
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager) { }

	// RVA: 0x1F6BAC8 Offset: 0x1F67AC8 VA: 0x1F6BAC8 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F6BAE4 Offset: 0x1F67AE4 VA: 0x1F6BAE4 Slot: 5
	public int get_Level() { }

	// RVA: 0x1F6BB00 Offset: 0x1F67B00 VA: 0x1F6BB00 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F6BB1C Offset: 0x1F67B1C VA: 0x1F6BB1C Slot: 7
	public int get_Def() { }

	// RVA: 0x1F6BC14 Offset: 0x1F67C14 VA: 0x1F6BC14 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F6BD48 Offset: 0x1F67D48 VA: 0x1F6BD48 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F6BD64 Offset: 0x1F67D64 VA: 0x1F6BD64 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F6BD80 Offset: 0x1F67D80 VA: 0x1F6BD80 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F6BE6C Offset: 0x1F67E6C VA: 0x1F6BE6C Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F6BED8 Offset: 0x1F67ED8 VA: 0x1F6BED8 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F699CC Offset: 0x1F659CC VA: 0x1F699CC Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F6BEF4 Offset: 0x1F67EF4 VA: 0x1F6BEF4 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F6BF10 Offset: 0x1F67F10 VA: 0x1F6BF10 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F6BF2C Offset: 0x1F67F2C VA: 0x1F6BF2C Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F6BF34 Offset: 0x1F67F34 VA: 0x1F6BF34 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F6BF6C Offset: 0x1F67F6C VA: 0x1F6BF6C Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F6BFA0 Offset: 0x1F67FA0 VA: 0x1F6BFA0 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F6BFB8 Offset: 0x1F67FB8 VA: 0x1F6BFB8 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F6BFD0 Offset: 0x1F67FD0 VA: 0x1F6BFD0 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F6BFE8 Offset: 0x1F67FE8 VA: 0x1F6BFE8 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F6C004 Offset: 0x1F68004 VA: 0x1F6C004 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F6C00C Offset: 0x1F6800C VA: 0x1F6C00C Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F6C120 Offset: 0x1F68120 VA: 0x1F6C120 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
