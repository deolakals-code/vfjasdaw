// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptCharacterMove : MonoBehaviour, IMove // TypeDefIndex: 4666
{
	// Fields
	public const float Gravity = 9.8;
	public const float DefaultFallStartSpeed = -10;
	public const float DefaultFallMaxSpeed = -20;
	private float defaultRotateSpeed; // 0x20
	private bool moveLock; // 0x24
	public bool isRotateAction; // 0x25
	private Transform charaTransform; // 0x28
	private FieldRayPick fieldRay; // 0x30
	public float DefaultMoveSpeed; // 0x38
	public bool AutoLookMoveDirection; // 0x3C
	public bool AlwaysLookTarget; // 0x3D
	public bool IgnoreHeight; // 0x3E
	public float fallSpeed; // 0x40
	public bool MoveDirectionFlag; // 0x44
	public float FallStartSpeed; // 0x48
	public float FallMaxSpeed; // 0x4C
	protected FieldScriptMoveData move_data; // 0x50
	protected FieldScriptMoveData rotate_data; // 0x58
	protected FieldScriptMoveData lock_rotate_data; // 0x60
	protected List<FieldScriptMoveData> movelist; // 0x68

	// Properties
	public bool MoveLock { get; set; }
	public FieldRayPick FieldRay { get; }

	// Methods

	// RVA: 0x2588C54 Offset: 0x2584C54 VA: 0x2588C54
	public bool get_MoveLock() { }

	// RVA: 0x2588C5C Offset: 0x2584C5C VA: 0x2588C5C
	public void set_MoveLock(bool value) { }

	// RVA: 0x2588C68 Offset: 0x2584C68 VA: 0x2588C68
	public FieldRayPick get_FieldRay() { }

	// RVA: 0x2588C70 Offset: 0x2584C70 VA: 0x2588C70
	private float getFallSpeed_Gravity() { }

	// RVA: 0x2588C9C Offset: 0x2584C9C VA: 0x2588C9C
	public float calcGravity() { }

	// RVA: 0x2588D58 Offset: 0x2584D58 VA: 0x2588D58
	private void Start() { }

	// RVA: 0x2588D5C Offset: 0x2584D5C VA: 0x2588D5C
	private void Awake() { }

	// RVA: 0x2588DEC Offset: 0x2584DEC VA: 0x2588DEC
	private void Update() { }

	// RVA: 0x2589750 Offset: 0x2585750 VA: 0x2589750
	public void Reset() { }

	// RVA: 0x25898A0 Offset: 0x25858A0 VA: 0x25898A0 Slot: 4
	public void SetLookObject(Transform targetTransform) { }

	// RVA: 0x2589848 Offset: 0x2585848 VA: 0x2589848 Slot: 5
	public void ClearLookObject() { }

	// RVA: 0x2589964 Offset: 0x2585964 VA: 0x2589964 Slot: 14
	public void Move(Vector3 dir) { }

	// RVA: 0x258996C Offset: 0x258596C VA: 0x258996C Slot: 15
	public void Move(Vector3 dir, float speed) { }

	// RVA: 0x2589770 Offset: 0x2585770 VA: 0x2589770 Slot: 16
	public void MoveStop() { }

	// RVA: 0x25895A0 Offset: 0x25855A0 VA: 0x25895A0
	public void TargetMoveEnd() { }

	// RVA: 0x2589B50 Offset: 0x2585B50 VA: 0x2589B50 Slot: 18
	public void TargetMoveSkip() { }

	// RVA: 0x2589C88 Offset: 0x2585C88 VA: 0x2589C88 Slot: 8
	public void Rotate(float rot, Action endCallBack) { }

	// RVA: 0x25897DC Offset: 0x25857DC VA: 0x25897DC Slot: 12
	public void RotateStop() { }

	// RVA: 0x25896D0 Offset: 0x25856D0 VA: 0x25896D0 Slot: 13
	public void RotateSkip() { }

	// RVA: 0x2589F20 Offset: 0x2585F20 VA: 0x2589F20 Slot: 9
	public void RotateToObject(GameObject target, Action endCallBack) { }

	// RVA: 0x2589F64 Offset: 0x2585F64 VA: 0x2589F64 Slot: 6
	public void RotateToPosition(Vector3 target, Action endCallBack) { }

	// RVA: 0x258A014 Offset: 0x2586014 VA: 0x258A014 Slot: 7
	public void ImmediateRotateToPosition(Vector3 target) { }

	// RVA: 0x258A184 Offset: 0x2586184 VA: 0x258A184 Slot: 17
	public void TargetMove(float speed, Transform targetTransform, float range, Action endCallBack) { }

	// RVA: 0x258A440 Offset: 0x2586440 VA: 0x258A440
	public void TargetMove(float speed, Vector3 position, float range, Action endCallBack) { }

	// RVA: 0x258A7A4 Offset: 0x25867A4 VA: 0x258A7A4 Slot: 10
	public void TargetTimeMove(Vector3 target, float time, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x258AB9C Offset: 0x2586B9C VA: 0x258AB9C Slot: 11
	public void TimeRotate(float rot, float time, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x258AEB8 Offset: 0x2586EB8 VA: 0x258AEB8
	public void TimeParabolaMove(Vector3 start, Vector3 target, float time, float rot, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x258B5B0 Offset: 0x25875B0 VA: 0x258B5B0
	public void TimeRotateEx(Vector3 rot, float time, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x258B97C Offset: 0x258797C VA: 0x258B97C
	public void ParabolaMove(Vector3 start, Vector3 target, float yEuler, float maxheight, float zEuler, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x258BEA0 Offset: 0x2587EA0 VA: 0x258BEA0
	public void ParabolaMove(Vector3 start, Quaternion target, float yEuler, float maxheight, float zEuler, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x258C32C Offset: 0x258832C VA: 0x258C32C
	public void CurveMove(Vector3 end, Vector3 point, float time, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x258C6A4 Offset: 0x25886A4 VA: 0x258C6A4
	public void .ctor() { }
}
