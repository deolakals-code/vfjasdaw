// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationVarticalAttackPattern : MobPatternBase, IInstallationAttackPattern, ICircleparam // TypeDefIndex: 787
{
	// Fields
	private GameObject bullet; // 0x70
	private Motion bulletMotion; // 0x78
	private float fallTime; // 0x80
	private float range; // 0x84
	private float explosionDelay; // 0x88
	private InstallationVarticalAttackPattern.ExplosionState explosionState; // 0x8C
	private AttackArea attackArea; // 0x90
	[CompilerGenerated]
	private Action chageEnd; // 0x98
	public bool isForceEnd; // 0xA0
	private float scaling; // 0xA4
	private float endScale; // 0xA8
	private float warningFloorReducedTime; // 0xAC
	private byte loopCount; // 0xB0
	private float initAttackRot; // 0xB4
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0xB8

	// Properties
	public override bool VisibleAttackArea { get; }
	public Vector3 CenterPosition { get; }
	public MobAttackCategory InstallationCategory { get; }
	public override bool IsAttackTargetOtherMob { get; }
	public override bool IsHitMySelf { get; }
	public override bool IsForceAddAbnormal { get; }
	public override bool IsForceAddAbnormalApplyToPlayer { get; }
	public override bool IsIgnoreDefResist { get; }
	public ElementType Element { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D4A9A0 Offset: 0x1D469A0 VA: 0x1D4A9A0
	public void add_chageEnd(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1D4AA3C Offset: 0x1D46A3C VA: 0x1D4AA3C
	public void remove_chageEnd(Action value) { }

	// RVA: 0x1D4AAD8 Offset: 0x1D46AD8 VA: 0x1D4AAD8 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1D4AB18 Offset: 0x1D46B18 VA: 0x1D4AB18 Slot: 45
	public Vector3 get_CenterPosition() { }

	// RVA: 0x1D4AB24 Offset: 0x1D46B24 VA: 0x1D4AB24 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1D4AB2C Offset: 0x1D46B2C VA: 0x1D4AB2C Slot: 9
	public override bool get_IsAttackTargetOtherMob() { }

	// RVA: 0x1D4AB50 Offset: 0x1D46B50 VA: 0x1D4AB50 Slot: 10
	public override bool get_IsHitMySelf() { }

	// RVA: 0x1D4AB74 Offset: 0x1D46B74 VA: 0x1D4AB74 Slot: 12
	public override bool get_IsForceAddAbnormal() { }

	// RVA: 0x1D4AB98 Offset: 0x1D46B98 VA: 0x1D4AB98 Slot: 13
	public override bool get_IsForceAddAbnormalApplyToPlayer() { }

	// RVA: 0x1D4ABDC Offset: 0x1D46BDC VA: 0x1D4ABDC Slot: 11
	public override bool get_IsIgnoreDefResist() { }

	[CompilerGenerated]
	// RVA: 0x1D4AC00 Offset: 0x1D46C00 VA: 0x1D4AC00 Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1D4AC08 Offset: 0x1D46C08 VA: 0x1D4AC08
	private void set_Element(ElementType value) { }

	// RVA: 0x1D4AC10 Offset: 0x1D46C10 VA: 0x1D4AC10
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 targetPos, ElementType element) { }

	// RVA: 0x1D4AE48 Offset: 0x1D46E48 VA: 0x1D4AE48
	public void .ctor(InstallationVarticalAttackPattern basePattern, GameObject bullet, Vector3 targetPos) { }

	// RVA: 0x1D4B270 Offset: 0x1D47270 VA: 0x1D4B270 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1D4B6E8 Offset: 0x1D476E8 VA: 0x1D4B6E8 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D4B734 Offset: 0x1D47734 VA: 0x1D4B734 Slot: 38
	public void Clear() { }

	// RVA: 0x1D4B818 Offset: 0x1D47818 VA: 0x1D4B818 Slot: 39
	public void Invalid() { }

	// RVA: 0x1D4B824 Offset: 0x1D47824 VA: 0x1D4B824 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1D4B82C Offset: 0x1D4782C VA: 0x1D4B82C Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1D4B864 Offset: 0x1D47864 VA: 0x1D4B864 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1D4B964 Offset: 0x1D47964 VA: 0x1D4B964 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D4C114 Offset: 0x1D48114 VA: 0x1D4C114 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D4C174 Offset: 0x1D48174 VA: 0x1D4C174 Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1D4C1C8 Offset: 0x1D481C8 VA: 0x1D4C1C8 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D4C228 Offset: 0x1D48228 VA: 0x1D4C228 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D4C290 Offset: 0x1D48290 VA: 0x1D4C290 Slot: 46
	public bool CheckNearCircumfrence(Transform targetTransform) { }

	// RVA: 0x1D4C298 Offset: 0x1D48298 VA: 0x1D4C298 Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1D4C2A0 Offset: 0x1D482A0 VA: 0x1D4C2A0 Slot: 41
	public void SetBulletModel(GameObject[] bulletModel) { }

	// RVA: 0x1D4C398 Offset: 0x1D48398 VA: 0x1D4C398 Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }
}
