// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TakePlayer : MonoBehaviour, IFieldItemData // TypeDefIndex: 4647
{
	// Fields
	private List<TakePlayer> children; // 0x20
	public int ParentTakeUid; // 0x28
	private TakePlayer parent; // 0x30
	private float lostChecker; // 0x38
	private bool isTakePlay; // 0x3C
	private bool isLastTakePlay; // 0x3D
	private bool destroyFlag; // 0x3E
	private Dictionary<TakeParameterType, bool> childAppendParamFlag; // 0x40
	private CameraManager cameraManager; // 0x48
	private AnimationBase animationPlayer; // 0x50
	private Action<int, TakeEventType, int> eventAction; // 0x58
	private List<TakeEvent> remainingTaskList; // 0x60
	private List<TakeEvent> takeEndEventList; // 0x68
	private SkinnedMeshRenderer skinnedMeshRenderer; // 0x70
	[CompilerGenerated]
	private int <TakeId>k__BackingField; // 0x78
	private int takeUid; // 0x7C
	private bool focusDestroy; // 0x80
	private GameObject baseObject; // 0x88
	private GameObject targetObject; // 0x90
	private TakeClip takeClip; // 0x98
	private TakeAnimationClip takeAnimationClip; // 0xA0
	private int animationIndex; // 0xA8
	private int eventIndex; // 0xAC
	private int animationId; // 0xB0
	private float animationSpeed; // 0xB4
	private float animationTimer; // 0xB8
	private float clipSpeed; // 0xBC
	private bool isPause; // 0xC0
	private bool isMoveAction; // 0xC1
	private bool skipCheck; // 0xC2
	private bool skipCommand; // 0xC3
	private bool noLoopCheck; // 0xC4
	private bool flatTrace; // 0xC5
	private Transform traceParent; // 0xC8
	private Transform traceTarget; // 0xD0
	private TakeModel.TraceType traceType; // 0xD8
	private TakeController takeController; // 0xE0
	private Dictionary<TakeParameterType, int> appendParam; // 0xE8
	private bool reSetPlay; // 0xF0
	private int takeParamData; // 0xF4
	private bool takeEndParamReset; // 0xF8
	private bool nonCrossFadeMotion; // 0xF9
	private bool noLoopPlay; // 0xFA
	private float crossFadeSecond; // 0xFC
	private Dictionary<TakeEvent, float> loopEventInterval; // 0x100
	private bool forcePlay; // 0x108
	private TakePlayer.TakeStopActionType stopDestroy; // 0x10C
	private bool animationStopEnd; // 0x110
	private bool skillIndexMove; // 0x111
	[CompilerGenerated]
	private bool <IsNotParentTakeId>k__BackingField; // 0x112
	private int takeLoop; // 0x114
	private int takeLoopDef; // 0x118
	private bool takeClipTimer; // 0x11C
	private float takeClipLenght; // 0x120
	private float takeClipTimeWatch; // 0x124
	private FadeAnimationManager fadeAnimationManager; // 0x128
	private EffectDistanceFadeManager distanceFadeManager; // 0x130
	private float endTimer; // 0x138
	private bool isOnDestroy; // 0x13C
	private CharacterMove characterMove; // 0x140
	private EffectMove effectMove; // 0x148
	private float moveSpeed; // 0x150
	private float accelSpeed; // 0x154
	private float accelSpeedLimit; // 0x158
	private float moveTime; // 0x15C
	private TakeMoveType takeMoveType; // 0x160
	private float moveRate; // 0x164
	private float fixedAnimationSpeed; // 0x168
	private int moveEndIndex; // 0x16C

	// Properties
	public TakePlayer playerParent { get; }
	public bool IsTakePlay { get; }
	public int TakeId { get; set; }
	public int TakeUid { get; }
	public int AnimationIndex { get; }
	public int CurrentAnimationId { get; }
	public bool IsNotParentTakeId { get; set; }

	// Methods

	// RVA: 0x2540288 Offset: 0x253C288 VA: 0x2540288
	public void AddChildren(TakePlayer child) { }

	// RVA: 0x25403A4 Offset: 0x253C3A4 VA: 0x25403A4
	public void StopChildrenByParentTakeUid(int parentTakeUid) { }

	// RVA: 0x25407F8 Offset: 0x253C7F8 VA: 0x25407F8
	public TakePlayer get_playerParent() { }

	// RVA: 0x2540874 Offset: 0x253C874 VA: 0x2540874
	public bool get_IsTakePlay() { }

	// RVA: 0x254087C Offset: 0x253C87C VA: 0x254087C
	private Vector3 RnadomVector3(Vector3 random) { }

	// RVA: 0x25408E4 Offset: 0x253C8E4 VA: 0x25408E4
	private Vector3 RandomFixedVector3(Vector3 random) { }

	// RVA: 0x2540964 Offset: 0x253C964 VA: 0x2540964
	private Quaternion TraceAngleSetting(Vector3 start, Vector3 end, bool flat, TakeModel.TraceType traceType, Transform parent, Transform target) { }

	// RVA: 0x2540AA4 Offset: 0x253CAA4 VA: 0x2540AA4
	public void TakeModelSetting(TakeModel takeModel, Transform parent, Vector3 position, Quaternion rot, GameObject targetTrans, float scaling) { }

	// RVA: 0x2541914 Offset: 0x253D914 VA: 0x2541914
	public void SetTarget(GameObject target) { }

	// RVA: 0x254191C Offset: 0x253D91C VA: 0x254191C
	public bool UpdateAppendParam(TakeParameterType type, int param) { }

	// RVA: 0x25419C0 Offset: 0x253D9C0 VA: 0x25419C0 Slot: 4
	public bool CheckField(bool isEnter, int fieldId, byte roomType) { }

	[CompilerGenerated]
	// RVA: 0x2541A50 Offset: 0x253DA50 VA: 0x2541A50
	private void set_TakeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2541A58 Offset: 0x253DA58 VA: 0x2541A58
	public int get_TakeId() { }

	// RVA: 0x2541A60 Offset: 0x253DA60 VA: 0x2541A60
	public int get_TakeUid() { }

	// RVA: 0x2541A68 Offset: 0x253DA68 VA: 0x2541A68
	public int get_AnimationIndex() { }

	// RVA: 0x2541A70 Offset: 0x253DA70 VA: 0x2541A70
	public int get_CurrentAnimationId() { }

	[CompilerGenerated]
	// RVA: 0x2541A78 Offset: 0x253DA78 VA: 0x2541A78
	public bool get_IsNotParentTakeId() { }

	[CompilerGenerated]
	// RVA: 0x2541A80 Offset: 0x253DA80 VA: 0x2541A80
	private void set_IsNotParentTakeId(bool value) { }

	// RVA: 0x2541A8C Offset: 0x253DA8C VA: 0x2541A8C
	private Dictionary<TakeParameterType, int> childAppendParam(Dictionary<TakeParameterType, bool> paramFlag) { }

	// RVA: 0x2541F9C Offset: 0x253DF9C VA: 0x2541F9C
	public void Initialize(TakePlayer parent, int uid, TakeController takeController) { }

	// RVA: 0x25420D8 Offset: 0x253E0D8 VA: 0x25420D8
	private Quaternion TraceAngleAction(Vector3 start, Vector3 end) { }

	// RVA: 0x25420FC Offset: 0x253E0FC VA: 0x25420FC
	private void Update() { }

	// RVA: 0x254B740 Offset: 0x2547740 VA: 0x254B740
	public void NextTakeAnimation(int index, bool skillIndexMove) { }

	// RVA: 0x2542BA8 Offset: 0x253EBA8 VA: 0x2542BA8
	private void NextTakeAnimation(bool isEndEvent, TakeEventType[] skipTakeEventTypes) { }

	// RVA: 0x254BF24 Offset: 0x2547F24 VA: 0x254BF24
	public void ReplayCurrentTakeAnimation() { }

	// RVA: 0x254BFC0 Offset: 0x2547FC0 VA: 0x254BFC0
	private int ParamCheck(TakeParameterType type, int baseParam) { }

	// RVA: 0x254C064 Offset: 0x2548064 VA: 0x254C064
	private bool TargetTimeMoveSlowStart(bool baseParam) { }

	// RVA: 0x254C09C Offset: 0x254809C VA: 0x254C09C
	private bool TargetTimeMoveSlowStop(bool baseParam) { }

	// RVA: 0x254B7FC Offset: 0x25477FC VA: 0x254B7FC
	private void TakeAnimation(int index) { }

	// RVA: 0x254C24C Offset: 0x254824C VA: 0x254C24C
	public void TakePlay(TakeClip takeClip, Action<int, TakeEventType, int> eventAction, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam, int uid) { }

	// RVA: 0x254C47C Offset: 0x254847C VA: 0x254C47C
	public bool TakePause() { }

	// RVA: 0x254C5F0 Offset: 0x25485F0 VA: 0x254C5F0
	public bool TakeRestart() { }

	// RVA: 0x254C768 Offset: 0x2548768 VA: 0x254C768
	public void TakeDestroy() { }

	// RVA: 0x25404D0 Offset: 0x253C4D0 VA: 0x25404D0
	public bool TakeStop() { }

	// RVA: 0x2542B84 Offset: 0x253EB84 VA: 0x2542B84
	public bool TakeSkip() { }

	// RVA: 0x254C934 Offset: 0x2548934 VA: 0x254C934
	public void TakeLoopEnd() { }

	// RVA: 0x2542D6C Offset: 0x253ED6C VA: 0x2542D6C
	public void TakeEvent(TakePlayer takePlayer, TakeEventType eventType, int param) { }

	[IteratorStateMachine(typeof(TakePlayer.<StartScaleAnimation>d__104))]
	// RVA: 0x254D73C Offset: 0x254973C VA: 0x254D73C
	private IEnumerator StartScaleAnimation(float time, Vector3 scale) { }

	// RVA: 0x254C0D4 Offset: 0x25480D4 VA: 0x254C0D4
	private bool TakeMoveAction() { }

	// RVA: 0x254F5A0 Offset: 0x254B5A0 VA: 0x254F5A0
	private bool CharacterMoveAction() { }

	// RVA: 0x254D98C Offset: 0x254998C VA: 0x254D98C
	private bool EffectMoveAction() { }

	// RVA: 0x2542B98 Offset: 0x253EB98 VA: 0x2542B98
	private void OnEndMoveAction() { }

	// RVA: 0x2550BE4 Offset: 0x254CBE4 VA: 0x2550BE4
	public void OnEndEmotion() { }

	// RVA: 0x2550BF0 Offset: 0x254CBF0 VA: 0x2550BF0
	private void OnDestroy() { }

	// RVA: 0x254CB1C Offset: 0x2548B1C VA: 0x254CB1C
	private void AccelBladeMove() { }

	// RVA: 0x254CD78 Offset: 0x2548D78 VA: 0x254CD78
	private void DragoonSwordMove(int param, float speed) { }

	// RVA: 0x254CFE0 Offset: 0x2548FE0 VA: 0x254CFE0
	private void AvoidWrapAroundMove(int param) { }

	// RVA: 0x254D570 Offset: 0x2549570 VA: 0x254D570
	private void DirectionMove(int param, float speed) { }

	// RVA: 0x254C93C Offset: 0x254893C VA: 0x254C93C
	private void WaitTime(TakePlayer takePlayer, int num) { }

	// RVA: 0x254D7DC Offset: 0x25497DC VA: 0x254D7DC
	private void TakeBoneRenameEvent(int param) { }

	// RVA: 0x2550C8C Offset: 0x254CC8C VA: 0x2550C8C
	public bool CheckTakeUidPlay(int uid) { }

	// RVA: 0x2550E1C Offset: 0x254CE1C VA: 0x2550E1C
	public bool CheckTakeUidPlay(int uid, int takeId) { }

	// RVA: 0x2550FC0 Offset: 0x254CFC0 VA: 0x2550FC0
	public bool CheckPlayingTakeId(int takeId) { }

	// RVA: 0x2551150 Offset: 0x254D150 VA: 0x2551150
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x25512A4 Offset: 0x254D2A4 VA: 0x25512A4
	private void <TakeEvent>b__103_0() { }

	[CompilerGenerated]
	// RVA: 0x25512C4 Offset: 0x254D2C4 VA: 0x25512C4
	private void <TakeEvent>b__103_1() { }

	[CompilerGenerated]
	// RVA: 0x25512E8 Offset: 0x254D2E8 VA: 0x25512E8
	private void <TakeEvent>b__103_2() { }

	[CompilerGenerated]
	// RVA: 0x2551308 Offset: 0x254D308 VA: 0x2551308
	private void <CharacterMoveAction>b__116_4() { }

	[CompilerGenerated]
	// RVA: 0x2551334 Offset: 0x254D334 VA: 0x2551334
	private void <CharacterMoveAction>b__116_0() { }

	[CompilerGenerated]
	// RVA: 0x2551474 Offset: 0x254D474 VA: 0x2551474
	private void <EffectMoveAction>b__117_2() { }

	[CompilerGenerated]
	// RVA: 0x255147C Offset: 0x254D47C VA: 0x255147C
	private void <EffectMoveAction>b__117_3() { }

	[CompilerGenerated]
	// RVA: 0x25514C8 Offset: 0x254D4C8 VA: 0x25514C8
	private void <EffectMoveAction>b__117_0() { }

	[CompilerGenerated]
	// RVA: 0x2551500 Offset: 0x254D500 VA: 0x2551500
	private void <EffectMoveAction>b__117_1() { }

	[CompilerGenerated]
	// RVA: 0x2551530 Offset: 0x254D530 VA: 0x2551530
	private void <EffectMoveAction>b__117_4() { }

	[CompilerGenerated]
	// RVA: 0x2551540 Offset: 0x254D540 VA: 0x2551540
	private void <AccelBladeMove>b__121_0() { }

	[CompilerGenerated]
	// RVA: 0x2551560 Offset: 0x254D560 VA: 0x2551560
	private void <DragoonSwordMove>b__122_0() { }

	[CompilerGenerated]
	// RVA: 0x2551580 Offset: 0x254D580 VA: 0x2551580
	private void <DirectionMove>b__124_0() { }
}
