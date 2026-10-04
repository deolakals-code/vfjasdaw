// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptCameraMainAction : FieldScriptCameraActionBase // TypeDefIndex: 4816
{
	// Fields
	private FieldScriptBaias fieldScriptBaias; // 0x18
	private FieldScriptCameraMainAction.ScriptCameraType cameraType; // 0x20
	private float moveTime; // 0x24
	private float moveProgressTime; // 0x28
	private Quaternion scriptTargetRotate; // 0x2C
	private Quaternion scriptMoveTargetRotate; // 0x3C
	private Vector3 scriptCameraPos; // 0x4C
	private Vector3 scriptMoveCameraPos; // 0x58
	private Vector3 defaultEuler; // 0x64
	private FieldScriptBaias.TimeFlag moveTimeFlag; // 0x70

	// Properties
	public override bool IsAction { get; }
	public override FieldScriptCameraActionBase.ActionType CurrentType { get; }

	// Methods

	// RVA: 0x25B1D70 Offset: 0x25ADD70 VA: 0x25B1D70 Slot: 5
	public override bool get_IsAction() { }

	// RVA: 0x25B1D80 Offset: 0x25ADD80 VA: 0x25B1D80 Slot: 4
	public override FieldScriptCameraActionBase.ActionType get_CurrentType() { }

	// RVA: 0x25B1688 Offset: 0x25AD688 VA: 0x25B1688
	public void .ctor(Transform camera) { }

	// RVA: 0x25B1D88 Offset: 0x25ADD88 VA: 0x25B1D88 Slot: 6
	public override void End() { }

	// RVA: 0x25B1DAC Offset: 0x25ADDAC VA: 0x25B1DAC Slot: 7
	public override void Update() { }

	// RVA: 0x25B1F74 Offset: 0x25ADF74 VA: 0x25B1F74
	private Vector3 getCameraPos(Vector3 pos) { }

	// RVA: 0x25B2104 Offset: 0x25AE104 VA: 0x25B2104
	private Quaternion getCameraTarget(Vector3 target) { }

	// RVA: 0x25B229C Offset: 0x25AE29C VA: 0x25B229C
	public void SetScriptCamera(float time, Vector3 target, Vector3 pos) { }

	// RVA: 0x25B231C Offset: 0x25AE31C VA: 0x25B231C
	public void SetScriptCameraMove(float time, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos) { }

	// RVA: 0x25B23FC Offset: 0x25AE3FC VA: 0x25B23FC
	public void SetScriptCameraMove(float time, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos, bool slowStart, bool slowStop) { }

	// RVA: 0x25B2548 Offset: 0x25AE548 VA: 0x25B2548
	public float SetScriptCameraMoveSpeed(float speed, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos) { }

	// RVA: 0x25B2698 Offset: 0x25AE698 VA: 0x25B2698 Slot: 8
	public override void Skip() { }
}
