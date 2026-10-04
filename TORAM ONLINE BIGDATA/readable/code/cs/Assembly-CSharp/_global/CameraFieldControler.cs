// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraFieldControler : CameraControlerBase // TypeDefIndex: 369
{
	// Fields
	private readonly float pinchMoveSpeed; // 0x20
	private readonly float minDist; // 0x24
	private readonly float maxDist; // 0x28
	private float rotateSpeed; // 0x2C
	private readonly float heightMoveSpeed; // 0x30
	private bool screenXMove; // 0x34
	private bool screenYMove; // 0x35
	private bool screenZMove; // 0x36
	private float ax; // 0x38
	private float rotateStartX; // 0x3C
	private float ay; // 0x40
	private float heightStart; // 0x44
	private float az; // 0x48
	private float pinchStart; // 0x4C
	private float screenRotateThreshold; // 0x50
	private float screenHeightThreshold; // 0x54
	private float screenPinchThreshold; // 0x58
	private float rotateThreshold; // 0x5C
	private float heightMoveThreshold; // 0x60
	private float moveTimer; // 0x64
	private bool isMovePlayerBack; // 0x68
	private bool isMovePlayerFront; // 0x69
	private float damping; // 0x6C
	public Vector3 newCameraPos; // 0x70
	public Vector3 oldCameraPos; // 0x7C
	private bool oldHitFlag; // 0x88
	private bool newHitFlag; // 0x89
	private Vector3 oldNoraml; // 0x8C
	private Vector3 newNoraml; // 0x98
	protected Vector3 targetPos; // 0xA4
	protected Vector3 oldTargetPos; // 0xB0
	protected float dist; // 0xBC
	protected float height; // 0xC0
	protected Quaternion rotate; // 0xC4
	public float rotateX; // 0xD4
	private bool isImmediatelyResetFrame; // 0xD8
	private bool isResetFrame; // 0xD9
	private Transform playerTransData; // 0xE0
	private float heightMax; // 0xE8
	private float heightMin; // 0xEC
	private bool isInit; // 0xF0
	private float followCamRate; // 0xF4
	[SerializeField]
	private float fastCamRate; // 0xF8
	[SerializeField]
	private float normalCamRate; // 0xFC
	[SerializeField]
	private float slowCamRate; // 0x100
	private OptionsSystem.CameraFollowType followType; // 0x104

	// Properties
	protected virtual Transform playerTrans { get; }
	protected virtual Transform autoLookTargetObject { get; }
	public override CameraControlerType Type { get; }
	public override Vector3 Position { get; }
	public override Vector3 TargetDist { get; }
	public Quaternion Rotate { get; }
	protected virtual ICamaraInputManager inputManager { get; }

	// Methods

	// RVA: 0x248E778 Offset: 0x248A778 VA: 0x248E778 Slot: 10
	protected virtual Transform get_playerTrans() { }

	// RVA: 0x248E80C Offset: 0x248A80C VA: 0x248E80C Slot: 11
	protected virtual Transform get_autoLookTargetObject() { }

	// RVA: 0x248E828 Offset: 0x248A828 VA: 0x248E828 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x248E830 Offset: 0x248A830 VA: 0x248E830 Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x248E878 Offset: 0x248A878 VA: 0x248E878 Slot: 4
	public override Vector3 get_TargetDist() { }

	// RVA: 0x248E890 Offset: 0x248A890 VA: 0x248E890
	public Quaternion get_Rotate() { }

	// RVA: 0x248E89C Offset: 0x248A89C VA: 0x248E89C Slot: 12
	protected virtual ICamaraInputManager get_inputManager() { }

	// RVA: 0x248E8DC Offset: 0x248A8DC VA: 0x248E8DC
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x248EA48 Offset: 0x248AA48 VA: 0x248EA48
	public void Init(float rot, Quaternion rotate, float heightMin, float heightMax) { }

	// RVA: 0x248F600 Offset: 0x248B600 VA: 0x248F600 Slot: 13
	protected virtual void setTargetPos() { }

	// RVA: 0x248F638 Offset: 0x248B638 VA: 0x248F638 Slot: 8
	public override void Update() { }

	// RVA: 0x248F63C Offset: 0x248B63C VA: 0x248F63C Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x248EB50 Offset: 0x248AB50 VA: 0x248EB50
	private void defaultCameraUpdate() { }

	// RVA: 0x249072C Offset: 0x248C72C VA: 0x249072C
	public void RotateCameraPlayerBack() { }

	// RVA: 0x24908D8 Offset: 0x248C8D8 VA: 0x24908D8
	public void RotateCameraPlayerFront() { }

	// RVA: 0x2490A7C Offset: 0x248CA7C VA: 0x2490A7C
	public void ResetCamera(float rot) { }

	// RVA: 0x2490AF0 Offset: 0x248CAF0 VA: 0x2490AF0
	public void ImmediatelyResetCamera() { }

	// RVA: 0x2490AFC Offset: 0x248CAFC VA: 0x2490AFC
	public void CopyCamera(CameraFieldControler copyBase) { }

	// RVA: 0x248FD08 Offset: 0x248BD08 VA: 0x248FD08
	private void screenRotateCamera(float dx) { }

	// RVA: 0x248FE54 Offset: 0x248BE54 VA: 0x248FE54
	private void screenHeightRotateCamera(float dy) { }

	// RVA: 0x2490B2C Offset: 0x248CB2C VA: 0x2490B2C Slot: 14
	protected virtual float screenHeightRotateCameraMove(float heightStart, float move, float power) { }

	// RVA: 0x24901E4 Offset: 0x248C1E4 VA: 0x24901E4
	private void screenPinchCamera(float dz) { }

	// RVA: 0x248FF84 Offset: 0x248BF84 VA: 0x248FF84
	private void rotateCamera(float dx) { }

	// RVA: 0x24900C0 Offset: 0x248C0C0 VA: 0x24900C0
	private void heightMoveCamera(float dy) { }

	// RVA: 0x2490B38 Offset: 0x248CB38 VA: 0x2490B38 Slot: 15
	protected virtual float heightMoveCameraMove(float move, float power) { }

	// RVA: 0x24902C8 Offset: 0x248C2C8 VA: 0x24902C8
	private Vector3 cameraMoveHitCheck() { }

	// RVA: 0x248F8C4 Offset: 0x248B8C4 VA: 0x248F8C4
	private void defaultCamera() { }

	// RVA: 0x2490B40 Offset: 0x248CB40 VA: 0x2490B40
	public void SetFollowCamRate(float rate) { }

	// RVA: 0x2490B48 Offset: 0x248CB48 VA: 0x2490B48
	public void ResetCameraFollow() { }

	// RVA: 0x248F780 Offset: 0x248B780 VA: 0x248F780
	private void UpdateFollowRate() { }
}
