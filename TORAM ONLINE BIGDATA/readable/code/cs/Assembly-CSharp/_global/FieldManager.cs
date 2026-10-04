// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldManager : Singleton<FieldManager> // TypeDefIndex: 3927
{
	// Fields
	private MapInfo mapInfo; // 0x20
	private FieldManager.ClientFieldData fieldData; // 0x28
	private bool bgmFadeOut; // 0x30
	private FieldTextManager fieldTextManager; // 0x38
	private int lastMmoFieldId; // 0x40
	private int lastMmoChannelId; // 0x44
	[CompilerGenerated]
	private bool <IsSavePointField>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <NextEnterFieldId>k__BackingField; // 0x4C
	private const int mobaLobbyFieldId = 94700;
	private const int mobaVsFieldId = 94800;

	// Properties
	public MapInfo MapInfo { get; }
	public int FieldId { get; }
	public int RoomId { get; }
	public int Channel { get; }
	public FieldRoomType RoomType { get; }
	public int WorldId { get; }
	public int ScriptLocalizeId { get; }
	public bool IsPCServer { get; }
	public float CameraMaxLimit { get; }
	public float CameraMinLimit { get; }
	public GameObject FieldInfoObject { get; }
	public Transform FieldInfoTransform { get; }
	public GameObject FieldRoomObject { get; }
	public Texture[] FieldMiniMapTexture { get; }
	public float ColliderSize { get; }
	public float FallHeight { get; }
	public bool IsDefaultField { get; }
	public bool IsGlobalField { get; }
	public bool IsSafetyArea { get; }
	public bool IsPartyRoom { get; }
	public bool IsNoRevivalRoom { get; }
	public bool IsMmo { get; }
	public bool IsMoRoom { get; }
	public bool IsMasterFieldIdRoomType { get; }
	public Vector3 FieldAreaTopLeft { get; set; }
	public Vector3 FieldAreaBottomRight { get; set; }
	public float WorldBrightness { get; }
	public bool BGMFadeOut { get; set; }
	public bool IsSavePointField { get; set; }
	public bool IsRaidRoom { get; }
	public int NextEnterFieldId { get; set; }
	public bool IsMobaLobby { get; }

	// Methods

	// RVA: 0x240B1C0 Offset: 0x24071C0 VA: 0x240B1C0
	public MapInfo get_MapInfo() { }

	// RVA: 0x240A178 Offset: 0x2406178 VA: 0x240A178
	public int get_FieldId() { }

	// RVA: 0x240B1C8 Offset: 0x24071C8 VA: 0x240B1C8
	public int get_RoomId() { }

	// RVA: 0x240B1E4 Offset: 0x24071E4 VA: 0x240B1E4
	public int get_Channel() { }

	// RVA: 0x240A194 Offset: 0x2406194 VA: 0x240A194
	public FieldRoomType get_RoomType() { }

	// RVA: 0x240B200 Offset: 0x2407200 VA: 0x240B200
	public int get_WorldId() { }

	// RVA: 0x240B21C Offset: 0x240721C VA: 0x240B21C
	public int get_ScriptLocalizeId() { }

	// RVA: 0x240B2C8 Offset: 0x24072C8 VA: 0x240B2C8
	public bool get_IsPCServer() { }

	// RVA: 0x240B30C Offset: 0x240730C VA: 0x240B30C
	public float get_CameraMaxLimit() { }

	// RVA: 0x240B330 Offset: 0x2407330 VA: 0x240B330
	public float get_CameraMinLimit() { }

	// RVA: 0x240B354 Offset: 0x2407354 VA: 0x240B354
	public GameObject get_FieldInfoObject() { }

	// RVA: 0x240B370 Offset: 0x2407370 VA: 0x240B370
	public Transform get_FieldInfoTransform() { }

	// RVA: 0x2409064 Offset: 0x2405064 VA: 0x2409064
	public GameObject get_FieldRoomObject() { }

	// RVA: 0x240B408 Offset: 0x2407408 VA: 0x240B408
	public Texture[] get_FieldMiniMapTexture() { }

	// RVA: 0x240B42C Offset: 0x240742C VA: 0x240B42C
	public float get_ColliderSize() { }

	// RVA: 0x240B450 Offset: 0x2407450 VA: 0x240B450
	public float get_FallHeight() { }

	// RVA: 0x240B474 Offset: 0x2407474 VA: 0x240B474
	public bool get_IsDefaultField() { }

	// RVA: 0x240B4C0 Offset: 0x24074C0 VA: 0x240B4C0
	public bool get_IsGlobalField() { }

	// RVA: 0x240B4E4 Offset: 0x24074E4 VA: 0x240B4E4
	public bool get_IsSafetyArea() { }

	// RVA: 0x240B55C Offset: 0x240755C VA: 0x240B55C
	public bool get_IsPartyRoom() { }

	// RVA: 0x240B580 Offset: 0x2407580 VA: 0x240B580
	public bool get_IsNoRevivalRoom() { }

	// RVA: 0x240B5A4 Offset: 0x24075A4 VA: 0x240B5A4
	public bool get_IsMmo() { }

	// RVA: 0x240B5DC Offset: 0x24075DC VA: 0x240B5DC
	public bool get_IsMoRoom() { }

	// RVA: 0x240B62C Offset: 0x240762C VA: 0x240B62C
	public bool get_IsMasterFieldIdRoomType() { }

	// RVA: 0x240B67C Offset: 0x240767C VA: 0x240B67C
	public void set_FieldAreaTopLeft(Vector3 value) { }

	// RVA: 0x240B69C Offset: 0x240769C VA: 0x240B69C
	public Vector3 get_FieldAreaTopLeft() { }

	// RVA: 0x240B6BC Offset: 0x24076BC VA: 0x240B6BC
	public void set_FieldAreaBottomRight(Vector3 value) { }

	// RVA: 0x240B6DC Offset: 0x24076DC VA: 0x240B6DC
	public Vector3 get_FieldAreaBottomRight() { }

	// RVA: 0x240B6FC Offset: 0x24076FC VA: 0x240B6FC
	public float get_WorldBrightness() { }

	// RVA: 0x240B720 Offset: 0x2407720 VA: 0x240B720
	public bool get_BGMFadeOut() { }

	// RVA: 0x240B73C Offset: 0x240773C VA: 0x240B73C
	public void set_BGMFadeOut(bool value) { }

	[CompilerGenerated]
	// RVA: 0x240B748 Offset: 0x2407748 VA: 0x240B748
	public bool get_IsSavePointField() { }

	[CompilerGenerated]
	// RVA: 0x240B750 Offset: 0x2407750 VA: 0x240B750
	private void set_IsSavePointField(bool value) { }

	// RVA: 0x240B75C Offset: 0x240775C VA: 0x240B75C
	public bool get_IsRaidRoom() { }

	[CompilerGenerated]
	// RVA: 0x240B860 Offset: 0x2407860 VA: 0x240B860
	public int get_NextEnterFieldId() { }

	[CompilerGenerated]
	// RVA: 0x240B868 Offset: 0x2407868 VA: 0x240B868
	private void set_NextEnterFieldId(int value) { }

	// RVA: 0x240B870 Offset: 0x2407870 VA: 0x240B870
	public bool get_IsMobaLobby() { }

	// RVA: 0x240B8B0 Offset: 0x24078B0 VA: 0x240B8B0
	private void Awake() { }

	// RVA: 0x240B9CC Offset: 0x24079CC VA: 0x240B9CC
	public void FirstLoadField(int fieldId, FieldRoomType roomType, byte roomId, Action<bool> callback) { }

	// RVA: 0x240BBC0 Offset: 0x2407BC0 VA: 0x240BBC0
	public static bool IsChatShoutErrRoom(FieldRoomType roomType) { }

	// RVA: 0x240BBE0 Offset: 0x2407BE0 VA: 0x240BBE0
	public void EnterSavePointField() { }

	[IteratorStateMachine(typeof(FieldManager.<firstLoadField>d__84))]
	// RVA: 0x240BB14 Offset: 0x2407B14 VA: 0x240BB14
	private IEnumerator firstLoadField(int fieldId, FieldRoomType roomType, byte roomId, Action<bool> callback) { }

	// RVA: 0x240BBEC Offset: 0x2407BEC VA: 0x240BBEC
	public void LoadField(int fieldId, FieldRoomType roomType, byte roomId, Action<bool> callback) { }

	[IteratorStateMachine(typeof(FieldManager.<loadingField>d__86))]
	// RVA: 0x240BD2C Offset: 0x2407D2C VA: 0x240BD2C
	private IEnumerator loadingField(int fieldId, FieldRoomType roomType, byte roomId, Action<bool> callback) { }

	// RVA: 0x240BDD8 Offset: 0x2407DD8 VA: 0x240BDD8
	public void InitializeFieldData(FieldData field) { }

	// RVA: 0x240BE1C Offset: 0x2407E1C VA: 0x240BE1C
	public void SetLoginWorldId(int worldId) { }

	// RVA: 0x240BE38 Offset: 0x2407E38 VA: 0x240BE38
	public void ExportFieldChangeLog(int fieldId, int channel) { }

	[IteratorStateMachine(typeof(FieldManager.<checkScene>d__90))]
	// RVA: 0x240BFAC Offset: 0x2407FAC VA: 0x240BFAC
	private IEnumerator checkScene() { }

	[IteratorStateMachine(typeof(FieldManager.<LoadFieldResource>d__91))]
	// RVA: 0x240C020 Offset: 0x2408020 VA: 0x240C020
	private IEnumerator LoadFieldResource(int fieldId, byte roomId, FieldRoomType roomType) { }

	[IteratorStateMachine(typeof(FieldManager.<LoadFieldResource>d__92))]
	// RVA: 0x240C0DC Offset: 0x24080DC VA: 0x240C0DC
	private IEnumerator LoadFieldResource(string assetPath, string assetName, int deep) { }

	[IteratorStateMachine(typeof(FieldManager.<LoadFieldLevelResource>d__93))]
	// RVA: 0x240C1B0 Offset: 0x24081B0 VA: 0x240C1B0
	private IEnumerator LoadFieldLevelResource(int fieldId, byte roomId, FieldRoomType roomType) { }

	[IteratorStateMachine(typeof(FieldManager.<LoadMapInfo>d__94))]
	// RVA: 0x240C26C Offset: 0x240826C VA: 0x240C26C
	private IEnumerator LoadMapInfo(int fieldId, byte roomId, FieldRoomType roomType) { }

	[IteratorStateMachine(typeof(FieldManager.<LoadScriptLocalize>d__95))]
	// RVA: 0x240C328 Offset: 0x2408328 VA: 0x240C328
	private IEnumerator LoadScriptLocalize(int fieldId, FieldRoomType roomType) { }

	[IteratorStateMachine(typeof(FieldManager.<LoadFieldEventResource>d__96))]
	// RVA: 0x240C3B0 Offset: 0x24083B0 VA: 0x240C3B0
	private IEnumerator LoadFieldEventResource(int fieldId, FieldRoomType roomType, byte roomId) { }

	[IteratorStateMachine(typeof(FieldManager.<LoadScriptModel>d__97))]
	// RVA: 0x240C468 Offset: 0x2408468 VA: 0x240C468
	private IEnumerator LoadScriptModel(int fieldId, FieldRoomType roomType, byte roomId) { }

	[IteratorStateMachine(typeof(FieldManager.<LoadModelDate>d__98))]
	// RVA: 0x240C500 Offset: 0x2408500 VA: 0x240C500
	private IEnumerator LoadModelDate(string assetPath, string cachePath) { }

	// RVA: 0x240C5A4 Offset: 0x24085A4 VA: 0x240C5A4
	public void ReEntryField() { }

	// RVA: 0x240C73C Offset: 0x240873C VA: 0x240C73C
	public void OnEnterBossField(EnterBossField data) { }

	// RVA: 0x240C740 Offset: 0x2408740 VA: 0x240C740
	private void OnExitBossField() { }

	// RVA: 0x240C744 Offset: 0x2408744 VA: 0x240C744
	public void CreateDungeonField(int randamSeed, int areaLevel, byte areaDay, DungeonFloorEventType type, byte[] roomMapChip, Dictionary<byte, byte> trapList, byte[] itemBoxList, MobResponseData[] mobList, bool firstLogIn) { }

	// RVA: 0x240D478 Offset: 0x2409478 VA: 0x240D478
	public void EnterDungeonTreasureRoom() { }

	// RVA: 0x240D728 Offset: 0x2409728 VA: 0x240D728
	public void CreateDefenceField() { }

	// RVA: 0x240D854 Offset: 0x2409854 VA: 0x240D854
	public void .ctor() { }
}
