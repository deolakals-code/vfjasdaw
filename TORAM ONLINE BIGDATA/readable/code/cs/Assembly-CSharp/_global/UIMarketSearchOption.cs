// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketSearchOption : MonoBehaviour // TypeDefIndex: 8438
{
	// Fields
	private ItemType selectItemType; // 0x20
	private SystemTextManager systemTextManager; // 0x28
	private ItemPropertyTextManager itemPropertyTextManager; // 0x30
	private Dictionary<int, string> itemPropNameList; // 0x38
	private ItemRandomPropertyTextManager itemRandomPropertyTextManager; // 0x40
	private Dictionary<int, string> itemRandomPropNameList; // 0x48
	private float bottom; // 0x50
	[SerializeField]
	private GameObject mainPanel; // 0x58
	private UIMarketSearchOption.SelectColorFlag selectColorFlag; // 0x60
	[SerializeField]
	private GameObject equipPanel; // 0x68
	[SerializeField]
	private UILabel slotButtonLabel; // 0x70
	[SerializeField]
	private UILabel colorPartButtonLabel; // 0x78
	[SerializeField]
	private UILabel colorSelectButtonLabel; // 0x80
	[SerializeField]
	private UIButtonSendMessage colorSelectAddButtonMes; // 0x88
	[SerializeField]
	private UIButtonSendMessage colorSelectSubButtonMes; // 0x90
	[SerializeField]
	private UISprite colorSelectPalette; // 0x98
	[SerializeField]
	private GameObject nonColorSelectPalette; // 0xA0
	[SerializeField]
	private UILabel searchMethodButtonLabel; // 0xA8
	[SerializeField]
	private GameObject equipOpBottom; // 0xB0
	[SerializeField]
	private GameObject aibilityEquipOptionObj; // 0xB8
	[SerializeField]
	private UILabel abilityEquipButtonLabel; // 0xC0
	[SerializeField]
	private UILabel abilityPropertyButtonLabel; // 0xC8
	[SerializeField]
	private GameObject abilityPropertyButtonObj; // 0xD0
	private int searchSlotNum; // 0xD8
	private MarketProductList.EnumOptionsSlot enumSlot; // 0xDC
	private int searchColorPartNum; // 0xE0
	private MarketProductList.EnumOptionsParts enumParts; // 0xE4
	private byte searchColorSelect; // 0xE5
	private Coroutine colorAddCoroutine; // 0xE8
	private Coroutine colorSubCoroutine; // 0xF0
	private bool isItemNamePriority; // 0xF8
	private UIMarketBuy marketBuy; // 0x100
	private UIMarketSearchOption.SearchTextType searchTextType; // 0x108
	private UITextSearchScrollWindow textSearchScrollWindow; // 0x110
	private short selectAbilityCapOptipn; // 0x118
	private short selectAbilityRPropertyOption; // 0x11A
	private float[] bottomPosYList; // 0x120

	// Properties
	public float Bottom { get; }
	public MarketProductList.EnumOptionsSlot OptionSlot { get; }
	public MarketProductList.EnumOptionsParts OptionParts { get; }
	public byte OptionColor { get; }
	public bool IsItemNamePriority { get; }
	public bool IsEnableTextSearchScrollWindow { get; }
	public short AbilityCapOption { get; }
	public short AbilityRPropertyOption { get; }

	// Methods

	// RVA: 0x1D62664 Offset: 0x1D5E664 VA: 0x1D62664
	public float get_Bottom() { }

	// RVA: 0x1D626C4 Offset: 0x1D5E6C4 VA: 0x1D626C4
	public MarketProductList.EnumOptionsSlot get_OptionSlot() { }

	// RVA: 0x1D626CC Offset: 0x1D5E6CC VA: 0x1D626CC
	public MarketProductList.EnumOptionsParts get_OptionParts() { }

	// RVA: 0x1D626D4 Offset: 0x1D5E6D4 VA: 0x1D626D4
	public byte get_OptionColor() { }

	// RVA: 0x1D626E4 Offset: 0x1D5E6E4 VA: 0x1D626E4
	public bool get_IsItemNamePriority() { }

	// RVA: 0x1D626EC Offset: 0x1D5E6EC VA: 0x1D626EC
	public bool get_IsEnableTextSearchScrollWindow() { }

	// RVA: 0x1D62774 Offset: 0x1D5E774 VA: 0x1D62774
	public short get_AbilityCapOption() { }

	// RVA: 0x1D62800 Offset: 0x1D5E800 VA: 0x1D62800
	public short get_AbilityRPropertyOption() { }

	// RVA: 0x1D6288C Offset: 0x1D5E88C VA: 0x1D6288C
	public bool CheckEquip(int itemId) { }

	// RVA: 0x1D62910 Offset: 0x1D5E910 VA: 0x1D62910
	public bool IsCategoryEquip(ItemType type) { }

	// RVA: 0x1D628FC Offset: 0x1D5E8FC VA: 0x1D628FC
	private UIMarketSearchOption.OptionCategory GetCategory(ItemType type) { }

	// RVA: 0x1D62924 Offset: 0x1D5E924 VA: 0x1D62924
	private bool IsAbilityRProperty(ItemType type) { }

	// RVA: 0x1D6294C Offset: 0x1D5E94C VA: 0x1D6294C
	public void Initialize(ItemType selectItemType) { }

	// RVA: 0x1D62958 Offset: 0x1D5E958 VA: 0x1D62958
	public void Initialize(ItemType selectItemType, UIMarketBuy marketBuy, Transform searchScrollParent) { }

	// RVA: 0x1D62AC0 Offset: 0x1D5EAC0 VA: 0x1D62AC0
	public void InitTextSearchScrollWindow(Transform scrollParent) { }

	// RVA: 0x1D62F44 Offset: 0x1D5EF44 VA: 0x1D62F44
	public void UpdateItemType(ItemType selectItemType) { }

	// RVA: 0x1D62D64 Offset: 0x1D5ED64 VA: 0x1D62D64
	private void InitEquipOption() { }

	// RVA: 0x1D62F4C Offset: 0x1D5EF4C VA: 0x1D62F4C
	private void UpdateAbilityOption() { }

	// RVA: 0x1D631C8 Offset: 0x1D5F1C8 VA: 0x1D631C8
	private void onSearchBySlot() { }

	// RVA: 0x1D632F4 Offset: 0x1D5F2F4 VA: 0x1D632F4
	private void onSearchColorPart() { }

	// RVA: 0x1D633E0 Offset: 0x1D5F3E0 VA: 0x1D633E0
	private void onSearchColorSelect(int param) { }

	[IteratorStateMachine(typeof(UIMarketSearchOption.<AddSelectColor>d__70))]
	// RVA: 0x1D63724 Offset: 0x1D5F724 VA: 0x1D63724
	private IEnumerator AddSelectColor() { }

	[IteratorStateMachine(typeof(UIMarketSearchOption.<SubSelectColor>d__71))]
	// RVA: 0x1D63790 Offset: 0x1D5F790 VA: 0x1D63790
	private IEnumerator SubSelectColor() { }

	// RVA: 0x1D63580 Offset: 0x1D5F580 VA: 0x1D63580
	private void ChangeColorSelect(int param) { }

	// RVA: 0x1D6384C Offset: 0x1D5F84C VA: 0x1D6384C
	private void onSearchMethod() { }

	// RVA: 0x1D638E0 Offset: 0x1D5F8E0 VA: 0x1D638E0
	public void OnAbilityEquip() { }

	// RVA: 0x1D63AD0 Offset: 0x1D5FAD0 VA: 0x1D63AD0
	public void OnAbilityProperty() { }

	// RVA: 0x1D63964 Offset: 0x1D5F964 VA: 0x1D63964
	private void OpenTextScrollWindow(UIMarketSearchOption.SearchTextType searchTextType, Action initAction) { }

	// RVA: 0x1D63B54 Offset: 0x1D5FB54 VA: 0x1D63B54
	private void SearchEnterAction() { }

	// RVA: 0x1D63C5C Offset: 0x1D5FC5C VA: 0x1D63C5C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D63D84 Offset: 0x1D5FD84 VA: 0x1D63D84
	private void <OnAbilityEquip>b__74_0() { }

	[CompilerGenerated]
	// RVA: 0x1D63F20 Offset: 0x1D5FF20 VA: 0x1D63F20
	private void <OnAbilityProperty>b__75_0() { }

	[CompilerGenerated]
	// RVA: 0x1D64164 Offset: 0x1D60164 VA: 0x1D64164
	private void <OpenTextScrollWindow>b__76_0() { }
}
