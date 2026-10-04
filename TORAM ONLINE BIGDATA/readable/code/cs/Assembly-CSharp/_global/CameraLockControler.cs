// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraLockControler : CameraControlerBase // TypeDefIndex: 370
{
	// Fields
	protected float rotateSpeed; // 0x20
	protected float heightMoveSpeed; // 0x24
	protected bool screenXMove; // 0x28
	protected bool screenYMove; // 0x29
	private bool screenZMove; // 0x2A
	protected float ax; // 0x2C
	private float rotateStartX; // 0x30
	protected float ay; // 0x34
	private float heightStart; // 0x38
	private float az; // 0x3C
	private float pinchStart; // 0x40
	protected float screenRotateThreshold; // 0x44
	protected float screenHeightThreshold; // 0x48
	private float screenPinchThreshold; // 0x4C
	protected float rotateThreshold; // 0x50
	protected float heightMoveThreshold; // 0x54
	protected Vector3 angle; // 0x58
	private Vector3 cameraOffset; // 0x64
	private float moveTimer; // 0x70
	private bool isMovePlayerBack; // 0x74
	private Vector3 savePosition; // 0x78
	private Quaternion saveRotaition; // 0x84
	private Transform playerTrans; // 0x98
	private CharacterMove characterMove; // 0xA0
	protected bool isHeight; // 0xA8
	protected float minHeight; // 0xAC
	protected float maxHeight; // 0xB0
	protected bool isCameraLock; // 0xB4

	// Properties
	public override CameraControlerType Type { get; }
	public override Vector3 Position { get; }
	public override Vector3 TargetDist { get; }
	protected Vector3 cameraTracePosition { get; }
	public Vector3 Angle { get; }

	// Methods

	// RVA: 0x25515A8 Offset: 0x254D5A8 VA: 0x25515A8 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x25515B0 Offset: 0x254D5B0 VA: 0x25515B0 Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x25515F8 Offset: 0x254D5F8 VA: 0x25515F8 Slot: 4
	public override Vector3 get_TargetDist() { }

	// RVA: 0x2551624 Offset: 0x254D624 VA: 0x2551624
	protected Vector3 get_cameraTracePosition() { }

	// RVA: 0x2551790 Offset: 0x254D790 VA: 0x2551790
	public Vector3 get_Angle() { }

	// RVA: 0x255179C Offset: 0x254D79C VA: 0x255179C
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x2551894 Offset: 0x254D894 VA: 0x2551894 Slot: 7
	public override void OnActive() { }

	// RVA: 0x2551988 Offset: 0x254D988 VA: 0x2551988 Slot: 8
	public override void Update() { }

	// RVA: 0x255198C Offset: 0x254D98C VA: 0x255198C Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x2551BBC Offset: 0x254DBBC VA: 0x2551BBC
	public void SetCameraOffset(Vector3 offset) { }

	// RVA: 0x2551BC8 Offset: 0x254DBC8 VA: 0x2551BC8
	public void SetCameraDetailData(bool isHeight, float minHeight, float maxHeight) { }

	// RVA: 0x2551BD8 Offset: 0x254DBD8 VA: 0x2551BD8
	public void SetCameraDetailData(bool isHeight, float minHeight, float maxHeight, Vector3 angle) { }

	// RVA: 0x2551C00 Offset: 0x254DC00 VA: 0x2551C00
	public void SetCameraAngle(byte flag, Vector3 angle) { }

	// RVA: 0x2551C2C Offset: 0x254DC2C VA: 0x2551C2C
	public void ChangeCameraLock(bool isLock) { }

	// RVA: 0x2551C38 Offset: 0x254DC38 VA: 0x2551C38 Slot: 10
	protected virtual void screenRotateCamera(float dx) { }

	// RVA: 0x2551D34 Offset: 0x254DD34 VA: 0x2551D34 Slot: 11
	protected virtual void screenHeightRotateCamera(float dy) { }

	// RVA: 0x2551E34 Offset: 0x254DE34 VA: 0x2551E34 Slot: 12
	protected virtual void rotateCamera(float dx) { }

	// RVA: 0x2551F24 Offset: 0x254DF24 VA: 0x2551F24 Slot: 13
	protected virtual void heightMoveCamera(float dy) { }
}
