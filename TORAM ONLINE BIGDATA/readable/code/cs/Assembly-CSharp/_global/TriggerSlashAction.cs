// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TriggerSlashAction : PlayerAttackBase // TypeDefIndex: 2577
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int mp; // 0x128
	private bool oneHandSwordHit; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x21FEA44 Offset: 0x21FAA44 VA: 0x21FEA44 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21FEA4C Offset: 0x21FAA4C VA: 0x21FEA4C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21FEA54 Offset: 0x21FAA54 VA: 0x21FEA54 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21FEA5C Offset: 0x21FAA5C VA: 0x21FEA5C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21FEA64 Offset: 0x21FAA64 VA: 0x21FEA64 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21FEA6C Offset: 0x21FAA6C VA: 0x21FEA6C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21FEA74 Offset: 0x21FAA74 VA: 0x21FEA74 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21FEA7C Offset: 0x21FAA7C VA: 0x21FEA7C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21FEA84 Offset: 0x21FAA84 VA: 0x21FEA84 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21FECE4 Offset: 0x21FACE4 VA: 0x21FECE4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21FEE18 Offset: 0x21FAE18 VA: 0x21FEE18 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21FEF30 Offset: 0x21FAF30 VA: 0x21FEF30 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21FF188 Offset: 0x21FB188 VA: 0x21FF188
	public void .ctor() { }
}
