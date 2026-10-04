// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipRecycleStarGemPanel : MonoBehaviour, UIItemScrollPanelManager // TypeDefIndex: 6991
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor buttonAnchor; // 0x20
	[SerializeField]
	private GameObject windowPanel; // 0x28
	[SerializeField]
	private GameObject checkPanel; // 0x30
	[SerializeField]
	private GameObject delayPanel; // 0x38
	[SerializeField]
	private GameObject resultPanel; // 0x40
	[SerializeField]
	private GameObject errorPanel; // 0x48
	[SerializeField]
	private UILabel selectNumLabel; // 0x50
	[SerializeField]
	private TweenScale selectMaxIconScale; // 0x58
	[SerializeField]
	private UISprite selectChangeIcon; // 0x60
	[SerializeField]
	private UILabel converButtonLabel; // 0x68
	[SerializeField]
	private UILabel windowCheckMesLabel; // 0x70
	[SerializeField]
	private UILabel getNumLabel; // 0x78
	[SerializeField]
	private GameObject getGoldObj; // 0x80
	[SerializeField]
	private UILabel getGoldNumLabel; // 0x88
	[SerializeField]
	private UILabel buttonLabel; // 0x90
	[SerializeField]
	private UIImageButton windowButton; // 0x98
	[SerializeField]
	private UISlider loadSlider; // 0xA0
	[SerializeField]
	private GameObject scrollElement; // 0xA8
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0xB0
	[SerializeField]
	private UILabel resultMesLabel; // 0xB8
	[SerializeField]
	private UILabel[] resultNumLabels; // 0xC0
	[SerializeField]
	private GameObject[] resultNumObjs; // 0xC8
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0xD0
	[CompilerGenerated]
	private bool <IsOpenWindow>k__BackingField; // 0xD1
	private GameObject itemListObject; // 0xD8
	private SystemTextManager systemTextManager; // 0xE0
	private ItemTextManager itemTextManager; // 0xE8
	private ItemPropertyTextManager itemPropertyTextManager; // 0xF0
	private UIItemScrollListManager itemListManager; // 0xF8
	private PlayerDataManager playerDataManager; // 0x100
	private OrbEquipItemManager orbEquipItemManager; // 0x108
	private List<ItemData> itemList; // 0x110
	private List<ItemData> selectedItemList; // 0x118
	private List<IUIItemScrollPanelButton> selectedItemButtonList; // 0x120
	private ItemDBData.ItemType selectedItemType; // 0x128
	private ItemData firstItemData; // 0x130
	private int nowBag; // 0x138
	private int bagCount; // 0x13C
	private bool isMultSelect; // 0x140
	private string iconName; // 0x148
	private Coroutine iconCoroutine; // 0x150
	private const int bagSpace = 20;
	private int selectMax; // 0x158
	private Action<int> endAction; // 0x160
	private UILabel windowButtonLabel; // 0x168
	private UISprite windowButtonBase; // 0x170
	private BoxCollider windowButtonCol; // 0x178
	private readonly Dictionary<ItemDBData.ItemType, int> starGemCountList; // 0x180
	private GameObject[] panelObjs; // 0x188

	// Properties
	public bool IsOpen { get; set; }
	public bool IsOpenWindow { get; set; }
	public bool IsOpenResult { get; }
	public static int SelectAvatarMax { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A67FA0 Offset: 0x1A63FA0 VA: 0x1A67FA0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1A67FA8 Offset: 0x1A63FA8 VA: 0x1A67FA8
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1A67FB4 Offset: 0x1A63FB4 VA: 0x1A67FB4
	public bool get_IsOpenWindow() { }

	[CompilerGenerated]
	// RVA: 0x1A67FBC Offset: 0x1A63FBC VA: 0x1A67FBC
	private void set_IsOpenWindow(bool value) { }

	// RVA: 0x1A67FC8 Offset: 0x1A63FC8 VA: 0x1A67FC8
	public bool get_IsOpenResult() { }

	// RVA: 0x1A67FE4 Offset: 0x1A63FE4 VA: 0x1A67FE4
	private void Awake() { }

	// RVA: 0x1A682C0 Offset: 0x1A642C0 VA: 0x1A682C0
	private void Update() { }

	// RVA: 0x1A682EC Offset: 0x1A642EC VA: 0x1A682EC
	public static int GetStarGemCount(ItemDBData.ItemType type) { }

	// RVA: 0x1A68310 Offset: 0x1A64310 VA: 0x1A68310
	public static int get_SelectAvatarMax() { }

	// RVA: 0x1A68318 Offset: 0x1A64318 VA: 0x1A68318
	public void Open(ItemDBData.ItemType itemType, ItemData itemData, int selectMax, Action<int> endAction) { }

	// RVA: 0x1A69720 Offset: 0x1A65720 VA: 0x1A69720
	public void Close() { }

	// RVA: 0x1A698AC Offset: 0x1A658AC VA: 0x1A698AC
	public void WindowClose() { }

	// RVA: 0x1A692A8 Offset: 0x1A652A8 VA: 0x1A692A8
	private void UpdateItemList() { }

	// RVA: 0x1A695AC Offset: 0x1A655AC VA: 0x1A695AC
	private void UpdateSelectNumLabel() { }

	// RVA: 0x1A691D4 Offset: 0x1A651D4 VA: 0x1A691D4
	private void UpdateChangeSelectObj() { }

	[IteratorStateMachine(typeof(UIEquipRecycleStarGemPanel.<TweenScaleIcon>d__70))]
	// RVA: 0x1A69988 Offset: 0x1A65988 VA: 0x1A69988
	private IEnumerator TweenScaleIcon() { }

	// RVA: 0x1A69A1C Offset: 0x1A65A1C VA: 0x1A69A1C
	private void CreateConvertList() { }

	[IteratorStateMachine(typeof(UIEquipRecycleStarGemPanel.<ActiveFalse>d__72))]
	// RVA: 0x1A69840 Offset: 0x1A65840 VA: 0x1A69840
	private IEnumerator ActiveFalse() { }

	[IteratorStateMachine(typeof(UIEquipRecycleStarGemPanel.<DelayToResult>d__73))]
	// RVA: 0x1A6A1BC Offset: 0x1A661BC VA: 0x1A6A1BC
	private IEnumerator DelayToResult() { }

	[IteratorStateMachine(typeof(UIEquipRecycleStarGemPanel.<OperationOneRecycle>d__74))]
	// RVA: 0x1A6A250 Offset: 0x1A66250 VA: 0x1A6A250
	private IEnumerator OperationOneRecycle() { }

	[IteratorStateMachine(typeof(UIEquipRecycleStarGemPanel.<OperationMultiRecycle>d__75))]
	// RVA: 0x1A6A2E4 Offset: 0x1A662E4 VA: 0x1A6A2E4
	private IEnumerator OperationMultiRecycle() { }

	// RVA: 0x1A6A378 Offset: 0x1A66378 VA: 0x1A6A378
	private void Result() { }

	// RVA: 0x1A6AA6C Offset: 0x1A66A6C VA: 0x1A6AA6C
	private void ErrowPanel() { }

	// RVA: 0x1A6A808 Offset: 0x1A66808 VA: 0x1A6A808
	private void ChangePanel(int state) { }

	// RVA: 0x1A6A874 Offset: 0x1A66874 VA: 0x1A6A874
	private ValueTuple<int, int> GetResultItemCount() { }

	// RVA: 0x1A6AC5C Offset: 0x1A66C5C VA: 0x1A6AC5C
	private void OnChangeSelect() { }

	// RVA: 0x1A6AD4C Offset: 0x1A66D4C VA: 0x1A6AD4C
	private void OnConvert() { }

	// RVA: 0x1A6B108 Offset: 0x1A67108 VA: 0x1A6B108
	private void OnWindowButton() { }

	// RVA: 0x1A6B2CC Offset: 0x1A672CC VA: 0x1A6B2CC Slot: 4
	public void OnPress(UIItemScrollPanelButton select) { }

	// RVA: 0x1A6B2D0 Offset: 0x1A672D0 VA: 0x1A6B2D0 Slot: 9
	public void OnRightButtonClick() { }

	// RVA: 0x1A6B3B8 Offset: 0x1A673B8 VA: 0x1A6B3B8 Slot: 10
	public void OnLeftButtonClick() { }

	// RVA: 0x1A6B4A4 Offset: 0x1A674A4 VA: 0x1A6B4A4 Slot: 8
	public void OnPanelChangeClick() { }

	// RVA: 0x1A6B4C8 Offset: 0x1A674C8 VA: 0x1A6B4C8 Slot: 5
	public void OnRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1A6BD48 Offset: 0x1A67D48 VA: 0x1A6BD48 Slot: 6
	public void OnDrag(UIItemScrollPanelButton select) { }

	// RVA: 0x1A6B4F0 Offset: 0x1A674F0 VA: 0x1A6B4F0
	private void SelectItemButton(UIItemScrollPanelButton select) { }

	// RVA: 0x1A6BD8C Offset: 0x1A67D8C VA: 0x1A6BD8C Slot: 7
	public void OnDragRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1A6BDAC Offset: 0x1A67DAC VA: 0x1A6BDAC Slot: 11
	public void OnFilterButton() { }

	// RVA: 0x1A6BDB0 Offset: 0x1A67DB0 VA: 0x1A6BDB0 Slot: 12
	public bool CheckIconDrag() { }

	// RVA: 0x1A6BDCC Offset: 0x1A67DCC VA: 0x1A6BDCC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A6C02C Offset: 0x1A6802C VA: 0x1A6C02C
	private void <Open>b__64_0() { }

	[CompilerGenerated]
	// RVA: 0x1A6C0A8 Offset: 0x1A680A8 VA: 0x1A6C0A8
	private void <Open>b__64_1() { }
}
