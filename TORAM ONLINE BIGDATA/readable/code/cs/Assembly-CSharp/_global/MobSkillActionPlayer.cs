// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobSkillActionPlayer : SkillActionManagerBase // TypeDefIndex: 739
{
	// Fields
	private const string ClipLayerName = "ClippingLayer";
	private Transform mobTransform; // 0x58
	private MobAnimation mobAnimation; // 0x60
	private EnemyMobActionManagerBase mobActManager; // 0x68
	private MobBattlePlayer mobBattlePlayer; // 0x70
	private TakeController takeController; // 0x78
	private CharacterMove charaMove; // 0x80
	private GameObject actionTarget; // 0x88
	private MobAttackBase currentSkill; // 0x90
	private MobPatternBase mobPattern; // 0x98
	private bool rangeCheck; // 0xA0

	// Properties
	public override bool IsInterruptable { get; }
	public override SkillActionBase CurrentSkill { get; }
	public override bool IsCasting { get; }
	public MobPatternBase MobPattern { get; }
	public bool IsTarget { get; }

	// Methods

	// RVA: 0x1B9D454 Offset: 0x1B99454 VA: 0x1B9D454 Slot: 4
	public override bool get_IsInterruptable() { }

	// RVA: 0x1B9D45C Offset: 0x1B9945C VA: 0x1B9D45C Slot: 5
	public override SkillActionBase get_CurrentSkill() { }

	// RVA: 0x1B9D464 Offset: 0x1B99464 VA: 0x1B9D464 Slot: 6
	public override bool get_IsCasting() { }

	// RVA: 0x1B9D46C Offset: 0x1B9946C VA: 0x1B9D46C
	public MobPatternBase get_MobPattern() { }

	// RVA: 0x1B9D474 Offset: 0x1B99474 VA: 0x1B9D474
	public bool get_IsTarget() { }

	// RVA: 0x1B9D490 Offset: 0x1B99490 VA: 0x1B9D490
	private void Awake() { }

	// RVA: 0x1B9D5D8 Offset: 0x1B995D8 VA: 0x1B9D5D8 Slot: 7
	public override void Initialize() { }

	// RVA: 0x1B9D5E4 Offset: 0x1B995E4 VA: 0x1B9D5E4 Slot: 10
	public override void ActionCancel() { }

	// RVA: 0x1B9D6A4 Offset: 0x1B996A4 VA: 0x1B9D6A4 Slot: 8
	public override void End() { }

	// RVA: 0x1B9D6B0 Offset: 0x1B996B0 VA: 0x1B9D6B0 Slot: 9
	public override void SetCurrentSkill(GameObject target, SkillActionBase actiontargetPos) { }

	// RVA: 0x1B97CF0 Offset: 0x1B93CF0 VA: 0x1B97CF0
	public void SetCurrentSkill(GameObject target, Quaternion actionStartRot, SkillActionBase action, List<MobActionTargetData> targetPosList) { }

	// RVA: 0x1B97384 Offset: 0x1B93384 VA: 0x1B97384
	public void SetCurrentSkillHateChange() { }

	// RVA: 0x1B98584 Offset: 0x1B94584 VA: 0x1B98584
	public void CurrentSkillDamage() { }

	// RVA: 0x1B9D6B4 Offset: 0x1B996B4 VA: 0x1B9D6B4
	private bool initAction(List<MobActionTargetData> targetPosList, Quaternion actionStartRot) { }

	// RVA: 0x1B9E600 Offset: 0x1B9A600 VA: 0x1B9E600
	private void Update() { }

	// RVA: 0x1B9FF98 Offset: 0x1B9BF98 VA: 0x1B9FF98
	private void LateUpdate() { }

	// RVA: 0x1B9FFD8 Offset: 0x1B9BFD8 VA: 0x1B9FFD8
	public void Damaged() { }

	// RVA: 0x1BA0028 Offset: 0x1B9C028 VA: 0x1BA0028
	public void .ctor() { }
}
