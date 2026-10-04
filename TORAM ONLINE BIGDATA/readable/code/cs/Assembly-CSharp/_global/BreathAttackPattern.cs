// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BreathAttackPattern : MobPatternBase // TypeDefIndex: 752
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private CharacterMove charaMove; // 0x78
	private float attackRangeRad; // 0x80
	private int rapidFireCount; // 0x84
	private int currentRapidFireCount; // 0x88
	private int reAim; // 0x8C
	private int boneId; // 0x90
	private Vector3 oldForward; // 0x94
	private AttackArea attackArea; // 0xA0
	private bool isAttack; // 0xA8
	private bool isAttackable; // 0xA9
	private float hitEffectTiming; // 0xAC
	private ElementType element; // 0xB0
	private Vector3 attackPos; // 0xB4
	private float warningFloorReducedTime; // 0xC0

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1C705F0 Offset: 0x1C6C5F0 VA: 0x1C705F0 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1C705F8 Offset: 0x1C6C5F8 VA: 0x1C705F8 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C70638 Offset: 0x1C6C638 VA: 0x1C70638
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, CharacterMove charaMove, float playSpeed) { }

	// RVA: 0x1C71884 Offset: 0x1C6D884 VA: 0x1C71884
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 targetPos, MobAnimation animation, CharacterMove charaMove, float playSpeed) { }

	// RVA: 0x1C71C20 Offset: 0x1C6DC20 VA: 0x1C71C20 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C71DA0 Offset: 0x1C6DDA0 VA: 0x1C71DA0 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1C71CC4 Offset: 0x1C6DCC4 VA: 0x1C71CC4
	private void ChargeEnd() { }

	// RVA: 0x1C71FEC Offset: 0x1C6DFEC VA: 0x1C71FEC Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C7205C Offset: 0x1C6E05C VA: 0x1C7205C Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C72910 Offset: 0x1C6E910 VA: 0x1C72910 Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1C72938 Offset: 0x1C6E938 VA: 0x1C72938 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1C72998 Offset: 0x1C6E998 VA: 0x1C72998 Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float range) { }

	// RVA: 0x1C70B34 Offset: 0x1C6CB34 VA: 0x1C70B34
	private void CreateTargetList() { }
}
