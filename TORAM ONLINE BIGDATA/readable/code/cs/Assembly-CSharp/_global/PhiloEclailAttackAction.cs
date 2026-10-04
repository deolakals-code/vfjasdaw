// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhiloEclailAttackAction : PlayerAttackBase, IDualElementSkill // TypeDefIndex: 2642
{
	// Fields
	[CompilerGenerated]
	private bool <IsValidDualElement>k__BackingField; // 0x120
	private Vector3 placePosition; // 0x124
	private float skillRate; // 0x130
	private int fixAddDamage; // 0x134
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x138
	private bool isDualSword; // 0x140

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsNoMotionTake { get; }
	public bool IsValidDualElement { get; set; }

	// Methods

	// RVA: 0x221E994 Offset: 0x221A994 VA: 0x221E994 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x221E99C Offset: 0x221A99C VA: 0x221E99C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x221E9A4 Offset: 0x221A9A4 VA: 0x221E9A4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x221E9AC Offset: 0x221A9AC VA: 0x221E9AC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x221E9B4 Offset: 0x221A9B4 VA: 0x221E9B4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x221E9BC Offset: 0x221A9BC VA: 0x221E9BC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x221E9C4 Offset: 0x221A9C4 VA: 0x221E9C4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x221E9CC Offset: 0x221A9CC VA: 0x221E9CC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x221E9D4 Offset: 0x221A9D4 VA: 0x221E9D4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x221E9DC Offset: 0x221A9DC VA: 0x221E9DC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x221E9E4 Offset: 0x221A9E4 VA: 0x221E9E4 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x221E9EC Offset: 0x221A9EC VA: 0x221E9EC Slot: 31
	public override bool get_IsNoMotionTake() { }

	[CompilerGenerated]
	// RVA: 0x221E9F4 Offset: 0x221A9F4 VA: 0x221E9F4 Slot: 91
	public bool get_IsValidDualElement() { }

	[CompilerGenerated]
	// RVA: 0x221E9FC Offset: 0x221A9FC VA: 0x221E9FC
	private void set_IsValidDualElement(bool value) { }

	// RVA: 0x221EA08 Offset: 0x221AA08 VA: 0x221EA08 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221ECA0 Offset: 0x221ACA0 VA: 0x221ECA0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x221ED78 Offset: 0x221AD78 VA: 0x221ED78 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x221F310 Offset: 0x221B310 VA: 0x221F310 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x221F40C Offset: 0x221B40C VA: 0x221F40C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x221F47C Offset: 0x221B47C VA: 0x221F47C
	public void .ctor() { }
}
