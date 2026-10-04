// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildCustomManager : UIBasePanelConnection // TypeDefIndex: 6627
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private UIIruna2Anchor listAncthor; // 0x38
	[SerializeField]
	private UIIruna2Anchor recipeAncthor; // 0x40
	[SerializeField]
	private UILabel selectItemLabel; // 0x48
	[SerializeField]
	private GameObject selectedItemLabel; // 0x50
	[SerializeField]
	private UILabel selectItemRecipeText; // 0x58
	[SerializeField]
	private GameObject selectItemRecipeBaseObject; // 0x60
	[SerializeField]
	private UIIcon selectItemRecipeIcon; // 0x68
	[SerializeField]
	private UILabel selectItemRecipeItemLabel; // 0x70
	[SerializeField]
	private UILabel selectItemRecipeNumLabel; // 0x78
	[SerializeField]
	private GameObject selectItemRecipeOpenIcon; // 0x80
	[SerializeField]
	private UIImageButton selectEnterButtonImage; // 0x88
	[SerializeField]
	private UILabel selectEnterButtonLabel; // 0x90
	[SerializeField]
	private GameObject[] labelObject; // 0x98
	[SerializeField]
	private GameObject homeSelectButton; // 0xA0
	[SerializeField]
	private GameObject changePopPanel; // 0xA8
	[SerializeField]
	private UILabel changeFieldLabel; // 0xB0
	[SerializeField]
	private GameObject changePopMessage; // 0xB8
	[SerializeField]
	private UILabel titleLabel; // 0xC0
	[SerializeField]
	private UIImageButton previewButton; // 0xC8
	[SerializeField]
	private UIButtonStateSwitcher selectButtonSwitcher; // 0xD0
	[SerializeField]
	private UILabel changeRecipeLabel; // 0xD8
	[SerializeField]
	private UILabel centerChangeLabel; // 0xE0
	private UIGuildCustomManager.PanelType activePanelType; // 0xE8
	private PlayerDataManager playerDataManager; // 0xF0
	private List<GuildHomeRecipeData> recipeData; // 0xF8
	private GuildManager guildManager; // 0x100
	private int selectHomeId; // 0x108
	private bool isClose; // 0x10C
	private bool cancelCheck; // 0x10D
	private List<GameObject> recipeObjectList; // 0x110
	private bool isInit; // 0x118
	private const string UserLockButtonKey = "GuildHomeChangedUserLockButtonLabel";
	private GuildCustomUIData customUIData; // 0x120
	private IUIGuildCustomController controller; // 0x128

	// Methods

	// RVA: 0x199E424 Offset: 0x199A424 VA: 0x199E424
	public void Setup(IUIGuildCustomController controller) { }

	[IteratorStateMachine(typeof(UIGuildCustomManager.<Start>d__37))]
	// RVA: 0x199E434 Offset: 0x199A434 VA: 0x199E434
	private IEnumerator Start() { }

	// RVA: 0x199E4C8 Offset: 0x199A4C8 VA: 0x199E4C8
	private void OnDestroy() { }

	// RVA: 0x199E56C Offset: 0x199A56C VA: 0x199E56C
	private void AddRecipeItem(Vector3 pos, string icon, string label, bool isLock, string currentText, string useText) { }

	// RVA: 0x199E880 Offset: 0x199A880 VA: 0x199E880
	private void selectedGuildHomeTypeData() { }

	// RVA: 0x199F5F8 Offset: 0x199B5F8 VA: 0x199F5F8
	private void UpdateGuildHomeTypeList() { }

	// RVA: 0x199FDE4 Offset: 0x199BDE4 VA: 0x199FDE4
	public void OnClickEnterGuildHome() { }

	[IteratorStateMachine(typeof(UIGuildCustomManager.<PopUpWaitWindow>d__43))]
	// RVA: 0x199FE74 Offset: 0x199BE74 VA: 0x199FE74
	private IEnumerator PopUpWaitWindow() { }

	[IteratorStateMachine(typeof(UIGuildCustomManager.<PopUpWindow>d__44))]
	// RVA: 0x199FF08 Offset: 0x199BF08 VA: 0x199FF08
	private IEnumerator PopUpWindow(UIPopBaseWindow popUpWindow, Action callBack) { }

	// RVA: 0x199FC64 Offset: 0x199BC64 VA: 0x199FC64
	private GameObject AddScrollButton(GameObject baseButtun, Vector3 pos, string text, string iconSprite) { }

	// RVA: 0x199F528 Offset: 0x199B528 VA: 0x199F528
	private void setGuildHomeEnterButton(bool isEnabled, string text, int activeId, bool isSelected) { }

	// RVA: 0x199FFCC Offset: 0x199BFCC VA: 0x199FFCC
	private void ChangePanel(int panelId) { }

	// RVA: 0x19A0110 Offset: 0x199C110 VA: 0x19A0110
	public void OnClickSelectGuildHomeType(int id) { }

	// RVA: 0x19A01A4 Offset: 0x199C1A4 VA: 0x19A01A4
	public void OnPreview() { }

	// RVA: 0x19A030C Offset: 0x199C30C VA: 0x19A030C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19A03CC Offset: 0x199C3CC VA: 0x19A03CC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19A0458 Offset: 0x199C458 VA: 0x19A0458
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19A056C Offset: 0x199C56C VA: 0x19A056C
	private bool <selectedGuildHomeTypeData>b__40_0(GuildHomeRecipeData x) { }

	[CompilerGenerated]
	// RVA: 0x19A0590 Offset: 0x199C590 VA: 0x19A0590
	private void <OnPreview>b__49_0() { }
}
