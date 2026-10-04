// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraCardGameControler : CameraControlerBase // TypeDefIndex: 364
{
	// Fields
	private Vector3 cameraPos; // 0x20
	private Vector3 targetPos; // 0x2C

	// Properties
	public override Vector3 Position { get; }
	public override Vector3 TargetDist { get; }
	public override CameraControlerType Type { get; }
	public Vector3 TargetPos { get; }

	// Methods

	// RVA: 0x248D4EC Offset: 0x24894EC VA: 0x248D4EC Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x248D4F8 Offset: 0x24894F8 VA: 0x248D4F8 Slot: 4
	public override Vector3 get_TargetDist() { }

	// RVA: 0x248D53C Offset: 0x248953C VA: 0x248D53C Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x248D544 Offset: 0x2489544 VA: 0x248D544
	public Vector3 get_TargetPos() { }

	// RVA: 0x248D550 Offset: 0x2489550 VA: 0x248D550
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x248D554 Offset: 0x2489554 VA: 0x248D554
	public void SetCameraTrans(Vector3 pos, Vector3 rot) { }

	// RVA: 0x248D5C4 Offset: 0x24895C4 VA: 0x248D5C4
	public void SetCameraTransLookTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x248D62C Offset: 0x248962C VA: 0x248D62C Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x248D630 Offset: 0x2489630 VA: 0x248D630 Slot: 8
	public override void Update() { }

	// RVA: 0x248D558 Offset: 0x2489558 VA: 0x248D558
	private void SetCamera(Vector3 pos, Vector3 rot) { }

	// RVA: 0x248D5C8 Offset: 0x24895C8 VA: 0x248D5C8
	private void SetCameraLookTarget(Vector3 pos, Vector3 target) { }
}
