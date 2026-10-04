// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationTranslationAttackPattern : MobPatternBase, IInstallationAttackPattern // TypeDefIndex: 781
{
	// Fields
	private GameObject bullet; // 0x70
	private Motion bulletMotion; // 0x78
	private float range; // 0x80
	private float speed; // 0x84
	private float acceleration; // 0x88
	private float curvature; // 0x8C
	private bool isCurve; // 0x90
	private List<Transform> hitTargetList; // 0x98
	private List<float> hitTargetTimerList; // 0xA0
	private CharacterMove charaMove; // 0xA8
	private int state; // 0xB0
	private Vector3 startPos; // 0xB4
	private Vector3 endPos; // 0xC0
	private float startRot; // 0xCC
	private Vector3 moveDir; // 0xD0
	private bool isForceEnd; // 0xDC
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0xE0

	// Properties
	public MobAttackCategory InstallationCategory { get; }
	public override bool IsAttackTargetOtherMob { get; }
	public override bool IsHitMySelf { get; }
	public override bool IsForceAddAbnormal { get; }
	public override bool IsForceAddAbnormalApplyToPlayer { get; }
	public override bool IsIgnoreDefResist { get; }
	public override bool VisibleAttackArea { get; }
	public ElementType Element { get; set; }

	// Methods

	// RVA: 0x1D48AC8 Offset: 0x1D44AC8 VA: 0x1D48AC8 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1D48AD0 Offset: 0x1D44AD0 VA: 0x1D48AD0 Slot: 9
	public override bool get_IsAttackTargetOtherMob() { }

	// RVA: 0x1D48AF4 Offset: 0x1D44AF4 VA: 0x1D48AF4 Slot: 10
	public override bool get_IsHitMySelf() { }

	// RVA: 0x1D48B18 Offset: 0x1D44B18 VA: 0x1D48B18 Slot: 12
	public override bool get_IsForceAddAbnormal() { }

	// RVA: 0x1D48B3C Offset: 0x1D44B3C VA: 0x1D48B3C Slot: 13
	public override bool get_IsForceAddAbnormalApplyToPlayer() { }

	// RVA: 0x1D48B80 Offset: 0x1D44B80 VA: 0x1D48B80 Slot: 11
	public override bool get_IsIgnoreDefResist() { }

	// RVA: 0x1D48BA4 Offset: 0x1D44BA4 VA: 0x1D48BA4 Slot: 4
	public override bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1D48BAC Offset: 0x1D44BAC VA: 0x1D48BAC Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1D48BB4 Offset: 0x1D44BB4 VA: 0x1D48BB4
	private void set_Element(ElementType value) { }

	// RVA: 0x1D48BBC Offset: 0x1D44BBC VA: 0x1D48BBC
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 StartPos, Vector3 EndPos, bool isCurve) { }

	// RVA: 0x1D48DB0 Offset: 0x1D44DB0 VA: 0x1D48DB0 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D48DB4 Offset: 0x1D44DB4 VA: 0x1D48DB4 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D48EF8 Offset: 0x1D44EF8 VA: 0x1D48EF8
	private void NextPos(Vector3 pos, float deg, float speed, float time) { }

	// RVA: 0x1D49230 Offset: 0x1D45230 VA: 0x1D49230 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D494D8 Offset: 0x1D454D8 VA: 0x1D494D8 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D49560 Offset: 0x1D45560 VA: 0x1D49560 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D495C8 Offset: 0x1D455C8 VA: 0x1D495C8 Slot: 38
	public void Clear() { }

	// RVA: 0x1D49668 Offset: 0x1D45668 VA: 0x1D49668 Slot: 39
	public void Invalid() { }

	// RVA: 0x1D49674 Offset: 0x1D45674 VA: 0x1D49674 Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1D49684 Offset: 0x1D45684 VA: 0x1D49684 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1D4968C Offset: 0x1D4568C VA: 0x1D4968C Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1D49694 Offset: 0x1D45694 VA: 0x1D49694 Slot: 41
	public void SetBulletModel(GameObject[] bulletModel) { }

	// RVA: 0x1D497D4 Offset: 0x1D457D4 VA: 0x1D497D4 Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }
}
