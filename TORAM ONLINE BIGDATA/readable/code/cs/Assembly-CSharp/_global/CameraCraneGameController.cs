// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraCraneGameController : CameraControlerBase // TypeDefIndex: 367
{
	// Fields
	private UICraneGameManager uiManager; // 0x20
	private CraneGameRoomData roomData; // 0x28
	private Vector3 cameraPos; // 0x30
	private Vector3 targetPos; // 0x3C
	private Dictionary<string, Vector3> cameraWidthMaxPos; // 0x48
	private int cameraWidthMaxAngle; // 0x50
	private Dictionary<string, Vector3> cameraHeightMaxPos; // 0x58
	private int cameraHeightMaxAngle; // 0x60
	private float cameraMoveSpeed; // 0x64
	private float cameraFormedAngle; // 0x68

	// Properties
	public override Vector3 Position { get; }
	public override Vector3 TargetDist { get; }
	public override CameraControlerType Type { get; }
	public Vector3 TargetPos { get; }
	protected virtual ICamaraInputManager inputManager { get; }
	public float CameraFormedAngle { get; }

	// Methods

	// RVA: 0x248D660 Offset: 0x2489660 VA: 0x248D660 Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x248D66C Offset: 0x248966C VA: 0x248D66C Slot: 4
	public override Vector3 get_TargetDist() { }

	// RVA: 0x248D6B0 Offset: 0x24896B0 VA: 0x248D6B0 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x248D6B8 Offset: 0x24896B8 VA: 0x248D6B8
	public Vector3 get_TargetPos() { }

	// RVA: 0x248D6C4 Offset: 0x24896C4 VA: 0x248D6C4 Slot: 10
	protected virtual ICamaraInputManager get_inputManager() { }

	// RVA: 0x248D704 Offset: 0x2489704 VA: 0x248D704
	public float get_CameraFormedAngle() { }

	// RVA: 0x248D70C Offset: 0x248970C VA: 0x248D70C
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x248D7D0 Offset: 0x24897D0 VA: 0x248D7D0
	public void SetCameraTrans(Vector3 pos, Vector3 rot) { }

	// RVA: 0x248DAA4 Offset: 0x2489AA4 VA: 0x248DAA4
	public void SetCameraTransLookTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x248DB20 Offset: 0x2489B20 VA: 0x248DB20 Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x248E580 Offset: 0x248A580 VA: 0x248E580 Slot: 8
	public override void Update() { }

	// RVA: 0x248D7E8 Offset: 0x24897E8 VA: 0x248D7E8
	private void SetCamera(Vector3 pos, Vector3 rot) { }

	// RVA: 0x248DABC Offset: 0x2489ABC VA: 0x248DABC
	private void SetCameraLookTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x248D854 Offset: 0x2489854 VA: 0x248D854
	private void Initialize() { }

	// RVA: 0x248DE8C Offset: 0x2489E8C VA: 0x248DE8C
	public void CameraWidthMove(float movePower) { }

	// RVA: 0x248E318 Offset: 0x248A318 VA: 0x248E318
	public void CameraHeightMove(float movePower) { }

	// RVA: 0x248E584 Offset: 0x248A584 VA: 0x248E584
	private Vector3 GetCameraWidthMoveRange(bool isLeftMove) { }

	// RVA: 0x248E734 Offset: 0x248A734 VA: 0x248E734
	private Vector3 GetCameraHeightMoveRange(bool isUpMove) { }
}
