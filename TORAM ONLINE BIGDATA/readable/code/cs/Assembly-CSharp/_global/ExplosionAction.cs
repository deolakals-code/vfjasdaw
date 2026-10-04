// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExplosionAction : PlayerAttackBase // TypeDefIndex: 2543
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int mp; // 0x128
	private float range; // 0x12C
	private Vector3 targetPos; // 0x130

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsOverMp { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x21EB8E8 Offset: 0x21E78E8 VA: 0x21EB8E8 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x21EB8F0 Offset: 0x21E78F0 VA: 0x21EB8F0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21EB8F8 Offset: 0x21E78F8 VA: 0x21EB8F8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21EB900 Offset: 0x21E7900 VA: 0x21EB900 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21EB908 Offset: 0x21E7908 VA: 0x21EB908 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21EB910 Offset: 0x21E7910 VA: 0x21EB910 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21EB918 Offset: 0x21E7918 VA: 0x21EB918 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21EB920 Offset: 0x21E7920 VA: 0x21EB920 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21EB928 Offset: 0x21E7928 VA: 0x21EB928 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21EB930 Offset: 0x21E7930 VA: 0x21EB930 Slot: 24
	public override bool get_IsOverMp() { }

	// RVA: 0x21EB938 Offset: 0x21E7938 VA: 0x21EB938 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x21EB940 Offset: 0x21E7940 VA: 0x21EB940 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21EBC54 Offset: 0x21E7C54 VA: 0x21EBC54 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21EBD84 Offset: 0x21E7D84 VA: 0x21EBD84 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21EBDD4 Offset: 0x21E7DD4 VA: 0x21EBDD4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21EC05C Offset: 0x21E805C VA: 0x21EC05C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21EC158 Offset: 0x21E8158 VA: 0x21EC158 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21EC354 Offset: 0x21E8354 VA: 0x21EC354 Slot: 84
	public override void RecalcCostMp(PlayerActionManagerBase playerAction) { }

	// RVA: 0x21EC48C Offset: 0x21E848C VA: 0x21EC48C
	public void .ctor() { }
}
