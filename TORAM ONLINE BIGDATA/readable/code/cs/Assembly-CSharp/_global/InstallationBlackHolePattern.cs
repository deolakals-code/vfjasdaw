// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationBlackHolePattern : MobPatternBase, IInstallationAttackPattern, ICircleparam // TypeDefIndex: 766
{
	// Fields
	private static AbnormalType[] SuctionInvalidAbnormal; // 0x0
	private readonly byte localId; // 0x6E
	private readonly bool hideEffect; // 0x6F
	private readonly InstallationBlackHolePattern.EffectType effectType; // 0x70
	private GameObject effect; // 0x78
	private Motion motion; // 0x80
	private float range; // 0x88
	private float runTimer; // 0x8C
	private float hitInterval; // 0x90
	private float suctionInterval; // 0x94
	private float suctionPower; // 0x98
	private float suctionTime; // 0x9C
	private float distanceDecay; // 0xA0
	private float powerDecay; // 0xA4
	private Dictionary<Transform, InstallationBlackHolePattern.HitTimerManager> targetTimerList; // 0xA8
	private bool invalid; // 0xB0
	[CompilerGenerated]
	private Vector3 <CenterPosition>k__BackingField; // 0xB4
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0xC0

	// Properties
	public MobAttackCategory InstallationCategory { get; }
	public override bool VisibleAttackArea { get; }
	public Vector3 CenterPosition { get; set; }
	public ElementType Element { get; set; }

	// Methods

	// RVA: 0x1C79B2C Offset: 0x1C75B2C VA: 0x1C79B2C Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1C79B34 Offset: 0x1C75B34 VA: 0x1C79B34 Slot: 4
	public override bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1C79B3C Offset: 0x1C75B3C VA: 0x1C79B3C Slot: 45
	public Vector3 get_CenterPosition() { }

	[CompilerGenerated]
	// RVA: 0x1C79B48 Offset: 0x1C75B48 VA: 0x1C79B48
	private void set_CenterPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x1C79B54 Offset: 0x1C75B54 VA: 0x1C79B54 Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1C79B5C Offset: 0x1C75B5C VA: 0x1C79B5C
	private void set_Element(ElementType value) { }

	// RVA: 0x1C79B64 Offset: 0x1C75B64 VA: 0x1C79B64
	public void .ctor(MobActionPattern pattern, MobActionPattern parentPattern, EnemyMobActionManagerBase actionManager, GameObject target, Vector3 pos, byte localId) { }

	// RVA: 0x1C79DD4 Offset: 0x1C75DD4 VA: 0x1C79DD4 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C79DD8 Offset: 0x1C75DD8 VA: 0x1C79DD8 Slot: 46
	public bool CheckNearCircumfrence(Transform targetTransform) { }

	// RVA: 0x1C79DE0 Offset: 0x1C75DE0 VA: 0x1C79DE0 Slot: 38
	public void Clear() { }

	// RVA: 0x1C7A118 Offset: 0x1C76118 VA: 0x1C7A118 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1C7A120 Offset: 0x1C76120 VA: 0x1C7A120 Slot: 39
	public void Invalid() { }

	// RVA: 0x1C7A404 Offset: 0x1C76404 VA: 0x1C7A404 Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1C7A44C Offset: 0x1C7644C VA: 0x1C7A44C Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1C7B064 Offset: 0x1C77064 VA: 0x1C7B064 Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1C7B0B8 Offset: 0x1C770B8 VA: 0x1C7B0B8 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1C7B110 Offset: 0x1C77110 VA: 0x1C7B110 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C7B19C Offset: 0x1C7719C VA: 0x1C7B19C Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1C7B204 Offset: 0x1C77204 VA: 0x1C7B204
	private static float CalcDistance(Vector3 actorPos, Vector3 targetPos) { }

	// RVA: 0x1C7A688 Offset: 0x1C76688 VA: 0x1C7A688
	private bool CheckSuctionHit(Transform targetTransform) { }

	// RVA: 0x1C7AE68 Offset: 0x1C76E68 VA: 0x1C7AE68
	private bool CheckDamageHit(Transform targetTransform) { }

	// RVA: 0x1C7A93C Offset: 0x1C7693C VA: 0x1C7A93C
	private void Suction(Transform targetTransform) { }

	// RVA: 0x1C7AEFC Offset: 0x1C76EFC VA: 0x1C7AEFC
	private void Damage(Transform targetTransform) { }

	// RVA: 0x1C7B2A8 Offset: 0x1C772A8 VA: 0x1C7B2A8 Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1C7B2B0 Offset: 0x1C772B0 VA: 0x1C7B2B0 Slot: 41
	public void SetBulletModel(GameObject[] bulletModel) { }

	// RVA: 0x1C7B4DC Offset: 0x1C774DC VA: 0x1C7B4DC Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }

	// RVA: 0x1C7B520 Offset: 0x1C77520 VA: 0x1C7B520
	private static void .cctor() { }
}
