// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ConversionAction : PlayerAttackBase // TypeDefIndex: 3631
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23B3E7C Offset: 0x23AFE7C VA: 0x23B3E7C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B3E84 Offset: 0x23AFE84 VA: 0x23B3E84 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B3E8C Offset: 0x23AFE8C VA: 0x23B3E8C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B3E94 Offset: 0x23AFE94 VA: 0x23B3E94 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B3E9C Offset: 0x23AFE9C VA: 0x23B3E9C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B3EA4 Offset: 0x23AFEA4 VA: 0x23B3EA4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B3EAC Offset: 0x23AFEAC VA: 0x23B3EAC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B3EB4 Offset: 0x23AFEB4 VA: 0x23B3EB4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B3EBC Offset: 0x23AFEBC VA: 0x23B3EBC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B3EC4 Offset: 0x23AFEC4 VA: 0x23B3EC4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B3FB8 Offset: 0x23AFFB8 VA: 0x23B3FB8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B4180 Offset: 0x23B0180 VA: 0x23B4180 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23B4250 Offset: 0x23B0250 VA: 0x23B4250 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B42D0 Offset: 0x23B02D0 VA: 0x23B42D0
	public static bool CheckApplicationConversion(int type) { }

	// RVA: 0x23B42F4 Offset: 0x23B02F4 VA: 0x23B42F4
	public static int GetMasteryValue(int lv, MasteryId id) { }

	// RVA: 0x23B4304 Offset: 0x23B0304 VA: 0x23B4304
	public void .ctor() { }
}
