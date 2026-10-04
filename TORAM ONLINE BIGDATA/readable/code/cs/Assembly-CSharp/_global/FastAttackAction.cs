// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FastAttackAction : PlayerAttackBase // TypeDefIndex: 2558
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int costMp; // 0x128
	private int percent; // 0x12C
	private bool isDualSword; // 0x130

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

	// RVA: 0x21F30D4 Offset: 0x21EF0D4 VA: 0x21F30D4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F30DC Offset: 0x21EF0DC VA: 0x21F30DC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F30E4 Offset: 0x21EF0E4 VA: 0x21F30E4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F30EC Offset: 0x21EF0EC VA: 0x21F30EC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F30F4 Offset: 0x21EF0F4 VA: 0x21F30F4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F30FC Offset: 0x21EF0FC VA: 0x21F30FC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F3104 Offset: 0x21EF104 VA: 0x21F3104 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F310C Offset: 0x21EF10C VA: 0x21F310C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F3114 Offset: 0x21EF114 VA: 0x21F3114 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F354C Offset: 0x21EF54C VA: 0x21F354C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F3698 Offset: 0x21EF698 VA: 0x21F3698 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F380C Offset: 0x21EF80C VA: 0x21F380C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F3AE8 Offset: 0x21EFAE8 VA: 0x21F3AE8
	public void .ctor() { }
}
