// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BeautiesOfNatureAction : PlayerAttackBase // TypeDefIndex: 2596
{
	// Fields
	private const int MaxDamageCount = 4;
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float attackRange; // 0x128
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x130

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

	// RVA: 0x2206EB8 Offset: 0x2202EB8 VA: 0x2206EB8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2206EC0 Offset: 0x2202EC0 VA: 0x2206EC0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2206EC8 Offset: 0x2202EC8 VA: 0x2206EC8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2206ED0 Offset: 0x2202ED0 VA: 0x2206ED0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2206ED8 Offset: 0x2202ED8 VA: 0x2206ED8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2206EE0 Offset: 0x2202EE0 VA: 0x2206EE0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2206EE8 Offset: 0x2202EE8 VA: 0x2206EE8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2206EF0 Offset: 0x2202EF0 VA: 0x2206EF0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2206EF8 Offset: 0x2202EF8 VA: 0x2206EF8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2207100 Offset: 0x2203100 VA: 0x2207100 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22071C4 Offset: 0x22031C4 VA: 0x22071C4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22073FC Offset: 0x22033FC VA: 0x22073FC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2207518 Offset: 0x2203518 VA: 0x2207518 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2207588 Offset: 0x2203588 VA: 0x2207588 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2207B04 Offset: 0x2203B04 VA: 0x2207B04
	public void .ctor() { }
}
