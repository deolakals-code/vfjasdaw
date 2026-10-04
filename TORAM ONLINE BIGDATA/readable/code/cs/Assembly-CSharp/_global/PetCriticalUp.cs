// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetCriticalUp : PetSkillActionBase // TypeDefIndex: 3545
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

	// RVA: 0x2368AA0 Offset: 0x2364AA0 VA: 0x2368AA0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2368AA8 Offset: 0x2364AA8 VA: 0x2368AA8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2368AB0 Offset: 0x2364AB0 VA: 0x2368AB0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2368AB8 Offset: 0x2364AB8 VA: 0x2368AB8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2368AC0 Offset: 0x2364AC0 VA: 0x2368AC0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2368AC8 Offset: 0x2364AC8 VA: 0x2368AC8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2368AD0 Offset: 0x2364AD0 VA: 0x2368AD0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2368AD8 Offset: 0x2364AD8 VA: 0x2368AD8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2368AE0 Offset: 0x2364AE0 VA: 0x2368AE0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2368AE8 Offset: 0x2364AE8 VA: 0x2368AE8 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2368AF0 Offset: 0x2364AF0 VA: 0x2368AF0 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2368AF8 Offset: 0x2364AF8 VA: 0x2368AF8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2368BC4 Offset: 0x2364BC4 VA: 0x2368BC4 Slot: 94
	protected override void OnPetSkillInitialize(CharacterActionManagerBase action, byte lv, PetAttackPatternData.PatternData motion) { }

	// RVA: 0x2368BE8 Offset: 0x2364BE8 VA: 0x2368BE8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2368D28 Offset: 0x2364D28 VA: 0x2368D28
	public void .ctor() { }
}
