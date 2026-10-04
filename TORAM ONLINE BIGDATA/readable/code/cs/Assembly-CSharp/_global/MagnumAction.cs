// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagnumAction : PlayerAttackBase, IHalloweenSkill // TypeDefIndex: 2658
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public int UseItemId { get; }
	public bool IsHate { get; }

	// Methods

	// RVA: 0x2224B34 Offset: 0x2220B34 VA: 0x2224B34 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2224B3C Offset: 0x2220B3C VA: 0x2224B3C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2224B44 Offset: 0x2220B44 VA: 0x2224B44 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x2224B4C Offset: 0x2220B4C VA: 0x2224B4C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2224B54 Offset: 0x2220B54 VA: 0x2224B54 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2224B5C Offset: 0x2220B5C VA: 0x2224B5C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2224B64 Offset: 0x2220B64 VA: 0x2224B64 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2224B6C Offset: 0x2220B6C VA: 0x2224B6C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2224B74 Offset: 0x2220B74 VA: 0x2224B74 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2224B7C Offset: 0x2220B7C VA: 0x2224B7C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2224B84 Offset: 0x2220B84 VA: 0x2224B84 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2224D3C Offset: 0x2220D3C VA: 0x2224D3C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2224DC4 Offset: 0x2220DC4 VA: 0x2224DC4 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x2224E48 Offset: 0x2220E48 VA: 0x2224E48 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2224F98 Offset: 0x2220F98 VA: 0x2224F98 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2225354 Offset: 0x2221354 VA: 0x2225354 Slot: 91
	public int get_UseItemId() { }

	// RVA: 0x222535C Offset: 0x222135C VA: 0x222535C Slot: 92
	public bool get_IsHate() { }

	// RVA: 0x2225364 Offset: 0x2221364 VA: 0x2225364 Slot: 93
	public void OnInitializeEventRoom() { }

	// RVA: 0x22253DC Offset: 0x22213DC VA: 0x22253DC Slot: 94
	public bool CheckRangeHitEventRoom(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22253E4 Offset: 0x22213E4 VA: 0x22253E4
	public void .ctor() { }
}
