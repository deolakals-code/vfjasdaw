// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CrazyDaggerBuf.EffectManager.KnifeMove // TypeDefIndex: 3109
{
	// Fields
	private readonly float shakingRange; // 0x10
	private readonly float shakingTime; // 0x14
	private Vector3 position; // 0x18
	private Vector3 target; // 0x24
	private Vector3 moveDirection; // 0x30
	private float moveSpeed; // 0x3C
	private float accelSpeed; // 0x40
	private CrazyDaggerBuf.EffectManager.KnifeMove.MoveType moveType; // 0x44
	private CrazyDaggerBuf.EffectManager.KnifeMove.MoveFlag flag; // 0x48
	private bool isMove; // 0x4C
	private bool isRotate; // 0x4D
	private bool isShaking; // 0x4E
	private float shakingRate; // 0x50
	private Quaternion rotate; // 0x54
	private Quaternion targetRotate; // 0x64
	private float rotateRate; // 0x74
	private float rotateTime; // 0x78

	// Properties
	public bool IsMove { get; }
	public Vector3 Position { get; }
	public Quaternion Rotate { get; }

	// Methods

	// RVA: 0x2327534 Offset: 0x2323534 VA: 0x2327534
	public bool get_IsMove() { }

	// RVA: 0x232753C Offset: 0x232353C VA: 0x232753C
	public Vector3 get_Position() { }

	// RVA: 0x23275F0 Offset: 0x23235F0 VA: 0x23275F0
	public Quaternion get_Rotate() { }

	// RVA: 0x232762C Offset: 0x232362C VA: 0x232762C
	public void .ctor(Vector3 pos) { }

	// RVA: 0x23276D0 Offset: 0x23236D0 VA: 0x23276D0
	public void UpdateTransform(Transform transform) { }

	// RVA: 0x232771C Offset: 0x232371C VA: 0x232771C
	public bool PositionUpdate() { }

	// RVA: 0x2327970 Offset: 0x2323970 VA: 0x2327970
	public void TargetMove(Vector3 position, float speed, float accel = 0, CrazyDaggerBuf.EffectManager.KnifeMove.MoveFlag flag = 0) { }

	// RVA: 0x232798C Offset: 0x232398C VA: 0x232798C
	public void TargetMoveTime(Vector3 position, float timer) { }

	// RVA: 0x2327A78 Offset: 0x2323A78 VA: 0x2327A78
	public void DirectionMove(Vector3 dir, float speed, float accel = 0, CrazyDaggerBuf.EffectManager.KnifeMove.MoveFlag flag = 0) { }

	// RVA: 0x2327958 Offset: 0x2323958 VA: 0x2327958
	public void Stop(bool shakeEnd) { }

	// RVA: 0x2327A94 Offset: 0x2323A94 VA: 0x2327A94
	public void ChangeShaking(bool shake) { }

	// RVA: 0x2327AA8 Offset: 0x2323AA8 VA: 0x2327AA8
	public void SetRotation(Quaternion start, Quaternion target, float speed) { }

	// RVA: 0x2327B38 Offset: 0x2323B38 VA: 0x2327B38
	public void SetRotationTime(Quaternion start, Quaternion target, float time) { }

	// RVA: 0x2327B60 Offset: 0x2323B60 VA: 0x2327B60
	public bool RotationUpdate() { }
}
