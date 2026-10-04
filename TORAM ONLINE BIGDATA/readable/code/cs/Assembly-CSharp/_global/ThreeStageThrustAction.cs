// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ThreeStageThrustAction : PlayerAttackBase // TypeDefIndex: 2868
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

	// Methods

	// RVA: 0x22A2088 Offset: 0x229E088 VA: 0x22A2088 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22A2090 Offset: 0x229E090 VA: 0x22A2090 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22A2098 Offset: 0x229E098 VA: 0x22A2098 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22A20A0 Offset: 0x229E0A0 VA: 0x22A20A0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22A20A8 Offset: 0x229E0A8 VA: 0x22A20A8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22A20B0 Offset: 0x229E0B0 VA: 0x22A20B0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22A20B8 Offset: 0x229E0B8 VA: 0x22A20B8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22A20C0 Offset: 0x229E0C0 VA: 0x22A20C0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22A20C8 Offset: 0x229E0C8 VA: 0x22A20C8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22A235C Offset: 0x229E35C VA: 0x22A235C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22A2434 Offset: 0x229E434 VA: 0x22A2434 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22A26F0 Offset: 0x229E6F0 VA: 0x22A26F0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22A27E0 Offset: 0x229E7E0 VA: 0x22A27E0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22A29FC Offset: 0x229E9FC VA: 0x22A29FC
	public void .ctor() { }
}
