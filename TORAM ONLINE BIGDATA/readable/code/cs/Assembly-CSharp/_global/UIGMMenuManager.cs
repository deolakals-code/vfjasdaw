// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGMMenuManager : UIBaseMenuPanel // TypeDefIndex: 8150
{
	// Fields
	[SerializeField]
	private UILabel input; // 0x80
	[SerializeField]
	private UILabel input2; // 0x88
	private int inputValue; // 0x90
	private int inputValue2; // 0x94
	private PlayerDataManager pdata; // 0x98
	private Dictionary<int, Action> commandList; // 0xA0
	private Action backCommand; // 0xA8
	private List<UIGMMenuManager.SearchTargetData> searchTargetList; // 0xB0
	private bool isInputClearLock; // 0xB8
	private UIGMMenuManager.SearchTarget searchTarget; // 0xBC
	private int pageNum; // 0xC0
	private int pageMaxNum; // 0xC4
	private int pageContentCount; // 0xC8
	private string inputKeyWord; // 0xD0
	private bool openKeywordSearch; // 0xD8
	private bool openIdSearch; // 0xD9
	private FieldTextManager fieldTextManager; // 0xE0
	private List<int> warpPointIdList; // 0xE8
	private ItemTextManager itemTextManager; // 0xF0
	private SkillTextManager skillTextManager; // 0xF8
	private List<int> skillTreeTypeIds; // 0x100
	private List<SkillMasterData> selectSkillList; // 0x108
	private List<SkillMasterData> allSkillDataList; // 0x110
	private float scrollCamera_Y; // 0x118
	private SkillTreeType selectTreeType; // 0x11C

	// Methods

	// RVA: 0x1CDA3AC Offset: 0x1CD63AC VA: 0x1CDA3AC
	public void .ctor() { }
}
