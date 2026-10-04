// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InstallationBounceParabolaAttackPattern : MobPatternBase, IInstallationAttackPattern, ILineParam // TypeDefIndex: 768
{
	// Fields
	private bool isEnd; // 0x6E
	private readonly ElementType element; // 0x70
	private readonly Vector3 lineVector; // 0x74
	private GameObject bullet; // 0x80
	private Motion bulletMotion; // 0x88
	private CharacterMove charaMove; // 0x90
	private Vector3 initPos; // 0x98
	private Vector3 prevUpdatePos; // 0xA4
	private Vector3 startPos; // 0xB0
	private Vector3 endPos; // 0xBC
	private float boundMoveDistanceXZ; // 0xC8
	private float boundMoveDistanceY; // 0xCC
	private float movePosY; // 0xD0
	private float boundHeight; // 0xD4
	private float moveAngle; // 0xD8
	private Vector3 moveDir; // 0xDC
	private List<Transform> hitTargetList; // 0xE8
	private int boundCount; // 0xF0
	private int flag; // 0xF4
	private int boundEffectId; // 0xF8
	private int boundEffectMotionNo; // 0xFC
	private float range; // 0x100
	private float speed; // 0x104
	private float rangeAttenuation; // 0x108
	private float boundDistance; // 0x10C
	private float boundDistanceAttenuation; // 0x110
	private float boundNextAngleValue; // 0x114
	private float nextAngleValueAttenuation; // 0x118
	private bool isMove; // 0x11C
	private bool reverse; // 0x11D
	private float timeToPeak; // 0x120
	private float totalMoveTime; // 0x124
	private float gravity; // 0x128
	private float initSpeedY; // 0x12C
	private bool isFallOutside; // 0x130
	private float correctDistance; // 0x134

	// Properties
	public override bool VisibleAttackArea { get; }
	public MobAttackCategory InstallationCategory { get; }
	public ElementType Element { get; }
	public Vector3 LineVector { get; }

	// Methods

	// RVA: 0x1C7B5D8 Offset: 0x1C775D8 VA: 0x1C7B5D8
	public void .ctor(MobActionPattern pattern, MobActionPattern parentPattern, EnemyMobActionManagerBase mobAction, GameObject target, Vector3 startPos, Vector3 attackDir, ElementType elementType) { }

	// RVA: 0x1C7BB08 Offset: 0x1C77B08 VA: 0x1C7BB08 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C7BB10 Offset: 0x1C77B10 VA: 0x1C7BB10 Slot: 36
	public MobAttackCategory get_InstallationCategory() { }

	// RVA: 0x1C7BB18 Offset: 0x1C77B18 VA: 0x1C7BB18 Slot: 37
	public ElementType get_Element() { }

	// RVA: 0x1C7BB20 Offset: 0x1C77B20 VA: 0x1C7BB20 Slot: 45
	public Vector3 get_LineVector() { }

	// RVA: 0x1C7BB2C Offset: 0x1C77B2C VA: 0x1C7BB2C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C7BB30 Offset: 0x1C77B30 VA: 0x1C7BB30 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C7CAF4 Offset: 0x1C78AF4 VA: 0x1C7CAF4 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1C7CBF4 Offset: 0x1C78BF4 VA: 0x1C7CBF4 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1C7CC7C Offset: 0x1C78C7C VA: 0x1C7CC7C Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1C7C34C Offset: 0x1C7834C VA: 0x1C7C34C
	private void NextMove(Vector3 pos, float time) { }

	// RVA: 0x1C7C5B0 Offset: 0x1C785B0 VA: 0x1C7C5B0
	private void NextBound() { }

	// RVA: 0x1C7CCE4 Offset: 0x1C78CE4 VA: 0x1C7CCE4
	private bool CheckWall(Vector3 checkPos, Vector3 dir) { }

	// RVA: 0x1C7CEAC Offset: 0x1C78EAC VA: 0x1C7CEAC
	private bool CheckFloor(Vector3 checkPos) { }

	// RVA: 0x1C7C8B4 Offset: 0x1C788B4 VA: 0x1C7C8B4
	private void PlayBoundEffect() { }

	// RVA: 0x1C7BA34 Offset: 0x1C77A34 VA: 0x1C7BA34
	private void InitializeMoveParameter() { }

	// RVA: 0x1C7C4E8 Offset: 0x1C784E8 VA: 0x1C7C4E8
	private float CalcCurrentHeight(Vector3 currentPos) { }

	// RVA: 0x1C7CFF8 Offset: 0x1C78FF8 VA: 0x1C7CFF8 Slot: 38
	public void Clear() { }

	// RVA: 0x1C7D098 Offset: 0x1C79098 VA: 0x1C7D098 Slot: 44
	public GameObject GetBullet() { }

	// RVA: 0x1C7D0A0 Offset: 0x1C790A0 VA: 0x1C7D0A0 Slot: 43
	public GameObject GetTarget() { }

	// RVA: 0x1C7D0A8 Offset: 0x1C790A8 VA: 0x1C7D0A8 Slot: 39
	public void Invalid() { }

	// RVA: 0x1C7D0AC Offset: 0x1C790AC VA: 0x1C7D0AC Slot: 40
	public bool IsEnd() { }

	// RVA: 0x1C7D0B4 Offset: 0x1C790B4 VA: 0x1C7D0B4 Slot: 41
	public void SetBulletModel(GameObject[] bulletModels) { }

	// RVA: 0x1C7D26C Offset: 0x1C7926C VA: 0x1C7D26C Slot: 42
	public void SetParentParameter(MobPatternBase parentPattern) { }
}
