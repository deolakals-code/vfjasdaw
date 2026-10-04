// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationBreathAttackPattern : MobPatternBase, IInstallationAttackPattern, ILineParam // TypeDefIndex: 772
{
	// Fields
	private GameObject bullet; // 0x70
	private Motion bulletMotion; // 0x78
	private GameObject explosion; // 0x80
	private Motion explosionMotion; // 0x88
	private float range; // 0x90
	private float speed; // 0x94
	private float power; // 0x98
	private float explosionRange; // 0x9C
	private int effectId; // 0xA0
	private int motionId; // 0xA4
	private List<Transform> hitTargetList; // 0xA8
	private InstallationBreathAttackPattern.UpdateState state; // 0xB0
	private float moveTime; // 0xB4
	private FieldRayPick fieldRay; // 0xB8
	private float fallSpeed; // 0xC0
	private Vector3 direction; // 0xC4
	private Vector3 startPos; // 0xD0
	private bool isForceEnd; // 0xDC
	private InstallationBreathAttackPattern.MultFlag flag; // 0xDE
	[CompilerGenerated]
	private bool <IsExplosion>k__BackingField; // 0xE0
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0xE4

	// Properties
	public Vector3 LineVector { get; }
	public MobAttackCategory InstallationCategory { get; }
	public override bool VisibleAttackArea { get; }
	public bool IsExplosion { get; set; }
	public ElementType Element { get; set; }

	// Methods

	// RVA: 0x1D440D0 Offset: 0x1D400D0 VA: 0x1D440D0 Slot: 45
	public Vector3 get_LineVector() { }

	// RVA: 0x1D440F0 Offset: 0x1D400F0 VA: 0x1D440F0 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1D440F8 Offset: 0x1D400F8 VA: 0x1D440F8 Slot: 4
	public override bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1D44100 Offset: 0x1D40100 VA: 0x1D44100
	public bool get_IsExplosion() { }

	[CompilerGenerated]
	// RVA: 0x1D44108 Offset: 0x1D40108 VA: 0x1D44108
	private void set_IsExplosion(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D44114 Offset: 0x1D40114 VA: 0x1D44114 Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1D4411C Offset: 0x1D4011C VA: 0x1D4411C
	private void set_Element(ElementType value) { }

	// RVA: 0x1D44124 Offset: 0x1D40124 VA: 0x1D44124
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 StartPos, Vector3 EndPos) { }

	// RVA: 0x1D44580 Offset: 0x1D40580 VA: 0x1D44580 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D44584 Offset: 0x1D40584 VA: 0x1D44584 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D44B98 Offset: 0x1D40B98 VA: 0x1D44B98 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D44DB8 Offset: 0x1D40DB8 VA: 0x1D44DB8 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D44EC0 Offset: 0x1D40EC0 VA: 0x1D44EC0 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D44F3C Offset: 0x1D40F3C VA: 0x1D44F3C Slot: 38
	public void Clear() { }

	// RVA: 0x1D45044 Offset: 0x1D41044 VA: 0x1D45044 Slot: 39
	public void Invalid() { }

	// RVA: 0x1D45050 Offset: 0x1D41050 VA: 0x1D45050 Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1D45108 Offset: 0x1D41108 VA: 0x1D45108 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1D44AD8 Offset: 0x1D40AD8 VA: 0x1D44AD8
	private Vector3 move(Vector3 pos, Vector3 dir) { }

	// RVA: 0x1D45110 Offset: 0x1D41110 VA: 0x1D45110
	private float calcGravity() { }

	// RVA: 0x1D44568 Offset: 0x1D40568 VA: 0x1D44568
	private bool CheckFlag(InstallationBreathAttackPattern.MultFlag flag) { }

	// RVA: 0x1D45134 Offset: 0x1D41134 VA: 0x1D45134 Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1D4513C Offset: 0x1D4113C VA: 0x1D4513C Slot: 41
	public void SetBulletModel(GameObject[] bulletModel) { }

	// RVA: 0x1D453C0 Offset: 0x1D413C0 VA: 0x1D453C0 Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }
}
