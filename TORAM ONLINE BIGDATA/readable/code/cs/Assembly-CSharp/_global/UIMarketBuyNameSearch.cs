// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketBuyNameSearch : MonoBehaviour // TypeDefIndex: 8382
{
	// Fields
	[SerializeField]
	private UIImageButton searchButton; // 0x20
	[SerializeField]
	private TweenColor searchTweenColor; // 0x28
	[SerializeField]
	private UIInput inputItemName; // 0x30
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x38
	[SerializeField]
	private UILabel addElement; // 0x40
	[SerializeField]
	private UISprite matchCaseButton; // 0x48
	[SerializeField]
	private UILabel matchCaseLabel; // 0x50
	private ItemTextManager itemTextManager; // 0x58
	private SystemTextManager systemTextManager; // 0x60
	private SkillTextManager skillTextManager; // 0x68
	private EnemyTextManager enemyTextManager; // 0x70
	private Dictionary<int, string> nameList; // 0x78
	private List<ItemType> categoryList; // 0x80
	private Dictionary<int, string> skillNameList; // 0x88
	private Dictionary<int, string> enemyNameList; // 0x90
	private List<UIButtonSendMessage> addedButtons; // 0x98
	[CompilerGenerated]
	private int <SelectedItemId>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <SelectedSkillId>k__BackingField; // 0xA4
	[CompilerGenerated]
	private int <SelectedPetId>k__BackingField; // 0xA8
	private bool ignoreCase; // 0xAC
	private ItemType selectItemType; // 0xAE
	private ItemType prevItemType; // 0xB0
	private Coroutine nameCoroutine; // 0xB8
	private bool isStorageSearch; // 0xC0
	private Dictionary<UIMarketBuyNameSearch.HistoryType, List<UIMarketBuyNameSearch.HistoryData>> searchHistoryList; // 0xC8
	private const string SearchHistoryKey = "MarketNameSearchHistoryKey";
	private const string StorageSearchHistoryKey = "StorageNameSearchHistoryKey";
	private const int MaxHistoryCount = 30;
	private string searchWord; // 0xD0

	// Properties
	public int SelectedItemId { get; set; }
	public int SelectedSkillId { get; set; }
	public int SelectedPetId { get; set; }
	private StringComparison MatchCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D36EB8 Offset: 0x1D32EB8 VA: 0x1D36EB8
	public int get_SelectedItemId() { }

	[CompilerGenerated]
	// RVA: 0x1D36EC0 Offset: 0x1D32EC0 VA: 0x1D36EC0
	private void set_SelectedItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D36EC8 Offset: 0x1D32EC8 VA: 0x1D36EC8
	public int get_SelectedSkillId() { }

	[CompilerGenerated]
	// RVA: 0x1D36ED0 Offset: 0x1D32ED0 VA: 0x1D36ED0
	private void set_SelectedSkillId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D36ED8 Offset: 0x1D32ED8 VA: 0x1D36ED8
	public int get_SelectedPetId() { }

	[CompilerGenerated]
	// RVA: 0x1D36EE0 Offset: 0x1D32EE0 VA: 0x1D36EE0
	private void set_SelectedPetId(int value) { }

	// RVA: 0x1D36EE8 Offset: 0x1D32EE8 VA: 0x1D36EE8
	private StringComparison get_MatchCase() { }

	// RVA: 0x1D33204 Offset: 0x1D2F204 VA: 0x1D33204
	public void SetCategoryItemType(ItemType type) { }

	// RVA: 0x1D36EFC Offset: 0x1D32EFC VA: 0x1D36EFC
	public void SetCategoryList(ItemType[] itemTypes) { }

	// RVA: 0x1D33CBC Offset: 0x1D2FCBC VA: 0x1D33CBC
	public void UpdateHistoryList() { }

	// RVA: 0x1D3772C Offset: 0x1D3372C VA: 0x1D3772C
	private void Awake() { }

	// RVA: 0x1D38940 Offset: 0x1D34940 VA: 0x1D38940
	private void OnDestroy() { }

	// RVA: 0x1D38944 Offset: 0x1D34944 VA: 0x1D38944
	public void OnEnable() { }

	// RVA: 0x1D38E40 Offset: 0x1D34E40 VA: 0x1D38E40
	public void OnDisable() { }

	// RVA: 0x1D38EE0 Offset: 0x1D34EE0 VA: 0x1D38EE0
	public void OnSubmitSearchWord() { }

	[IteratorStateMachine(typeof(UIMarketBuyNameSearch.<updateFindList>d__50))]
	// RVA: 0x1D38F60 Offset: 0x1D34F60 VA: 0x1D38F60
	private IEnumerator updateFindList(string word) { }

	[IteratorStateMachine(typeof(UIMarketBuyNameSearch.<getContainsNames>d__51))]
	// RVA: 0x1D39010 Offset: 0x1D35010 VA: 0x1D39010
	private IEnumerator getContainsNames(string keyword, Action<Dictionary<int, string>> callback) { }

	[IteratorStateMachine(typeof(UIMarketBuyNameSearch.<getContainsSkillNames>d__52))]
	// RVA: 0x1D390D4 Offset: 0x1D350D4 VA: 0x1D390D4
	private IEnumerator getContainsSkillNames(string keyword, Action<Dictionary<int, string>> callback) { }

	[IteratorStateMachine(typeof(UIMarketBuyNameSearch.<getContainsMobNames>d__53))]
	// RVA: 0x1D39198 Offset: 0x1D35198 VA: 0x1D39198
	private IEnumerator getContainsMobNames(string keyword, Action<Dictionary<int, string>> callback) { }

	// RVA: 0x1D3925C Offset: 0x1D3525C VA: 0x1D3925C
	private void onSelectElement(int param) { }

	// RVA: 0x1D38C6C Offset: 0x1D34C6C VA: 0x1D38C6C
	private void setEnableSearchButton(bool isEnable) { }

	// RVA: 0x1D394E8 Offset: 0x1D354E8 VA: 0x1D394E8
	private void onSwitchMatchCase() { }

	// RVA: 0x1D38D2C Offset: 0x1D34D2C VA: 0x1D38D2C
	private void updateToggle() { }

	// RVA: 0x1D38CE4 Offset: 0x1D34CE4 VA: 0x1D38CE4
	private bool CheckAllClearScrollWindow() { }

	[IteratorStateMachine(typeof(UIMarketBuyNameSearch.<EnableHistoryScrollList>d__59))]
	// RVA: 0x1D38DD4 Offset: 0x1D34DD4 VA: 0x1D38DD4
	private IEnumerator EnableHistoryScrollList() { }

	// RVA: 0x1D3868C Offset: 0x1D3468C VA: 0x1D3868C
	private void LoadLocalHistoryList() { }

	// RVA: 0x1D37380 Offset: 0x1D33380 VA: 0x1D37380
	private void SaveHistoryList() { }

	// RVA: 0x1D36F6C Offset: 0x1D32F6C VA: 0x1D36F6C
	private void AddHistoryList(bool isInsert, UIMarketBuyNameSearch.HistoryType type, int itemType, int itemId) { }

	// RVA: 0x1D39588 Offset: 0x1D35588 VA: 0x1D39588
	private string GetSearchHistoryKey() { }

	// RVA: 0x1D39720 Offset: 0x1D35720 VA: 0x1D39720
	public void .ctor() { }
}
