// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SurroundRectangleAttackPattern : MobPatternBase, ILineParam // TypeDefIndex: 830
{
	// Fields
	[CompilerGenerated]
	private Vector3 <LineVector>k__BackingField; // 0x70
	private MobAnimation animation; // 0x80
	private bool setupEnd; // 0x88
	private AttackArea attackArea; // 0x90
	private bool createAttackArea; // 0x98
	private float warningFloorReducedTime; // 0x9C
	private float attackStartRot; // 0xA0
	private float hight; // 0xA4
	private float width; // 0xA8
	private float safeHight; // 0xAC
	private float safeWidth; // 0xB0
	private OBB attackRect; // 0xB8
	private OBB safeRect; // 0xC0

	// Properties
	public override bool VisibleAttackArea { get; }
	public Vector3 LineVector { get; set; }
	private int ChargeMotionId { get; }
	private int PoseMotionId { get; }
	public SurroundRectangleAttackPattern.Flag PatternFlag { get; }

	// Methods

	// RVA: 0x1E20AD8 Offset: 0x1E1CAD8 VA: 0x1E20AD8
	public static SurroundRectangleAttackPattern ManagedPattern(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E20DAC Offset: 0x1E1CDAC VA: 0x1E20DAC
	public static SurroundRectangleAttackPattern UnmanagedPattern(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, Vector3 targetPos, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E20B94 Offset: 0x1E1CB94 VA: 0x1E20B94
	private void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E20E6C Offset: 0x1E1CE6C VA: 0x1E20E6C Slot: 4
	public override bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1E20E8C Offset: 0x1E1CE8C VA: 0x1E20E8C Slot: 36
	public Vector3 get_LineVector() { }

	[CompilerGenerated]
	// RVA: 0x1E20E98 Offset: 0x1E1CE98 VA: 0x1E20E98
	private void set_LineVector(Vector3 value) { }

	// RVA: 0x1E20EA4 Offset: 0x1E1CEA4 VA: 0x1E20EA4
	private int get_ChargeMotionId() { }

	// RVA: 0x1E20EB8 Offset: 0x1E1CEB8 VA: 0x1E20EB8
	private int get_PoseMotionId() { }

	// RVA: 0x1E20ECC Offset: 0x1E1CECC VA: 0x1E20ECC
	public SurroundRectangleAttackPattern.Flag get_PatternFlag() { }

	// RVA: 0x1E20EE0 Offset: 0x1E1CEE0 VA: 0x1E20EE0 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E21574 Offset: 0x1E1D574 VA: 0x1E21574 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E215B4 Offset: 0x1E1D5B4 VA: 0x1E215B4 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E215B8 Offset: 0x1E1D5B8 VA: 0x1E215B8 Slot: 20
	protected override bool OnPreUpdate() { }

	// RVA: 0x1E21650 Offset: 0x1E1D650 VA: 0x1E21650 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E21738 Offset: 0x1E1D738 VA: 0x1E21738 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E21774 Offset: 0x1E1D774 VA: 0x1E21774 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1E217F0 Offset: 0x1E1D7F0 VA: 0x1E217F0 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E2186C Offset: 0x1E1D86C VA: 0x1E2186C Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1E21578 Offset: 0x1E1D578 VA: 0x1E21578
	private void HideAttackArea() { }

	// RVA: 0x1E2134C Offset: 0x1E1D34C VA: 0x1E2134C
	private void ChargeStart() { }

	// RVA: 0x1E218E4 Offset: 0x1E1D8E4 VA: 0x1E218E4
	public MobSendData GetMobSendData(EnemyMobActionManagerBase mobAction) { }
}
