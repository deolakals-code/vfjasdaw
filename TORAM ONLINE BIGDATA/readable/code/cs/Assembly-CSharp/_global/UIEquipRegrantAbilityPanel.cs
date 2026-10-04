// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipRegrantAbilityPanel : MonoBehaviour // TypeDefIndex: 7004
{
	// Fields
	[SerializeField]
	private GameObject basePanel; // 0x20
	[SerializeField]
	private UIEquipAbilityElement elementObj; // 0x28
	[SerializeField]
	private UILabel titleLabel; // 0x30
	[SerializeField]
	private UISprite[] titleIcons; // 0x38
	[SerializeField]
	private GameObject changeListButton; // 0x40
	[SerializeField]
	private GameObject listPanel; // 0x48
	[SerializeField]
	private UIScrollWindow listScrollWindow; // 0x50
	[SerializeField]
	private GameObject readyPanel; // 0x58
	[SerializeField]
	private GameObject selectItemObj; // 0x60
	[SerializeField]
	private GameObject selectItemPropObj; // 0x68
	[SerializeField]
	private UIIcon selectItemIcon; // 0x70
	[SerializeField]
	private UILabel selectItemLabel; // 0x78
	[SerializeField]
	private GameObject selectAbilityObj; // 0x80
	[SerializeField]
	private UIIcon selectAbilityIcon; // 0x88
	[SerializeField]
	private GameObject selectAbilityBatsuIcon; // 0x90
	[SerializeField]
	private UILabel selectAbilityEquipLabel; // 0x98
	[SerializeField]
	private UILabel[] selectAbilityLabels; // 0xA0
	[SerializeField]
	private GameObject[] selectAbilityMaxIcons; // 0xA8
	[SerializeField]
	private GameObject newSelectAbilityObj; // 0xB0
	[SerializeField]
	private UILabel[] selectBeforeAbilityLabels; // 0xB8
	[SerializeField]
	private GameObject[] selectBeforeAbilityMaxIcons; // 0xC0
	[SerializeField]
	private UILabel[] selectAfterAbilityLabels; // 0xC8
	[SerializeField]
	private GameObject[] selectAfterAbilityMaxIcons; // 0xD0
	[SerializeField]
	private UILabel[] expLabels; // 0xD8
	[SerializeField]
	private GameObject lineObj; // 0xE0
	[SerializeField]
	private UILabel startButtonLabel; // 0xE8
	[SerializeField]
	private GameObject startButtonIcon; // 0xF0
	[SerializeField]
	private GameObject newLabelObj; // 0xF8
	[SerializeField]
	private GameObject loadPanel; // 0x100
	[SerializeField]
	private UISlider loadSlider; // 0x108
	[SerializeField]
	private UILabel loadExpLabel; // 0x110
	[SerializeField]
	private UILabel[] loadAbilityLabels; // 0x118
	[SerializeField]
	private GameObject[] loadAbilityMaxIcons; // 0x120
	[SerializeField]
	private GameObject buySlotPanel; // 0x128
	[SerializeField]
	private GameObject[] buySlotInnerPanels; // 0x130
	[SerializeField]
	private UILabel[] buySlotCheckLabels; // 0x138
	[SerializeField]
	private UIImageButton buySlotCheckButton; // 0x140
	[SerializeField]
	private UILabel[] buySlotLoadLabels; // 0x148
	[SerializeField]
	private UISlider buySlotLoadSlider; // 0x150
	[SerializeField]
	private UIIcon[] buySlotEquipTypeIcons; // 0x158
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x160
	private const int DefaultSlotCount = 10;
	private const float PanelTweenDuration = 0.2;
	private const float LoadBarDuration = 10;
	private UIEquipRegrantAbilityPanel.PanelState panelState; // 0x164
	private int selectedParam; // 0x168
	private ItemData selectItemData; // 0x170
	private Coroutine loadCoroutine; // 0x178
	private ItemTextManager itemTextManager; // 0x180
	private SystemTextManager systemTextManager; // 0x188
	private ItemPropertyTextManager itemPropertyTextManager; // 0x190
	private Action closeAction; // 0x198
	private OrbEnchantData selectedEnchantData; // 0x1A0
	private int selectedIndex; // 0x1A8
	private OrbManager orbManager; // 0x1B0
	private OrbEquipItemManager orbEquipItemManager; // 0x1B8
	private bool isOld; // 0x1C0
	private EquipType selectedEquipType; // 0x1C4
	private bool opIsFailure; // 0x1C8
	private short opReturnCode; // 0x1CA

	// Properties
	public bool IsOpen { get; set; }
	private bool isReEnchant { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A6CEA8 Offset: 0x1A68EA8 VA: 0x1A6CEA8
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1A6CEB0 Offset: 0x1A68EB0 VA: 0x1A6CEB0
	private void set_IsOpen(bool value) { }

	// RVA: 0x1A6CEBC Offset: 0x1A68EBC VA: 0x1A6CEBC
	private bool get_isReEnchant() { }

	// RVA: 0x1A6CECC Offset: 0x1A68ECC VA: 0x1A6CECC
	private void Start() { }

	// RVA: 0x1A6D164 Offset: 0x1A69164 VA: 0x1A6D164
	public void OpenWindow(int selectedParam, ItemData selectItemData, Action closeAction) { }

	// RVA: 0x1A6D418 Offset: 0x1A69418 VA: 0x1A6D418
	public void BackAction() { }

	// RVA: 0x1A6D6AC Offset: 0x1A696AC VA: 0x1A6D6AC
	public void OnChangeList() { }

	// RVA: 0x1A6DB38 Offset: 0x1A69B38 VA: 0x1A6DB38
	public void OnBuySlotGreenButton() { }

	// RVA: 0x1A6D4E8 Offset: 0x1A694E8 VA: 0x1A6D4E8
	public void OnBuySlotCancel() { }

	// RVA: 0x1A6D688 Offset: 0x1A69688 VA: 0x1A6D688
	private void CloseWindow() { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<CloseWaitWindow>d__73))]
	// RVA: 0x1A6DCF8 Offset: 0x1A69CF8 VA: 0x1A6DCF8
	private IEnumerator CloseWaitWindow() { }

	// RVA: 0x1A6D4AC Offset: 0x1A694AC VA: 0x1A6D4AC
	private void ChangePanel(UIEquipRegrantAbilityPanel.PanelState state) { }

	// RVA: 0x1A6DD8C Offset: 0x1A69D8C VA: 0x1A6DD8C
	private void SetupListPanel() { }

	// RVA: 0x1A6E018 Offset: 0x1A6A018 VA: 0x1A6E018
	private void SetupReadyPanel() { }

	// RVA: 0x1A6E780 Offset: 0x1A6A780 VA: 0x1A6E780
	private void SetupLoadPanel() { }

	// RVA: 0x1A6EB8C Offset: 0x1A6AB8C VA: 0x1A6EB8C
	private void SetupBuySlotPanel() { }

	// RVA: 0x1A6F3C8 Offset: 0x1A6B3C8 VA: 0x1A6F3C8
	private void UpdataReadyPanelData() { }

	// RVA: 0x1A6F7A8 Offset: 0x1A6B7A8 VA: 0x1A6F7A8
	private void UpdateReadyPanelOld() { }

	// RVA: 0x1A6F91C Offset: 0x1A6B91C VA: 0x1A6F91C
	private void UpdateReadyPanelNew(short[] beforeCapIds, short[] beforeCapVals, bool isBeforeEnchant, short[] afterCapIds, short[] afterCapVals, bool isAfterEnchant) { }

	// RVA: 0x1A6F2FC Offset: 0x1A6B2FC VA: 0x1A6F2FC
	private bool IsHaveAbility() { }

	// RVA: 0x1A6F360 Offset: 0x1A6B360 VA: 0x1A6F360
	private bool IsAbilitySaved() { }

	// RVA: 0x1A6F248 Offset: 0x1A6B248 VA: 0x1A6F248
	private string GetOrbItemName() { }

	// RVA: 0x1A6F174 Offset: 0x1A6B174 VA: 0x1A6F174
	public static string GetEquipTypeText(EquipType type, SystemTextManager systemTextManager) { }

	// RVA: 0x1A6FAFC Offset: 0x1A6BAFC VA: 0x1A6FAFC
	public static string GetAbilityText(short capId, short capVal, bool isRed, bool isEnchant, ItemPropertyTextManager propMgr, SystemTextManager sysMgr, out bool isMax) { }

	// RVA: 0x1A6F718 Offset: 0x1A6B718 VA: 0x1A6F718
	private string GetAbilityText(short capId, short capVal, bool isRed, bool isItem, out bool isMax) { }

	// RVA: 0x1A6D2DC Offset: 0x1A692DC VA: 0x1A6D2DC
	private void ListPanelProcess() { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<GetList>d__89))]
	// RVA: 0x1A6FD10 Offset: 0x1A6BD10 VA: 0x1A6FD10
	private IEnumerator GetList() { }

	// RVA: 0x1A6D6E0 Offset: 0x1A696E0 VA: 0x1A6D6E0
	private void InitScrollWindow() { }

	// RVA: 0x1A6FDAC Offset: 0x1A6BDAC VA: 0x1A6FDAC
	private void ToReady(int index, OrbEnchantData enchantData) { }

	// RVA: 0x1A6FDDC Offset: 0x1A6BDDC VA: 0x1A6FDDC
	private void onToLoad() { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<LoadPanelProccess>d__93))]
	// RVA: 0x1A6F73C Offset: 0x1A6B73C VA: 0x1A6F73C
	private IEnumerator LoadPanelProccess() { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<LoadBar>d__94))]
	// RVA: 0x1A6FE10 Offset: 0x1A6BE10 VA: 0x1A6FE10
	private IEnumerator LoadBar(UISlider slider) { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<Operation>d__95))]
	// RVA: 0x1A6FEA4 Offset: 0x1A6BEA4 VA: 0x1A6FEA4
	private IEnumerator Operation() { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<OperationReEnchant>d__96))]
	// RVA: 0x1A6FF38 Offset: 0x1A6BF38 VA: 0x1A6FF38
	private IEnumerator OperationReEnchant() { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<OperationExtract>d__97))]
	// RVA: 0x1A6FFCC Offset: 0x1A6BFCC VA: 0x1A6FFCC
	private IEnumerator OperationExtract() { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<WaitOperation>d__98))]
	// RVA: 0x1A70060 Offset: 0x1A6C060 VA: 0x1A70060
	private IEnumerator WaitOperation(OperationCode op, byte subCode) { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<WaitConnectFlag>d__99))]
	// RVA: 0x1A700F8 Offset: 0x1A6C0F8 VA: 0x1A700F8
	private IEnumerator WaitConnectFlag(OrbManager.ConnectFlag flag) { }

	// RVA: 0x1A6D63C Offset: 0x1A6963C VA: 0x1A6D63C
	private void onCancel() { }

	// RVA: 0x1A6D2BC Offset: 0x1A692BC VA: 0x1A6D2BC
	private EquipType GetEquipType(int type) { }

	// RVA: 0x1A7019C Offset: 0x1A6C19C VA: 0x1A7019C
	private void OnBuySlot() { }

	[IteratorStateMachine(typeof(UIEquipRegrantAbilityPanel.<BuySlotLoadPanelProccess>d__103))]
	// RVA: 0x1A6DC8C Offset: 0x1A69C8C VA: 0x1A6DC8C
	private IEnumerator BuySlotLoadPanelProccess() { }

	// RVA: 0x1A701D0 Offset: 0x1A6C1D0 VA: 0x1A701D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A703F4 Offset: 0x1A6C3F4 VA: 0x1A703F4
	private bool <InitScrollWindow>b__90_0(OrbEnchantData x) { }
}
