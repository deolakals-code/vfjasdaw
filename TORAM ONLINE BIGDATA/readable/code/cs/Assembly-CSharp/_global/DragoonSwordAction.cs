// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DragoonSwordAction : PlayerAttackBase // TypeDefIndex: 2625
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float rangeRad; // 0x128
	private float runRange; // 0x12C
	private Vector3 startPos; // 0x130
	private List<Vector3> pointList; // 0x140
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x148
	private bool isEquipCriticalGemCart; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsMove { get; }

	// Methods

	// RVA: 0x2216F38 Offset: 0x2212F38 VA: 0x2216F38 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2216F40 Offset: 0x2212F40 VA: 0x2216F40 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2216F48 Offset: 0x2212F48 VA: 0x2216F48 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2216F50 Offset: 0x2212F50 VA: 0x2216F50 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2216F58 Offset: 0x2212F58 VA: 0x2216F58 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2216F60 Offset: 0x2212F60 VA: 0x2216F60 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2216F68 Offset: 0x2212F68 VA: 0x2216F68 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2216F70 Offset: 0x2212F70 VA: 0x2216F70 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2216F78 Offset: 0x2212F78 VA: 0x2216F78 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2216F80 Offset: 0x2212F80 VA: 0x2216F80 Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x2216F88 Offset: 0x2212F88 VA: 0x2216F88 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22171D4 Offset: 0x22131D4 VA: 0x22171D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x221729C Offset: 0x221329C VA: 0x221729C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22177C8 Offset: 0x22137C8 VA: 0x22177C8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22178F8 Offset: 0x22138F8 VA: 0x22178F8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2217E80 Offset: 0x2213E80 VA: 0x2217E80 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2217EF0 Offset: 0x2213EF0 VA: 0x2217EF0
	public void .ctor() { }
}
