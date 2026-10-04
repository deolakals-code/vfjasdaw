// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationMoveBlackHolePattern : MobPatternBase, IInstallationAttackPattern, ICircleparam // TypeDefIndex: 778
{
	// Fields
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0x70
	private readonly AbnormalType[] SuctionInvalidAbnormal; // 0x78
	private readonly byte localId; // 0x80
	private readonly bool hideEffect; // 0x81
	private readonly InstallationMoveBlackHolePattern.EffectType effectType; // 0x84
	private GameObject effect; // 0x88
	private Motion motion; // 0x90
	private Vector3 initPos; // 0x98
	private float range; // 0xA4
	private float runTimer; // 0xA8
	private float hitInterval; // 0xAC
	private float suctionInterval; // 0xB0
	private float suctionPower; // 0xB4
	private float suctionTime; // 0xB8
	private float moveSpeed; // 0xBC
	private float moveAccele; // 0xC0
	private float moveAngle; // 0xC4
	private float distanceDecay; // 0xC8
	private float powerDecay; // 0xCC
	private Vector3 moveDir; // 0xD0
	private CharacterMove effectMove; // 0xE0
	private Dictionary<Transform, InstallationMoveBlackHolePattern.HitTimerManager> targetTimerList; // 0xE8
	private bool invalid; // 0xF0
	private bool isPlayEndMotion; // 0xF1
	private bool isMoveEffectStart; // 0xF2

	// Properties
	public override bool VisibleAttackArea { get; }
	public Vector3 CenterPosition { get; }
	public MobAttackCategory InstallationCategory { get; }
	public ElementType Element { get; set; }

	// Methods

	// RVA: 0x1D45EA4 Offset: 0x1D41EA4 VA: 0x1D45EA4
	public void .ctor(MobActionPattern pattern, MobActionPattern parentPattern, EnemyMobActionManagerBase actionManager, GameObject target, Vector3 initPos, Vector3 targetPos, byte localId) { }

	// RVA: 0x1D463C4 Offset: 0x1D423C4 VA: 0x1D463C4 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1D463CC Offset: 0x1D423CC VA: 0x1D463CC Slot: 45
	public Vector3 get_CenterPosition() { }

	// RVA: 0x1D46460 Offset: 0x1D42460 VA: 0x1D46460 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	[CompilerGenerated]
	// RVA: 0x1D46468 Offset: 0x1D42468 VA: 0x1D46468 Slot: 37
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1D46470 Offset: 0x1D42470 VA: 0x1D46470
	private void set_Element(ElementType value) { }

	// RVA: 0x1D46478 Offset: 0x1D42478 VA: 0x1D46478 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D4647C Offset: 0x1D4247C VA: 0x1D4647C Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D47008 Offset: 0x1D43008 VA: 0x1D47008 Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1D4705C Offset: 0x1D4305C VA: 0x1D4705C Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D470C4 Offset: 0x1D430C4 VA: 0x1D470C4 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D473F4 Offset: 0x1D433F4 VA: 0x1D473F4 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D4745C Offset: 0x1D4345C VA: 0x1D4745C Slot: 46
	public bool CheckNearCircumfrence(Transform targetTransform) { }

	// RVA: 0x1D47464 Offset: 0x1D43464 VA: 0x1D47464 Slot: 38
	public void Clear() { }

	// RVA: 0x1D4779C Offset: 0x1D4379C VA: 0x1D4779C Slot: 39
	public void Invalid() { }

	// RVA: 0x1D47A80 Offset: 0x1D43A80 VA: 0x1D47A80 Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1D47AC8 Offset: 0x1D43AC8 VA: 0x1D47AC8 Slot: 41
	public void SetBulletModel(GameObject[] bulletModel) { }

	// RVA: 0x1D48000 Offset: 0x1D44000 VA: 0x1D48000 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1D48008 Offset: 0x1D44008 VA: 0x1D48008 Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1D48010 Offset: 0x1D44010 VA: 0x1D48010 Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }

	// RVA: 0x1D47268 Offset: 0x1D43268 VA: 0x1D47268
	private void NextMove(Vector3 pos, float speed, float time) { }

	// RVA: 0x1D47DD4 Offset: 0x1D43DD4 VA: 0x1D47DD4
	private bool CheckWall(Vector3 nextPos) { }

	// RVA: 0x1D47EDC Offset: 0x1D43EDC VA: 0x1D47EDC
	private bool CheckFloor(Vector3 nextPos) { }

	// RVA: 0x1D466A4 Offset: 0x1D426A4 VA: 0x1D466A4
	private bool CheckSuctionHit(Transform targetTransform) { }

	// RVA: 0x1D46E38 Offset: 0x1D42E38 VA: 0x1D46E38
	private bool CheckDamageHit(Transform targetTransform) { }

	// RVA: 0x1D4692C Offset: 0x1D4292C VA: 0x1D4692C
	private void Suction(Transform targetTransform) { }

	// RVA: 0x1D46ECC Offset: 0x1D42ECC VA: 0x1D46ECC
	private void Damage(Transform targetTransform) { }

	// RVA: 0x1D4806C Offset: 0x1D4406C VA: 0x1D4806C
	private static float CalcDistance(Vector3 actorPos, Vector3 targetPos) { }
}
