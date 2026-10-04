// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationBarrierScreenAttackPattern : MobPatternBase, IInstallationAttackPattern, ICustomKnockBackDirection // TypeDefIndex: 763
{
	// Fields
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0x70
	private readonly float hitSize; // 0x74
	private readonly float effectHeight; // 0x78
	private readonly float fadeAwayMotionTime; // 0x7C
	private float speed; // 0x80
	private float attackRange; // 0x84
	private InstallationBarrierScreenAttackPattern.State state; // 0x88
	private bool isForceEnd; // 0x8C
	private int loopCount; // 0x90
	private int loopMax; // 0x94
	private bool loopTurn; // 0x98
	private float hitInterval; // 0x9C
	[TupleElementNames(new[] { "Timer", "Bullet" })]
	private Dictionary<Transform, ValueTuple<float, InstallationBarrierScreenAttackPattern.BarrierBullet>> hitTargetTimerList; // 0xA0
	private bool isAttackAreaView; // 0xA8
	private float moveTime; // 0xAC
	private float attackAreaStartTimer; // 0xB0
	private float safeWidth; // 0xB4
	private bool alternateDirectionFlag; // 0xB8
	private bool reverseDirectionFlag; // 0xB9
	private AttackArea attackArea; // 0xC0
	private Vector3 lineStart; // 0xC8
	private float baseAngle; // 0xD4
	private List<InstallationBarrierScreenAttackPattern.BarrierBullet> bullets; // 0xD8

	// Properties
	public MobAttackCategory InstallationCategory { get; }
	public override bool VisibleAttackArea { get; }
	public ElementType Element { get; set; }

	// Methods

	// RVA: 0x1C77284 Offset: 0x1C73284 VA: 0x1C77284 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1C7728C Offset: 0x1C7328C VA: 0x1C7728C Slot: 4
	public override bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1C772AC Offset: 0x1C732AC VA: 0x1C772AC Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1C772B4 Offset: 0x1C732B4 VA: 0x1C772B4
	private void set_Element(ElementType value) { }

	// RVA: 0x1C772BC Offset: 0x1C732BC VA: 0x1C772BC
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x1C775FC Offset: 0x1C735FC VA: 0x1C775FC Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C77C6C Offset: 0x1C73C6C VA: 0x1C77C6C
	private InstallationBarrierScreenAttackPattern.BarrierBullet GetLeader() { }

	// RVA: 0x1C77AA4 Offset: 0x1C73AA4 VA: 0x1C77AA4
	private void CreateAttackArea() { }

	// RVA: 0x1C77DF8 Offset: 0x1C73DF8 VA: 0x1C77DF8 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C78014 Offset: 0x1C74014 VA: 0x1C78014 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1C77FC8 Offset: 0x1C73FC8 VA: 0x1C77FC8
	private void StopAttackArea() { }

	// RVA: 0x1C78018 Offset: 0x1C74018 VA: 0x1C78018
	private void ShowAttackAreaForNextLoop() { }

	// RVA: 0x1C780B8 Offset: 0x1C740B8 VA: 0x1C780B8 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1C782D0 Offset: 0x1C742D0 VA: 0x1C782D0 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C78A78 Offset: 0x1C74A78 VA: 0x1C78A78 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1C78FD0 Offset: 0x1C74FD0 VA: 0x1C78FD0 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1C79274 Offset: 0x1C75274 VA: 0x1C79274 Slot: 38
	public void Clear() { }

	// RVA: 0x1C79444 Offset: 0x1C75444 VA: 0x1C79444 Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1C794C4 Offset: 0x1C754C4 VA: 0x1C794C4 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1C794CC Offset: 0x1C754CC VA: 0x1C794CC Slot: 39
	public void Invalid() { }

	// RVA: 0x1C794D8 Offset: 0x1C754D8 VA: 0x1C794D8 Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1C794E8 Offset: 0x1C754E8 VA: 0x1C794E8 Slot: 41
	public void SetBulletModel(GameObject[] bulletModels) { }

	// RVA: 0x1C79678 Offset: 0x1C75678 VA: 0x1C79678 Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }

	// RVA: 0x1C799E8 Offset: 0x1C759E8 VA: 0x1C799E8 Slot: 45
	public bool TryGetKnockBackDir(Transform target, out Vector3 dir) { }
}
