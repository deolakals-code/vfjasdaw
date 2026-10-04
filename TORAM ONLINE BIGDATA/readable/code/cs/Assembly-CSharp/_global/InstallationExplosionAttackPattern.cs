// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationExplosionAttackPattern : MobPatternBase, IInstallationAttackPattern, ICircleparam // TypeDefIndex: 774
{
	// Fields
	[CompilerGenerated]
	private Vector3 <CenterPosition>k__BackingField; // 0x70
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0x7C
	private GameObject bullet; // 0x80
	private Motion bulletMotion; // 0x88
	private AttackArea attackArea; // 0x90
	private float attackRad; // 0x98
	private float explosionDelay; // 0x9C
	private float explosiveTime; // 0xA0
	private InstallationExplosionAttackPattern.ExplosionState state; // 0xA4
	private bool attackValid; // 0xA8

	// Properties
	public MobAttackCategory InstallationCategory { get; }
	public override bool VisibleAttackArea { get; }
	public Vector3 CenterPosition { get; set; }
	public ElementType Element { get; set; }

	// Methods

	// RVA: 0x1D45404 Offset: 0x1D41404 VA: 0x1D45404 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1D4540C Offset: 0x1D4140C VA: 0x1D4540C Slot: 4
	public override bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1D4542C Offset: 0x1D4142C VA: 0x1D4542C Slot: 45
	public Vector3 get_CenterPosition() { }

	[CompilerGenerated]
	// RVA: 0x1D45438 Offset: 0x1D41438 VA: 0x1D45438
	private void set_CenterPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x1D45444 Offset: 0x1D41444 VA: 0x1D45444 Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1D4544C Offset: 0x1D4144C VA: 0x1D4544C
	private void set_Element(ElementType value) { }

	// RVA: 0x1D45454 Offset: 0x1D41454 VA: 0x1D45454
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase actionManager, GameObject target, Vector3 attackPos) { }

	// RVA: 0x1D45604 Offset: 0x1D41604 VA: 0x1D45604 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1D45674 Offset: 0x1D41674 VA: 0x1D45674 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D4574C Offset: 0x1D4174C VA: 0x1D4574C Slot: 38
	public void Clear() { }

	// RVA: 0x1D45824 Offset: 0x1D41824 VA: 0x1D45824 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1D4582C Offset: 0x1D4182C VA: 0x1D4582C Slot: 39
	public void Invalid() { }

	// RVA: 0x1D45834 Offset: 0x1D41834 VA: 0x1D45834 Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1D4586C Offset: 0x1D4186C VA: 0x1D4586C Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1D45A88 Offset: 0x1D41A88 VA: 0x1D45A88 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D45C44 Offset: 0x1D41C44 VA: 0x1D45C44 Slot: 46
	public bool CheckNearCircumfrence(Transform targetTransform) { }

	// RVA: 0x1D45C4C Offset: 0x1D41C4C VA: 0x1D45C4C Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D45C5C Offset: 0x1D41C5C VA: 0x1D45C5C Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D45CB4 Offset: 0x1D41CB4 VA: 0x1D45CB4 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D45D1C Offset: 0x1D41D1C VA: 0x1D45D1C Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1D45D24 Offset: 0x1D41D24 VA: 0x1D45D24 Slot: 41
	public void SetBulletModel(GameObject[] bulletModel) { }

	// RVA: 0x1D45E60 Offset: 0x1D41E60 VA: 0x1D45E60 Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }

	// RVA: 0x1D4591C Offset: 0x1D4191C VA: 0x1D4591C
	private void AddExtraInstallation(int commandId) { }
}
