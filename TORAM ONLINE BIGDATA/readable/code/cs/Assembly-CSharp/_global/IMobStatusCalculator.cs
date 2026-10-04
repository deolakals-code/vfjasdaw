// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IMobStatusCalculator // TypeDefIndex: 901
{
	// Properties
	public abstract int MaxHp { get; }
	public abstract int Level { get; }
	public abstract int NecessaryHit { get; }
	public abstract int Def { get; }
	public abstract int MagicDef { get; }
	public abstract int CutAttack { get; }
	public abstract int CutMagicAttack { get; }
	public abstract int GuardProbability { get; }
	public abstract int AvoidProbability { get; }
	public abstract ElementType Element { get; }
	public abstract int MoveSpeed { get; }
	public abstract byte Persona { get; }
	public abstract int PersonaValue { get; }
	public abstract float DamagePercent { get; }
	public abstract float NecessaryFleePercent { get; }
	public abstract float StablePercent { get; }
	public abstract int ExpDefNormal { get; }
	public abstract int ExpDefSkill { get; }
	public abstract int ExpDefMagic { get; }
	public abstract MobPropertyManager Property { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_MaxHp();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Level();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_NecessaryHit();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_Def();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_MagicDef();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_CutAttack();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_CutMagicAttack();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_GuardProbability();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_AvoidProbability();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ElementType get_Element();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_MoveSpeed();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract byte get_Persona();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_PersonaValue();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_DamagePercent();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_NecessaryFleePercent();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract float get_StablePercent();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int get_ExpDefNormal();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int get_ExpDefSkill();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int get_ExpDefMagic();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MobPropertyManager get_Property();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void SetMobStatus(MobStatus mobStatus);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int CalcDef(PlayerStatusBase status);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int CalcMdef(PlayerStatusBase status);
}
