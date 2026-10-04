// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DamageReflectionAction : PlayerAttackBase // TypeDefIndex: 1490
{
	// Fields
	private readonly int damageCount; // 0x120
	private const int DamageLimit = 99999;

	// Properties
	public override int ActionID { get; }
	public override bool NoCost { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsChatLog { get; }
	public override bool IsHideAttackApplied { get; }

	// Methods

	// RVA: 0x2061480 Offset: 0x205D480 VA: 0x2061480 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2061488 Offset: 0x205D488 VA: 0x2061488 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x2061490 Offset: 0x205D490 VA: 0x2061490 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2061498 Offset: 0x205D498 VA: 0x2061498 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x20614A0 Offset: 0x205D4A0 VA: 0x20614A0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x20614A8 Offset: 0x205D4A8 VA: 0x20614A8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x20614B0 Offset: 0x205D4B0 VA: 0x20614B0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x20614B8 Offset: 0x205D4B8 VA: 0x20614B8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x20614C0 Offset: 0x205D4C0 VA: 0x20614C0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x20614C8 Offset: 0x205D4C8 VA: 0x20614C8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x20614D0 Offset: 0x205D4D0 VA: 0x20614D0 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x20614D8 Offset: 0x205D4D8 VA: 0x20614D8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x20614E0 Offset: 0x205D4E0 VA: 0x20614E0 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x20614E8 Offset: 0x205D4E8 VA: 0x20614E8 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x20614F0 Offset: 0x205D4F0 VA: 0x20614F0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x20614FC Offset: 0x205D4FC VA: 0x20614FC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2061508 Offset: 0x205D508 VA: 0x2061508 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2061C28 Offset: 0x205DC28 VA: 0x2061C28
	public void .ctor() { }
}
