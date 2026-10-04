// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ArrowRainAction : PlayerAttackBase // TypeDefIndex: 2969
{
	// Fields
	private int damageCount; // 0x120
	private float rad; // 0x124
	private float skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x130

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

	// RVA: 0x22EC02C Offset: 0x22E802C VA: 0x22EC02C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22EC034 Offset: 0x22E8034 VA: 0x22EC034 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22EC03C Offset: 0x22E803C VA: 0x22EC03C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22EC044 Offset: 0x22E8044 VA: 0x22EC044 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22EC04C Offset: 0x22E804C VA: 0x22EC04C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22EC054 Offset: 0x22E8054 VA: 0x22EC054 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22EC05C Offset: 0x22E805C VA: 0x22EC05C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22EC064 Offset: 0x22E8064 VA: 0x22EC064 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22EC06C Offset: 0x22E806C VA: 0x22EC06C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22EC4F4 Offset: 0x22E84F4 VA: 0x22EC4F4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22EC870 Offset: 0x22E8870 VA: 0x22EC870 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22ECA5C Offset: 0x22E8A5C VA: 0x22ECA5C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22ECF90 Offset: 0x22E8F90 VA: 0x22ECF90 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22ED0C4 Offset: 0x22E90C4 VA: 0x22ED0C4 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22ED134 Offset: 0x22E9134 VA: 0x22ED134
	public void .ctor() { }
}
