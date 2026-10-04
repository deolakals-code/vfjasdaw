// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraManager : MonoBehaviour // TypeDefIndex: 384
{
	// Fields
	[SerializeField]
	private float fastCamRate; // 0x20
	[SerializeField]
	private float normalCamRate; // 0x24
	[SerializeField]
	private float slowCamRate; // 0x28
	[SerializeField]
	private float rotateSpeed; // 0x2C
	[SerializeField]
	private float heightMoveSpeed; // 0x30
	[SerializeField]
	private float heightMaxLimit; // 0x34
	[SerializeField]
	private float heightMinLimit; // 0x38
	[CompilerGenerated]
	private static Vector3 <mainCameraPos>k__BackingField; // 0x0
	[CompilerGenerated]
	private static Vector3 <mainCameraForward>k__BackingField; // 0xC
	private Dictionary<CameraControlerType, CameraControlerBase> controlList; // 0x40
	private CameraControlerBase activeController; // 0x48
	private Transform cameraTransform; // 0x50
	private Transform dummyTargetObject; // 0x58
	private Transform targetObject; // 0x60
	private Transform autoLookTargetObject; // 0x68
	public const float DefaultDist = 7;
	private float targetHeight; // 0x70
	private Vector3 oldTargetPos; // 0x74
	private Vector3 targetPos; // 0x80
	private float initRot; // 0x8C
	private CameraControlerType fieldMainGameraType; // 0x90
	private Quaternion initSaveRotate; // 0x94
	private float initSaveRotSet; // 0xA4
	private Vector3 defaultEuler; // 0xA8
	private float shakeTime; // 0xB4
	private float shakeValue; // 0xB8
	private CameraManager.ShakeType shakeType; // 0xBC
	private Vector3 preShakeCameraPos; // 0xC0
	private bool shakeTiming; // 0xCC
	private float shakeCounter; // 0xD0

	// Properties
	public static Vector3 mainCameraPos { get; set; }
	public static Vector3 mainCameraForward { get; set; }
	public Transform AutoLookTargetObject { get; }
	public Vector3 OldTargetPos { get; }
	public Vector3 TargetPos { get; }
	public Vector3 DefaultEuler { get; }
	public bool IsCameraMove { get; }
	public CameraControlerBase ActiveCameraConroler { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2557624 Offset: 0x2553624 VA: 0x2557624
	public static Vector3 get_mainCameraPos() { }

	[CompilerGenerated]
	// RVA: 0x2557670 Offset: 0x2553670 VA: 0x2557670
	private static void set_mainCameraPos(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x25576D8 Offset: 0x25536D8 VA: 0x25576D8
	public static Vector3 get_mainCameraForward() { }

	[CompilerGenerated]
	// RVA: 0x2557724 Offset: 0x2553724 VA: 0x2557724
	private static void set_mainCameraForward(Vector3 value) { }

	// RVA: 0x255778C Offset: 0x255378C VA: 0x255778C
	public static int CheckCameraClip(Vector3 pos) { }

	// RVA: 0x255789C Offset: 0x255389C VA: 0x255789C
	public Transform get_AutoLookTargetObject() { }

	// RVA: 0x25578A4 Offset: 0x25538A4 VA: 0x25578A4
	public Vector3 get_OldTargetPos() { }

	// RVA: 0x25578B0 Offset: 0x25538B0 VA: 0x25578B0
	public Vector3 get_TargetPos() { }

	// RVA: 0x2551BAC Offset: 0x254DBAC VA: 0x2551BAC
	public void UpdateTarget(Vector3 pos) { }

	// RVA: 0x255736C Offset: 0x255336C VA: 0x255736C
	public void SaveDefaultEuler() { }

	// RVA: 0x25578BC Offset: 0x25538BC VA: 0x25578BC
	public Vector3 get_DefaultEuler() { }

	// RVA: 0x25578C8 Offset: 0x25538C8 VA: 0x25578C8
	public bool get_IsCameraMove() { }

	// RVA: 0x255795C Offset: 0x255395C VA: 0x255795C
	public CameraControlerBase get_ActiveCameraConroler() { }

	// RVA: 0x2557964 Offset: 0x2553964 VA: 0x2557964
	private void Awake() { }

	// RVA: 0x2557D38 Offset: 0x2553D38 VA: 0x2557D38
	private void Start() { }

	// RVA: 0x2557E90 Offset: 0x2553E90 VA: 0x2557E90
	public void Init(float minLimit, float maxLimit) { }

	// RVA: 0x2558638 Offset: 0x2554638 VA: 0x2558638
	private void Update() { }

	// RVA: 0x2558728 Offset: 0x2554728 VA: 0x2558728
	private void LateUpdate() { }

	// RVA: 0x2558C44 Offset: 0x2554C44 VA: 0x2558C44
	private void OnPostRender() { }

	// RVA: 0x2558C7C Offset: 0x2554C7C VA: 0x2558C7C
	public void SetDummyTarget(Vector3 pos, float rot) { }

	// RVA: 0x2558D18 Offset: 0x2554D18 VA: 0x2558D18
	public void SetPlayerTarget() { }

	// RVA: 0x2558D4C Offset: 0x2554D4C VA: 0x2558D4C
	public void SetAutoLookTarget(Transform target) { }

	// RVA: 0x2558320 Offset: 0x2554320 VA: 0x2558320
	public void ClearAutoLookTarget() { }

	// RVA: 0x2558D54 Offset: 0x2554D54 VA: 0x2558D54
	public void TargetLookCamera(Transform transform, float second) { }

	[IteratorStateMachine(typeof(CameraManager.<TargetLook>d__63))]
	// RVA: 0x2558D74 Offset: 0x2554D74 VA: 0x2558D74
	private IEnumerator TargetLook(Transform trans, float second) { }

	// RVA: 0x2553EB4 Offset: 0x254FEB4 VA: 0x2553EB4
	public CameraControlerBase GetCameraControler(CameraControlerType type) { }

	// RVA: 0x255832C Offset: 0x255432C VA: 0x255832C
	private bool ChangeCameraControler(CameraControlerType type) { }

	// RVA: 0x25583D0 Offset: 0x25543D0 VA: 0x25583D0
	public bool ChangeLockOnCameraControler(Vector3 cameraOffset) { }

	// RVA: 0x2558E34 Offset: 0x2554E34 VA: 0x2558E34
	public bool ChangeViewModeCameraControle() { }

	// RVA: 0x2558F40 Offset: 0x2554F40 VA: 0x2558F40
	public bool ChangePetFieldCameraControler(GameObject pet, ICamaraInputManager cameraInputManager) { }

	// RVA: 0x255900C Offset: 0x255500C VA: 0x255900C
	public bool ChangeRhythmGameCameraControler(byte type, Vector3 pos, Vector3 rot) { }

	// RVA: 0x2558480 Offset: 0x2554480 VA: 0x2558480
	public bool SetRhythmGameCameraTransform(byte type, Vector3 pos, Vector3 rot) { }

	// RVA: 0x25590F4 Offset: 0x25550F4 VA: 0x25590F4
	public bool SetRhythmGameCameraMoveFlag(bool isMoveCamera) { }

	// RVA: 0x2559180 Offset: 0x2555180 VA: 0x2559180
	public bool SetCardGameCameraTransform(Vector3 pos, Vector3 rot) { }

	// RVA: 0x2559260 Offset: 0x2555260 VA: 0x2559260
	public bool SetCardGameCameraTransformLookTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x2559340 Offset: 0x2555340 VA: 0x2559340
	public bool ChangeRezeroCameraControler() { }

	// RVA: 0x2558568 Offset: 0x2554568 VA: 0x2558568
	public bool Set2DBlackKnightCameraController() { }

	// RVA: 0x2558570 Offset: 0x2554570 VA: 0x2558570
	public bool ChangeSnowballCameraControler() { }

	// RVA: 0x25594BC Offset: 0x25554BC VA: 0x25594BC
	public bool ChangeSnowballCameraType(CameraSnowballControler.CameraType cameraType) { }

	// RVA: 0x25594C8 Offset: 0x25554C8 VA: 0x25594C8
	public bool ChangeSnowballCameraType(CameraSnowballControler.CameraType cameraType, float moveTime) { }

	// RVA: 0x2559584 Offset: 0x2555584 VA: 0x2559584
	public bool ForceChangeSnowballCameraType(CameraSnowballControler.CameraType cameraType) { }

	// RVA: 0x2559624 Offset: 0x2555624 VA: 0x2559624
	public bool ChangeSnowballPCCameraLock(bool isLock) { }

	// RVA: 0x25596C4 Offset: 0x25556C4 VA: 0x25596C4
	public bool SetCraneGameCameraTransform(Vector3 pos, Vector3 rot) { }

	// RVA: 0x25597A4 Offset: 0x25557A4 VA: 0x25597A4
	public bool SetCraneGameCameraTransformLookTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x2559884 Offset: 0x2555884 VA: 0x2559884
	public bool SetMahjongCameraTransform(Vector3 pos, Vector3 rot) { }

	// RVA: 0x2559960 Offset: 0x2555960 VA: 0x2559960
	public bool SetMahjongCameraTransformLookTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x25588F4 Offset: 0x25548F4 VA: 0x25588F4
	private void shakeMonitorUpdate() { }

	// RVA: 0x2559A4C Offset: 0x2555A4C VA: 0x2559A4C
	public void SetScriptCameraShake(int time, int shake, int type) { }

	// RVA: 0x2559A3C Offset: 0x2555A3C VA: 0x2559A3C
	public void ShakeEnd() { }

	// RVA: 0x2559B40 Offset: 0x2555B40 VA: 0x2559B40
	public void SetInitCameraRotation(float rot) { }

	// RVA: 0x2559B48 Offset: 0x2555B48 VA: 0x2559B48
	public void RotateCameraPlayerBack() { }

	// RVA: 0x2559BD8 Offset: 0x2555BD8 VA: 0x2559BD8
	public void SkillLinkPlayerBack() { }

	// RVA: 0x2559C48 Offset: 0x2555C48 VA: 0x2559C48
	public void RotateCameraPlayerFront() { }

	// RVA: 0x2559CD8 Offset: 0x2555CD8 VA: 0x2559CD8
	public void SkillLinkPlayerFront() { }

	// RVA: 0x2559D48 Offset: 0x2555D48 VA: 0x2559D48
	public void ResetCameraFollow() { }

	// RVA: 0x2559DD8 Offset: 0x2555DD8 VA: 0x2559DD8
	public void SetCameraAutoReset() { }

	// RVA: 0x2553C98 Offset: 0x254FC98 VA: 0x2553C98
	public void ResetCamera() { }

	// RVA: 0x2559E64 Offset: 0x2555E64 VA: 0x2559E64
	public void ImmediatelyResetCamera() { }

	// RVA: 0x2559F14 Offset: 0x2555F14 VA: 0x2559F14
	public void ResetCamera(float rot) { }

	// RVA: 0x255A010 Offset: 0x2556010 VA: 0x255A010
	public void TargetPositionCheck() { }

	// RVA: 0x255A100 Offset: 0x2556100 VA: 0x255A100
	public void SetScriptCamera(float time, Vector3 target, Vector3 pos) { }

	// RVA: 0x255A1FC Offset: 0x25561FC VA: 0x255A1FC
	public void SetScriptCameraMove(float time, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos) { }

	// RVA: 0x255A314 Offset: 0x2556314 VA: 0x255A314
	public void SetScriptCameraMove(float time, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos, bool slowStart, bool slowStop) { }

	// RVA: 0x255A448 Offset: 0x2556448 VA: 0x255A448
	public float SetScriptCameraMoveSpeed(float speed, Vector3 startTarget, Vector3 startPos, Vector3 target, Vector3 pos) { }

	// RVA: 0x255A564 Offset: 0x2556564 VA: 0x255A564
	public void ScriptCameraMoveSkip() { }

	// RVA: 0x255A614 Offset: 0x2556614 VA: 0x255A614
	public void .ctor() { }
}
