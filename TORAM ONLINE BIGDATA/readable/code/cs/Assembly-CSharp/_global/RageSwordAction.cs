// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RageSwordAction : PlayerAttackBase // TypeDefIndex: 2751
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private bool isHateTarget; // 0x128

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

	// RVA: 0x2256350 Offset: 0x2252350 VA: 0x2256350 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2256358 Offset: 0x2252358 VA: 0x2256358 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2256360 Offset: 0x2252360 VA: 0x2256360 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2256368 Offset: 0x2252368 VA: 0x2256368 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2256370 Offset: 0x2252370 VA: 0x2256370 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2256378 Offset: 0x2252378 VA: 0x2256378 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2256380 Offset: 0x2252380 VA: 0x2256380 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2256388 Offset: 0x2252388 VA: 0x2256388 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2256390 Offset: 0x2252390 VA: 0x2256390 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2256684 Offset: 0x2252684 VA: 0x2256684 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22567D4 Offset: 0x22527D4 VA: 0x22567D4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22569A8 Offset: 0x22529A8 VA: 0x22569A8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2256D58 Offset: 0x2252D58 VA: 0x2256D58 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2256E68 Offset: 0x2252E68 VA: 0x2256E68
	public void .ctor() { }
}
