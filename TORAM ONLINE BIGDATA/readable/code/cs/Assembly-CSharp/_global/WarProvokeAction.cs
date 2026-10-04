// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WarProvokeAction : PlayerAttackBase // TypeDefIndex: 2934
{
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

	// RVA: 0x22D8CB8 Offset: 0x22D4CB8 VA: 0x22D8CB8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D8CC0 Offset: 0x22D4CC0 VA: 0x22D8CC0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D8CC8 Offset: 0x22D4CC8 VA: 0x22D8CC8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D8CD0 Offset: 0x22D4CD0 VA: 0x22D8CD0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D8CD8 Offset: 0x22D4CD8 VA: 0x22D8CD8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D8CE0 Offset: 0x22D4CE0 VA: 0x22D8CE0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D8CE8 Offset: 0x22D4CE8 VA: 0x22D8CE8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D8CF0 Offset: 0x22D4CF0 VA: 0x22D8CF0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D8CF8 Offset: 0x22D4CF8 VA: 0x22D8CF8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D8DF8 Offset: 0x22D4DF8 VA: 0x22D8DF8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D8E78 Offset: 0x22D4E78 VA: 0x22D8E78 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D8FD8 Offset: 0x22D4FD8 VA: 0x22D8FD8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22D9064 Offset: 0x22D5064 VA: 0x22D9064 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22D911C Offset: 0x22D511C VA: 0x22D911C
	public void .ctor() { }
}
