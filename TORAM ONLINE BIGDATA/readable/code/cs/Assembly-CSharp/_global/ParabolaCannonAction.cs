// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParabolaCannonAction : PlayerAttackBase // TypeDefIndex: 2999
{
	// Fields
	[CompilerGenerated]
	private bool <Placed>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int constantDamage; // 0x128
	private float trapSkillRate; // 0x12C
	private int trapConstantDamage; // 0x130
	private int percent; // 0x134
	private bool targetLook; // 0x138
	private float attackRange; // 0x13C
	private float trapDetectionRange; // 0x140
	private float trapAttackRange; // 0x144
	private bool allowedRolling; // 0x148
	private bool rolling; // 0x149
	private bool moveInput; // 0x14A
	private ParabolaCannonAction.State state; // 0x14C
	private bool otherHit; // 0x150
	private Vector3 attackPos; // 0x154
	private PlayerActionManagerBase actorAction; // 0x160
	private bool isIdentify; // 0x168

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsBreakable { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override bool IsSkillStartTargetLook { get; }
	public bool Placed { get; set; }

	// Methods

	// RVA: 0x22F8A10 Offset: 0x22F4A10 VA: 0x22F8A10 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22F8A18 Offset: 0x22F4A18 VA: 0x22F8A18 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22F8A20 Offset: 0x22F4A20 VA: 0x22F8A20 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22F8A28 Offset: 0x22F4A28 VA: 0x22F8A28 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22F8A30 Offset: 0x22F4A30 VA: 0x22F8A30 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22F8A38 Offset: 0x22F4A38 VA: 0x22F8A38 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22F8A40 Offset: 0x22F4A40 VA: 0x22F8A40 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22F8A48 Offset: 0x22F4A48 VA: 0x22F8A48 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22F8A50 Offset: 0x22F4A50 VA: 0x22F8A50 Slot: 17
	public override bool get_IsBreakable() { }

	// RVA: 0x22F8A58 Offset: 0x22F4A58 VA: 0x22F8A58 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x22F8A60 Offset: 0x22F4A60 VA: 0x22F8A60 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x22F8A68 Offset: 0x22F4A68 VA: 0x22F8A68 Slot: 32
	public override bool get_IsSkillStartTargetLook() { }

	[CompilerGenerated]
	// RVA: 0x22F8A70 Offset: 0x22F4A70 VA: 0x22F8A70
	public bool get_Placed() { }

	[CompilerGenerated]
	// RVA: 0x22F8A78 Offset: 0x22F4A78 VA: 0x22F8A78
	private void set_Placed(bool value) { }

	// RVA: 0x22F8A84 Offset: 0x22F4A84 VA: 0x22F8A84 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22F8E9C Offset: 0x22F4E9C VA: 0x22F8E9C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22F9164 Offset: 0x22F5164 VA: 0x22F9164 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F98B0 Offset: 0x22F58B0 VA: 0x22F98B0 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22F9BA8 Offset: 0x22F5BA8 VA: 0x22F9BA8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22FA37C Offset: 0x22F637C VA: 0x22FA37C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22FA52C Offset: 0x22F652C VA: 0x22FA52C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22FA844 Offset: 0x22F6844 VA: 0x22FA844 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22FAC08 Offset: 0x22F6C08 VA: 0x22FAC08 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22FAC84 Offset: 0x22F6C84 VA: 0x22FAC84 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22FB018 Offset: 0x22F7018 VA: 0x22FB018
	public bool CheckBreak(CharacterActionManagerBase targetAction, SkillActionBase action) { }

	// RVA: 0x22FAB6C Offset: 0x22F6B6C VA: 0x22FAB6C
	private bool CheckRolling() { }

	// RVA: 0x22F99E4 Offset: 0x22F59E4 VA: 0x22F99E4
	private bool SetRollingTake(Vector3 dir) { }

	// RVA: 0x22FB1A8 Offset: 0x22F71A8 VA: 0x22FB1A8
	public void .ctor() { }
}
