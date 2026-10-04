// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BraveUp : PetSkillActionBase // TypeDefIndex: 3541
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

	// RVA: 0x2368094 Offset: 0x2364094 VA: 0x2368094 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x236809C Offset: 0x236409C VA: 0x236809C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23680A4 Offset: 0x23640A4 VA: 0x23680A4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23680AC Offset: 0x23640AC VA: 0x23680AC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23680B4 Offset: 0x23640B4 VA: 0x23680B4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23680BC Offset: 0x23640BC VA: 0x23680BC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23680C4 Offset: 0x23640C4 VA: 0x23680C4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23680CC Offset: 0x23640CC VA: 0x23680CC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23680D4 Offset: 0x23640D4 VA: 0x23680D4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23680DC Offset: 0x23640DC VA: 0x23680DC Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x23680E4 Offset: 0x23640E4 VA: 0x23680E4 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x23680EC Offset: 0x23640EC VA: 0x23680EC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23681B8 Offset: 0x23641B8 VA: 0x23681B8 Slot: 94
	protected override void OnPetSkillInitialize(CharacterActionManagerBase action, byte lv, PetAttackPatternData.PatternData motion) { }

	// RVA: 0x23681DC Offset: 0x23641DC VA: 0x23681DC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23683C4 Offset: 0x23643C4 VA: 0x23683C4
	public void .ctor() { }
}
