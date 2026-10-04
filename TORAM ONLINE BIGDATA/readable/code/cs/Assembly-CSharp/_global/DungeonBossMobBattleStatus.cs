// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DungeonBossMobBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 871
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private Dictionary<int, MobPartsStatus> partsStatus; // 0x28
	private MobStatus mobStatus; // 0x30
	private readonly int mobLevel; // 0x38
	private readonly int areaLevel; // 0x3C

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

	// RVA: 0x1EE6094 Offset: 0x1EE2094 VA: 0x1EE6094 Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	// RVA: 0x1EE609C Offset: 0x1EE209C VA: 0x1EE609C
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int playerLevel, int area, int day) { }

	// RVA: 0x1EE6194 Offset: 0x1EE2194 VA: 0x1EE6194 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EE619C Offset: 0x1EE219C VA: 0x1EE619C Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1EE62AC Offset: 0x1EE22AC VA: 0x1EE62AC Slot: 29
	public void ClearParts() { }

	// RVA: 0x1EE62FC Offset: 0x1EE22FC VA: 0x1EE62FC Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EE6690 Offset: 0x1EE2690 VA: 0x1EE6690 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1EE6A24 Offset: 0x1EE2A24 VA: 0x1EE6A24 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1EE6A90 Offset: 0x1EE2A90 VA: 0x1EE6A90 Slot: 5
	public int get_Level() { }

	// RVA: 0x1EE6A98 Offset: 0x1EE2A98 VA: 0x1EE6A98 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EE6410 Offset: 0x1EE2410 VA: 0x1EE6410 Slot: 7
	public int get_Def() { }

	// RVA: 0x1EE67A4 Offset: 0x1EE27A4 VA: 0x1EE67A4 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EE6C84 Offset: 0x1EE2C84 VA: 0x1EE6C84 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EE6CCC Offset: 0x1EE2CCC VA: 0x1EE6CCC Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EE6D14 Offset: 0x1EE2D14 VA: 0x1EE6D14 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EE6F9C Offset: 0x1EE2F9C VA: 0x1EE6F9C Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EE71C8 Offset: 0x1EE31C8 VA: 0x1EE71C8 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EE71E4 Offset: 0x1EE31E4 VA: 0x1EE71E4 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EE7394 Offset: 0x1EE3394 VA: 0x1EE7394 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EE73B0 Offset: 0x1EE33B0 VA: 0x1EE73B0 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EE73CC Offset: 0x1EE33CC VA: 0x1EE73CC Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EE7480 Offset: 0x1EE3480 VA: 0x1EE7480 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EE74E0 Offset: 0x1EE34E0 VA: 0x1EE74E0 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1EE7514 Offset: 0x1EE3514 VA: 0x1EE7514 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EE752C Offset: 0x1EE352C VA: 0x1EE752C Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EE7544 Offset: 0x1EE3544 VA: 0x1EE7544 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EE755C Offset: 0x1EE355C VA: 0x1EE755C Slot: 23
	public MobPropertyManager get_Property() { }
}
