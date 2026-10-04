// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBazaarSellRegister : MonoBehaviour // TypeDefIndex: 8292
{
	// Fields
	[SerializeField]
	private UILabel titleLabel; // 0x20
	[SerializeField]
	private UIItemPropertyStretch selectItemProperty; // 0x28
	[SerializeField]
	private GameObject selectMessageObject; // 0x30
	[SerializeField]
	private UILabel salesPriceMessageLabel; // 0x38
	[SerializeField]
	private ItemIcon selectItemIcon; // 0x40
	[SerializeField]
	private UIImageButton priceButton; // 0x48
	[SerializeField]
	private UILabel priceButtonLabel; // 0x50
	[SerializeField]
	private UIImageButton registerButton; // 0x58
	[SerializeField]
	private UIImageButton collectButton; // 0x60
	[SerializeField]
	private TweenColor registerTweenColor; // 0x68
	[SerializeField]
	private UIBazaarSellRegisterInput inputWindow; // 0x70
	[SerializeField]
	private UIToggle agreementCheckBox; // 0x78
	[SerializeField]
	private GameObject starGemPanel; // 0x80
	[SerializeField]
	private UILabel starGemPropertyLabel; // 0x88
	[SerializeField]
	private GameObject starGemScrollCamera; // 0x90
	private StarGemData selectedStarGem; // 0x98
	private UIPopBaseWindow skillPopWindow; // 0xA0
	private GameObject skillIconObj; // 0xA8
	private bool isSkillPopWindow; // 0xB0
	private UIBazaarSettingPanel topControl; // 0xB8
	private SystemTextManager systemTextManager; // 0xC0
	private ItemSelector itemSelector; // 0xC8
	private PlayerDataManager playerDataManager; // 0xD0
	private SkillTextManager skillTextManager; // 0xD8
	private ItemData selectedItem; // 0xE0
	private BazaarItemData previousItem; // 0xE8
	private int totalPrice; // 0xF0
	private int unitPrice; // 0xF4
	private int count; // 0xF8
	private int selectedSlot; // 0xFC

	// Properties
	private bool isSelectedItem { get; }
	private bool isEnteredPrice { get; }

	// Methods

	// RVA: 0x1D155D4 Offset: 0x1D115D4 VA: 0x1D155D4
	private bool get_isSelectedItem() { }

	// RVA: 0x1D155F4 Offset: 0x1D115F4 VA: 0x1D155F4
	private bool get_isEnteredPrice() { }

	// RVA: 0x1D15604 Offset: 0x1D11604 VA: 0x1D15604
	private void Awake() { }

	// RVA: 0x1D15D20 Offset: 0x1D11D20 VA: 0x1D15D20
	private void Start() { }

	// RVA: 0x1D15D24 Offset: 0x1D11D24 VA: 0x1D15D24
	public void Initialize(UIBazaarSettingPanel topControl, int index, BazaarItemData data) { }

	// RVA: 0x1D158B8 Offset: 0x1D118B8 VA: 0x1D158B8
	private void updatePriceButton(bool isChanged) { }

	// RVA: 0x1D1674C Offset: 0x1D1274C VA: 0x1D1674C
	private bool CheckChangedData() { }

	// RVA: 0x1D167D4 Offset: 0x1D127D4 VA: 0x1D167D4
	private void onClickSelectItem() { }

	// RVA: 0x1D160A8 Offset: 0x1D120A8 VA: 0x1D160A8
	private void onSelectedItem(ItemData item, int selectCount) { }

	// RVA: 0x1D16194 Offset: 0x1D12194 VA: 0x1D16194
	private void onSelectedItem(ItemData item, int selectCount, bool isNullableItem) { }

	// RVA: 0x1D16AC0 Offset: 0x1D12AC0 VA: 0x1D16AC0
	private void onClickPrice() { }

	// RVA: 0x1D160B0 Offset: 0x1D120B0 VA: 0x1D160B0
	public void onSubmit(int allprice) { }

	// RVA: 0x1D17340 Offset: 0x1D13340 VA: 0x1D17340
	private void onStarGemSubmit(int allprice) { }

	// RVA: 0x1D173E8 Offset: 0x1D133E8 VA: 0x1D173E8
	private void onCollect() { }

	[IteratorStateMachine(typeof(UIBazaarSellRegister.<onRegister>d__46))]
	// RVA: 0x1D174FC Offset: 0x1D134FC VA: 0x1D174FC
	private IEnumerator onRegister() { }

	// RVA: 0x1D17590 Offset: 0x1D13590 VA: 0x1D17590
	public void Register() { }

	// RVA: 0x1D17700 Offset: 0x1D13700 VA: 0x1D17700
	public void OnChangedAcceptCheckBox() { }

	// RVA: 0x1D172F0 Offset: 0x1D132F0 VA: 0x1D172F0
	private bool IsAccepted() { }

	// RVA: 0x1D17740 Offset: 0x1D13740 VA: 0x1D17740
	private void OnClickStarGemSelect(StarGemData data) { }

	// RVA: 0x1D17B7C Offset: 0x1D13B7C VA: 0x1D17B7C
	private void OnSkillInfo() { }

	[IteratorStateMachine(typeof(UIBazaarSellRegister.<openSkillInfo>d__52))]
	// RVA: 0x1D17C60 Offset: 0x1D13C60 VA: 0x1D17C60
	private IEnumerator openSkillInfo() { }

	// RVA: 0x1D17CF4 Offset: 0x1D13CF4 VA: 0x1D17CF4
	private void CloseSkillPopWindow() { }

	// RVA: 0x1D15840 Offset: 0x1D11840 VA: 0x1D15840
	private void setEnableRegisterButton(bool isEnable) { }

	// RVA: 0x1D17D04 Offset: 0x1D13D04 VA: 0x1D17D04
	private void backToRegisterFromInput() { }

	// RVA: 0x1D17D98 Offset: 0x1D13D98 VA: 0x1D17D98
	private void closeError() { }

	// RVA: 0x1D17E40 Offset: 0x1D13E40 VA: 0x1D17E40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D17E48 Offset: 0x1D13E48 VA: 0x1D17E48
	private bool <onClickSelectItem>b__39_1(ItemData item) { }
}
