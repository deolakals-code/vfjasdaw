// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EarthStyleAttackAction : NinjaSkillBase // TypeDefIndex: 2908
{
	// Fields
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private GameObject mainTarget; // 0x130

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsSupport { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x22CC03C Offset: 0x22C803C VA: 0x22CC03C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22CC044 Offset: 0x22C8044 VA: 0x22CC044 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x22CC04C Offset: 0x22C804C VA: 0x22CC04C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22CC054 Offset: 0x22C8054 VA: 0x22CC054 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22CC05C Offset: 0x22C805C VA: 0x22CC05C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22CC064 Offset: 0x22C8064 VA: 0x22CC064 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22CC06C Offset: 0x22C806C VA: 0x22CC06C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22CC074 Offset: 0x22C8074 VA: 0x22CC074 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22CC07C Offset: 0x22C807C VA: 0x22CC07C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22CC084 Offset: 0x22C8084 VA: 0x22CC084 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22CC08C Offset: 0x22C808C VA: 0x22CC08C Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22CC094 Offset: 0x22C8094 VA: 0x22CC094 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22CC09C Offset: 0x22C809C VA: 0x22CC09C Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22CC0A4 Offset: 0x22C80A4 VA: 0x22CC0A4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22CC0B8 Offset: 0x22C80B8 VA: 0x22CC0B8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22CC0C4 Offset: 0x22C80C4 VA: 0x22CC0C4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22CC0C8 Offset: 0x22C80C8 VA: 0x22CC0C8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22CC4BC Offset: 0x22C84BC VA: 0x22CC4BC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22CC580 Offset: 0x22C8580 VA: 0x22CC580 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22CC77C Offset: 0x22C877C VA: 0x22CC77C
	public void .ctor() { }
}
