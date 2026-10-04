// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CutUp : PetSkillActionBase // TypeDefIndex: 3542
{
	// Fields
	private int isSupportStrong; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsSupport { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	protected override bool UseSkillEffect { get; }
	protected override int HitTakeId { get; }

	// Methods

	// RVA: 0x23683CC Offset: 0x23643CC VA: 0x23683CC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23683D4 Offset: 0x23643D4 VA: 0x23683D4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23683DC Offset: 0x23643DC VA: 0x23683DC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23683E4 Offset: 0x23643E4 VA: 0x23683E4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23683EC Offset: 0x23643EC VA: 0x23683EC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23683F4 Offset: 0x23643F4 VA: 0x23683F4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23683FC Offset: 0x23643FC VA: 0x23683FC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2368404 Offset: 0x2364404 VA: 0x2368404 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x236840C Offset: 0x236440C VA: 0x236840C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2368414 Offset: 0x2364414 VA: 0x2368414 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x236841C Offset: 0x236441C VA: 0x236841C Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2368424 Offset: 0x2364424 VA: 0x2368424 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23684F0 Offset: 0x23644F0 VA: 0x23684F0 Slot: 94
	protected override void OnPetSkillInitialize(CharacterActionManagerBase action, byte lv, PetAttackPatternData.PatternData motion) { }

	// RVA: 0x2368514 Offset: 0x2364514 VA: 0x2368514 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2368654 Offset: 0x2364654 VA: 0x2368654
	public void .ctor() { }
}
