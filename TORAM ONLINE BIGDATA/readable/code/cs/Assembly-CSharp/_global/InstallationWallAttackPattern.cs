// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationWallAttackPattern : MobPatternBase, IInstallationAttackPattern // TypeDefIndex: 788
{
	// Fields
	private GameObject bullet; // 0x70
	private Motion motion; // 0x78
	private Vector3 attackPos; // 0x80
	private float attackRange; // 0x8C
	private float safeRange; // 0x90
	private float runTime; // 0x94
	private float hitInterval; // 0x98
	private bool isAttackEnd; // 0x9C
	private List<Transform> hitTargetList; // 0xA0
	private List<float> hitTargetTimerList; // 0xA8
	private bool isForceEnd; // 0xB0
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0xB4

	// Properties
	public MobAttackCategory InstallationCategory { get; }
	public override bool VisibleAttackArea { get; }
	public ElementType Element { get; set; }

	// Methods

	// RVA: 0x1D4C3DC Offset: 0x1D483DC VA: 0x1D4C3DC Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1D4C3E4 Offset: 0x1D483E4 VA: 0x1D4C3E4 Slot: 4
	public override bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1D4C3EC Offset: 0x1D483EC VA: 0x1D4C3EC Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1D4C3F4 Offset: 0x1D483F4 VA: 0x1D4C3F4
	private void set_Element(ElementType value) { }

	// RVA: 0x1D4C3FC Offset: 0x1D483FC VA: 0x1D4C3FC
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 EndPos) { }

	// RVA: 0x1D4C59C Offset: 0x1D4859C VA: 0x1D4C59C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D4C5A0 Offset: 0x1D485A0 VA: 0x1D4C5A0 Slot: 38
	public void Clear() { }

	// RVA: 0x1D4C640 Offset: 0x1D48640 VA: 0x1D4C640 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1D4C648 Offset: 0x1D48648 VA: 0x1D4C648 Slot: 39
	public void Invalid() { }

	// RVA: 0x1D4C654 Offset: 0x1D48654 VA: 0x1D4C654 Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1D4C68C Offset: 0x1D4868C VA: 0x1D4C68C Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D4C700 Offset: 0x1D48700 VA: 0x1D4C700 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D4C9C0 Offset: 0x1D489C0 VA: 0x1D4C9C0 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D4CA70 Offset: 0x1D48A70 VA: 0x1D4CA70 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D4CAD8 Offset: 0x1D48AD8 VA: 0x1D4CAD8 Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1D4CAE0 Offset: 0x1D48AE0 VA: 0x1D4CAE0 Slot: 41
	public void SetBulletModel(GameObject[] bulletModel) { }

	// RVA: 0x1D4CCE0 Offset: 0x1D48CE0 VA: 0x1D4CCE0 Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }
}
