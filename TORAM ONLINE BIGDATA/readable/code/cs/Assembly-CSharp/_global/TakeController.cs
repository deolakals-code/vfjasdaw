// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TakeController : MonoBehaviour // TypeDefIndex: 4622
{
	// Fields
	private TakePlayer mainPlayer; // 0x20
	private CountUpIdManager takePlayerIdManager; // 0x28
	private Dictionary<int, TakePlayer> takePlayerList; // 0x30
	private bool initFlag; // 0x38
	[CompilerGenerated]
	private bool <EffectDisable>k__BackingField; // 0x39

	// Properties
	public TakePlayer MainPlayer { get; }
	public Dictionary<int, TakePlayer> TakePlayerList { get; }
	public bool EffectDisable { get; set; }

	// Methods

	// RVA: 0x253B228 Offset: 0x2537228 VA: 0x253B228
	public TakePlayer get_MainPlayer() { }

	// RVA: 0x253B338 Offset: 0x2537338 VA: 0x253B338
	public Dictionary<int, TakePlayer> get_TakePlayerList() { }

	// RVA: 0x253B340 Offset: 0x2537340 VA: 0x253B340
	public int GetUID() { }

	// RVA: 0x253B38C Offset: 0x253738C VA: 0x253B38C
	public bool ReleaseUID(int uid) { }

	[CompilerGenerated]
	// RVA: 0x253B40C Offset: 0x253740C VA: 0x253B40C
	public bool get_EffectDisable() { }

	[CompilerGenerated]
	// RVA: 0x253B414 Offset: 0x2537414 VA: 0x253B414
	public void set_EffectDisable(bool value) { }

	// RVA: 0x253B420 Offset: 0x2537420 VA: 0x253B420
	private void Awake() { }

	// RVA: 0x253B29C Offset: 0x253729C VA: 0x253B29C
	private void Initialize() { }

	// RVA: 0x253B424 Offset: 0x2537424 VA: 0x253B424
	public void ReInitialize() { }

	// RVA: 0x253B4FC Offset: 0x25374FC VA: 0x253B4FC
	private TakeClip LoadTakeClip(int takeId) { }

	// RVA: 0x253B6EC Offset: 0x25376EC VA: 0x253B6EC
	public int CheckTakeAnimtionNum(int takeId) { }

	// RVA: 0x253B7A0 Offset: 0x25377A0 VA: 0x253B7A0
	public int TakePlay(int uid, int takeId, Action<int, TakeEventType, int> eventAction, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253BC28 Offset: 0x2537C28 VA: 0x253BC28
	public int TakePlayUidRetention(int takeId, Action<int, TakeEventType, int> eventAction, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253BD84 Offset: 0x2537D84 VA: 0x253BD84
	public int TakePlay(int takeId, Action<int, TakeEventType, int> eventAction, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253C06C Offset: 0x253806C VA: 0x253C06C
	public int TakePlay(int takeId, Action<int, TakeEventType, int> eventAction, Vector3 position, Quaternion rotation, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253BE64 Offset: 0x2537E64 VA: 0x253BE64
	private int TakePlay(int takeId, Action<int, TakeEventType, int> eventAction, Vector3 pos, Quaternion rot, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253C07C Offset: 0x253807C VA: 0x253C07C
	public int TakePlay(TakeClip takeClip, Action<int, TakeEventType, int> eventAction, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253C340 Offset: 0x2538340 VA: 0x253C340
	public int TakeEffectPlay(int modelId, int motionId, Vector3 position, Quaternion rot, Vector3 scale) { }

	// RVA: 0x253C70C Offset: 0x253870C VA: 0x253C70C
	public int TakeEffectPlay(int modelId, int motionId, Vector3 position, Quaternion rot, Vector3 scale, ElementType elementType) { }

	// RVA: 0x253CAD8 Offset: 0x2538AD8 VA: 0x253CAD8
	public int TakeEffectPlay(int modelId, int motionId, GameObject target, ElementType elementType) { }

	// RVA: 0x253CE4C Offset: 0x2538E4C VA: 0x253CE4C
	public int TakeEffectPlay(int modelId, int motionId, GameObject target, TakeModel.SettingPositionType settingPositionType, TakeModel.SettingAngleType angleType, ElementType elementType) { }

	// RVA: 0x253D1D0 Offset: 0x25391D0 VA: 0x253D1D0
	public int TakeEffectPlay(int takeId, int modelId, int motionId, Vector3 position, Quaternion rot, Action<int, TakeEventType, int> onEvent, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253D418 Offset: 0x2539418 VA: 0x253D418
	public int TakeEffectPlay(int takeId, Vector3 position, Quaternion rot, Action<int, TakeEventType, int> onEvent, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253D61C Offset: 0x253961C VA: 0x253D61C
	public int TakeTraceEffectPlay(int modelId, int motionId, Vector3 position, Quaternion rot, Vector3 scale, GameObject trace) { }

	// RVA: 0x253D738 Offset: 0x2539738 VA: 0x253D738
	public int TakeTraceEffectPlay(int modelId, int motionId, Vector3 position, Quaternion rot, Vector3 scale, GameObject trace, MasterModelDataManager.ColorListData colorData) { }

	// RVA: 0x253D9A0 Offset: 0x25399A0 VA: 0x253D9A0
	public int TakeTraceEffectPlay(int modelId, int motionId, Vector3 position, Quaternion rot, Vector3 scale, GameObject trace, Color[] rgb, bool loop) { }

	// RVA: 0x253DB88 Offset: 0x2539B88 VA: 0x253DB88
	public int TakeWorldEffectPlay(int modelId, int motionId, Vector3 position, Quaternion rot, Vector3 scale, Color[] rgb, bool loop) { }

	// RVA: 0x253D978 Offset: 0x2539978 VA: 0x253D978
	private TakeClip CreateTakeClipTraceEffect(int modelId, int motionId, Vector3 position, Quaternion rot, Vector3 scale, GameObject trace, Color[] rgb, bool loop) { }

	// RVA: 0x253DD6C Offset: 0x2539D6C VA: 0x253DD6C
	private TakeClip CreateEffectTakeClip(int modelId, int motionId, TakeModel.SettingPositionType posType, Vector3 position, TakeModel.SettingAngleType rotType, Quaternion rot, Vector3 scale, Color[] rgb, bool loop) { }

	[IteratorStateMachine(typeof(TakeController.<CreateTakePlayer>d__37))]
	// RVA: 0x253BAC8 Offset: 0x2537AC8 VA: 0x253BAC8
	private IEnumerator CreateTakePlayer(int uid, TakeClip takeClip, Action<int, TakeEventType, int> eventAction, Vector3 pos, Quaternion rot, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam, TakePlayer parentPlayer) { }

	// RVA: 0x253E0E0 Offset: 0x253A0E0 VA: 0x253E0E0
	private GameObject CloneModel(GameObject copyBase, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253E5C0 Offset: 0x253A5C0 VA: 0x253E5C0
	private GameObject CloneModelAvoid(GameObject copyBase, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253E728 Offset: 0x253A728 VA: 0x253E728
	private GameObject CloneModelColorAvoid(GameObject copyBase, Color colorRGB, Dictionary<TakeParameterType, int> appendParam) { }

	// RVA: 0x253E920 Offset: 0x253A920 VA: 0x253E920
	private void ModelSetting(GameObject cacheObject, int uid, TakeClip takeClip, Action<int, TakeEventType, int> eventAction, Vector3 pos, Quaternion rot, GameObject baseObject, GameObject targetObject, Dictionary<TakeParameterType, int> appendParam, TakePlayer parentPlayer) { }

	// RVA: 0x253F3B0 Offset: 0x253B3B0 VA: 0x253F3B0
	public bool TakePlayerDestroy(int uid) { }

	// RVA: 0x253F560 Offset: 0x253B560 VA: 0x253F560
	public bool TakePlayerUidCheck(int checkUid, TakePlayer takePlayer) { }

	// RVA: 0x253F618 Offset: 0x253B618 VA: 0x253F618
	public bool TakePause(int uid) { }

	// RVA: 0x253F6B4 Offset: 0x253B6B4 VA: 0x253F6B4
	public bool TakePause() { }

	// RVA: 0x253F6D8 Offset: 0x253B6D8 VA: 0x253F6D8
	public bool TakeStop(int uid) { }

	// RVA: 0x253F774 Offset: 0x253B774 VA: 0x253F774
	public bool TakeStop() { }

	// RVA: 0x253F798 Offset: 0x253B798 VA: 0x253F798
	public bool TakeRestart(int uid) { }

	// RVA: 0x253F834 Offset: 0x253B834 VA: 0x253F834
	public bool TakeRestart() { }

	// RVA: 0x253F858 Offset: 0x253B858 VA: 0x253F858
	public bool TakeSkip(int uid) { }

	// RVA: 0x253F8F4 Offset: 0x253B8F4 VA: 0x253F8F4
	public bool TakeSkip() { }

	// RVA: 0x253F918 Offset: 0x253B918 VA: 0x253F918
	public bool CheckTakeUidPlay(int uid) { }

	// RVA: 0x253FAA8 Offset: 0x253BAA8 VA: 0x253FAA8
	public bool CheckTakeUidPlay(int uid, int takeId) { }

	// RVA: 0x253FC44 Offset: 0x253BC44 VA: 0x253FC44
	public bool CheckPlayingTakeId(int takeId) { }

	// RVA: 0x253FDD4 Offset: 0x253BDD4 VA: 0x253FDD4
	public void TakeEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x253FE98 Offset: 0x253BE98 VA: 0x253FE98
	public int ElementTakeId(int takeId, ElementType elementType) { }

	// RVA: 0x253FF24 Offset: 0x253BF24 VA: 0x253FF24
	public void OnLeave() { }

	// RVA: 0x253FF28 Offset: 0x253BF28 VA: 0x253FF28
	public void AllClear() { }

	// RVA: 0x25401A8 Offset: 0x253C1A8 VA: 0x25401A8
	public void EndTakeEmotion() { }

	// RVA: 0x25401C4 Offset: 0x253C1C4 VA: 0x25401C4
	public void .ctor() { }
}
