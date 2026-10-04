// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BreathExtraAttackPattern : MobPatternBase // TypeDefIndex: 754
{
	// Fields
	private readonly MobPatternTargetType[] TargetTypes; // 0x70
	private MobAnimation mobAnimation; // 0x78
	private CharacterMove charaMove; // 0x80
	private float attackRangeRad; // 0x88
	private int rapidFireCount; // 0x8C
	private int currentRapidFireCount; // 0x90
	private int reAim; // 0x94
	private int boneId; // 0x98
	private Vector3 oldForward; // 0x9C
	private AttackArea attackArea; // 0xA8
	private bool isAttack; // 0xB0
	private float hitEffectTiming; // 0xB4
	private ElementType element; // 0xB8
	private Vector3 attackPos; // 0xBC
	private float warningFloorReducedTime; // 0xC8

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1C72A08 Offset: 0x1C6EA08 VA: 0x1C72A08 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1C72A10 Offset: 0x1C6EA10 VA: 0x1C72A10 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C72A50 Offset: 0x1C6EA50 VA: 0x1C72A50
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, MobAnimation animation, CharacterMove charaMove, float playSpeed) { }

	// RVA: 0x1C73C9C Offset: 0x1C6FC9C VA: 0x1C73C9C
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, Vector3 targetPos, MobAnimation animation, CharacterMove charaMove, float playSpeed) { }

	// RVA: 0x1C74018 Offset: 0x1C70018 VA: 0x1C74018 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C74198 Offset: 0x1C70198 VA: 0x1C74198 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1C740BC Offset: 0x1C700BC VA: 0x1C740BC
	private void ChargeEnd() { }

	// RVA: 0x1C743E4 Offset: 0x1C703E4 VA: 0x1C743E4 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C74454 Offset: 0x1C70454 VA: 0x1C74454 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C72F2C Offset: 0x1C6EF2C VA: 0x1C72F2C
	private void CreateTargetList() { }
}
