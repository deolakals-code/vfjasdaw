// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BounceParabolaAttackPattern : MobPatternBase // TypeDefIndex: 750
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private MobAnimation mobAnimation; // 0x78
	private List<BounceParabolaAttackPattern.TargetData> targetDataList; // 0x80
	public List<AttackArea> attackAreaList; // 0x88
	private float hitEffectTiming; // 0x90
	private int boundCount; // 0x94
	private int simultaneousShotNum; // 0x98
	private int simultaneousShotAngle; // 0x9C
	private int boneId; // 0xA0
	private BounceParabolaAttackPattern.Flag flag; // 0xA4
	private float attackRange; // 0xA8
	private float rangeAttenuation; // 0xAC
	private float boundDistance; // 0xB0
	private float boundDistanceAttenuation; // 0xB4
	private float boundNextAngleValue; // 0xB8
	private float nextAngleValueAttenuation; // 0xBC
	private float shotHeight; // 0xC0
	private bool isAttacked; // 0xC4

	// Properties
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1C6E1CC Offset: 0x1C6A1CC VA: 0x1C6E1CC
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, MobAnimation mobAnimation, float playSpeed) { }

	// RVA: 0x1C6E4A8 Offset: 0x1C6A4A8 VA: 0x1C6E4A8 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C6E5D0 Offset: 0x1C6A5D0 VA: 0x1C6E5D0 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C6F8E4 Offset: 0x1C6B8E4 VA: 0x1C6F8E4 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C6FA88 Offset: 0x1C6BA88 VA: 0x1C6FA88 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1C6FB08 Offset: 0x1C6BB08 VA: 0x1C6FB08 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C6FFFC Offset: 0x1C6BFFC VA: 0x1C6FFFC Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1C70050 Offset: 0x1C6C050 VA: 0x1C70050 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1C6FA94 Offset: 0x1C6BA94 VA: 0x1C6FA94
	private void EndCharge() { }

	// RVA: 0x1C6E7E8 Offset: 0x1C6A7E8 VA: 0x1C6E7E8
	private void CreateTarget() { }

	// RVA: 0x1C6EC34 Offset: 0x1C6AC34 VA: 0x1C6EC34
	private void CreateAttackLine() { }

	// RVA: 0x1C6F34C Offset: 0x1C6B34C VA: 0x1C6F34C
	private void CreateAttackArea() { }

	// RVA: 0x1C6F8E8 Offset: 0x1C6B8E8 VA: 0x1C6F8E8
	private void ClearAttackArea() { }
}
