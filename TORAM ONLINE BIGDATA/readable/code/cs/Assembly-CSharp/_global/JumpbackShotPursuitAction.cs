// Assembly: Assembly-CSharp.dll
// Namespace: 
public class JumpbackShotPursuitAction : PlayerAttackBase // TypeDefIndex: 1494
{
	// Fields
	private float baseSkillRate; // 0x120
	private float bonusSkillRate; // 0x124
	private int resistBreaker; // 0x128
	private int count; // 0x12C

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
	public override bool IsMoveAssistContinue { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x2062E78 Offset: 0x205EE78 VA: 0x2062E78 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2062E80 Offset: 0x205EE80 VA: 0x2062E80 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2062E88 Offset: 0x205EE88 VA: 0x2062E88 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2062E90 Offset: 0x205EE90 VA: 0x2062E90 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2062E98 Offset: 0x205EE98 VA: 0x2062E98 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2062EA0 Offset: 0x205EEA0 VA: 0x2062EA0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2062EA8 Offset: 0x205EEA8 VA: 0x2062EA8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2062EB0 Offset: 0x205EEB0 VA: 0x2062EB0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2062EB8 Offset: 0x205EEB8 VA: 0x2062EB8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2062EC0 Offset: 0x205EEC0 VA: 0x2062EC0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2062EC8 Offset: 0x205EEC8 VA: 0x2062EC8 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x2062ED0 Offset: 0x205EED0 VA: 0x2062ED0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2062ED8 Offset: 0x205EED8 VA: 0x2062ED8 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2062EE0 Offset: 0x205EEE0 VA: 0x2062EE0 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2062EE8 Offset: 0x205EEE8 VA: 0x2062EE8 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x2062EF0 Offset: 0x205EEF0 VA: 0x2062EF0 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2062EF8 Offset: 0x205EEF8 VA: 0x2062EF8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x20630C8 Offset: 0x205F0C8 VA: 0x20630C8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x20630D4 Offset: 0x205F0D4 VA: 0x20630D4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x20630D8 Offset: 0x205F0D8 VA: 0x20630D8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2063234 Offset: 0x205F234 VA: 0x2063234 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x20634D8 Offset: 0x205F4D8 VA: 0x20634D8
	public void SetParameter(int count) { }

	// RVA: 0x20634E0 Offset: 0x205F4E0 VA: 0x20634E0
	public void .ctor() { }
}
