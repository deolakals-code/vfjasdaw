// Assembly: Assembly-CSharp.dll
// Namespace: 
public class VerticalAirAction : PlayerAttackBase // TypeDefIndex: 2716
{
	// Fields
	private float[] skillRate; // 0x120
	private int[] fixAddDamage; // 0x128
	private int[] physicsResist; // 0x130
	private int damageCount; // 0x138
	private byte invincibilityLocalId; // 0x13C

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

	// RVA: 0x22479A0 Offset: 0x22439A0 VA: 0x22479A0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22479A8 Offset: 0x22439A8 VA: 0x22479A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22479B0 Offset: 0x22439B0 VA: 0x22479B0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22479B8 Offset: 0x22439B8 VA: 0x22479B8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22479C0 Offset: 0x22439C0 VA: 0x22479C0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22479C8 Offset: 0x22439C8 VA: 0x22479C8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22479D0 Offset: 0x22439D0 VA: 0x22479D0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22479D8 Offset: 0x22439D8 VA: 0x22479D8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22479E0 Offset: 0x22439E0 VA: 0x22479E0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2247C58 Offset: 0x2243C58 VA: 0x2247C58 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2247D1C Offset: 0x2243D1C VA: 0x2247D1C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2247E68 Offset: 0x2243E68 VA: 0x2247E68 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2248298 Offset: 0x2244298 VA: 0x2248298 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2248388 Offset: 0x2244388 VA: 0x2248388
	public void .ctor() { }
}
