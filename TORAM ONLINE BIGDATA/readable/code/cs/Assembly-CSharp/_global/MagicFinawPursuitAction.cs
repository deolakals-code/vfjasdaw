// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class MagicFinawPursuitAction : PlayerAttackBase // TypeDefIndex: 2782
{
	// Fields
	private float[] skillRate; // 0x120
	private int[] fixAddDamage; // 0x128
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x130
	private int damageCount; // 0x138
	private float[] rad; // 0x140
	private Vector3 attackPos; // 0x148

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool NoCost { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x226CBD8 Offset: 0x2268BD8 VA: 0x226CBD8 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x226CBE0 Offset: 0x2268BE0 VA: 0x226CBE0 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x226CBE8 Offset: 0x2268BE8 VA: 0x226CBE8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x226CBF0 Offset: 0x2268BF0 VA: 0x226CBF0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x226CBF8 Offset: 0x2268BF8 VA: 0x226CBF8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x226CC00 Offset: 0x2268C00 VA: 0x226CC00 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x226CC08 Offset: 0x2268C08 VA: 0x226CC08 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x226CC10 Offset: 0x2268C10 VA: 0x226CC10 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x226CC18 Offset: 0x2268C18 VA: 0x226CC18 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x226CC20 Offset: 0x2268C20 VA: 0x226CC20 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x226CC28 Offset: 0x2268C28 VA: 0x226CC28 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x226CC30 Offset: 0x2268C30 VA: 0x226CC30 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x226CC38 Offset: 0x2268C38 VA: 0x226CC38 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x226CC40 Offset: 0x2268C40 VA: 0x226CC40 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x226CC48 Offset: 0x2268C48 VA: 0x226CC48 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x226CC50 Offset: 0x2268C50 VA: 0x226CC50 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x226CC58 Offset: 0x2268C58 VA: 0x226CC58 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x226CFEC Offset: 0x2268FEC VA: 0x226CFEC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x226D250 Offset: 0x2269250 VA: 0x226D250 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226D420 Offset: 0x2269420 VA: 0x226D420 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226D448 Offset: 0x2269448 VA: 0x226D448 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x226D564 Offset: 0x2269564 VA: 0x226D564 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x226D5E0 Offset: 0x22695E0 VA: 0x226D5E0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x226DA98 Offset: 0x2269A98 VA: 0x226DA98
	public void .ctor() { }
}
