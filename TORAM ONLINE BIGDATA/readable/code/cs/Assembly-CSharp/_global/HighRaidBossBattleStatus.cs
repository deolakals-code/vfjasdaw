// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighRaidBossBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 891
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28
	private int mobLevel; // 0x30
	private Dictionary<int, MobPartsStatus> partsStatus; // 0x38

	// Properties
	private Dictionary<int, MobPartsStatus> IBossPartsStatus.PartsStatus { get; }
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

	// RVA: 0x1EFBF04 Offset: 0x1EF7F04 VA: 0x1EFBF04 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EFBF0C Offset: 0x1EF7F0C VA: 0x1EFBF0C Slot: 27
	private Dictionary<int, MobPartsStatus> IBossPartsStatus.get_PartsStatus() { }

	// RVA: 0x1EFBF14 Offset: 0x1EF7F14 VA: 0x1EFBF14 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1EFC050 Offset: 0x1EF8050 VA: 0x1EFC050 Slot: 5
	public int get_Level() { }

	// RVA: 0x1EFC058 Offset: 0x1EF8058 VA: 0x1EFC058 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EFC270 Offset: 0x1EF8270 VA: 0x1EFC270 Slot: 7
	public int get_Def() { }

	// RVA: 0x1EFC514 Offset: 0x1EF8514 VA: 0x1EFC514 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EFC7B8 Offset: 0x1EF87B8 VA: 0x1EFC7B8 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EFC9E8 Offset: 0x1EF89E8 VA: 0x1EFC9E8 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EFCC18 Offset: 0x1EF8C18 VA: 0x1EFCC18 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EFCEA0 Offset: 0x1EF8EA0 VA: 0x1EFCEA0 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EFD0CC Offset: 0x1EF90CC VA: 0x1EFD0CC Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EFD0E8 Offset: 0x1EF90E8 VA: 0x1EFD0E8 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EFD104 Offset: 0x1EF9104 VA: 0x1EFD104 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EFD120 Offset: 0x1EF9120 VA: 0x1EFD120 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EFD13C Offset: 0x1EF913C VA: 0x1EFD13C Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EFD144 Offset: 0x1EF9144 VA: 0x1EFD144 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EFD17C Offset: 0x1EF917C VA: 0x1EFD17C Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1EFD1B0 Offset: 0x1EF91B0 VA: 0x1EFD1B0 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EFD1C8 Offset: 0x1EF91C8 VA: 0x1EFD1C8 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EFD1E0 Offset: 0x1EF91E0 VA: 0x1EFD1E0 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EFD1F8 Offset: 0x1EF91F8 VA: 0x1EFD1F8 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1EFB098 Offset: 0x1EF7098 VA: 0x1EFB098
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalStateManager, MobBuffManager buffManager, int level) { }

	// RVA: 0x1EFD214 Offset: 0x1EF9214 VA: 0x1EFD214 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EFD328 Offset: 0x1EF9328 VA: 0x1EFD328 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1EFD43C Offset: 0x1EF943C VA: 0x1EFD43C Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1EFD54C Offset: 0x1EF954C VA: 0x1EFD54C Slot: 29
	public void ClearParts() { }

	// RVA: 0x1EFBFEC Offset: 0x1EF7FEC VA: 0x1EFBFEC
	private bool GetCalcExceptionFlag(out MobPropertyHighRaidCalcExceptionFlag flag) { }
}
