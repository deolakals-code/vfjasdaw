// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EffectMove : MonoBehaviour // TypeDefIndex: 235
{
	// Fields
	private Transform charaTransform; // 0x20
	private EffectMove.MoveType currentMoveType; // 0x28
	private float moveSpeed; // 0x2C
	private float accelSpeed; // 0x30
	private float accelSpeedLimit; // 0x34
	private float targetMoveSpeed; // 0x38
	private float processingTime; // 0x3C
	private float targetMoveTime; // 0x40
	private Vector3 moveDirection; // 0x44
	private float gravity; // 0x50
	private bool isGround; // 0x54
	private Vector3 startPos; // 0x58
	private float lerpTime; // 0x64
	private Vector3 startPoint; // 0x68
	private Vector3 bezier; // 0x74
	private Action targetMoveEndAction; // 0x80
	private float targetMovePositionRange; // 0x88
	private Transform targetMoveTransform; // 0x90
	private Vector3 targetMovePosition; // 0x98
	private Vector3 moveTarget; // 0xA4
	private Quaternion targetRotate; // 0xB0
	private float rotateDelta; // 0xC0
	private float rotateSpeed; // 0xC4
	private bool isRotate; // 0xC8
	[CompilerGenerated]
	private bool <AutoLookMoveDirection>k__BackingField; // 0xC9
	[CompilerGenerated]
	private bool <AlwaysLookTarget>k__BackingField; // 0xCA
	[CompilerGenerated]
	private bool <EnableFrameSecMove>k__BackingField; // 0xCB
	private Action wallCallback; // 0xD0
	private bool checkWall; // 0xD8
	private float wallCheckRange; // 0xDC
	private bool wallHitMoveStop; // 0xE0

	// Properties
	public bool IsMove { get; }
	public EffectMove.MoveType CurrentMoveType { get; }
	public bool IsTargetMove { get; }
	public bool AutoLookMoveDirection { get; set; }
	public bool AlwaysLookTarget { get; set; }
	public bool EnableFrameSecMove { get; set; }

	// Methods

	// RVA: 0x22A466C Offset: 0x22A066C VA: 0x22A466C
	public bool get_IsMove() { }

	// RVA: 0x22A4678 Offset: 0x22A0678 VA: 0x22A4678
	public EffectMove.MoveType get_CurrentMoveType() { }

	// RVA: 0x22A4680 Offset: 0x22A0680 VA: 0x22A4680
	public bool get_IsTargetMove() { }

	[CompilerGenerated]
	// RVA: 0x22A468C Offset: 0x22A068C VA: 0x22A468C
	public bool get_AutoLookMoveDirection() { }

	[CompilerGenerated]
	// RVA: 0x22A4694 Offset: 0x22A0694 VA: 0x22A4694
	public void set_AutoLookMoveDirection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22A46A0 Offset: 0x22A06A0 VA: 0x22A46A0
	public bool get_AlwaysLookTarget() { }

	[CompilerGenerated]
	// RVA: 0x22A46A8 Offset: 0x22A06A8 VA: 0x22A46A8
	public void set_AlwaysLookTarget(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22A46B4 Offset: 0x22A06B4 VA: 0x22A46B4
	public bool get_EnableFrameSecMove() { }

	[CompilerGenerated]
	// RVA: 0x22A46BC Offset: 0x22A06BC VA: 0x22A46BC
	public void set_EnableFrameSecMove(bool value) { }

	// RVA: 0x22A46C8 Offset: 0x22A06C8 VA: 0x22A46C8
	private void Awake() { }

	// RVA: 0x22A46FC Offset: 0x22A06FC VA: 0x22A46FC
	public void Update() { }

	// RVA: 0x22A47E4 Offset: 0x22A07E4 VA: 0x22A47E4
	private void moveUpdate() { }

	// RVA: 0x22A506C Offset: 0x22A106C VA: 0x22A506C
	private Vector3 calcMoveUnit() { }

	// RVA: 0x22A4E70 Offset: 0x22A0E70 VA: 0x22A4E70
	private void moveEnd() { }

	// RVA: 0x22A5738 Offset: 0x22A1738 VA: 0x22A5738
	public void TargetMove(float speed, Transform targetTransform, float range) { }

	// RVA: 0x22A5784 Offset: 0x22A1784 VA: 0x22A5784
	public void TargetMove(float accel, float speed, Transform targetTransform, float range, Action endCallBack) { }

	// RVA: 0x22A57F4 Offset: 0x22A17F4 VA: 0x22A57F4
	public void TargetMove(float speed, Vector3 position, float range) { }

	// RVA: 0x22A5818 Offset: 0x22A1818 VA: 0x22A5818
	public void TargetMove(float accel, float speed, Vector3 position, float range, Action endCallBack) { }

	// RVA: 0x22A5834 Offset: 0x22A1834 VA: 0x22A5834
	public void TargetMove(float accel, float accelLimit, float speed, Vector3 position, float range, Action endCallBack) { }

	// RVA: 0x22A59CC Offset: 0x22A19CC VA: 0x22A59CC
	public void TargetMoveHomingShot(float accel, float speed, Transform targetTransform, float range, Action endCallBack) { }

	// RVA: 0x22A5A3C Offset: 0x22A1A3C VA: 0x22A5A3C
	public void TargetLerpMove(Vector3 bezier, float speed, Transform targetTransform, float range, Action endCallBack) { }

	// RVA: 0x22A5AC4 Offset: 0x22A1AC4 VA: 0x22A5AC4
	public void TargetParabolicMove(float time, float height, Vector3 position, float range, Action endCallBack) { }

	// RVA: 0x22A5D9C Offset: 0x22A1D9C VA: 0x22A5D9C
	public void TargetMoveSkip() { }

	// RVA: 0x22A5E7C Offset: 0x22A1E7C VA: 0x22A5E7C
	public void MoveStop(bool callback) { }

	// RVA: 0x22A5EA4 Offset: 0x22A1EA4 VA: 0x22A5EA4
	public void SetMoveGround(bool isGround) { }

	// RVA: 0x22A5EB0 Offset: 0x22A1EB0 VA: 0x22A5EB0
	public void Rotate(float angle, float speed = 1) { }

	// RVA: 0x22A6078 Offset: 0x22A2078 VA: 0x22A6078
	public void RotateToPos(Vector3 pos, float speed = 1) { }

	// RVA: 0x22A61C0 Offset: 0x22A21C0 VA: 0x22A61C0
	public void RotateTimeToPos(Vector3 pos, float time) { }

	// RVA: 0x22A4F24 Offset: 0x22A0F24 VA: 0x22A4F24
	private void RotationUpdate() { }

	// RVA: 0x22A6020 Offset: 0x22A2020 VA: 0x22A6020
	private void EndRotaion() { }

	// RVA: 0x22A630C Offset: 0x22A230C VA: 0x22A630C
	public void ActiveWall(float range, bool moveStop, Action callback) { }

	// RVA: 0x22A632C Offset: 0x22A232C VA: 0x22A632C
	public void .ctor() { }
}
