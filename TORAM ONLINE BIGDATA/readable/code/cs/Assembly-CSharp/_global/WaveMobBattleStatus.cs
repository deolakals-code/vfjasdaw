// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 1162
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

	// RVA: 0x1F72830 Offset: 0x1F6E830 VA: 0x1F72830 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F7284C Offset: 0x1F6E84C VA: 0x1F7284C Slot: 5
	public int get_Level() { }

	// RVA: 0x1F72868 Offset: 0x1F6E868 VA: 0x1F72868 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F72884 Offset: 0x1F6E884 VA: 0x1F72884 Slot: 7
	public int get_Def() { }

	// RVA: 0x1F7297C Offset: 0x1F6E97C VA: 0x1F7297C Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F72AB0 Offset: 0x1F6EAB0 VA: 0x1F72AB0 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F72ACC Offset: 0x1F6EACC VA: 0x1F72ACC Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F72AE8 Offset: 0x1F6EAE8 VA: 0x1F72AE8 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F72BD4 Offset: 0x1F6EBD4 VA: 0x1F72BD4 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F72C40 Offset: 0x1F6EC40 VA: 0x1F72C40 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F7025C Offset: 0x1F6C25C VA: 0x1F7025C Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F72C5C Offset: 0x1F6EC5C VA: 0x1F72C5C Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F72C78 Offset: 0x1F6EC78 VA: 0x1F72C78 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F72C94 Offset: 0x1F6EC94 VA: 0x1F72C94 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F72C9C Offset: 0x1F6EC9C VA: 0x1F72C9C Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F72CD4 Offset: 0x1F6ECD4 VA: 0x1F72CD4 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F72D08 Offset: 0x1F6ED08 VA: 0x1F72D08 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F72D20 Offset: 0x1F6ED20 VA: 0x1F72D20 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F72D38 Offset: 0x1F6ED38 VA: 0x1F72D38 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F72D50 Offset: 0x1F6ED50 VA: 0x1F72D50 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F7031C Offset: 0x1F6C31C VA: 0x1F7031C
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager) { }

	// RVA: 0x1F72D6C Offset: 0x1F6ED6C VA: 0x1F72D6C Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F72D74 Offset: 0x1F6ED74 VA: 0x1F72D74 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F72E88 Offset: 0x1F6EE88 VA: 0x1F72E88 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
