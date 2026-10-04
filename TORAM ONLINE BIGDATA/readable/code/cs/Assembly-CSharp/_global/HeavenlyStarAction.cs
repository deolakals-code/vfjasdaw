// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HeavenlyStarAction : PlayerAttackBase // TypeDefIndex: 2836
{
	// Fields
	private float skillRate; // 0x120
	private float fixAddDamage; // 0x124
	private readonly int damageCount; // 0x128
	private int mp; // 0x12C
	private int stackLevel; // 0x130
	private bool isExpDefFluctuate; // 0x134

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	protected override bool IsMotionSpeedVariable { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x22921B0 Offset: 0x228E1B0 VA: 0x22921B0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22921B8 Offset: 0x228E1B8 VA: 0x22921B8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22921C0 Offset: 0x228E1C0 VA: 0x22921C0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22921C8 Offset: 0x228E1C8 VA: 0x22921C8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22921D0 Offset: 0x228E1D0 VA: 0x22921D0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22921D8 Offset: 0x228E1D8 VA: 0x22921D8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22921E0 Offset: 0x228E1E0 VA: 0x22921E0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22921E8 Offset: 0x228E1E8 VA: 0x22921E8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22921F0 Offset: 0x228E1F0 VA: 0x22921F0 Slot: 74
	protected override bool get_IsMotionSpeedVariable() { }

	// RVA: 0x22921F8 Offset: 0x228E1F8 VA: 0x22921F8 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2292200 Offset: 0x228E200 VA: 0x2292200 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2292388 Offset: 0x228E388 VA: 0x2292388 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x229244C Offset: 0x228E44C VA: 0x229244C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x229259C Offset: 0x228E59C VA: 0x229259C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2292874 Offset: 0x228E874 VA: 0x2292874 Slot: 85
	protected override bool CheckHit(PlayerStatusBase status, int needHit, int mp, bool isFlash, out bool correct) { }

	// RVA: 0x2292A48 Offset: 0x228EA48 VA: 0x2292A48 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2292E5C Offset: 0x228EE5C VA: 0x2292E5C
	public void .ctor() { }
}
