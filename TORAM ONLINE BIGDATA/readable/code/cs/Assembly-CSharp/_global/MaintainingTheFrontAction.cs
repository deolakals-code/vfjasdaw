// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MaintainingTheFrontAction : PlayerAttackBase // TypeDefIndex: 2948
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x22DF204 Offset: 0x22DB204 VA: 0x22DF204 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22DF20C Offset: 0x22DB20C VA: 0x22DF20C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22DF214 Offset: 0x22DB214 VA: 0x22DF214 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22DF21C Offset: 0x22DB21C VA: 0x22DF21C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22DF224 Offset: 0x22DB224 VA: 0x22DF224 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22DF22C Offset: 0x22DB22C VA: 0x22DF22C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22DF234 Offset: 0x22DB234 VA: 0x22DF234 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22DF23C Offset: 0x22DB23C VA: 0x22DF23C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22DF244 Offset: 0x22DB244 VA: 0x22DF244 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22DF24C Offset: 0x22DB24C VA: 0x22DF24C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22DF380 Offset: 0x22DB380 VA: 0x22DF380 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22DF440 Offset: 0x22DB440 VA: 0x22DF440 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DF7A0 Offset: 0x22DB7A0 VA: 0x22DF7A0
	private bool CheckHateTarget(Transform actorTransform, MobActionManagerBase target) { }

	// RVA: 0x22DFB84 Offset: 0x22DBB84 VA: 0x22DFB84
	public void .ctor() { }
}
