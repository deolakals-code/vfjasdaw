// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class MagicKnifeAction : PlayerAttackBase // TypeDefIndex: 2787
{
	// Fields
	private int skillRate; // 0x120
	private SkillLinkedTake placeTake; // 0x128
	private SkillLinkedTake attackTake; // 0x130
	private int effectAngle; // 0x138
	private int targetSize; // 0x13C
	private int attackCount; // 0x140

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

	// RVA: 0x2270920 Offset: 0x226C920 VA: 0x2270920 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2270928 Offset: 0x226C928 VA: 0x2270928 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2270930 Offset: 0x226C930 VA: 0x2270930 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2270938 Offset: 0x226C938 VA: 0x2270938 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2270940 Offset: 0x226C940 VA: 0x2270940 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2270948 Offset: 0x226C948 VA: 0x2270948 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2270950 Offset: 0x226C950 VA: 0x2270950 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2270958 Offset: 0x226C958 VA: 0x2270958 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2270960 Offset: 0x226C960 VA: 0x2270960 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actorAction) { }

	// RVA: 0x2270BA4 Offset: 0x226CBA4 VA: 0x2270BA4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2270D2C Offset: 0x226CD2C VA: 0x2270D2C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2270E34 Offset: 0x226CE34 VA: 0x2270E34 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2270F94 Offset: 0x226CF94 VA: 0x2270F94 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22713E4 Offset: 0x226D3E4 VA: 0x22713E4 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22714D0 Offset: 0x226D4D0 VA: 0x22714D0
	public bool CheckExpDefFluctuate() { }

	// RVA: 0x22714F8 Offset: 0x226D4F8 VA: 0x22714F8
	public void .ctor() { }
}
