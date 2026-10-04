// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraMahjongController : CameraControlerBase // TypeDefIndex: 371
{
	// Fields
	private MahjongRoomData roomData; // 0x20
	private UIMahjongMainManager uiManager; // 0x28
	private Vector3 cameraPos; // 0x30
	private Vector3 targetPos; // 0x3C
	private readonly Vector2 MaxTouchScreenPos; // 0x48
	private readonly Vector2 MinTouchScreenPos; // 0x50
	private float mouseOverTime; // 0x58
	private const float MouseOverResetTime = 0.2;
	private Vector3 firstTouchPos; // 0x5C
	private bool isDraging; // 0x68
	private readonly Vector2 InitialEuler; // 0x6C
	private Vector2 angleOffset; // 0x74
	private readonly float MaxRadius; // 0x7C
	private float returnDefaultAngleTimer; // 0x80
	private bool isReturnDefaultPosMove; // 0x84
	private const float returnDefaultPosDuration = 5;

	// Properties
	public override Vector3 Position { get; }
	public Vector3 EulerAngles { get; }
	public override Vector3 TargetDist { get; }
	public override CameraControlerType Type { get; }
	public Vector3 TargetPos { get; }

	// Methods

	// RVA: 0x2552034 Offset: 0x254E034 VA: 0x2552034 Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x2552050 Offset: 0x254E050 VA: 0x2552050
	public Vector3 get_EulerAngles() { }

	// RVA: 0x2552090 Offset: 0x254E090 VA: 0x2552090 Slot: 4
	public override Vector3 get_TargetDist() { }

	// RVA: 0x25520D4 Offset: 0x254E0D4 VA: 0x25520D4 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x25520DC Offset: 0x254E0DC VA: 0x25520DC
	public Vector3 get_TargetPos() { }

	// RVA: 0x25520E8 Offset: 0x254E0E8 VA: 0x25520E8
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x25521A8 Offset: 0x254E1A8 VA: 0x25521A8
	public void SetCameraTrans(Vector3 pos, Vector3 rot) { }

	// RVA: 0x2552218 Offset: 0x254E218 VA: 0x2552218
	public void SetCameraTransTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x2552280 Offset: 0x254E280 VA: 0x2552280
	public void ResetCameraAngle() { }

	// RVA: 0x2552384 Offset: 0x254E384 VA: 0x2552384 Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x2552DBC Offset: 0x254EDBC VA: 0x2552DBC Slot: 8
	public override void Update() { }

	// RVA: 0x25521AC Offset: 0x254E1AC VA: 0x25521AC
	private void SetCamera(Vector3 pos, Vector3 rot) { }

	// RVA: 0x255221C Offset: 0x254E21C VA: 0x255221C
	private void SetCameraLookTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x2552960 Offset: 0x254E960 VA: 0x2552960
	private bool IsScreenTouch(out Vector3 touchPos) { }

	// RVA: 0x2552AB0 Offset: 0x254EAB0 VA: 0x2552AB0
	private void ReturnDefaultAngle() { }
}
