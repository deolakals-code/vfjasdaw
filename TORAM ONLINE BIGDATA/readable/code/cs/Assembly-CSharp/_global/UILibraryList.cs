// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UILibraryList : MonoBehaviour // TypeDefIndex: 8354
{
	// Fields
	[SerializeField]
	private UIScrollWindow scroll; // 0x20
	[SerializeField]
	private GameObject element; // 0x28
	[SerializeField]
	private float elementHeight; // 0x30
	[SerializeField]
	private GameObject scrollBarObject; // 0x38
	[SerializeField]
	private GameObject addObject; // 0x40
	[SerializeField]
	private UILabel addObjectCostLabel; // 0x48
	[SerializeField]
	private UILabel addObjectHaveLabel; // 0x50
	[SerializeField]
	private UISprite addObjectIcon; // 0x58
	[SerializeField]
	private GameObject allLearnLabelObj; // 0x60
	private UIPopWindow popWindow; // 0x68
	private GameObject popWindowObject; // 0x70
	private int shopId; // 0x78
	private UIBasePanelControl topControl; // 0x80
	private Dictionary<UILibrary.LibrarySkillTreeType, List<SkillMasterData>> treeList; // 0x88
	private Dictionary<SkillTreeType, List<int>> treeLevel; // 0x90
	private SystemTextManager systemTextManager; // 0x98
	private PlayerDataManager playerDataManager; // 0xA0
	private int nextSkillLevel; // 0xA8
	private int learnSkillType; // 0xAC
	private GameObject addedObject; // 0xB0
	private int learnSpina; // 0xB8
	private static readonly int[] TreeLevelUpCosts; // 0x0
	private SkillTreeType[] invisibleTreeTypes; // 0xC0

	// Methods

	// RVA: 0x1D2B830 Offset: 0x1D27830 VA: 0x1D2B830
	private void Awake() { }

	// RVA: 0x1D2B938 Offset: 0x1D27938 VA: 0x1D2B938
	private void Start() { }

	// RVA: 0x1D2A984 Offset: 0x1D26984 VA: 0x1D2A984
	public void Initalize(int shopId, UILibrary.LibrarySkillTreeType treeType, UIBasePanelControl control) { }

	// RVA: 0x1D2C4E8 Offset: 0x1D284E8 VA: 0x1D2C4E8
	private void initializeList(List<SkillMasterData> list) { }

	// RVA: 0x1D2B95C Offset: 0x1D2795C VA: 0x1D2B95C
	private void initializeTreeType() { }

	// RVA: 0x1D2BDD8 Offset: 0x1D27DD8 VA: 0x1D2BDD8
	private void initializeTreeLevel() { }

	// RVA: 0x1D2CCAC Offset: 0x1D28CAC VA: 0x1D2CCAC
	public void OnLearnSkillTree(int type, int nextLv, int skillId, int skillTreeId) { }

	// RVA: 0x1D2D56C Offset: 0x1D2956C VA: 0x1D2D56C
	private int getNextReleaseSkillCount(int type, int nextLv) { }

	// RVA: 0x1D2D7C8 Offset: 0x1D297C8 VA: 0x1D2D7C8
	private void onLearnOK() { }

	[IteratorStateMachine(typeof(UILibraryList.<waitConnect>d__32))]
	// RVA: 0x1D2D8F4 Offset: 0x1D298F4 VA: 0x1D2D8F4
	private IEnumerator waitConnect(Action reconnectAction) { }

	// RVA: 0x1D2D9A4 Offset: 0x1D299A4 VA: 0x1D2D9A4
	public void onOpened() { }

	// RVA: 0x1D2D9C4 Offset: 0x1D299C4 VA: 0x1D2D9C4
	private void closePopup() { }

	// RVA: 0x1D2D9FC Offset: 0x1D299FC VA: 0x1D2D9FC
	private void finishLearn() { }

	// RVA: 0x1D2DA14 Offset: 0x1D29A14 VA: 0x1D2DA14
	public void CloseList() { }

	// RVA: 0x1D2D6E0 Offset: 0x1D296E0 VA: 0x1D2D6E0
	private int GetTreeLevelUpCosts(int nextLv) { }

	// RVA: 0x1D2DA64 Offset: 0x1D29A64 VA: 0x1D2DA64
	public void .ctor() { }

	// RVA: 0x1D2DBAC Offset: 0x1D29BAC VA: 0x1D2DBAC
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1D2DC4C Offset: 0x1D29C4C VA: 0x1D2DC4C
	private void <onLearnOK>b__31_0() { }
}
