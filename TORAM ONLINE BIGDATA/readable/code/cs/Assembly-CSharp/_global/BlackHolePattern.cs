// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackHolePattern : MobPatternBase // TypeDefIndex: 744
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private MobAnimation mobAnimation; // 0x78
	private float attackRange; // 0x80
	private float hitEffectTiming; // 0x84
	private List<Vector3> targetPosList; // 0x88
	private List<AttackArea> attackAreaList; // 0x90
	private bool isAttack; // 0x98

	// Properties
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1C6C76C Offset: 0x1C6876C VA: 0x1C6C76C Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C6C898 Offset: 0x1C68898 VA: 0x1C6C898
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1C6D268 Offset: 0x1C69268 VA: 0x1C6D268
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, List<MobActionTargetData> targetList, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1C6D7E8 Offset: 0x1C697E8 VA: 0x1C6D7E8 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C6DA14 Offset: 0x1C69A14 VA: 0x1C6DA14 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C6DBB8 Offset: 0x1C69BB8 VA: 0x1C6DBB8 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1C6DC00 Offset: 0x1C69C00 VA: 0x1C6DC00 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C6DF38 Offset: 0x1C69F38 VA: 0x1C6DF38 Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1C6DF8C Offset: 0x1C69F8C VA: 0x1C6DF8C Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1C6D8C4 Offset: 0x1C698C4 VA: 0x1C6D8C4
	private void ActiveAttackArea() { }

	// RVA: 0x1C6DA18 Offset: 0x1C69A18 VA: 0x1C6DA18
	private void RemoveAttackArea() { }

	// RVA: 0x1C6CAF0 Offset: 0x1C68AF0 VA: 0x1C6CAF0
	private void CreateTarget() { }
}
