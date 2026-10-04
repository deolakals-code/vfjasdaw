// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FlashStubAction : PlayerAttackBase // TypeDefIndex: 2683
{
	// Fields
	private float skillRate; // 0x120
	private float fixAddDamage; // 0x124
	private readonly int damageCount; // 0x128

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

	// Methods

	// RVA: 0x22327A8 Offset: 0x222E7A8 VA: 0x22327A8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22327B0 Offset: 0x222E7B0 VA: 0x22327B0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22327B8 Offset: 0x222E7B8 VA: 0x22327B8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22327C0 Offset: 0x222E7C0 VA: 0x22327C0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22327C8 Offset: 0x222E7C8 VA: 0x22327C8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22327D0 Offset: 0x222E7D0 VA: 0x22327D0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22327D8 Offset: 0x222E7D8 VA: 0x22327D8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22327E0 Offset: 0x222E7E0 VA: 0x22327E0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22327E8 Offset: 0x222E7E8 VA: 0x22327E8 Slot: 74
	protected override bool get_IsMotionSpeedVariable() { }

	// RVA: 0x22327F0 Offset: 0x222E7F0 VA: 0x22327F0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2232A3C Offset: 0x222EA3C VA: 0x2232A3C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2232AC0 Offset: 0x222EAC0 VA: 0x2232AC0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2232C10 Offset: 0x222EC10 VA: 0x2232C10 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2232E80 Offset: 0x222EE80 VA: 0x2232E80
	public void .ctor() { }
}
