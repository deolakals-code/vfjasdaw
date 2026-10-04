// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BeragelungAction : PlayerAttackBase // TypeDefIndex: 2963
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private float attackRange; // 0x128
	private int shieldRefine; // 0x12C
	private Dictionary<MobActionManagerBase, short> targetExpList; // 0x130
	private GameObject mainTarget; // 0x138
	private Vector3 mainTargetPos; // 0x140
	private BeragelungAction.State state; // 0x14C
	private GameObject straightObject; // 0x150
	private SkillLinkedTake straightEventTake; // 0x158
	private GameObject homingObject; // 0x160
	private SkillLinkedTake homingEventTake; // 0x168

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x22E7DC8 Offset: 0x22E3DC8 VA: 0x22E7DC8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E7DD0 Offset: 0x22E3DD0 VA: 0x22E7DD0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E7DD8 Offset: 0x22E3DD8 VA: 0x22E7DD8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E7DE0 Offset: 0x22E3DE0 VA: 0x22E7DE0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E7DE8 Offset: 0x22E3DE8 VA: 0x22E7DE8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E7DF0 Offset: 0x22E3DF0 VA: 0x22E7DF0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E7DF8 Offset: 0x22E3DF8 VA: 0x22E7DF8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22E7E00 Offset: 0x22E3E00 VA: 0x22E7E00 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E7E08 Offset: 0x22E3E08 VA: 0x22E7E08 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x22E7E10 Offset: 0x22E3E10 VA: 0x22E7E10 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x22E7E18 Offset: 0x22E3E18 VA: 0x22E7E18 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E7FBC Offset: 0x22E3FBC VA: 0x22E7FBC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E8080 Offset: 0x22E4080 VA: 0x22E8080 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E814C Offset: 0x22E414C VA: 0x22E814C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E8420 Offset: 0x22E4420 VA: 0x22E8420 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22E88DC Offset: 0x22E48DC VA: 0x22E88DC Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22E8934 Offset: 0x22E4934 VA: 0x22E8934 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22E89B0 Offset: 0x22E49B0 VA: 0x22E89B0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22E8A74 Offset: 0x22E4A74 VA: 0x22E8A74 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E8F2C Offset: 0x22E4F2C VA: 0x22E8F2C Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x22E8FA0 Offset: 0x22E4FA0 VA: 0x22E8FA0
	public static void AddDebuff(SkillActionBase action, CharacterActionManagerBase actionManager) { }

	// RVA: 0x22E9380 Offset: 0x22E5380 VA: 0x22E9380
	public static void ReceiveAttackResult(MobResponseData responseData) { }

	// RVA: 0x22E962C Offset: 0x22E562C VA: 0x22E962C
	public static void ValidDebuff(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E99B0 Offset: 0x22E59B0 VA: 0x22E99B0
	public static void InvalidDebuff(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E99F0 Offset: 0x22E59F0 VA: 0x22E99F0
	public void .ctor() { }
}
