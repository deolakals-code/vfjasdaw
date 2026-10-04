// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CharacterMove : MonoBehaviour, IMove // TypeDefIndex: 548
{
	// Fields
	private Transform charaTransform; // 0x20
	private CharacterMove.MoveType currentMoveType; // 0x28
	private CharacterMove.MoveStateType currentMoveState; // 0x2C
	private FieldRayPick fieldRay; // 0x30
	private float defaultMoveSpeed; // 0x38
	private float moveSpeed; // 0x3C
	private float targetMoveSpeed; // 0x40
	private float gravity; // 0x44
	private bool isGravity; // 0x48
	private float fallSpeed; // 0x4C
	private bool moveLock; // 0x50
	private Vector3 moveDirection; // 0x54
	private CharacterMove.TimeFlag moveTimeFlag; // 0x60
	private Vector3 timeMoveStartPosition; // 0x64
	private float timeMoveDistance; // 0x70
	private float moveTime; // 0x74
	private float moveProgressTime; // 0x78
	private float timeMoveTmpDist; // 0x7C
	private float timeMoveBias1; // 0x80
	private float timeMoveBias2; // 0x84
	private Vector3 deltaMoveVec; // 0x88
	private Action targetMoveEndAction; // 0x98
	private float targetMovePositionRange; // 0xA0
	private Transform targetMoveTransform; // 0xA8
	private Vector3 targetMovePosition; // 0xB0
	private Vector3 moveTarget; // 0xBC
	private CharacterMove.RotateType currentRotateType; // 0xC8
	private float defaultRotateSpeed; // 0xCC
	private float rotateSpeed; // 0xD0
	private Transform lookTransform; // 0xD8
	private bool isRotateAction; // 0xE0
	private Action rotateEndAction; // 0xE8
	private Quaternion targetRotate; // 0xF0
	private float rotateDelta; // 0x100
	private CharacterMove.TimeFlag rotateTimeFlag; // 0x104
	private Quaternion timeRotateStart; // 0x108
	private float timeRotateEnd; // 0x118
	private float rotateTime; // 0x11C
	private float rotateProgressTime; // 0x120
	private float timeRotateBias1; // 0x124
	private float timeRotateBias2; // 0x128
	private bool isGroundRayAngle; // 0x12C
	private float groundRot; // 0x130
	private float vecRot; // 0x134
	[CompilerGenerated]
	private bool <AutoLookMoveDirection>k__BackingField; // 0x138
	[CompilerGenerated]
	private bool <AutoLookTarget>k__BackingField; // 0x139
	[CompilerGenerated]
	private bool <AlwaysLookTarget>k__BackingField; // 0x13A
	[CompilerGenerated]
	private bool <EndPositionJump>k__BackingField; // 0x13B
	[CompilerGenerated]
	private bool <IgnoreEndPositionJumpY>k__BackingField; // 0x13C
	[CompilerGenerated]
	private bool <EnableFrameSecMove>k__BackingField; // 0x13D
	[SerializeField]
	private bool ignoreHeight; // 0x13E
	[CompilerGenerated]
	private bool <MoveHeightRangeCheck>k__BackingField; // 0x13F
	[CompilerGenerated]
	private bool <IsMoveY>k__BackingField; // 0x140
	[CompilerGenerated]
	private bool <IsEventMove>k__BackingField; // 0x141
	[CompilerGenerated]
	private bool <IsDirectionMove>k__BackingField; // 0x142
	private Dictionary<byte, CharacterMove.Suction> suctionList; // 0x148

	// Properties
	public float DefaultMoveSpeed { get; }
	public float MoveSpeed { get; }
	public bool IsGravity { get; set; }
	public FieldRayPick FieldRay { get; }
	public float Height { get; set; }
	public float Radius { get; set; }
	public bool MoveLock { get; set; }
	public bool IsMove { get; }
	public CharacterMove.MoveStateType MoveState { get; }
	public Vector3 DeltaMoveVec { get; }
	public CharacterMove.MoveType CurrentMoveType { get; }
	public bool IsTargetMove { get; }
	public bool AutoLookMoveDirection { get; set; }
	public bool AutoLookTarget { get; set; }
	public bool AlwaysLookTarget { get; set; }
	public bool IsRotate { get; }
	public CharacterMove.RotateType CurrentRotateType { get; }
	public Transform LookTargetObject { get; }
	public bool EndPositionJump { get; set; }
	public bool IgnoreEndPositionJumpY { get; set; }
	private bool EnableFrameSecMove { get; set; }
	public bool IgnoreHeight { get; set; }
	public bool MoveHeightRangeCheck { get; set; }
	public bool EnableWallHit { get; set; }
	public bool EnableOnGroundMove { get; set; }
	public bool IsMoveOrRotation { get; }
	public bool IsMoveY { get; set; }
	public bool IsEventMove { get; set; }
	public bool IsDirectionMove { get; set; }

	// Methods

	// RVA: 0x18359BC Offset: 0x18319BC VA: 0x18359BC
	public float get_DefaultMoveSpeed() { }

	// RVA: 0x18359C4 Offset: 0x18319C4 VA: 0x18359C4
	public float get_MoveSpeed() { }

	// RVA: 0x18359CC Offset: 0x18319CC VA: 0x18359CC
	public bool get_IsGravity() { }

	// RVA: 0x18359D4 Offset: 0x18319D4 VA: 0x18359D4
	public void set_IsGravity(bool value) { }

	// RVA: 0x18359E0 Offset: 0x18319E0 VA: 0x18359E0
	public FieldRayPick get_FieldRay() { }

	// RVA: 0x18359E8 Offset: 0x18319E8 VA: 0x18359E8
	public float get_Height() { }

	// RVA: 0x1835A04 Offset: 0x1831A04 VA: 0x1835A04
	public void set_Height(float value) { }

	// RVA: 0x1835A20 Offset: 0x1831A20 VA: 0x1835A20
	public float get_Radius() { }

	// RVA: 0x1835A3C Offset: 0x1831A3C VA: 0x1835A3C
	public void set_Radius(float value) { }

	// RVA: 0x1835A58 Offset: 0x1831A58 VA: 0x1835A58
	public bool get_MoveLock() { }

	// RVA: 0x1835A60 Offset: 0x1831A60 VA: 0x1835A60
	public void set_MoveLock(bool value) { }

	// RVA: 0x1835A6C Offset: 0x1831A6C VA: 0x1835A6C
	public bool get_IsMove() { }

	// RVA: 0x1835A78 Offset: 0x1831A78 VA: 0x1835A78
	public CharacterMove.MoveStateType get_MoveState() { }

	// RVA: 0x1835A80 Offset: 0x1831A80 VA: 0x1835A80
	public Vector3 get_DeltaMoveVec() { }

	// RVA: 0x1835A8C Offset: 0x1831A8C VA: 0x1835A8C
	public CharacterMove.MoveType get_CurrentMoveType() { }

	// RVA: 0x1835A94 Offset: 0x1831A94 VA: 0x1835A94
	public bool get_IsTargetMove() { }

	[CompilerGenerated]
	// RVA: 0x1835AA0 Offset: 0x1831AA0 VA: 0x1835AA0
	public bool get_AutoLookMoveDirection() { }

	[CompilerGenerated]
	// RVA: 0x1835AA8 Offset: 0x1831AA8 VA: 0x1835AA8
	public void set_AutoLookMoveDirection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1835AB4 Offset: 0x1831AB4 VA: 0x1835AB4
	public bool get_AutoLookTarget() { }

	[CompilerGenerated]
	// RVA: 0x1835ABC Offset: 0x1831ABC VA: 0x1835ABC
	public void set_AutoLookTarget(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1835AC8 Offset: 0x1831AC8 VA: 0x1835AC8
	public bool get_AlwaysLookTarget() { }

	[CompilerGenerated]
	// RVA: 0x1835AD0 Offset: 0x1831AD0 VA: 0x1835AD0
	public void set_AlwaysLookTarget(bool value) { }

	// RVA: 0x1835ADC Offset: 0x1831ADC VA: 0x1835ADC
	public bool get_IsRotate() { }

	// RVA: 0x1835AE8 Offset: 0x1831AE8 VA: 0x1835AE8
	public CharacterMove.RotateType get_CurrentRotateType() { }

	// RVA: 0x1835AF0 Offset: 0x1831AF0 VA: 0x1835AF0
	public Transform get_LookTargetObject() { }

	[CompilerGenerated]
	// RVA: 0x1835AF8 Offset: 0x1831AF8 VA: 0x1835AF8
	public bool get_EndPositionJump() { }

	[CompilerGenerated]
	// RVA: 0x1835B00 Offset: 0x1831B00 VA: 0x1835B00
	public void set_EndPositionJump(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1835B0C Offset: 0x1831B0C VA: 0x1835B0C
	public bool get_IgnoreEndPositionJumpY() { }

	[CompilerGenerated]
	// RVA: 0x1835B14 Offset: 0x1831B14 VA: 0x1835B14
	public void set_IgnoreEndPositionJumpY(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1835B20 Offset: 0x1831B20 VA: 0x1835B20
	private bool get_EnableFrameSecMove() { }

	[CompilerGenerated]
	// RVA: 0x1835B28 Offset: 0x1831B28 VA: 0x1835B28
	private void set_EnableFrameSecMove(bool value) { }

	// RVA: 0x1835B34 Offset: 0x1831B34 VA: 0x1835B34
	public bool get_IgnoreHeight() { }

	// RVA: 0x1835B3C Offset: 0x1831B3C VA: 0x1835B3C
	public void set_IgnoreHeight(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1835B68 Offset: 0x1831B68 VA: 0x1835B68
	public bool get_MoveHeightRangeCheck() { }

	[CompilerGenerated]
	// RVA: 0x1835B70 Offset: 0x1831B70 VA: 0x1835B70
	public void set_MoveHeightRangeCheck(bool value) { }

	// RVA: 0x1835B7C Offset: 0x1831B7C VA: 0x1835B7C
	public bool get_EnableWallHit() { }

	// RVA: 0x1835B98 Offset: 0x1831B98 VA: 0x1835B98
	public void set_EnableWallHit(bool value) { }

	// RVA: 0x1835BB8 Offset: 0x1831BB8 VA: 0x1835BB8
	public bool get_EnableOnGroundMove() { }

	// RVA: 0x1835BD4 Offset: 0x1831BD4 VA: 0x1835BD4
	public void set_EnableOnGroundMove(bool value) { }

	// RVA: 0x1835BF4 Offset: 0x1831BF4 VA: 0x1835BF4
	public bool get_IsMoveOrRotation() { }

	[CompilerGenerated]
	// RVA: 0x1835C14 Offset: 0x1831C14 VA: 0x1835C14
	public bool get_IsMoveY() { }

	[CompilerGenerated]
	// RVA: 0x1835C1C Offset: 0x1831C1C VA: 0x1835C1C
	public void set_IsMoveY(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1835C28 Offset: 0x1831C28 VA: 0x1835C28
	public bool get_IsEventMove() { }

	[CompilerGenerated]
	// RVA: 0x1835C30 Offset: 0x1831C30 VA: 0x1835C30
	private void set_IsEventMove(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1835C3C Offset: 0x1831C3C VA: 0x1835C3C
	public bool get_IsDirectionMove() { }

	[CompilerGenerated]
	// RVA: 0x1835C44 Offset: 0x1831C44 VA: 0x1835C44
	public void set_IsDirectionMove(bool value) { }

	// RVA: 0x1835C50 Offset: 0x1831C50 VA: 0x1835C50
	private void Awake() { }

	// RVA: 0x1835CB8 Offset: 0x1831CB8 VA: 0x1835CB8
	public void Update() { }

	// RVA: 0x1834ACC Offset: 0x1830ACC VA: 0x1834ACC
	public void Reset() { }

	// RVA: 0x18361E8 Offset: 0x18321E8 VA: 0x18361E8
	private void moveUpdate() { }

	// RVA: 0x1836E28 Offset: 0x1832E28 VA: 0x1836E28
	private void move_upate_target_moving() { }

	// RVA: 0x18371C8 Offset: 0x18331C8 VA: 0x18371C8
	private void move_update_time_movinng() { }

	// RVA: 0x18378B4 Offset: 0x18338B4 VA: 0x18378B4
	private void update_timemove_time_over() { }

	// RVA: 0x1837ACC Offset: 0x1833ACC VA: 0x1837ACC
	private float calc_time_move_dist(float _progress_time, float _setting_time) { }

	// RVA: 0x183730C Offset: 0x183330C VA: 0x183730C
	private void move_udpate_normal_moving() { }

	// RVA: 0x183746C Offset: 0x183346C VA: 0x183746C
	private Vector3 calcMoveUnit() { }

	// RVA: 0x1836204 Offset: 0x1832204 VA: 0x1836204
	private float calcGravity() { }

	// RVA: 0x18377F8 Offset: 0x18337F8 VA: 0x18377F8
	private void moveEnd() { }

	// RVA: 0x1831B88 Offset: 0x182DB88 VA: 0x1831B88 Slot: 16
	public void MoveStop() { }

	// RVA: 0x1837B8C Offset: 0x1833B8C VA: 0x1837B8C
	public void MoveStop(bool invokeCallback) { }

	// RVA: 0x1837C44 Offset: 0x1833C44 VA: 0x1837C44 Slot: 14
	public void Move(Vector3 dir) { }

	// RVA: 0x1837C4C Offset: 0x1833C4C VA: 0x1837C4C
	public void Move(Vector3 dir, bool isGroundRayAngle) { }

	// RVA: 0x1837D68 Offset: 0x1833D68 VA: 0x1837D68 Slot: 15
	public void Move(Vector3 dir, float speed) { }

	// RVA: 0x1837D70 Offset: 0x1833D70 VA: 0x1837D70
	public void Move(Vector3 dir, float speed, bool isGroundRayAngle) { }

	// RVA: 0x1837E98 Offset: 0x1833E98 VA: 0x1837E98
	public void TargetMove(float speed, Transform targetTransform, float range) { }

	// RVA: 0x1837EA0 Offset: 0x1833EA0 VA: 0x1837EA0 Slot: 17
	public void TargetMove(float speed, Transform targetTransform, float range, Action endCallBack) { }

	// RVA: 0x1837F94 Offset: 0x1833F94 VA: 0x1837F94
	public void TargetMove(float speed, Vector3 position, float range) { }

	// RVA: 0x1837FAC Offset: 0x1833FAC VA: 0x1837FAC
	public void EventTargetMove(float speed, Vector3 position, float range) { }

	// RVA: 0x1837FA0 Offset: 0x1833FA0 VA: 0x1837FA0
	public void TargetMove(float speed, Vector3 position, float range, Action endCallBack) { }

	// RVA: 0x1837FD0 Offset: 0x1833FD0 VA: 0x1837FD0
	public void TargetMove(float speed, Vector3 position, float range, bool isGroundRayAngle, Action endCallBack) { }

	// RVA: 0x1838540 Offset: 0x1834540 VA: 0x1838540
	public void TargetTimeMove(Vector3 target, float time, bool slowStart, bool slowStop) { }

	// RVA: 0x1838558 Offset: 0x1834558 VA: 0x1838558 Slot: 10
	public void TargetTimeMove(Vector3 target, float time, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x1838570 Offset: 0x1834570 VA: 0x1838570
	public void TargetTimeMove(Vector3 target, float time, bool isGroundRayAngle, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x183882C Offset: 0x183482C VA: 0x183882C
	private void timeMoveEnd() { }

	// RVA: 0x18381E0 Offset: 0x18341E0 VA: 0x18381E0 Slot: 18
	public void TargetMoveSkip() { }

	// RVA: 0x18389F8 Offset: 0x18349F8 VA: 0x18389F8
	public void EmotionMoveAdjust(Vector3 position, float rotation) { }

	// RVA: 0x18366DC Offset: 0x18326DC VA: 0x18366DC
	private void rotateUpdate(bool isMoving, Vector3 dir, Vector3 targetDir) { }

	// RVA: 0x1838BF4 Offset: 0x1834BF4 VA: 0x1838BF4 Slot: 4
	public void SetLookObject(Transform targetTransform) { }

	// RVA: 0x1832B64 Offset: 0x182EB64 VA: 0x1832B64 Slot: 5
	public void ClearLookObject() { }

	// RVA: 0x1838C1C Offset: 0x1834C1C VA: 0x1838C1C
	public void RotateToObject(GameObject target) { }

	// RVA: 0x1838CF4 Offset: 0x1834CF4 VA: 0x1838CF4 Slot: 9
	public void RotateToObject(GameObject target, Action endCallBack) { }

	// RVA: 0x1838D28 Offset: 0x1834D28 VA: 0x1838D28
	public void RotateToPosition(Vector3 target) { }

	// RVA: 0x1838C50 Offset: 0x1834C50 VA: 0x1838C50 Slot: 6
	public void RotateToPosition(Vector3 target, Action endCallBack) { }

	// RVA: 0x1838D34 Offset: 0x1834D34 VA: 0x1838D34 Slot: 7
	public void ImmediateRotateToPosition(Vector3 target) { }

	// RVA: 0x1838D2C Offset: 0x1834D2C VA: 0x1838D2C
	public void Rotate(float rot) { }

	// RVA: 0x1838EA4 Offset: 0x1834EA4 VA: 0x1838EA4 Slot: 8
	public void Rotate(float rot, Action endCallBack) { }

	// RVA: 0x1838FE0 Offset: 0x1834FE0 VA: 0x1838FE0
	public void TimeRotate(float rot, float time, bool slowStart, bool slowStop) { }

	// RVA: 0x1838FF0 Offset: 0x1834FF0 VA: 0x1838FF0 Slot: 11
	public void TimeRotate(float rot, float time, bool slowStart, bool slowStop, Action endCallBack) { }

	// RVA: 0x1836C78 Offset: 0x1832C78 VA: 0x1836C78 Slot: 12
	public void RotateStop() { }

	// RVA: 0x183920C Offset: 0x183520C VA: 0x183920C Slot: 13
	public void RotateSkip() { }

	// RVA: 0x1838BA0 Offset: 0x1834BA0 VA: 0x1838BA0
	private void rotateEnd() { }

	// RVA: 0x183924C Offset: 0x183524C VA: 0x183924C
	public void ChangeMoveState(int id) { }

	// RVA: 0x1839270 Offset: 0x1835270 VA: 0x1839270
	public void SuctionTimeMove(byte localId, Vector3 pos, float time, float distance, float range, bool slowStart, bool slowEnd, Action endCallback) { }

	// RVA: 0x1836C90 Offset: 0x1832C90 VA: 0x1836C90
	public void SuctionStop() { }

	// RVA: 0x18393F4 Offset: 0x18353F4 VA: 0x18393F4
	public void SuctionStop(byte localId) { }

	// RVA: 0x18362BC Offset: 0x18322BC VA: 0x18362BC
	private void UpdateSuction() { }

	// RVA: 0x18394B8 Offset: 0x18354B8 VA: 0x18394B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18395FC Offset: 0x18355FC VA: 0x18395FC
	private void <UpdateSuction>b__186_0(byte id) { }
}
