// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationTrueTranslationAttackPattern : MobPatternBase, IInstallationAttackPattern // TypeDefIndex: 784
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
	private bool isForceEnd; // 0xB4
	private InstallationTrueTranslationAttackPattern.TranslationFlag flag; // 0xB8
	private Vector3 attackStartPos; // 0xBC
	private Vector3 attackEndPos; // 0xC8
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0xD4

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

	// RVA: 0x1D49854 Offset: 0x1D45854 VA: 0x1D49854 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1D4985C Offset: 0x1D4585C VA: 0x1D4985C Slot: 9
	public override bool get_IsAttackTargetOtherMob() { }

	// RVA: 0x1D49880 Offset: 0x1D45880 VA: 0x1D49880 Slot: 10
	public override bool get_IsHitMySelf() { }

	// RVA: 0x1D498A4 Offset: 0x1D458A4 VA: 0x1D498A4 Slot: 12
	public override bool get_IsForceAddAbnormal() { }

	// RVA: 0x1D498B0 Offset: 0x1D458B0 VA: 0x1D498B0 Slot: 13
	public override bool get_IsForceAddAbnormalApplyToPlayer() { }

	// RVA: 0x1D498E4 Offset: 0x1D458E4 VA: 0x1D498E4 Slot: 11
	public override bool get_IsIgnoreDefResist() { }

	// RVA: 0x1D498F0 Offset: 0x1D458F0 VA: 0x1D498F0 Slot: 4
	public override bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1D498F8 Offset: 0x1D458F8 VA: 0x1D498F8 Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1D49900 Offset: 0x1D45900 VA: 0x1D49900
	private void set_Element(ElementType value) { }

	// RVA: 0x1D49908 Offset: 0x1D45908 VA: 0x1D49908
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 StartPos, Vector3 EndPos, bool isCurve) { }

	// RVA: 0x1D49AE4 Offset: 0x1D45AE4 VA: 0x1D49AE4 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D49AE8 Offset: 0x1D45AE8 VA: 0x1D49AE8 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D49C64 Offset: 0x1D45C64 VA: 0x1D49C64
	private void NextMove(Vector3 pos, float nextRot, float speed, float time) { }

	// RVA: 0x1D49EBC Offset: 0x1D45EBC VA: 0x1D49EBC
	private bool CheckWall(Vector3 nextPos, Vector3 nextDir) { }

	// RVA: 0x1D4A094 Offset: 0x1D46094 VA: 0x1D4A094
	private bool CheckFloor(Vector3 nextPos) { }

	// RVA: 0x1D4A214 Offset: 0x1D46214 VA: 0x1D4A214 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D4A4E8 Offset: 0x1D464E8 VA: 0x1D4A4E8 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D4A570 Offset: 0x1D46570 VA: 0x1D4A570 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D4A5D8 Offset: 0x1D465D8 VA: 0x1D4A5D8 Slot: 38
	public void Clear() { }

	// RVA: 0x1D4A678 Offset: 0x1D46678 VA: 0x1D4A678 Slot: 39
	public void Invalid() { }

	// RVA: 0x1D4A684 Offset: 0x1D46684 VA: 0x1D4A684 Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1D4A694 Offset: 0x1D46694 VA: 0x1D4A694 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1D4A69C Offset: 0x1D4669C VA: 0x1D4A69C Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1D4A6A4 Offset: 0x1D466A4 VA: 0x1D4A6A4 Slot: 41
	public void SetBulletModel(GameObject[] bulletModel) { }

	// RVA: 0x1D4A910 Offset: 0x1D46910 VA: 0x1D4A910 Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }
}
