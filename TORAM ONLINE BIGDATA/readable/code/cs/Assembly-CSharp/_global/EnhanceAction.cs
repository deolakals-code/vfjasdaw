// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnhanceAction : PlayerAttackBase // TypeDefIndex: 3031
{
	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x230B73C Offset: 0x230773C VA: 0x230B73C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x230B744 Offset: 0x2307744 VA: 0x230B744 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230B74C Offset: 0x230774C VA: 0x230B74C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230B754 Offset: 0x2307754 VA: 0x230B754 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230B75C Offset: 0x230775C VA: 0x230B75C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230B764 Offset: 0x2307764 VA: 0x230B764 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230B76C Offset: 0x230776C VA: 0x230B76C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230B774 Offset: 0x2307774 VA: 0x230B774 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230B77C Offset: 0x230777C VA: 0x230B77C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230B784 Offset: 0x2307784 VA: 0x230B784 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230B89C Offset: 0x230789C VA: 0x230B89C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230B954 Offset: 0x2307954 VA: 0x230B954
	public static void AddEnhanceBuf(BattleMemberData member, byte skillLv, int type) { }

	// RVA: 0x230BBB8 Offset: 0x2307BB8 VA: 0x230BBB8
	public void .ctor() { }
}
