// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptManager : Singleton<FieldScriptManager>, ISceneChangeManager // TypeDefIndex: 4796
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x20
	private CameraManager cameraManager; // 0x28
	private FieldScriptMonitor fieldScriptMonitor; // 0x30
	private FieldScriptMonitor fieldScriptMaskMonitor; // 0x38
	private FieldScriptLoader loader; // 0x40
	private bool threadLoopFlag; // 0x48
	private int eventIndex; // 0x4C
	private GameObject loadingObject; // 0x50
	private GameObject bossTelop; // 0x58
	private GameObject bossNameTelop; // 0x60
	private GameObject partyNameTelop; // 0x68
	private GameObject defenceBattlePanel; // 0x70
	private GameObject alertMessagePanel; // 0x78
	private GameObject pointIconPanel; // 0x80
	private List<GameObject> eventTelopList; // 0x88
	private Dictionary<int, List<Vector3>> trace_point; // 0x90
	private Dictionary<int, int[,]> route_guide; // 0x98
	private List<GameObject> eventMobScriptData; // 0xA0
	private int maxCallMember; // 0xA8
	[CompilerGenerated]
	private bool <IsExecScript>k__BackingField; // 0xAC
	[CompilerGenerated]
	private bool <IsEscapeReaction>k__BackingField; // 0xAD
	private bool isEventWarpCommand; // 0xAE
	private float execTimer; // 0xB0
	private bool backScript; // 0xB4
	private float time; // 0xB8
	private float lastUpdatetime; // 0xBC
	private readonly float checkTime; // 0xC0
	private int partyMatchingFieldId; // 0xC4
	private int partyMatchingRoomId; // 0xC8
	private byte partyMatchingFlag; // 0xCC
	private int[] bossHpList; // 0xD0
	[CompilerGenerated]
	private bool <IsDashMove>k__BackingField; // 0xD8
	private FieldScriptManager.EventSceneType eventSceneType; // 0xDC
	[CompilerGenerated]
	private bool <IsSkillLockArea>k__BackingField; // 0xE0
	private bool cancelFlag; // 0xE1
	[CompilerGenerated]
	private FieldScriptManager.SkipModeType <SkipMode>k__BackingField; // 0xE2
	private UIEventMessageWindow uiEventMessageWindow; // 0xE8
	private List<UIEventMenuButton.MessageButtonData> eventButtonList; // 0xF0
	private UIInfoWindow uiInfoWindow; // 0xF8
	private IFieldScriptSystemLockManager systemLockManager; // 0x100
	private ScriptTextManager scriptTextManager; // 0x108
	private ScriptTextManagerData scriptTextManagerData; // 0x110
	private SystemTextManager systemManager; // 0x118
	private Dictionary<FieldScriptCommand, Action<FieldScriptCommand>> commandActionS; // 0x120
	private Dictionary<FieldScriptCommand, Func<FieldScriptCommand, IEnumerator>> commandFuncS; // 0x128
	private Dictionary<short, AbnormalType[]> abnormalGroupList; // 0x130
	private Dictionary<int, GameObject> modelList; // 0x138
	private Dictionary<int, GameObject> enemyDeadEventList; // 0x140
	private Dictionary<byte, FieldScriptSubCamera> subCameraList; // 0x148
	private List<FieldScriptManager.ScriptLoadObject> modelLsit; // 0x150

	// Properties
	public bool IsInitEvent { get; }
	public bool IsExecScript { get; set; }
	public bool IsEscapeReaction { get; set; }
	public bool IsDashMove { get; set; }
	public bool IsEventCheck { get; }
	public bool IsEventConnection { get; }
	public bool IsSkillLockArea { get; set; }
	public GameObject BossTelop { get; }
	public bool CancelFlag { get; set; }
	public FieldScriptManager.SkipModeType SkipMode { get; set; }
	public IFieldScriptSystemLockManager SystemLockManager { get; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x2563B34 Offset: 0x255FB34 VA: 0x2563B34
	public bool get_IsInitEvent() { }

	[CompilerGenerated]
	// RVA: 0x2563B44 Offset: 0x255FB44 VA: 0x2563B44
	private void set_IsExecScript(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2563B50 Offset: 0x255FB50 VA: 0x2563B50
	public bool get_IsExecScript() { }

	[CompilerGenerated]
	// RVA: 0x2563B58 Offset: 0x255FB58 VA: 0x2563B58
	private void set_IsEscapeReaction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2563B64 Offset: 0x255FB64 VA: 0x2563B64
	public bool get_IsEscapeReaction() { }

	[CompilerGenerated]
	// RVA: 0x2563B6C Offset: 0x255FB6C VA: 0x2563B6C
	public bool get_IsDashMove() { }

	[CompilerGenerated]
	// RVA: 0x2563B74 Offset: 0x255FB74 VA: 0x2563B74
	private void set_IsDashMove(bool value) { }

	// RVA: 0x2563B80 Offset: 0x255FB80 VA: 0x2563B80
	public bool get_IsEventCheck() { }

	// RVA: 0x2563BA0 Offset: 0x255FBA0 VA: 0x2563BA0
	public bool get_IsEventConnection() { }

	[CompilerGenerated]
	// RVA: 0x2563BB0 Offset: 0x255FBB0 VA: 0x2563BB0
	public bool get_IsSkillLockArea() { }

	[CompilerGenerated]
	// RVA: 0x2563BB8 Offset: 0x255FBB8 VA: 0x2563BB8
	private void set_IsSkillLockArea(bool value) { }

	// RVA: 0x2563BC4 Offset: 0x255FBC4 VA: 0x2563BC4
	public GameObject get_BossTelop() { }

	// RVA: 0x2563BCC Offset: 0x255FBCC VA: 0x2563BCC
	private void ChangeEventScene(FieldScriptManager.EventSceneType sceneType) { }

	// RVA: 0x2563E60 Offset: 0x255FE60 VA: 0x2563E60
	public bool CheckActiveEventId(int id) { }

	// RVA: 0x2563E80 Offset: 0x255FE80 VA: 0x2563E80
	public bool get_CancelFlag() { }

	// RVA: 0x2563E88 Offset: 0x255FE88 VA: 0x2563E88
	public void set_CancelFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2563E94 Offset: 0x255FE94 VA: 0x2563E94
	private void set_SkipMode(FieldScriptManager.SkipModeType value) { }

	[CompilerGenerated]
	// RVA: 0x2563E9C Offset: 0x255FE9C VA: 0x2563E9C
	public FieldScriptManager.SkipModeType get_SkipMode() { }

	// RVA: 0x2563EA4 Offset: 0x255FEA4 VA: 0x2563EA4
	private UIEventMessageWindow GetUIEventMessageWindow() { }

	// RVA: 0x2564028 Offset: 0x2560028 VA: 0x2564028
	private UIInfoWindow GetUIInfoWindow() { }

	// RVA: 0x2564154 Offset: 0x2560154 VA: 0x2564154
	public IFieldScriptSystemLockManager get_SystemLockManager() { }

	// RVA: 0x256415C Offset: 0x256015C VA: 0x256415C
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x256424C Offset: 0x256024C VA: 0x256424C
	private string ReadEventString(bool localize) { }

	// RVA: 0x256430C Offset: 0x256030C VA: 0x256430C
	private string ReadEventBString(bool localize) { }

	// RVA: 0x2564274 Offset: 0x2560274 VA: 0x2564274
	private string EventLocalizeText() { }

	// RVA: 0x2564334 Offset: 0x2560334 VA: 0x2564334
	private string EventLocalizeText(int localizeId) { }

	// RVA: 0x25643B8 Offset: 0x25603B8 VA: 0x25643B8
	private string EventLocalizeTextCheck(bool localizeFlag) { }

	// RVA: 0x256448C Offset: 0x256048C VA: 0x256448C
	private string ScriptLocalizeText() { }

	// RVA: 0x256451C Offset: 0x256051C VA: 0x256451C
	private string ScriptLocalizeText(int localizeId) { }

	// RVA: 0x256459C Offset: 0x256059C VA: 0x256459C
	private void BaseAction(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<BaseFunc>d__91))]
	// RVA: 0x25645E0 Offset: 0x25605E0 VA: 0x25645E0
	private IEnumerator BaseFunc(FieldScriptCommand command) { }

	// RVA: 0x2564638 Offset: 0x2560638 VA: 0x2564638
	private void Awake() { }

	// RVA: 0x256968C Offset: 0x256568C VA: 0x256968C
	private void Start() { }

	// RVA: 0x25696E4 Offset: 0x25656E4 VA: 0x25696E4
	private void AddEnemyDeadEvent(int id, GameObject eventAreaObject) { }

	// RVA: 0x25697A0 Offset: 0x25657A0 VA: 0x25697A0
	private void RemoveEnemyDeadEvent(int scriptId) { }

	// RVA: 0x2569BEC Offset: 0x2565BEC VA: 0x2569BEC
	private void ClearEnemyDeadEvent() { }

	// RVA: 0x2569C3C Offset: 0x2565C3C VA: 0x2569C3C
	private void SetObject(int id, GameObject model) { }

	// RVA: 0x2569A14 Offset: 0x2565A14 VA: 0x2569A14
	private void RemoveObject(int id) { }

	// RVA: 0x2569D80 Offset: 0x2565D80 VA: 0x2569D80
	private FieldScriptModel GetFieldScriptModel(int id) { }

	// RVA: 0x2569F0C Offset: 0x2565F0C VA: 0x2569F0C
	public List<GameObject> GetMiniMapFieldModel() { }

	// RVA: 0x256A224 Offset: 0x2566224 VA: 0x256A224
	private FieldScriptModel GetAndAddFieldScriptModel(int id, byte mid = 0, short motion = 0, short flag = 8) { }

	// RVA: 0x256A460 Offset: 0x2566460 VA: 0x256A460
	private GameObject GetFieldModelObject(int id) { }

	// RVA: 0x2569CB0 Offset: 0x2565CB0 VA: 0x2569CB0
	private void StopSound_ModelObject(GameObject gameObj) { }

	// RVA: 0x256A4D8 Offset: 0x25664D8 VA: 0x256A4D8 Slot: 4
	public void OnEnter() { }

	// RVA: 0x256AD6C Offset: 0x2566D6C VA: 0x256AD6C Slot: 5
	public void OnLeave() { }

	// RVA: 0x256B188 Offset: 0x2567188 VA: 0x256B188
	public FieldScriptManager.ScriptLoadObject[] LoadObejct(int fieldId, byte roomType, byte roomId) { }

	// RVA: 0x256B894 Offset: 0x2567894 VA: 0x256B894
	public bool LoadObejct(int fieldId, byte roomType, byte roomId, out List<FieldScriptManager.ScriptLoadObject> model, out Dictionary<int, List<int>> motion, out Dictionary<int, Vector4> fieldTrans) { }

	// RVA: 0x256B6D8 Offset: 0x25676D8 VA: 0x256B6D8
	private void ModelListAdd(ModelType modelType, int id) { }

	// RVA: 0x256C108 Offset: 0x2568108 VA: 0x256C108
	private void ModelListAdd(List<FieldScriptManager.ScriptLoadObject> modelDataList, ModelType modelType, int id) { }

	// RVA: 0x256C2B8 Offset: 0x25682B8 VA: 0x256C2B8
	public bool Initialize(TextAsset textAsset, int fieldId) { }

	// RVA: 0x256C574 Offset: 0x2568574 VA: 0x256C574
	public bool StartScript(int index, int retVal) { }

	// RVA: 0x256AB84 Offset: 0x2566B84 VA: 0x256AB84
	public bool StartScript(int index) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<ScriptThread>d__119))]
	// RVA: 0x256C5B0 Offset: 0x25685B0 VA: 0x256C5B0
	private IEnumerator ScriptThread(int theradIndex) { }

	// RVA: 0x256C634 Offset: 0x2568634 VA: 0x256C634
	private void LateUpdate() { }

	// RVA: 0x256C840 Offset: 0x2568840 VA: 0x256C840
	public bool ScriptEventSkip() { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnAutoNextCommand>d__122))]
	// RVA: 0x256CDBC Offset: 0x2568DBC VA: 0x256CDBC
	private IEnumerator OnAutoNextCommand(FieldScriptCommand command) { }

	// RVA: 0x256CE30 Offset: 0x2568E30 VA: 0x256CE30
	private void OnEndCommand(FieldScriptCommand command) { }

	// RVA: 0x256D4A8 Offset: 0x25694A8 VA: 0x256D4A8
	private void OnBackScriptCommand(FieldScriptCommand command) { }

	// RVA: 0x256D4B8 Offset: 0x25694B8 VA: 0x256D4B8
	private void OnFieldActionLockCommand(FieldScriptCommand command) { }

	// RVA: 0x256D598 Offset: 0x2569598 VA: 0x256D598
	private void OnSkipModeCommand(FieldScriptCommand command) { }

	// RVA: 0x256D740 Offset: 0x2569740 VA: 0x256D740
	private void OnSetShortcutCommand(FieldScriptCommand command) { }

	// RVA: 0x256D880 Offset: 0x2569880 VA: 0x256D880
	private void OnObjectDestroyCommand(FieldScriptCommand command) { }

	// RVA: 0x256D8AC Offset: 0x25698AC VA: 0x256D8AC
	private void OnMesCommand(FieldScriptCommand command) { }

	// RVA: 0x256D9C8 Offset: 0x25699C8 VA: 0x256D9C8
	private void OnMesChatCommand(FieldScriptCommand command) { }

	// RVA: 0x256DA64 Offset: 0x2569A64 VA: 0x256DA64
	private void OnAlertMessageCommand(FieldScriptCommand command) { }

	// RVA: 0x256DCAC Offset: 0x2569CAC VA: 0x256DCAC
	private void OnMesUserCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnMenuCommand>d__134))]
	// RVA: 0x256DD04 Offset: 0x2569D04 VA: 0x256DD04
	private IEnumerator OnMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x256DD88 Offset: 0x2569D88 VA: 0x256DD88
	private void OnMenuCancelLockCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNextInputCommand>d__136))]
	// RVA: 0x256DDA4 Offset: 0x2569DA4 VA: 0x256DDA4
	private IEnumerator OnNextInputCommand(FieldScriptCommand command) { }

	// RVA: 0x256DE28 Offset: 0x2569E28 VA: 0x256DE28
	private void OnCloseSlipCommand(FieldScriptCommand command) { }

	// RVA: 0x256DE44 Offset: 0x2569E44 VA: 0x256DE44
	private void OnInfoTextureCommand(FieldScriptCommand command) { }

	// RVA: 0x256DEAC Offset: 0x2569EAC VA: 0x256DEAC
	private void OnInfoTextCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnInfoNextCommand>d__140))]
	// RVA: 0x256DFEC Offset: 0x2569FEC VA: 0x256DFEC
	private IEnumerator OnInfoNextCommand(FieldScriptCommand command) { }

	// RVA: 0x256E060 Offset: 0x256A060 VA: 0x256E060
	private void OnIniteMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x256E0D0 Offset: 0x256A0D0 VA: 0x256E0D0
	private void OnAddMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x256E314 Offset: 0x256A314 VA: 0x256E314
	private void OnAddLeftMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x256E0DC Offset: 0x256A0DC VA: 0x256E0DC
	private void AddMenuCommandProcess(FieldScriptCommand command, FieldScriptCommand defaultCommand, UIWidget.Pivot pivot) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnExecMenuCommand>d__145))]
	// RVA: 0x256E320 Offset: 0x256A320 VA: 0x256E320
	private IEnumerator OnExecMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnWarpListMenuCommand>d__146))]
	// RVA: 0x256E3A4 Offset: 0x256A3A4 VA: 0x256E3A4
	private IEnumerator OnWarpListMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x256E428 Offset: 0x256A428 VA: 0x256E428
	private void OnSwitchCommand(FieldScriptCommand command) { }

	// RVA: 0x256E510 Offset: 0x256A510 VA: 0x256E510
	private void OnMoveAddressCommand(FieldScriptCommand command) { }

	// RVA: 0x256E538 Offset: 0x256A538 VA: 0x256E538
	private void OnSetCommand(FieldScriptCommand command) { }

	// RVA: 0x256E6C0 Offset: 0x256A6C0 VA: 0x256E6C0
	private void OnSetRandomCommand(FieldScriptCommand command) { }

	// RVA: 0x256E770 Offset: 0x256A770 VA: 0x256E770
	private void OnCheckCommand(FieldScriptCommand command) { }

	// RVA: 0x256E8A0 Offset: 0x256A8A0 VA: 0x256E8A0
	private void OnGetHaveItemIdNum(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnGetQuestListCommand>d__153))]
	// RVA: 0x256E924 Offset: 0x256A924 VA: 0x256E924
	private IEnumerator OnGetQuestListCommand(FieldScriptCommand command) { }

	// RVA: 0x256E998 Offset: 0x256A998 VA: 0x256E998
	private void OnProgressQuestCommand(FieldScriptCommand command) { }

	// RVA: 0x256EA40 Offset: 0x256AA40 VA: 0x256EA40
	private void OnCheckQuestCommand(FieldScriptCommand command) { }

	// RVA: 0x256EB90 Offset: 0x256AB90 VA: 0x256EB90
	private void OnCheckStartQuestCommand(FieldScriptCommand command) { }

	// RVA: 0x256EC40 Offset: 0x256AC40 VA: 0x256EC40
	private void OnStartQuestCommand(FieldScriptCommand command) { }

	// RVA: 0x256EF90 Offset: 0x256AF90 VA: 0x256EF90
	private void OnRewardQuestCommand(FieldScriptCommand command) { }

	// RVA: 0x256F068 Offset: 0x256B068 VA: 0x256F068
	private void OnSetKeyItemCommand(FieldScriptCommand command) { }

	// RVA: 0x256F19C Offset: 0x256B19C VA: 0x256F19C
	private void OnGetKeyItemCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnRepeatRewardQuestCommand>d__161))]
	// RVA: 0x256F290 Offset: 0x256B290 VA: 0x256F290
	private IEnumerator OnRepeatRewardQuestCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnRewardPopUpCommand>d__162))]
	// RVA: 0x256F304 Offset: 0x256B304 VA: 0x256F304
	private IEnumerator OnRewardPopUpCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnEndQuestCommand>d__163))]
	// RVA: 0x256F378 Offset: 0x256B378 VA: 0x256F378
	private IEnumerator OnEndQuestCommand(FieldScriptCommand command) { }

	// RVA: 0x256F3EC Offset: 0x256B3EC VA: 0x256F3EC
	private void OnRewardCheckCommand(FieldScriptCommand command) { }

	// RVA: 0x256F4F8 Offset: 0x256B4F8 VA: 0x256F4F8
	private void OnViewQuestCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnViewEffectCommand>d__166))]
	// RVA: 0x256F64C Offset: 0x256B64C VA: 0x256F64C
	private IEnumerator OnViewEffectCommand(FieldScriptCommand command) { }

	// RVA: 0x256F6C0 Offset: 0x256B6C0 VA: 0x256F6C0
	private void OnCheckStartMissionCommand(FieldScriptCommand command) { }

	// RVA: 0x256F824 Offset: 0x256B824 VA: 0x256F824
	private void OnCheckContentsCommand(FieldScriptCommand command) { }

	// RVA: 0x256F950 Offset: 0x256B950 VA: 0x256F950
	private void OnAccountProgressMissionCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSetObjectCommand>d__170))]
	// RVA: 0x256FAA0 Offset: 0x256BAA0 VA: 0x256FAA0
	private IEnumerator OnSetObjectCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSetMergeObjectCommand>d__171))]
	// RVA: 0x256FB14 Offset: 0x256BB14 VA: 0x256FB14
	private IEnumerator OnSetMergeObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x256FB88 Offset: 0x256BB88 VA: 0x256FB88
	private void OnMoveObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x256FE28 Offset: 0x256BE28 VA: 0x256FE28
	private void OnParabolaMoveObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x2570364 Offset: 0x256C364 VA: 0x2570364
	private void OnHeightObjectCommnad(FieldScriptCommand command) { }

	// RVA: 0x2570488 Offset: 0x256C488 VA: 0x2570488
	private void OnRotObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x25705C0 Offset: 0x256C5C0 VA: 0x25705C0
	private void OnScaleObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x25709D8 Offset: 0x256C9D8 VA: 0x25709D8
	private void OnRemoveScaleBoneCommand(FieldScriptCommand command) { }

	// RVA: 0x2570B70 Offset: 0x256CB70 VA: 0x2570B70
	private void OnMotionObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x2570CD4 Offset: 0x256CCD4 VA: 0x2570CD4
	private void OnInvisibleObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x2570F20 Offset: 0x256CF20 VA: 0x2570F20
	private void OnMobBreakPartsCommand(FieldScriptCommand command) { }

	// RVA: 0x25711E4 Offset: 0x256D1E4 VA: 0x25711E4
	private void OnMobBreakPartsBitCommand(FieldScriptCommand command) { }

	// RVA: 0x25714A8 Offset: 0x256D4A8 VA: 0x25714A8
	private void OnGetMobBreakPartsFlagCommand(FieldScriptCommand command) { }

	// RVA: 0x257173C Offset: 0x256D73C VA: 0x257173C
	private void OnChangeVartexColorCommand(FieldScriptCommand command) { }

	// RVA: 0x2571A80 Offset: 0x256DA80 VA: 0x2571A80
	private void OnAddShadowBoneEffectCommand(FieldScriptCommand command) { }

	// RVA: 0x2571B5C Offset: 0x256DB5C VA: 0x2571B5C
	private void OnAttachBoneObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x2571DA4 Offset: 0x256DDA4 VA: 0x2571DA4
	private void OnDetachBoneObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x2571ECC Offset: 0x256DECC VA: 0x2571ECC
	private void OnFieldLinkMotion(FieldScriptCommand command) { }

	// RVA: 0x2572014 Offset: 0x256E014 VA: 0x2572014
	private void OnRemoveFieldLinkMotion(FieldScriptCommand command) { }

	// RVA: 0x2572118 Offset: 0x256E118 VA: 0x2572118
	private void OnPlayerGraphicCommand(FieldScriptCommand command) { }

	// RVA: 0x25722DC Offset: 0x256E2DC VA: 0x25722DC
	private void OnFukidashiCommand(FieldScriptCommand command) { }

	// RVA: 0x2572748 Offset: 0x256E748 VA: 0x2572748
	private void OnSetMarkerCommand(FieldScriptCommand command) { }

	// RVA: 0x2572B48 Offset: 0x256EB48 VA: 0x2572B48
	private void OnBreakMarkerCommand(FieldScriptCommand command) { }

	// RVA: 0x2572C78 Offset: 0x256EC78 VA: 0x2572C78
	private void OnCloneNPCObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x2572D94 Offset: 0x256ED94 VA: 0x2572D94
	private void OnSetCloneObjectPosCommand(FieldScriptCommand command) { }

	// RVA: 0x2572F20 Offset: 0x256EF20 VA: 0x2572F20
	private void OnSetCloneObjectRotCommand(FieldScriptCommand command) { }

	// RVA: 0x25730AC Offset: 0x256F0AC VA: 0x25730AC
	private void OnSetCloneObjectScaleCommand(FieldScriptCommand command) { }

	// RVA: 0x2573238 Offset: 0x256F238 VA: 0x2573238
	private void CreateWarningArea(int id, Material matArea) { }

	// RVA: 0x257357C Offset: 0x256F57C VA: 0x257357C
	private void OnWarningLineAreaCommand(FieldScriptCommand command) { }

	// RVA: 0x2573954 Offset: 0x256F954 VA: 0x2573954
	private void OnWarningSectorAreaCommand(FieldScriptCommand command) { }

	// RVA: 0x2573DD8 Offset: 0x256FDD8 VA: 0x2573DD8
	private void OnPlayerObjectLinkCommand(FieldScriptCommand command) { }

	// RVA: 0x2573F7C Offset: 0x256FF7C VA: 0x2573F7C
	private void OnEmotionCommand(FieldScriptCommand command) { }

	// RVA: 0x2574008 Offset: 0x2570008 VA: 0x2574008
	private void OnPlayerPosCommand(FieldScriptCommand command) { }

	// RVA: 0x2574148 Offset: 0x2570148 VA: 0x2574148
	private void OnPlayerMoveCommand(FieldScriptCommand command) { }

	// RVA: 0x2574280 Offset: 0x2570280 VA: 0x2574280
	private void OnPlayerRotCommand(FieldScriptCommand command) { }

	// RVA: 0x2574328 Offset: 0x2570328 VA: 0x2574328
	private void OnGetAbnormalGroupCommand(FieldScriptCommand command) { }

	// RVA: 0x2574458 Offset: 0x2570458 VA: 0x2574458
	private void OnGetAbnormalStateCommand(FieldScriptCommand command) { }

	// RVA: 0x25744DC Offset: 0x25704DC VA: 0x25744DC
	private void OnPlayerTargetHatesCommand(FieldScriptCommand command) { }

	// RVA: 0x2574554 Offset: 0x2570554 VA: 0x2574554
	private void OnAutoMemberPartyCommand(FieldScriptCommand command) { }

	// RVA: 0x25746FC Offset: 0x25706FC VA: 0x25746FC
	private void OnSetTacticalCommand(FieldScriptCommand command) { }

	// RVA: 0x2574894 Offset: 0x2570894 VA: 0x2574894
	private void OnCameraHandShakeCommand(FieldScriptCommand command) { }

	// RVA: 0x25748D4 Offset: 0x25708D4 VA: 0x25748D4
	private void OnApplicationCameraResetCommand(FieldScriptCommand command) { }

	// RVA: 0x25748F0 Offset: 0x25708F0 VA: 0x25748F0
	private void OnApplicationCameraRotResetCommand(FieldScriptCommand command) { }

	// RVA: 0x2574930 Offset: 0x2570930 VA: 0x2574930
	private void OnAutoCameraResetCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnCameraNextCommand>d__216))]
	// RVA: 0x257494C Offset: 0x257094C VA: 0x257494C
	private IEnumerator OnCameraNextCommand(FieldScriptCommand command) { }

	// RVA: 0x25749C0 Offset: 0x25709C0 VA: 0x25749C0
	private void OnCameraRotCommand(FieldScriptCommand command) { }

	// RVA: 0x2574A00 Offset: 0x2570A00 VA: 0x2574A00
	private void OnCameraMoveCommand(FieldScriptCommand command) { }

	// RVA: 0x2574C98 Offset: 0x2570C98 VA: 0x2574C98
	private void OnCameraMoveExCommand(FieldScriptCommand command) { }

	// RVA: 0x2574E6C Offset: 0x2570E6C VA: 0x2574E6C
	private void OnCameraOptionCommand(FieldScriptCommand command) { }

	// RVA: 0x2574EF0 Offset: 0x2570EF0 VA: 0x2574EF0
	private void OnSetDivingCameraAngleCommand(FieldScriptCommand command) { }

	// RVA: 0x2575030 Offset: 0x2571030 VA: 0x2575030
	private void OnBillboradTarget(FieldScriptCommand command) { }

	// RVA: 0x257511C Offset: 0x257111C VA: 0x257511C
	private void OnFlashMonitorCommand(FieldScriptCommand command) { }

	// RVA: 0x25751A4 Offset: 0x25711A4 VA: 0x25751A4
	private void OnFlashMonitorExCommand(FieldScriptCommand command) { }

	// RVA: 0x2575220 Offset: 0x2571220 VA: 0x2575220
	private void OnShakeMonitorCommand(FieldScriptCommand command) { }

	// RVA: 0x25752FC Offset: 0x25712FC VA: 0x25752FC
	private void OnBgmControlCommand(FieldScriptCommand command) { }

	// RVA: 0x257543C Offset: 0x257143C VA: 0x257543C
	private void OnBgmUnDestroyCommand(FieldScriptCommand command) { }

	// RVA: 0x25754B0 Offset: 0x25714B0 VA: 0x25754B0
	private void BgmControlPositionCommand(FieldScriptCommand command) { }

	// RVA: 0x2575630 Offset: 0x2571630 VA: 0x2575630
	private void OnSoundEffectCommand(FieldScriptCommand command) { }

	// RVA: 0x2575704 Offset: 0x2571704 VA: 0x2575704
	private void OnSoundEffectPositionCommand(FieldScriptCommand command) { }

	// RVA: 0x2575BF4 Offset: 0x2571BF4 VA: 0x2575BF4
	private void OnSetNextBgm(FieldScriptCommand command) { }

	// RVA: 0x2575CA4 Offset: 0x2571CA4 VA: 0x2575CA4
	private void OnCrossFadeBgm(FieldScriptCommand command) { }

	// RVA: 0x2575D5C Offset: 0x2571D5C VA: 0x2575D5C
	private void OnCrossFadeVolumeBgm(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnDevelopWarpCommand>d__235))]
	// RVA: 0x2575E54 Offset: 0x2571E54 VA: 0x2575E54
	private IEnumerator OnDevelopWarpCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnWarpCommand>d__236))]
	// RVA: 0x2575ED8 Offset: 0x2571ED8 VA: 0x2575ED8
	private IEnumerator OnWarpCommand(FieldScriptCommand command) { }

	// RVA: 0x2575F5C Offset: 0x2571F5C VA: 0x2575F5C
	private EmergencyPositionData EmergencyPosition() { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnEscapeEmergencyWarpCommand>d__238))]
	// RVA: 0x25760E4 Offset: 0x25720E4 VA: 0x25760E4
	private IEnumerator OnEscapeEmergencyWarpCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnRoomWarpCommand>d__239))]
	// RVA: 0x2576168 Offset: 0x2572168 VA: 0x2576168
	private IEnumerator OnRoomWarpCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnCultivationGardenLeave>d__240))]
	// RVA: 0x25761EC Offset: 0x25721EC VA: 0x25761EC
	private IEnumerator OnCultivationGardenLeave(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnEnterGuildHomeCommand>d__241))]
	// RVA: 0x2576270 Offset: 0x2572270 VA: 0x2576270
	private IEnumerator OnEnterGuildHomeCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnReenterGuildRaidLobbyFieldCommand>d__242))]
	// RVA: 0x25762F4 Offset: 0x25722F4 VA: 0x25762F4
	private IEnumerator OnReenterGuildRaidLobbyFieldCommand(FieldScriptCommand command) { }

	// RVA: 0x2576378 Offset: 0x2572378 VA: 0x2576378
	private void OnTrafficProhibitionCommand(FieldScriptCommand command) { }

	// RVA: 0x25764D4 Offset: 0x25724D4 VA: 0x25764D4
	private void OnBothTrafficProhibitionCommand(FieldScriptCommand command) { }

	// RVA: 0x25766F8 Offset: 0x25726F8 VA: 0x25766F8
	private void OnBothTrafficProhibitionHeightCommand(FieldScriptCommand command) { }

	// RVA: 0x257695C Offset: 0x257295C VA: 0x257695C
	private void OnTrafficProhibitionWarningLineAreaCommand(FieldScriptCommand command) { }

	// RVA: 0x25770DC Offset: 0x25730DC VA: 0x25770DC
	private void OnCameraTrafficProhibitionCommand(FieldScriptCommand command) { }

	// RVA: 0x2577218 Offset: 0x2573218 VA: 0x2577218
	private void OnSetEventCommand(FieldScriptCommand command) { }

	// RVA: 0x2577488 Offset: 0x2573488 VA: 0x2577488
	private void OnSetTypeEventCommand(FieldScriptCommand command) { }

	// RVA: 0x2577738 Offset: 0x2573738 VA: 0x2577738
	private void OnSetCircleCommand(FieldScriptCommand command) { }

	// RVA: 0x2577768 Offset: 0x2573768 VA: 0x2577768
	private void OnBreakEvent(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnShopCommand>d__252))]
	// RVA: 0x25778BC Offset: 0x25738BC VA: 0x25778BC
	private IEnumerator OnShopCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnExchangeShopCommand>d__253))]
	// RVA: 0x2577940 Offset: 0x2573940 VA: 0x2577940
	private IEnumerator OnExchangeShopCommand(FieldScriptCommand command) { }

	// RVA: 0x25779C4 Offset: 0x25739C4 VA: 0x25779C4
	private void OnEventMonsterCommand(FieldScriptCommand command) { }

	// RVA: 0x2577BC0 Offset: 0x2573BC0 VA: 0x2577BC0
	private void OnBreakMob(FieldScriptCommand command) { }

	// RVA: 0x2577C48 Offset: 0x2573C48 VA: 0x2577C48
	private void OnBreakMapCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnGuildRaidBossResultCommand>d__257))]
	// RVA: 0x2577CEC Offset: 0x2573CEC VA: 0x2577CEC
	private IEnumerator OnGuildRaidBossResultCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnBossResultCommand>d__258))]
	// RVA: 0x2577D60 Offset: 0x2573D60 VA: 0x2577D60
	private IEnumerator OnBossResultCommand(FieldScriptCommand command) { }

	// RVA: 0x2577DD4 Offset: 0x2573DD4 VA: 0x2577DD4
	private void OnPartyMatchingCommand(FieldScriptCommand command) { }

	// RVA: 0x2577E88 Offset: 0x2573E88 VA: 0x2577E88
	private void OnBossHpMobIdListCommand(FieldScriptCommand command) { }

	// RVA: 0x2577FC0 Offset: 0x2573FC0 VA: 0x2577FC0
	private void OnBossHpListCommand(FieldScriptCommand command) { }

	// RVA: 0x25780A4 Offset: 0x25740A4 VA: 0x25780A4
	private void OnAutoMemberSecondPartyCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnBossMenuCommand>d__263))]
	// RVA: 0x25781CC Offset: 0x25741CC VA: 0x25781CC
	private IEnumerator OnBossMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnBossAreaLevelMenuCommand>d__264))]
	// RVA: 0x2578250 Offset: 0x2574250 VA: 0x2578250
	private IEnumerator OnBossAreaLevelMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x25782D4 Offset: 0x25742D4 VA: 0x25782D4
	private void OnBossEventScriptCommand(FieldScriptCommand command) { }

	// RVA: 0x2578A88 Offset: 0x2574A88 VA: 0x2578A88
	private void OnBossNameCommnad(FieldScriptCommand command) { }

	// RVA: 0x25795A4 Offset: 0x25755A4 VA: 0x25795A4
	private void OnGuildRaidBossNameCommnad(FieldScriptCommand command) { }

	// RVA: 0x2579250 Offset: 0x2575250 VA: 0x2579250
	private GameObject CreateTag(Object obj, byte position, string name, string data) { }

	// RVA: 0x25798F0 Offset: 0x25758F0 VA: 0x25798F0
	private void OnBossTelopCommand(FieldScriptCommand command) { }

	// RVA: 0x2579B70 Offset: 0x2575B70 VA: 0x2579B70
	private void OnEventTelopPositionCommand(FieldScriptCommand command) { }

	// RVA: 0x257A1BC Offset: 0x25761BC VA: 0x257A1BC
	private void OnEntreeStagingUpdateCommand(FieldScriptCommand command) { }

	// RVA: 0x257A1C0 Offset: 0x25761C0 VA: 0x257A1C0
	private void OnCheckPartyLinkCommand(FieldScriptCommand command) { }

	// RVA: 0x257A230 Offset: 0x2576230 VA: 0x257A230
	private void OnPartyNameCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnGemEffectCommand>d__274))]
	// RVA: 0x257A4A0 Offset: 0x25764A0 VA: 0x257A4A0
	private IEnumerator OnGemEffectCommand(FieldScriptCommand command) { }

	// RVA: 0x257A514 Offset: 0x2576514 VA: 0x257A514
	private void OnGuildHomeExitCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnGuildHomeTenantEditMenuCommand>d__276))]
	// RVA: 0x257A564 Offset: 0x2576564 VA: 0x257A564
	private IEnumerator OnGuildHomeTenantEditMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x257A5E8 Offset: 0x25765E8 VA: 0x257A5E8
	private void OnGuildHomeTenantTypeCommand(FieldScriptCommand command) { }

	// RVA: 0x257A6C4 Offset: 0x25766C4 VA: 0x257A6C4
	private void OnGetGuildRaidActiveElementCommand(FieldScriptCommand command) { }

	// RVA: 0x257A7B0 Offset: 0x25767B0 VA: 0x257A7B0
	private void OnCheckGuildSystemUnLockCommand(FieldScriptCommand command) { }

	// RVA: 0x257A980 Offset: 0x2576980 VA: 0x257A980
	private void OnOpenEnterGuildRaidCommand(FieldScriptCommand command) { }

	// RVA: 0x257AA04 Offset: 0x2576A04 VA: 0x257AA04
	private void OnOpenGuildQuestBoradCommand(FieldScriptCommand command) { }

	// RVA: 0x257AA88 Offset: 0x2576A88 VA: 0x257AA88
	private void OnOpenGuildGuildFacilitySwitchPanelCommand(FieldScriptCommand command) { }

	// RVA: 0x257AB0C Offset: 0x2576B0C VA: 0x257AB0C
	private void OnOpenGuildRaidSymbolCommand(FieldScriptCommand command) { }

	// RVA: 0x257AB90 Offset: 0x2576B90 VA: 0x257AB90
	private void OnOpenGuildRaidSummonCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnDungeonMenuCommand>d__285))]
	// RVA: 0x257AC14 Offset: 0x2576C14 VA: 0x257AC14
	private IEnumerator OnDungeonMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x257AC98 Offset: 0x2576C98 VA: 0x257AC98
	private void OnDungeonEscapeCommand(FieldScriptCommand command) { }

	// RVA: 0x257ACE8 Offset: 0x2576CE8 VA: 0x257ACE8
	private void OnCheckDungeonDownstairsCommand(FieldScriptCommand command) { }

	// RVA: 0x257ADA4 Offset: 0x2576DA4 VA: 0x257ADA4
	private void OnDungeonDownstairsCommand(FieldScriptCommand command) { }

	// RVA: 0x257AE14 Offset: 0x2576E14 VA: 0x257AE14
	private void OnCheckDungeonFloorCommand(FieldScriptCommand command) { }

	// RVA: 0x257AEC8 Offset: 0x2576EC8 VA: 0x257AEC8
	private void OnInitDungeonFloorCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnWeeklyDefenseMenuCommand>d__291))]
	// RVA: 0x257B4CC Offset: 0x25774CC VA: 0x257B4CC
	private IEnumerator OnWeeklyDefenseMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnChallengeDungeon2MenuCommand>d__292))]
	// RVA: 0x257B550 Offset: 0x2577550 VA: 0x257B550
	private IEnumerator OnChallengeDungeon2MenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnChallengeDungeon2ResultCommand>d__293))]
	// RVA: 0x257B5D4 Offset: 0x25775D4 VA: 0x257B5D4
	private IEnumerator OnChallengeDungeon2ResultCommand(FieldScriptCommand command) { }

	// RVA: 0x257B648 Offset: 0x2577648 VA: 0x257B648
	private void OnIsRegistletCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSetDefaultDefenseObjectCommand>d__295))]
	// RVA: 0x257B690 Offset: 0x2577690 VA: 0x257B690
	private IEnumerator OnSetDefaultDefenseObjectCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSetDefenseObjectCommand>d__296))]
	// RVA: 0x257B704 Offset: 0x2577704 VA: 0x257B704
	private IEnumerator OnSetDefenseObjectCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSetNPCDefenseObjectCommand>d__297))]
	// RVA: 0x257B778 Offset: 0x2577778 VA: 0x257B778
	private IEnumerator OnSetNPCDefenseObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x257B7EC Offset: 0x25777EC VA: 0x257B7EC
	private void OnAddDefenseObjectMotionEvent(FieldScriptCommand command) { }

	// RVA: 0x257BA28 Offset: 0x2577A28 VA: 0x257BA28
	private void OnSetDefenseLocalize(FieldScriptCommand command) { }

	// RVA: 0x257BC20 Offset: 0x2577C20 VA: 0x257BC20
	private void OnSetIndividualDefenseLocalize(FieldScriptCommand command) { }

	// RVA: 0x257BDDC Offset: 0x2577DDC VA: 0x257BDDC
	private void OnWaveStartArea(FieldScriptCommand command) { }

	// RVA: 0x257BF3C Offset: 0x2577F3C VA: 0x257BF3C
	private void OnWaveResultTimerMesChattCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnWaveExchangeShopCommand>d__303))]
	// RVA: 0x257C0CC Offset: 0x25780CC VA: 0x257C0CC
	private IEnumerator OnWaveExchangeShopCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnGuildMyroomMenuCommand>d__304))]
	// RVA: 0x257C140 Offset: 0x2578140 VA: 0x257C140
	private IEnumerator OnGuildMyroomMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x257C1C4 Offset: 0x25781C4 VA: 0x257C1C4
	private void OnInitMyroomCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnMyroomLandPurchaseCommand>d__306))]
	// RVA: 0x257C238 Offset: 0x2578238 VA: 0x257C238
	private IEnumerator OnMyroomLandPurchaseCommand(FieldScriptCommand command) { }

	// RVA: 0x257C2AC Offset: 0x25782AC VA: 0x257C2AC
	private void OnMiniMapChangeCommand(FieldScriptCommand command) { }

	// RVA: 0x257C31C Offset: 0x257831C VA: 0x257C31C
	private void OnSavePointCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnAutoMemberCallCommand>d__309))]
	// RVA: 0x257C450 Offset: 0x2578450 VA: 0x257C450
	private IEnumerator OnAutoMemberCallCommand(FieldScriptCommand command) { }

	// RVA: 0x257C4C4 Offset: 0x25784C4 VA: 0x257C4C4
	private void OnSkillLockCommand(FieldScriptCommand command) { }

	// RVA: 0x257C508 Offset: 0x2578508 VA: 0x257C508
	private void OnSystemLockCommand(FieldScriptCommand command) { }

	// RVA: 0x257C8FC Offset: 0x25788FC VA: 0x257C8FC
	private void OnEventScene(FieldScriptCommand command) { }

	// RVA: 0x257C93C Offset: 0x257893C VA: 0x257C93C
	private void OnEscapePositionCommand(FieldScriptCommand command) { }

	// RVA: 0x257CB9C Offset: 0x2578B9C VA: 0x257CB9C
	private void OnScriptDamageCommand(FieldScriptCommand command) { }

	// RVA: 0x257CC58 Offset: 0x2578C58 VA: 0x257CC58
	private void OnScriptBadstatusCommand(FieldScriptCommand command) { }

	// RVA: 0x257CDB8 Offset: 0x2578DB8 VA: 0x257CDB8
	private void OnScriptMonsterAttackCommand(FieldScriptCommand command) { }

	// RVA: 0x257D0B8 Offset: 0x25790B8 VA: 0x257D0B8
	private void OnMonsterEventCheckCommand(FieldScriptCommand command) { }

	// RVA: 0x257D11C Offset: 0x257911C VA: 0x257D11C
	private void OnMobScriptActionCommand(FieldScriptCommand command) { }

	// RVA: 0x257D1F0 Offset: 0x25791F0 VA: 0x257D1F0
	private void OnActivePointIconCommand(FieldScriptCommand command) { }

	// RVA: 0x257D478 Offset: 0x2579478 VA: 0x257D478
	private void OnRemovePointIconCommand(FieldScriptCommand command) { }

	// RVA: 0x257D508 Offset: 0x2579508 VA: 0x257D508
	private void OnCheckNowEvent(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSettingValEvent>d__322))]
	// RVA: 0x257D5AC Offset: 0x25795AC VA: 0x257D5AC
	private IEnumerator OnSettingValEvent(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSetValEvent>d__323))]
	// RVA: 0x257D620 Offset: 0x2579620 VA: 0x257D620
	private IEnumerator OnSetValEvent(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnGetValEvent>d__324))]
	// RVA: 0x257D694 Offset: 0x2579694 VA: 0x257D694
	private IEnumerator OnGetValEvent(FieldScriptCommand command) { }

	// RVA: 0x257D708 Offset: 0x2579708 VA: 0x257D708
	private void OnXmasBoxCheck(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnXmasBosSet>d__326))]
	// RVA: 0x257D7F8 Offset: 0x25797F8 VA: 0x257D7F8
	private IEnumerator OnXmasBosSet(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnXmasBosGet>d__327))]
	// RVA: 0x257D86C Offset: 0x257986C VA: 0x257D86C
	private IEnumerator OnXmasBosGet(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNewyearSupinaPawn>d__328))]
	// RVA: 0x257D8E0 Offset: 0x25798E0 VA: 0x257D8E0
	private IEnumerator OnNewyearSupinaPawn(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNewyearHandWater>d__329))]
	// RVA: 0x257D954 Offset: 0x2579954 VA: 0x257D954
	private IEnumerator OnNewyearHandWater(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSummerDivingMenuCommand>d__330))]
	// RVA: 0x257D9C8 Offset: 0x25799C8 VA: 0x257D9C8
	private IEnumerator OnSummerDivingMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnRouteSetting>d__331))]
	// RVA: 0x257DA4C Offset: 0x2579A4C VA: 0x257DA4C
	private IEnumerator OnRouteSetting(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<AddRouteInfoSetting>d__332))]
	// RVA: 0x257DAC0 Offset: 0x2579AC0 VA: 0x257DAC0
	private IEnumerator AddRouteInfoSetting(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<CreateMaterialData>d__333))]
	// RVA: 0x257DB34 Offset: 0x2579B34 VA: 0x257DB34
	private IEnumerator CreateMaterialData(FieldScriptCommand comand) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnRouteSettingAI>d__334))]
	// RVA: 0x257DBA8 Offset: 0x2579BA8 VA: 0x257DBA8
	private IEnumerator OnRouteSettingAI(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnSpriengEventAI>d__335))]
	// RVA: 0x257DC1C Offset: 0x2579C1C VA: 0x257DC1C
	private IEnumerator OnSpriengEventAI(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnDeleteRouteAI>d__336))]
	// RVA: 0x257DC90 Offset: 0x2579C90 VA: 0x257DC90
	private IEnumerator OnDeleteRouteAI(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnDeleteRouteInfo>d__337))]
	// RVA: 0x257DD04 Offset: 0x2579D04 VA: 0x257DD04
	private IEnumerator OnDeleteRouteInfo(FieldScriptCommand commnad) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<SetRouteIndex>d__338))]
	// RVA: 0x257DD78 Offset: 0x2579D78 VA: 0x257DD78
	private IEnumerator SetRouteIndex(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<GrantAIMaterialData>d__339))]
	// RVA: 0x257DDEC Offset: 0x2579DEC VA: 0x257DDEC
	private IEnumerator GrantAIMaterialData(FieldScriptCommand commnad) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<GrantIntervalMaterialData>d__340))]
	// RVA: 0x257DE60 Offset: 0x2579E60 VA: 0x257DE60
	private IEnumerator GrantIntervalMaterialData(FieldScriptCommand commnad) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnEventRoomResultMenuCommand>d__341))]
	// RVA: 0x257DED4 Offset: 0x2579ED4 VA: 0x257DED4
	private IEnumerator OnEventRoomResultMenuCommand(FieldScriptCommand command) { }

	// RVA: 0x257DF48 Offset: 0x2579F48 VA: 0x257DF48
	private void OnSetCameraViewCommand(FieldScriptCommand command) { }

	// RVA: 0x257E238 Offset: 0x257A238 VA: 0x257E238
	private void OnEnableCameraViewCommand(FieldScriptCommand command) { }

	// RVA: 0x257E390 Offset: 0x257A390 VA: 0x257E390
	private void OnBreakCameraViewCommand(FieldScriptCommand command) { }

	// RVA: 0x257E4EC Offset: 0x257A4EC VA: 0x257E4EC
	private void OnSubCameraViewCommand(FieldScriptCommand command) { }

	// RVA: 0x257E848 Offset: 0x257A848 VA: 0x257E848
	private void OnSetRhythmGamePotumPositionCommand(FieldScriptCommand command) { }

	// RVA: 0x257EA0C Offset: 0x257AA0C VA: 0x257EA0C
	private void OnSetRhythmGameBossPositionCommand(FieldScriptCommand command) { }

	// RVA: 0x257EBD0 Offset: 0x257ABD0 VA: 0x257EBD0
	private void OnSetRhythmGameCameraPositionCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnBlackKnightEventCommand>d__349))]
	// RVA: 0x257ED88 Offset: 0x257AD88 VA: 0x257ED88
	private IEnumerator OnBlackKnightEventCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnHalloween2024EnterFieldCommand>d__350))]
	// RVA: 0x257EDFC Offset: 0x257ADFC VA: 0x257EDFC
	private IEnumerator OnHalloween2024EnterFieldCommand(FieldScriptCommand command) { }

	// RVA: 0x257EE80 Offset: 0x257AE80 VA: 0x257EE80
	private void OnMetapsAggregateCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNewWaveMenuCommand>d__352))]
	// RVA: 0x257EF68 Offset: 0x257AF68 VA: 0x257EF68
	private IEnumerator OnNewWaveMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNewWaveMenuOldCommand>d__353))]
	// RVA: 0x257EFEC Offset: 0x257AFEC VA: 0x257EFEC
	private IEnumerator OnNewWaveMenuOldCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNewWaveResultCommand>d__354))]
	// RVA: 0x257F070 Offset: 0x257B070 VA: 0x257F070
	private IEnumerator OnNewWaveResultCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnHighRaidMainMenuCommand>d__355))]
	// RVA: 0x257F0E4 Offset: 0x257B0E4 VA: 0x257F0E4
	private IEnumerator OnHighRaidMainMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnHighRaidExchangeShopCommand>d__356))]
	// RVA: 0x257F168 Offset: 0x257B168 VA: 0x257F168
	private IEnumerator OnHighRaidExchangeShopCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnScoreAttackMainMenuCommand>d__357))]
	// RVA: 0x257F1EC Offset: 0x257B1EC VA: 0x257F1EC
	private IEnumerator OnScoreAttackMainMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnScoreAttackResultCommand>d__358))]
	// RVA: 0x257F270 Offset: 0x257B270 VA: 0x257F270
	private IEnumerator OnScoreAttackResultCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnMobaEventCommand>d__359))]
	// RVA: 0x257F2E4 Offset: 0x257B2E4 VA: 0x257F2E4
	private IEnumerator OnMobaEventCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnMobaResultSetObjectCommand>d__360))]
	// RVA: 0x257F358 Offset: 0x257B358 VA: 0x257F358
	private IEnumerator OnMobaResultSetObjectCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNCollaborationMenuCommand>d__361))]
	// RVA: 0x257F3CC Offset: 0x257B3CC VA: 0x257F3CC
	private IEnumerator OnNCollaborationMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNCollaborationResultCommand>d__362))]
	// RVA: 0x257F450 Offset: 0x257B450 VA: 0x257F450
	private IEnumerator OnNCollaborationResultCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnBCollaborationMenuCommand>d__363))]
	// RVA: 0x257F4C4 Offset: 0x257B4C4 VA: 0x257F4C4
	private IEnumerator OnBCollaborationMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnBCollaborationResultCommand>d__364))]
	// RVA: 0x257F548 Offset: 0x257B548 VA: 0x257F548
	private IEnumerator OnBCollaborationResultCommand(FieldScriptCommand command) { }

	// RVA: 0x257F5BC Offset: 0x257B5BC VA: 0x257F5BC
	private void OnBCollaborationRankingCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNaCollaborationMenuCommand>d__366))]
	// RVA: 0x257F640 Offset: 0x257B640 VA: 0x257F640
	private IEnumerator OnNaCollaborationMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnNaCollaborationResultCommand>d__367))]
	// RVA: 0x257F6C4 Offset: 0x257B6C4 VA: 0x257F6C4
	private IEnumerator OnNaCollaborationResultCommand(FieldScriptCommand command) { }

	// RVA: 0x257F738 Offset: 0x257B738 VA: 0x257F738
	private void OnInvisibleMiniMapObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x257F82C Offset: 0x257B82C VA: 0x257F82C
	private void OnRotExObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x257F9D0 Offset: 0x257B9D0 VA: 0x257F9D0
	private void OnPositionObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x257FB80 Offset: 0x257BB80 VA: 0x257FB80
	private void OnStartMapEventActionCommand(FieldScriptCommand command) { }

	// RVA: 0x257FDD4 Offset: 0x257BDD4 VA: 0x257FDD4
	private void OnSceneIconCommand(FieldScriptCommand command) { }

	// RVA: 0x257FF4C Offset: 0x257BF4C VA: 0x257FF4C
	private void OnOpenTimerWindowCommand(FieldScriptCommand command) { }

	// RVA: 0x25801DC Offset: 0x257C1DC VA: 0x25801DC
	private void OnCloseTimerWindowCommand(FieldScriptCommand command) { }

	// RVA: 0x2580238 Offset: 0x257C238 VA: 0x2580238
	private void OnSetTimerWindowGaugeCommand(FieldScriptCommand command) { }

	// RVA: 0x258033C Offset: 0x257C33C VA: 0x258033C
	private void OnGetTimerWindowGaugeCommand(FieldScriptCommand command) { }

	// RVA: 0x2580440 Offset: 0x257C440 VA: 0x2580440
	private void OnAlphaObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x2580570 Offset: 0x257C570 VA: 0x2580570
	private void OnBrightnessObjectCommand(FieldScriptCommand command) { }

	// RVA: 0x25806A0 Offset: 0x257C6A0 VA: 0x25806A0
	private void OnDashAuthorizationCommand(FieldScriptCommand command) { }

	// RVA: 0x25806FC Offset: 0x257C6FC VA: 0x25806FC
	private void OnCheckRegionCommand(FieldScriptCommand command) { }

	// RVA: 0x2580798 Offset: 0x257C798 VA: 0x2580798
	private void OnMotionObjectDxCommand(FieldScriptCommand command) { }

	// RVA: 0x2580958 Offset: 0x257C958 VA: 0x2580958
	private void OnCurveMoveObjectCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnPartyMenuCommand>d__383))]
	// RVA: 0x2580B70 Offset: 0x257CB70 VA: 0x2580B70
	private IEnumerator OnPartyMenuCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnAbortQuestCommand>d__384))]
	// RVA: 0x2580BF4 Offset: 0x257CBF4 VA: 0x2580BF4
	private IEnumerator OnAbortQuestCommand(FieldScriptCommand command) { }

	[IteratorStateMachine(typeof(FieldScriptManager.<OnGetQuestSortListCommand>d__386))]
	// RVA: 0x2580C68 Offset: 0x257CC68 VA: 0x2580C68
	private IEnumerator OnGetQuestSortListCommand(FieldScriptCommand command) { }

	// RVA: 0x2580CDC Offset: 0x257CCDC VA: 0x2580CDC
	private void OnFadeMonitorCommand(FieldScriptCommand command) { }

	// RVA: 0x2580D84 Offset: 0x257CD84 VA: 0x2580D84
	private void OnMaskMonitorCommand(FieldScriptCommand command) { }

	// RVA: 0x2580E1C Offset: 0x257CE1C VA: 0x2580E1C
	private void OnFukidashiExCommand(FieldScriptCommand command) { }

	// RVA: 0x2581400 Offset: 0x257D400 VA: 0x2581400
	protected void ScriptErrorMessageLog(string s) { }

	// RVA: 0x2570F10 Offset: 0x256CF10 VA: 0x2570F10
	protected bool CheckBitFlag(byte flag, byte checkbit) { }

	// RVA: 0x2581404 Offset: 0x257D404 VA: 0x2581404
	protected void DebugLogGetQuestList(QuestManager.QuestOrderCondition condition, string logTitle, int questId) { }

	// RVA: 0x2581408 Offset: 0x257D408 VA: 0x2581408
	public void .ctor() { }
}
