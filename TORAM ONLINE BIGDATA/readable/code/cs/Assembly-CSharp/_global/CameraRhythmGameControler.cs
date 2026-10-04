// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraRhythmGameControler : CameraControlerBase // TypeDefIndex: 375
{
	// Fields
	private Vector3 cameraPos; // 0x20
	private Vector3 cameraRot; // 0x2C
	private CameraRhythmGameControler.CameraType nowCameraType; // 0x38
	private bool isMoveCamera; // 0x3C
	private int moveState; // 0x40
	private float moveTimer; // 0x44
	private const float moveTime = 10;
	private TweenPosition tweenPosition; // 0x48
	private TweenRotation tweenRotation; // 0x50
	private float rotateX; // 0x58
	private Vector3 targetPos; // 0x5C
	private Vector3 offsetPos; // 0x68

	// Properties
	public override Vector3 Position { get; }
	public override Vector3 TargetDist { get; }
	public override CameraControlerType Type { get; }
	public CameraRhythmGameControler.CameraType NowCameraType { get; }

	// Methods

	// RVA: 0x2553520 Offset: 0x254F520 VA: 0x2553520 Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x255352C Offset: 0x254F52C VA: 0x255352C Slot: 4
	public override Vector3 get_TargetDist() { }

	// RVA: 0x2553570 Offset: 0x254F570 VA: 0x2553570 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x2553578 Offset: 0x254F578 VA: 0x2553578
	public CameraRhythmGameControler.CameraType get_NowCameraType() { }

	// RVA: 0x2553580 Offset: 0x254F580 VA: 0x2553580
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x2553590 Offset: 0x254F590 VA: 0x2553590
	public void UpdateCameraTrans(byte type, Vector3 pos, Vector3 rot) { }

	// RVA: 0x255364C Offset: 0x254F64C VA: 0x255364C
	public void SetCameraTrans(byte type, Vector3 pos, Vector3 rot) { }

	// RVA: 0x25536BC Offset: 0x254F6BC VA: 0x25536BC
	public void SetMoveCameraFlag(bool isMoveCamera) { }

	// RVA: 0x2553878 Offset: 0x254F878 VA: 0x2553878 Slot: 7
	public override void OnActive() { }

	// RVA: 0x255387C Offset: 0x254F87C VA: 0x255387C Slot: 8
	public override void Update() { }

	// RVA: 0x2553880 Offset: 0x254F880 VA: 0x2553880 Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x255359C Offset: 0x254F59C VA: 0x255359C
	private void UpdateCamera(Vector3 pos, Vector3 rot) { }

	// RVA: 0x2553658 Offset: 0x254F658 VA: 0x2553658
	private void SetCamera(Vector3 pos, Vector3 rot) { }
}
