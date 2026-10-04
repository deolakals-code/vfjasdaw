// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillComboState // TypeDefIndex: 3585
{
	// Fields
	private readonly SkillComboLine comboLine; // 0x10
	private int index; // 0x18
	private short totalCost; // 0x1C
	private SkillComboState.Values fixidValues; // 0x20
	private SkillComboState.Values tempValues; // 0x4C
	private int reduceMp; // 0x78
	[CompilerGenerated]
	private bool <IsNormalTermination>k__BackingField; // 0x7C
	[CompilerGenerated]
	private bool <IsHardHitEnd>k__BackingField; // 0x7D

	// Properties
	public SkillComboLine ComboLine { get; }
	public int Depth { get; }
	public short CurrentSkillId { get; }
	public byte CurrentComboType { get; }
	public short TotalCost { get; }
	public bool IsEnd { get; }
	public bool IsNormalTermination { get; set; }
	public bool IsHardHitEnd { get; set; }

	// Methods

	// RVA: 0x2394998 Offset: 0x2390998 VA: 0x2394998
	public SkillComboLine get_ComboLine() { }

	// RVA: 0x23949A0 Offset: 0x23909A0 VA: 0x23949A0
	public int get_Depth() { }

	// RVA: 0x239375C Offset: 0x238F75C VA: 0x239375C
	public short get_CurrentSkillId() { }

	// RVA: 0x2393908 Offset: 0x238F908 VA: 0x2393908
	public byte get_CurrentComboType() { }

	// RVA: 0x23949A8 Offset: 0x23909A8 VA: 0x23949A8
	public short get_TotalCost() { }

	// RVA: 0x2391EB8 Offset: 0x238DEB8 VA: 0x2391EB8
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x23949B0 Offset: 0x23909B0 VA: 0x23949B0
	public bool get_IsNormalTermination() { }

	[CompilerGenerated]
	// RVA: 0x23949B8 Offset: 0x23909B8 VA: 0x23949B8
	private void set_IsNormalTermination(bool value) { }

	[CompilerGenerated]
	// RVA: 0x23949C4 Offset: 0x23909C4 VA: 0x23949C4
	public bool get_IsHardHitEnd() { }

	[CompilerGenerated]
	// RVA: 0x23949CC Offset: 0x23909CC VA: 0x23949CC
	private void set_IsHardHitEnd(bool value) { }

	// RVA: 0x23937AC Offset: 0x238F7AC VA: 0x23937AC
	public void .ctor(SkillComboLine comboLine) { }

	// RVA: 0x2393AE8 Offset: 0x238FAE8 VA: 0x2393AE8
	public void .ctor(SkillComboState copy) { }

	// RVA: 0x23949D8 Offset: 0x23909D8 VA: 0x23949D8
	public void TemporaryUseSkill(PlayerStatusBase playerStatus, PlayerAttackBase skill) { }

	// RVA: 0x2393B7C Offset: 0x238FB7C VA: 0x2393B7C
	public bool UseSkill(PlayerAttackBase skill) { }

	// RVA: 0x2395B68 Offset: 0x2391B68 VA: 0x2395B68
	public void ReduceMp(PlayerAttackBase skill) { }

	// RVA: 0x2395BB0 Offset: 0x2391BB0 VA: 0x2395BB0
	public int GetThirdEyeValue() { }

	// RVA: 0x2395BE8 Offset: 0x2391BE8 VA: 0x2395BE8
	public void CheckThirdEye(MobActionManagerBase monster, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2396108 Offset: 0x2392108 VA: 0x2396108
	public bool CheckTenacityCost(PlayerStatusBase playerStatus) { }

	// RVA: 0x23963B8 Offset: 0x23923B8 VA: 0x23963B8
	public bool EnoughTenacityCost(PlayerStatusBase playerStatus) { }

	// RVA: 0x23964BC Offset: 0x23924BC VA: 0x23964BC
	public bool CheckInvincible() { }

	// RVA: 0x23964CC Offset: 0x23924CC VA: 0x23964CC
	public bool CheckBloody(PlayerStatusBase status) { }

	// RVA: 0x2393CF8 Offset: 0x238FCF8 VA: 0x2393CF8
	public bool CheckBloodSucking() { }

	// RVA: 0x23946B4 Offset: 0x23906B4 VA: 0x23946B4
	public int GetToughValue() { }

	// RVA: 0x23946DC Offset: 0x23906DC VA: 0x23946DC
	public bool CheckReflection() { }

	// RVA: 0x2394730 Offset: 0x2390730 VA: 0x2394730
	public bool ReceiveReflectionDamage() { }
}
