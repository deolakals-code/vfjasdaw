// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureHuntBossBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 1151
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

	// RVA: 0x1F6847C Offset: 0x1F6447C VA: 0x1F6847C Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	// RVA: 0x1F68484 Offset: 0x1F64484 VA: 0x1F68484 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F684A0 Offset: 0x1F644A0 VA: 0x1F684A0 Slot: 5
	public int get_Level() { }

	// RVA: 0x1F684BC Offset: 0x1F644BC VA: 0x1F684BC Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F68664 Offset: 0x1F64664 VA: 0x1F68664 Slot: 7
	public int get_Def() { }

	// RVA: 0x1F688EC Offset: 0x1F648EC VA: 0x1F688EC Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F68B74 Offset: 0x1F64B74 VA: 0x1F68B74 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F68D9C Offset: 0x1F64D9C VA: 0x1F68D9C Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F68FC4 Offset: 0x1F64FC4 VA: 0x1F68FC4 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F6924C Offset: 0x1F6524C VA: 0x1F6924C Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F69478 Offset: 0x1F65478 VA: 0x1F69478 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F671A4 Offset: 0x1F631A4 VA: 0x1F671A4 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F69494 Offset: 0x1F65494 VA: 0x1F69494 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F694B0 Offset: 0x1F654B0 VA: 0x1F694B0 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F694CC Offset: 0x1F654CC VA: 0x1F694CC Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F694D4 Offset: 0x1F654D4 VA: 0x1F694D4 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F6950C Offset: 0x1F6550C VA: 0x1F6950C Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F69540 Offset: 0x1F65540 VA: 0x1F69540 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F69558 Offset: 0x1F65558 VA: 0x1F69558 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F69570 Offset: 0x1F65570 VA: 0x1F69570 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F69588 Offset: 0x1F65588 VA: 0x1F69588 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F67644 Offset: 0x1F63644 VA: 0x1F67644
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager) { }

	// RVA: 0x1F695A4 Offset: 0x1F655A4 VA: 0x1F695A4 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F695AC Offset: 0x1F655AC VA: 0x1F695AC Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1F696BC Offset: 0x1F656BC VA: 0x1F696BC Slot: 29
	public void ClearParts() { }

	// RVA: 0x1F6970C Offset: 0x1F6570C VA: 0x1F6970C Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F69820 Offset: 0x1F65820 VA: 0x1F69820 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
