// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketSellRegister : MonoBehaviour // TypeDefIndex: 8457
{
	// Fields
	[SerializeField]
	private UIItemPropertyStretch selectItemProperty; // 0x20
	[SerializeField]
	private GameObject selectMessageObject; // 0x28
	[SerializeField]
	private UILabel salesPriceMessageLabel; // 0x30
	[SerializeField]
	private ItemIcon selectItemIcon; // 0x38
	[SerializeField]
	private UIImageButton priceButton; // 0x40
	[SerializeField]
	private UILabel priceButtonLabel; // 0x48
	[SerializeField]
	private UIImageButton registerButton; // 0x50
	[SerializeField]
	private TweenColor registerTweenColor; // 0x58
	[SerializeField]
	private UISprite publicCheckButton; // 0x60
	[SerializeField]
	private UISprite guildCheckButton; // 0x68
	[SerializeField]
	private UILabel publicCheckLabel; // 0x70
	[SerializeField]
	private UILabel guildCheckLabel; // 0x78
	[SerializeField]
	private LocalizeText taxLabel; // 0x80
	[SerializeField]
	private UIMarketSellRegisterInput inputWindow; // 0x88
	[SerializeField]
	private UIMarketSellCompleteWindow completeWindow; // 0x90
	[SerializeField]
	private GameObject starGemPanel; // 0x98
	[SerializeField]
	private UILabel starGemPropertyLabel; // 0xA0
	[SerializeField]
	private GameObject starGemScrollCamera; // 0xA8
	private StarGemData selectedStarGem; // 0xB0
	private UIPopBaseWindow skillPopWindow; // 0xB8
	private GameObject skillIconObj; // 0xC0
	private bool isSkillPopWindow; // 0xC8
	private UIMarketControl topControl; // 0xD0
	private SystemTextManager systemTextManager; // 0xD8
	private ItemSelector itemSelector; // 0xE0
	private PlayerDataManager playerDataManager; // 0xE8
	private SkillTextManager skillTextManager; // 0xF0
	private ItemData selectedItem; // 0xF8
	private int price; // 0x100
	private int count; // 0x104
	private double commitionRate; // 0x108
	private bool isPublic; // 0x110
	private bool isGuild; // 0x111
	private int selectedSlot; // 0x114
	private int fee; // 0x118

	// Properties
	private bool isSelectedItem { get; }
	private bool isEnteredPrice { get; }
	private MarketType currentMarketType { get; }
	private MarketType currentStarGemMarketType { get; }

	// Methods

	// RVA: 0x1D6A658 Offset: 0x1D66658 VA: 0x1D6A658
	private bool get_isSelectedItem() { }

	// RVA: 0x1D6A678 Offset: 0x1D66678 VA: 0x1D6A678
	private bool get_isEnteredPrice() { }

	// RVA: 0x1D6A688 Offset: 0x1D66688 VA: 0x1D6A688
	private MarketType get_currentMarketType() { }

	// RVA: 0x1D6A6AC Offset: 0x1D666AC VA: 0x1D6A6AC
	private MarketType get_currentStarGemMarketType() { }

	// RVA: 0x1D6A6D4 Offset: 0x1D666D4 VA: 0x1D6A6D4
	private void Awake() { }

	// RVA: 0x1D6A88C Offset: 0x1D6688C VA: 0x1D6A88C
	private void Start() { }

	// RVA: 0x1D64C2C Offset: 0x1D60C2C VA: 0x1D64C2C
	public void Initialize(UIMarketControl control, int slot, double rate, byte tax, MarketServiceType serviceType) { }

	// RVA: 0x1D6A9AC Offset: 0x1D669AC VA: 0x1D6A9AC
	private void updatePriceButton() { }

	// RVA: 0x1D6B218 Offset: 0x1D67218 VA: 0x1D6B218
	private void onClickSelectItem() { }

	// RVA: 0x1D6AD20 Offset: 0x1D66D20 VA: 0x1D6AD20
	private void onSelectedItem(ItemData item, int selectCount) { }

	// RVA: 0x1D6B504 Offset: 0x1D67504 VA: 0x1D6B504
	private void onClickPrice() { }

	// RVA: 0x1D6B6FC Offset: 0x1D676FC VA: 0x1D6B6FC
	public void onSubmit(int allprice) { }

	// RVA: 0x1D6B938 Offset: 0x1D67938 VA: 0x1D6B938
	private void onStarGemSubmit(int allprice) { }

	// RVA: 0x1D6BB68 Offset: 0x1D67B68 VA: 0x1D6BB68
	private void onSwitchPublic() { }

	// RVA: 0x1D6BC20 Offset: 0x1D67C20 VA: 0x1D6BC20
	private void onSwitchGuild() { }

	// RVA: 0x1D6B11C Offset: 0x1D6711C VA: 0x1D6B11C
	private void updateToggle() { }

	[IteratorStateMachine(typeof(UIMarketSellRegister.<onRegister>d__55))]
	// RVA: 0x1D6BD44 Offset: 0x1D67D44 VA: 0x1D6BD44
	private IEnumerator onRegister() { }

	// RVA: 0x1D6BDB8 Offset: 0x1D67DB8 VA: 0x1D6BDB8
	private void onRegisterCompleteCallback() { }

	// RVA: 0x1D6BDFC Offset: 0x1D67DFC VA: 0x1D6BDFC
	private void OnClickStarGemSelect(StarGemData data) { }

	// RVA: 0x1D6C228 Offset: 0x1D68228 VA: 0x1D6C228
	private void OnSkillInfo() { }

	[IteratorStateMachine(typeof(UIMarketSellRegister.<openSkillInfo>d__59))]
	// RVA: 0x1D6C30C Offset: 0x1D6830C VA: 0x1D6C30C
	private IEnumerator openSkillInfo() { }

	// RVA: 0x1D6C380 Offset: 0x1D68380 VA: 0x1D6C380
	private void CloseSkillPopWindow() { }

	// RVA: 0x1D6A934 Offset: 0x1D66934 VA: 0x1D6A934
	private void setEnableRegisterButton(bool isEnable) { }

	// RVA: 0x1D6C390 Offset: 0x1D68390 VA: 0x1D6C390
	private void backToRegisterFromInput() { }

	// RVA: 0x1D6C424 Offset: 0x1D68424 VA: 0x1D6C424
	private void closeError() { }

	// RVA: 0x1D6C4CC Offset: 0x1D684CC VA: 0x1D6C4CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D6C4E4 Offset: 0x1D684E4 VA: 0x1D6C4E4
	private bool <onClickSelectItem>b__47_1(ItemData item) { }
}
