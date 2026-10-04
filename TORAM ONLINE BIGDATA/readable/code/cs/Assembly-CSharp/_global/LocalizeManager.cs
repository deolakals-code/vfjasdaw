// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LocalizeManager : Singleton<LocalizeManager> // TypeDefIndex: 5252
{
	// Fields
	private Dictionary<LocalizeManager.LocalizeType, TextManagerBase> LocalizeData; // 0x20
	public NgWordReplace NgWordReplace; // 0x28
	private NgWordReplace ngNameReplace; // 0x30
	[CompilerGenerated]
	private NgWordReplace <NGMailReplace>k__BackingField; // 0x38
	[SerializeField]
	private UIFont mainFont; // 0x40
	[SerializeField]
	private NguiDynamicFont dynamicFont; // 0x48
	private UIFontData changeFontData; // 0x50
	private int[] ngIndex; // 0x58
	private int[] currentIndex; // 0x60
	private FieldTextManager fieldTextManager; // 0x68
	private SystemTextManager systemTextManager; // 0x70

	// Properties
	public NgWordReplace NGMailReplace { get; set; }
	private SystemLanguage systemLanguage { get; }

	// Methods

	// RVA: 0x26147BC Offset: 0x26107BC VA: 0x26147BC
	public static byte GetRegionCode() { }

	// RVA: 0x261484C Offset: 0x261084C VA: 0x261484C
	public static string GetUserRegionText(int regionCode) { }

	[CompilerGenerated]
	// RVA: 0x2614A88 Offset: 0x2610A88 VA: 0x2614A88
	private void set_NGMailReplace(NgWordReplace value) { }

	[CompilerGenerated]
	// RVA: 0x2614A90 Offset: 0x2610A90 VA: 0x2614A90
	public NgWordReplace get_NGMailReplace() { }

	// RVA: 0x2614A98 Offset: 0x2610A98 VA: 0x2614A98
	private SystemLanguage get_systemLanguage() { }

	// RVA: 0x26042D8 Offset: 0x26002D8 VA: 0x26042D8
	public TextManagerBase Get(LocalizeManager.LocalizeType type) { }

	// RVA: 0x26043A0 Offset: 0x26003A0 VA: 0x26043A0
	public void Initialize(byte[] binary, LocalizeManager.LocalizeType type) { }

	// RVA: 0x2614DEC Offset: 0x2610DEC VA: 0x2614DEC
	public bool IsLoadErr() { }

	// RVA: 0x2614F5C Offset: 0x2610F5C VA: 0x2614F5C
	public void SetLoadingFlag(LocalizeManager.LocalizeType[] types) { }

	// RVA: 0x2614FD4 Offset: 0x2610FD4 VA: 0x2614FD4
	public bool IsLoading() { }

	// RVA: 0x2615144 Offset: 0x2611144 VA: 0x2615144
	public TextManagerBase GetWithInitialize(byte[] binary, LocalizeManager.LocalizeType type) { }

	// RVA: 0x2614AE8 Offset: 0x2610AE8 VA: 0x2614AE8
	private TextManagerBase Factory(LocalizeManager.LocalizeType type) { }

	// RVA: 0x261520C Offset: 0x261120C VA: 0x261520C
	public void AllClear() { }

	// RVA: 0x260476C Offset: 0x260076C VA: 0x260476C
	public string GetLocalizeCode() { }

	// RVA: 0x2615398 Offset: 0x2611398 VA: 0x2615398
	public int getLocalizeId() { }

	// RVA: 0x2615418 Offset: 0x2611418 VA: 0x2615418
	public bool EnglishWordCheck() { }

	// RVA: 0x2615464 Offset: 0x2611464 VA: 0x2615464
	public string GetLoadingPlayId() { }

	// RVA: 0x26154CC Offset: 0x26114CC VA: 0x26154CC
	public void LoadIsNgNameData() { }

	[IteratorStateMachine(typeof(LocalizeManager.<LoadIsNgNameDataCoroutine>d__34))]
	// RVA: 0x2615568 Offset: 0x2611568 VA: 0x2615568
	public IEnumerator LoadIsNgNameDataCoroutine() { }

	[IteratorStateMachine(typeof(LocalizeManager.<loadNGName>d__35))]
	// RVA: 0x26154FC Offset: 0x26114FC VA: 0x26154FC
	private IEnumerator loadNGName() { }

	// RVA: 0x2615624 Offset: 0x2611624 VA: 0x2615624
	public bool CheckNGName(string name) { }

	// RVA: 0x2615640 Offset: 0x2611640 VA: 0x2615640
	public void LoadNGMail() { }

	// RVA: 0x2615860 Offset: 0x2611860 VA: 0x2615860
	public bool CheckNGMail(string name) { }

	// RVA: 0x2615940 Offset: 0x2611940 VA: 0x2615940
	public void LoadBuildInFont() { }

	// RVA: 0x26159DC Offset: 0x26119DC VA: 0x26159DC
	public void LoadFontData(UIFontData fontData, bool update) { }

	// RVA: 0x2615B18 Offset: 0x2611B18 VA: 0x2615B18
	public void LoadFontAtlas(byte[] binary, Texture texture, bool update) { }

	// RVA: 0x2616184 Offset: 0x2612184 VA: 0x2616184
	private void OnLevelWasLoaded() { }

	// RVA: 0x2615A14 Offset: 0x2611A14 VA: 0x2615A14
	private void UpdateMainFont() { }

	// RVA: 0x2616188 Offset: 0x2612188 VA: 0x2616188
	public void LoadQuestLocalizeData(Dictionary<int, List<int>> questId) { }

	[IteratorStateMachine(typeof(LocalizeManager.<loadQuestLocalizeData>d__45))]
	// RVA: 0x26161A8 Offset: 0x26121A8 VA: 0x26161A8
	private IEnumerator loadQuestLocalizeData(Dictionary<int, List<int>> questId) { }

	// RVA: 0x2616258 Offset: 0x2612258 VA: 0x2616258
	public void LoadMissionLocalizeData(Dictionary<int, List<int>> questId) { }

	[IteratorStateMachine(typeof(LocalizeManager.<LoadMissionLocalizeDataCoroutine>d__47))]
	// RVA: 0x2616300 Offset: 0x2612300 VA: 0x2616300
	public IEnumerator LoadMissionLocalizeDataCoroutine(Dictionary<int, List<int>> questId) { }

	[IteratorStateMachine(typeof(LocalizeManager.<loadMissionLocalizeData>d__48))]
	// RVA: 0x2616278 Offset: 0x2612278 VA: 0x2616278
	private IEnumerator loadMissionLocalizeData(Dictionary<int, List<int>> questId) { }

	// RVA: 0x26163D8 Offset: 0x26123D8 VA: 0x26163D8
	public void CheckNGWord(string mes, Action<string> callback) { }

	// RVA: 0x26163E4 Offset: 0x26123E4 VA: 0x26163E4
	public void CheckNGWord(string mes, LocalizeManager.NGThread thread, Action<string> callback) { }

	[IteratorStateMachine(typeof(LocalizeManager.<CheckNGWordThread>d__51))]
	// RVA: 0x2616470 Offset: 0x2612470 VA: 0x2616470
	private IEnumerator CheckNGWordThread(int index, byte type, string mes, Action<string> callback) { }

	// RVA: 0x261654C Offset: 0x261254C VA: 0x261654C
	public bool ContainsNGBanWord_Send(string inputText) { }

	// RVA: 0x26168C0 Offset: 0x26128C0 VA: 0x26168C0
	public string GetFieldName(FieldRoomType type, int fieldId) { }

	// RVA: 0x2616B98 Offset: 0x2612B98 VA: 0x2616B98
	public bool IsRFCInvalid(string email) { }

	// RVA: 0x2616E10 Offset: 0x2612E10 VA: 0x2616E10
	public void .ctor() { }
}
