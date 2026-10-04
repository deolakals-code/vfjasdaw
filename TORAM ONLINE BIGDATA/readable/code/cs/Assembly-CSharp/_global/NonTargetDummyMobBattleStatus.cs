// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NonTargetDummyMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 1051
{
	// Fields
	private MobPropertyManager mobProperty; // 0x10

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

	// RVA: 0x1F3EC4C Offset: 0x1F3AC4C VA: 0x1F3EC4C
	public void .ctor() { }

	// RVA: 0x1F3ECB8 Offset: 0x1F3ACB8 VA: 0x1F3ECB8 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F3ECBC Offset: 0x1F3ACBC VA: 0x1F3ECBC Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F3ECC4 Offset: 0x1F3ACC4 VA: 0x1F3ECC4 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1F3ECCC Offset: 0x1F3ACCC VA: 0x1F3ECCC Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F3ECD4 Offset: 0x1F3ACD4 VA: 0x1F3ECD4 Slot: 5
	public int get_Level() { }

	// RVA: 0x1F3ECDC Offset: 0x1F3ACDC VA: 0x1F3ECDC Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F3ECE4 Offset: 0x1F3ACE4 VA: 0x1F3ECE4 Slot: 7
	public int get_Def() { }

	// RVA: 0x1F3ECEC Offset: 0x1F3ACEC VA: 0x1F3ECEC Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F3ECF4 Offset: 0x1F3ACF4 VA: 0x1F3ECF4 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F3ECFC Offset: 0x1F3ACFC VA: 0x1F3ECFC Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F3ED04 Offset: 0x1F3AD04 VA: 0x1F3ED04 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F3ED0C Offset: 0x1F3AD0C VA: 0x1F3ED0C Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F3ED14 Offset: 0x1F3AD14 VA: 0x1F3ED14 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F3ED1C Offset: 0x1F3AD1C VA: 0x1F3ED1C Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F3ED24 Offset: 0x1F3AD24 VA: 0x1F3ED24 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F3ED2C Offset: 0x1F3AD2C VA: 0x1F3ED2C Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F3ED34 Offset: 0x1F3AD34 VA: 0x1F3ED34 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F3ED3C Offset: 0x1F3AD3C VA: 0x1F3ED3C Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F3ED44 Offset: 0x1F3AD44 VA: 0x1F3ED44 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F3ED4C Offset: 0x1F3AD4C VA: 0x1F3ED4C Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F3ED54 Offset: 0x1F3AD54 VA: 0x1F3ED54 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F3ED5C Offset: 0x1F3AD5C VA: 0x1F3ED5C Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F3ED64 Offset: 0x1F3AD64 VA: 0x1F3ED64 Slot: 23
	public MobPropertyManager get_Property() { }
}
