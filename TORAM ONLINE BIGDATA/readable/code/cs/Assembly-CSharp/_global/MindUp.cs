// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MindUp : PetSkillActionBase // TypeDefIndex: 3544
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

	// RVA: 0x2368810 Offset: 0x2364810 VA: 0x2368810 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2368818 Offset: 0x2364818 VA: 0x2368818 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2368820 Offset: 0x2364820 VA: 0x2368820 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2368828 Offset: 0x2364828 VA: 0x2368828 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2368830 Offset: 0x2364830 VA: 0x2368830 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2368838 Offset: 0x2364838 VA: 0x2368838 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2368840 Offset: 0x2364840 VA: 0x2368840 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2368848 Offset: 0x2364848 VA: 0x2368848 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2368850 Offset: 0x2364850 VA: 0x2368850 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2368858 Offset: 0x2364858 VA: 0x2368858 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2368860 Offset: 0x2364860 VA: 0x2368860 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2368868 Offset: 0x2364868 VA: 0x2368868 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2368934 Offset: 0x2364934 VA: 0x2368934 Slot: 94
	protected override void OnPetSkillInitialize(CharacterActionManagerBase action, byte lv, PetAttackPatternData.PatternData motion) { }

	// RVA: 0x2368958 Offset: 0x2364958 VA: 0x2368958 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2368A98 Offset: 0x2364A98 VA: 0x2368A98
	public void .ctor() { }
}
