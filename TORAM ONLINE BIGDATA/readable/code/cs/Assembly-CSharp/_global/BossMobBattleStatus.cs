// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BossMobBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 848
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private readonly short difficulty; // 0x28
	private Dictionary<int, MobPartsStatus> partsStatus; // 0x30
	private MobStatus mobStatus; // 0x38

	// Properties
	public Dictionary<int, MobPartsStatus> PartsStatus { get; }
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

	// RVA: 0x1ECBE64 Offset: 0x1EC7E64 VA: 0x1ECBE64 Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	// RVA: 0x1ECACD0 Offset: 0x1EC6CD0 VA: 0x1ECACD0
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, short difficulty) { }

	// RVA: 0x1ECBE6C Offset: 0x1EC7E6C VA: 0x1ECBE6C Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1ECBE74 Offset: 0x1EC7E74 VA: 0x1ECBE74 Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1ECBF84 Offset: 0x1EC7F84 VA: 0x1ECBF84 Slot: 29
	public void ClearParts() { }

	// RVA: 0x1ECBFD4 Offset: 0x1EC7FD4 VA: 0x1ECBFD4 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1ECC3AC Offset: 0x1EC83AC VA: 0x1ECC3AC Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1ECC784 Offset: 0x1EC8784 VA: 0x1ECC784 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1ECC7F4 Offset: 0x1EC87F4 VA: 0x1ECC7F4 Slot: 5
	public int get_Level() { }

	// RVA: 0x1ECC86C Offset: 0x1EC886C VA: 0x1ECC86C Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1ECC0E8 Offset: 0x1EC80E8 VA: 0x1ECC0E8 Slot: 7
	public int get_Def() { }

	// RVA: 0x1ECC4C0 Offset: 0x1EC84C0 VA: 0x1ECC4C0 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1ECCA54 Offset: 0x1EC8A54 VA: 0x1ECCA54 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1ECCC20 Offset: 0x1EC8C20 VA: 0x1ECCC20 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1ECCDEC Offset: 0x1EC8DEC VA: 0x1ECCDEC Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1ECD070 Offset: 0x1EC9070 VA: 0x1ECD070 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1ECD298 Offset: 0x1EC9298 VA: 0x1ECD298 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1ECD2B4 Offset: 0x1EC92B4 VA: 0x1ECD2B4 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1ECD464 Offset: 0x1EC9464 VA: 0x1ECD464 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1ECD480 Offset: 0x1EC9480 VA: 0x1ECD480 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1ECD49C Offset: 0x1EC949C VA: 0x1ECD49C Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1ECD4A4 Offset: 0x1EC94A4 VA: 0x1ECD4A4 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1ECD4DC Offset: 0x1EC94DC VA: 0x1ECD4DC Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1ECD510 Offset: 0x1EC9510 VA: 0x1ECD510 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1ECD528 Offset: 0x1EC9528 VA: 0x1ECD528 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1ECD540 Offset: 0x1EC9540 VA: 0x1ECD540 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1ECD558 Offset: 0x1EC9558 VA: 0x1ECD558 Slot: 23
	public MobPropertyManager get_Property() { }
}
