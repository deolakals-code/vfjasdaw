// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DeadlySpearAction : PlayerAttackBase // TypeDefIndex: 2668
{
	// Fields
	private float skillRate; // 0x120
	private float fixAddDamage; // 0x124
	private readonly int damageCount; // 0x128
	private int criticalPercent; // 0x12C
	private int resist; // 0x130
	private bool isCritical; // 0x134

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x222A0C8 Offset: 0x22260C8 VA: 0x222A0C8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x222A0D0 Offset: 0x22260D0 VA: 0x222A0D0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x222A0D8 Offset: 0x22260D8 VA: 0x222A0D8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x222A0E0 Offset: 0x22260E0 VA: 0x222A0E0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x222A0E8 Offset: 0x22260E8 VA: 0x222A0E8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x222A0F0 Offset: 0x22260F0 VA: 0x222A0F0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x222A0F8 Offset: 0x22260F8 VA: 0x222A0F8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x222A100 Offset: 0x2226100 VA: 0x222A100 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x222A108 Offset: 0x2226108 VA: 0x222A108 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x222A3A8 Offset: 0x22263A8 VA: 0x222A3A8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x222A42C Offset: 0x222642C VA: 0x222A42C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x222A58C Offset: 0x222658C VA: 0x222A58C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x222A888 Offset: 0x2226888 VA: 0x222A888 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x222A998 Offset: 0x2226998 VA: 0x222A998
	public void .ctor() { }
}
