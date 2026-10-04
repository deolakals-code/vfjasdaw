// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraScriptControler : CameraControlerBase // TypeDefIndex: 378
{
	// Fields
	private bool isScriptCameraAutoReset; // 0x20
	private CameraScriptControler.ScriptCameraType cameraType; // 0x24
	private float moveTime; // 0x28
	private float moveProgressTime; // 0x2C
	private Quaternion scriptTargetRotate; // 0x30
	private Quaternion scriptMoveTargetRotate; // 0x40
	private Vector3 scriptCameraPos; // 0x50
	private Vector3 scriptMoveCameraPos; // 0x5C
	private CameraScriptControler.TimeFlag moveTimeFlag; // 0x68
	private float timeMoveBias1; // 0x6C
	private float timeMoveBias2; // 0x70

	// Properties
	public override Vector3 TargetDist { get; }
	public override Vector3 Position { get; }
	public override CameraControlerType Type { get; }
	public bool IsMove { get; }

	// Methods

	// RVA: 0x25539A0 Offset: 0x254F9A0 VA: 0x25539A0 Slot: 4
	public override Vector3 get_TargetDist() { }

	// RVA: 0x25539BC Offset: 0x254F9BC VA: 0x25539BC Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x25539D8 Offset: 0x254F9D8 VA: 0x25539D8 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x25539E0 Offset: 0x254F9E0 VA: 0x25539E0
	public bool get_IsMove() { }

	// RVA: 0x25539F0 Offset: 0x254F9F0 VA: 0x25539F0
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x25539F8 Offset: 0x254F9F8 VA: 0x25539F8 Slot: 7
	public override void OnActive() { }

	// RVA: 0x2553A4C Offset: 0x254FA4C VA: 0x2553A4C Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x2553A50 Offset: 0x254FA50 VA: 0x2553A50 Slot: 8
	public override void Update() { }

	// RVA: 0x2553A54 Offset: 0x254FA54 VA: 0x2553A54
	private void scriptCameraUpdate() { }

	// RVA: 0x2553D38 Offset: 0x254FD38 VA: 0x2553D38
	private Vector3 getCameraPos(Vector3 pos) { }

	// RVA: 0x2553F2C Offset: 0x254FF2C VA: 0x2553F2C
	private Quaternion getCameraTarget(Vector3 target) { }

	// RVA: 0x25540CC Offset: 0x25500CC VA: 0x25540CC
	public void SetCameraAutoReset() { }

	// RVA: 0x25540FC Offset: 0x25500FC VA: 0x25540FC
	public void SetScriptCamera(float time, Vector3 target, Vector3 pos) { }

	// RVA: 0x2554180 Offset: 0x2550180 VA: 0x2554180
	public void SetScriptCameraMove(float time, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos) { }

	// RVA: 0x2554264 Offset: 0x2550264 VA: 0x2554264
	public void SetScriptCameraMove(float time, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos, bool slowStart, bool slowStop) { }

	// RVA: 0x255447C Offset: 0x255047C VA: 0x255447C
	public float SetScriptCameraMoveSpeed(float speed, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos) { }

	// RVA: 0x255440C Offset: 0x255040C VA: 0x255440C
	public bool ScriptCameraMoveSkip() { }
}
