// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveBossMobBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 1158
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

	// RVA: 0x1F6EBC0 Offset: 0x1F6ABC0 VA: 0x1F6EBC0 Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	// RVA: 0x1F6EBC8 Offset: 0x1F6ABC8 VA: 0x1F6EBC8 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F6EBE4 Offset: 0x1F6ABE4 VA: 0x1F6EBE4 Slot: 5
	public int get_Level() { }

	// RVA: 0x1F6EC00 Offset: 0x1F6AC00 VA: 0x1F6EC00 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F6EDA8 Offset: 0x1F6ADA8 VA: 0x1F6EDA8 Slot: 7
	public int get_Def() { }

	// RVA: 0x1F6EFF4 Offset: 0x1F6AFF4 VA: 0x1F6EFF4 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F6F240 Offset: 0x1F6B240 VA: 0x1F6F240 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F6F40C Offset: 0x1F6B40C VA: 0x1F6F40C Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F6F5D8 Offset: 0x1F6B5D8 VA: 0x1F6F5D8 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F6F860 Offset: 0x1F6B860 VA: 0x1F6F860 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F6FA8C Offset: 0x1F6BA8C VA: 0x1F6FA8C Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F6FAA8 Offset: 0x1F6BAA8 VA: 0x1F6FAA8 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F6FC58 Offset: 0x1F6BC58 VA: 0x1F6FC58 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F6FC74 Offset: 0x1F6BC74 VA: 0x1F6FC74 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F6FC90 Offset: 0x1F6BC90 VA: 0x1F6FC90 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F6FC98 Offset: 0x1F6BC98 VA: 0x1F6FC98 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F6FCD0 Offset: 0x1F6BCD0 VA: 0x1F6FCD0 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F6FD04 Offset: 0x1F6BD04 VA: 0x1F6FD04 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F6FD1C Offset: 0x1F6BD1C VA: 0x1F6FD1C Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F6FD34 Offset: 0x1F6BD34 VA: 0x1F6FD34 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F6FD4C Offset: 0x1F6BD4C VA: 0x1F6FD4C Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F6FD68 Offset: 0x1F6BD68 VA: 0x1F6FD68
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager) { }

	// RVA: 0x1F6FE34 Offset: 0x1F6BE34 VA: 0x1F6FE34 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F6FE3C Offset: 0x1F6BE3C VA: 0x1F6FE3C Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1F6FF4C Offset: 0x1F6BF4C VA: 0x1F6FF4C Slot: 29
	public void ClearParts() { }

	// RVA: 0x1F6FF9C Offset: 0x1F6BF9C VA: 0x1F6FF9C Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F700B0 Offset: 0x1F6C0B0 VA: 0x1F700B0 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
