// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraSnowballControler : CameraControlerBase // TypeDefIndex: 380
{
	// Fields
	public Vector3 newCameraPos; // 0x20
	public Vector3 oldCameraPos; // 0x2C
	public float rotateX; // 0x38
	protected float dist; // 0x3C
	protected float height; // 0x40
	protected Quaternion rotate; // 0x44
	private readonly float pinchMoveSpeed; // 0x54
	private readonly float minDist; // 0x58
	private readonly float maxDist; // 0x5C
	private float rotateSpeed; // 0x60
	private bool screenXMove; // 0x64
	private bool screenYMove; // 0x65
	private bool screenZMove; // 0x66
	private float ax; // 0x68
	private float rotateStartX; // 0x6C
	private float ay; // 0x70
	private float heightStart; // 0x74
	private float az; // 0x78
	private float pinchStart; // 0x7C
	private float screenRotateThreshold; // 0x80
	private float screenHeightThreshold; // 0x84
	private float screenPinchThreshold; // 0x88
	private float rotateThreshold; // 0x8C
	private float moveTimer; // 0x90
	private bool isMovePlayerBack; // 0x94
	private bool isMovePlayerFront; // 0x95
	private float damping; // 0x98
	private bool oldHitFlag; // 0x9C
	private bool newHitFlag; // 0x9D
	private Vector3 oldNoraml; // 0xA0
	private Vector3 newNoraml; // 0xAC
	private Vector3 targetPos; // 0xB8
	private Vector3 oldTargetPos; // 0xC4
	private bool isImmediatelyResetFrame; // 0xD0
	private bool isResetFrame; // 0xD1
	private Transform playerTrans; // 0xD8
	private float heightMax; // 0xE0
	private float heightMin; // 0xE4
	private bool isInit; // 0xE8
	private CameraSnowballControler.CameraType nowCameraType; // 0xEC
	private Vector3 angle; // 0xF0
	private float minHeight; // 0xFC
	private float maxHeight; // 0x100
	private bool isMove; // 0x104
	private float moveTime; // 0x108
	private Vector3 moveOldTransPos; // 0x10C
	private Quaternion moveOldTransRot; // 0x118
	private Vector3 moveNewTransPos; // 0x128
	private Quaternion moveNewTransRot; // 0x134
	private Vector3 defalutCameraNewPos; // 0x144
	private bool isPCCameraLock; // 0x150
	private Vector3 lastMousePosition; // 0x154
	private float mouseY; // 0x160
	private float followCamRate; // 0x164
	[SerializeField]
	private float fastCamRate; // 0x168
	[SerializeField]
	private float normalCamRate; // 0x16C
	[SerializeField]
	private float slowCamRate; // 0x170
	private OptionsSystem.CameraFollowType followType; // 0x174

	// Properties
	public override CameraControlerType Type { get; }
	public override Vector3 Position { get; }
	public override Vector3 TargetDist { get; }
	public CameraSnowballControler.CameraType NowCameraType { get; }
	private float heightMoveSpeed { get; }
	private float heightMoveThreshold { get; }
	private Transform autoLookTargetObject { get; }
	private Vector3 snowballCameraOffset { get; }
	private Vector3 cameraTracePosition { get; }
	protected virtual ICamaraInputManager inputManager { get; }

	// Methods

	// RVA: 0x25545D0 Offset: 0x25505D0 VA: 0x25545D0 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x25545D8 Offset: 0x25505D8 VA: 0x25545D8 Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x2554620 Offset: 0x2550620 VA: 0x2554620 Slot: 4
	public override Vector3 get_TargetDist() { }

	// RVA: 0x2554670 Offset: 0x2550670 VA: 0x2554670
	public CameraSnowballControler.CameraType get_NowCameraType() { }

	// RVA: 0x2554678 Offset: 0x2550678 VA: 0x2554678
	private float get_heightMoveSpeed() { }

	// RVA: 0x2554694 Offset: 0x2550694 VA: 0x2554694
	private float get_heightMoveThreshold() { }

	// RVA: 0x25546B0 Offset: 0x25506B0 VA: 0x25546B0
	private Transform get_autoLookTargetObject() { }

	// RVA: 0x25546CC Offset: 0x25506CC VA: 0x25546CC
	private Vector3 get_snowballCameraOffset() { }

	// RVA: 0x2554738 Offset: 0x2550738 VA: 0x2554738
	private Vector3 get_cameraTracePosition() { }

	// RVA: 0x25548BC Offset: 0x25508BC VA: 0x25548BC Slot: 10
	protected virtual ICamaraInputManager get_inputManager() { }

	// RVA: 0x25548FC Offset: 0x25508FC VA: 0x25548FC
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x2554AB8 Offset: 0x2550AB8 VA: 0x2554AB8
	public void Init(float rot, Quaternion rotate, float heightMin, float heightMax) { }

	// RVA: 0x25551D4 Offset: 0x25511D4 VA: 0x25551D4
	public void ForceChangeCameraType(CameraSnowballControler.CameraType cameraType, float moveTime) { }

	// RVA: 0x25559E0 Offset: 0x25519E0 VA: 0x25559E0
	public bool ChangeCameraType(CameraSnowballControler.CameraType cameraType, float moveTime) { }

	// RVA: 0x2555A10 Offset: 0x2551A10 VA: 0x2555A10
	public void ChangePCCameraLock(bool isLock) { }

	// RVA: 0x2555A1C Offset: 0x2551A1C VA: 0x2555A1C Slot: 7
	public override void OnActive() { }

	// RVA: 0x2555A20 Offset: 0x2551A20 VA: 0x2555A20 Slot: 8
	public override void Update() { }

	// RVA: 0x2555A24 Offset: 0x2551A24 VA: 0x2555A24 Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x2554C24 Offset: 0x2550C24 VA: 0x2554C24
	private void DefaultCameraUpdate() { }

	// RVA: 0x2554D7C Offset: 0x2550D7C VA: 0x2554D7C
	private void CharacterCameraUpdate() { }

	// RVA: 0x2555BD4 Offset: 0x2551BD4 VA: 0x2555BD4
	private void defaultCameraUpdate() { }

	// RVA: 0x2556B80 Offset: 0x2552B80 VA: 0x2556B80
	private void screenRotateCamera(float dx) { }

	// RVA: 0x2556CCC Offset: 0x2552CCC VA: 0x2556CCC
	private void screenHeightRotateCamera(float dy) { }

	// RVA: 0x2557274 Offset: 0x2553274 VA: 0x2557274 Slot: 11
	protected virtual float screenHeightRotateCameraMove(float heightStart, float move, float power) { }

	// RVA: 0x2557280 Offset: 0x2553280 VA: 0x2557280
	private void screenPinchCamera(float dz) { }

	// RVA: 0x2555554 Offset: 0x2551554 VA: 0x2555554
	private void rotateCamera(float dx) { }

	// RVA: 0x2555688 Offset: 0x2551688 VA: 0x2555688
	private void heightMoveCamera(float dy) { }

	// RVA: 0x2557364 Offset: 0x2553364 VA: 0x2557364 Slot: 12
	protected virtual float heightMoveCameraMove(float move, float power) { }

	// RVA: 0x2556E10 Offset: 0x2552E10 VA: 0x2556E10
	private Vector3 cameraMoveHitCheck() { }

	// RVA: 0x2556514 Offset: 0x2552514 VA: 0x2556514
	private void defaultCamera() { }

	// RVA: 0x25573CC Offset: 0x25533CC VA: 0x25573CC
	public void SetFollowCamRate(float rate) { }

	// RVA: 0x25573D4 Offset: 0x25533D4 VA: 0x25573D4
	public void ResetCameraFollow() { }

	// RVA: 0x2555A90 Offset: 0x2551A90 VA: 0x2555A90
	private void UpdateFollowRate() { }

	// RVA: 0x2556974 Offset: 0x2552974 VA: 0x2556974
	private void screenSnowballRotateCamera(float dx) { }

	// RVA: 0x2556A70 Offset: 0x2552A70 VA: 0x2556A70
	private void screenSnowballHeightRotateCamera(float dy) { }

	// RVA: 0x25557D0 Offset: 0x25517D0 VA: 0x25557D0
	private void rotateSnowballCamera(float dx) { }

	// RVA: 0x25558C0 Offset: 0x25518C0 VA: 0x25558C0
	private void heightSnowballMoveCamera(float dy) { }
}
