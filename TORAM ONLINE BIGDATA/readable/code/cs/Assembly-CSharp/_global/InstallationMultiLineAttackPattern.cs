// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationMultiLineAttackPattern : MobPatternBase, IInstallationAttackPattern, ILineParam // TypeDefIndex: 779
{
	// Fields
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0x70
	private readonly float attackRange; // 0x74
	private readonly Vector3 attackStartPos; // 0x78
	private readonly Vector3 attackEndPos; // 0x84
	private GameObject bullet; // 0x90
	private Motion bulletMotion; // 0x98
	private float hitInterval; // 0xA0
	private bool isAttackValid; // 0xA4

	// Properties
	public override bool VisibleAttackArea { get; }
	public Vector3 LineVector { get; }
	public MobAttackCategory InstallationCategory { get; }
	public ElementType Element { get; set; }

	// Methods

	// RVA: 0x1D48158 Offset: 0x1D44158 VA: 0x1D48158
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 startPos, Vector3 endPos, ElementType element) { }

	// RVA: 0x1D48218 Offset: 0x1D44218 VA: 0x1D48218 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1D48220 Offset: 0x1D44220 VA: 0x1D48220 Slot: 45
	public Vector3 get_LineVector() { }

	// RVA: 0x1D48240 Offset: 0x1D44240 VA: 0x1D48240 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	[CompilerGenerated]
	// RVA: 0x1D48248 Offset: 0x1D44248 VA: 0x1D48248 Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1D48250 Offset: 0x1D44250 VA: 0x1D48250
	private void set_Element(ElementType value) { }

	// RVA: 0x1D48258 Offset: 0x1D44258 VA: 0x1D48258 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1D48498 Offset: 0x1D44498 VA: 0x1D48498 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D4849C Offset: 0x1D4449C VA: 0x1D4849C Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D484F0 Offset: 0x1D444F0 VA: 0x1D484F0 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D48630 Offset: 0x1D44630 VA: 0x1D48630 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D48770 Offset: 0x1D44770 VA: 0x1D48770 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D4880C Offset: 0x1D4480C VA: 0x1D4880C Slot: 38
	public void Clear() { }

	// RVA: 0x1D48914 Offset: 0x1D44914 VA: 0x1D48914 Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1D4891C Offset: 0x1D4491C VA: 0x1D4891C Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1D48924 Offset: 0x1D44924 VA: 0x1D48924 Slot: 39
	public void Invalid() { }

	// RVA: 0x1D4892C Offset: 0x1D4492C VA: 0x1D4892C Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1D489B4 Offset: 0x1D449B4 VA: 0x1D489B4 Slot: 41
	public void SetBulletModel(GameObject[] bulletModels) { }

	// RVA: 0x1D489DC Offset: 0x1D449DC VA: 0x1D489DC Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }

	// RVA: 0x1D48A20 Offset: 0x1D44A20 VA: 0x1D48A20
	public static bool CheckInAttackArea(Vector3 pos, Vector3 start, Vector3 end, float range) { }
}
