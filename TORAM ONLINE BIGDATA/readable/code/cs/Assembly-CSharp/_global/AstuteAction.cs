// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AstuteAction : PlayerAttackBase // TypeDefIndex: 2551
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int cost; // 0x128

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool IsMotionSpeedVariable { get; }

	// Methods

	// RVA: 0x21EF55C Offset: 0x21EB55C VA: 0x21EF55C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21EF564 Offset: 0x21EB564 VA: 0x21EF564 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21EF56C Offset: 0x21EB56C VA: 0x21EF56C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21EF574 Offset: 0x21EB574 VA: 0x21EF574 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21EF57C Offset: 0x21EB57C VA: 0x21EF57C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21EF584 Offset: 0x21EB584 VA: 0x21EF584 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21EF58C Offset: 0x21EB58C VA: 0x21EF58C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21EF594 Offset: 0x21EB594 VA: 0x21EF594 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21EF59C Offset: 0x21EB59C VA: 0x21EF59C Slot: 74
	protected override bool get_IsMotionSpeedVariable() { }

	// RVA: 0x21EF5A4 Offset: 0x21EB5A4 VA: 0x21EF5A4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21EF798 Offset: 0x21EB798 VA: 0x21EF798 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21EF81C Offset: 0x21EB81C VA: 0x21EF81C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21EF96C Offset: 0x21EB96C VA: 0x21EF96C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21EFBEC Offset: 0x21EBBEC VA: 0x21EFBEC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21EFD28 Offset: 0x21EBD28 VA: 0x21EFD28
	public void .ctor() { }
}
