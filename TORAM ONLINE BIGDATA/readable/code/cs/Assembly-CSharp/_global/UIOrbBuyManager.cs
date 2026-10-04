// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbBuyManager : UIBasePanelControl // TypeDefIndex: 7558
{
	// Fields
	protected OrbManager orbManager; // 0x58
	protected UIScrollWindow scrollWindow; // 0x60
	[SerializeField]
	protected GameObject scrollButton; // 0x68
	[SerializeField]
	protected UILabel[] scrollLabelButton; // 0x70
	[SerializeField]
	protected UILabel productNoneLabel; // 0x78
	[SerializeField]
	protected GameObject remainLapsePanel; // 0x80
	[SerializeField]
	protected UILabel remainLapseLabel; // 0x88
	[SerializeField]
	protected UILabel paidCoinLabel; // 0x90
	[SerializeField]
	protected UILabel coinLabel; // 0x98
	[SerializeField]
	protected GameObject coinFrameTrans; // 0xA0
	[SerializeField]
	protected GameObject setAccountObj; // 0xA8
	[SerializeField]
	protected GameObject attentionWindowObj; // 0xB0
	[SerializeField]
	private GameObject refreshObj; // 0xB8
	[SerializeField]
	protected UIImageButton refreshButton; // 0xC0
	[SerializeField]
	private UIOrbBuyRefreshWindow refreshWindow; // 0xC8
	protected UIPopBaseWindow popUpWindow; // 0xD0
	protected UIMainManager.UIElicitFlag elicitFlag; // 0xD8
	protected List<ProductData> productList; // 0xE0
	protected int shadeButtonId; // 0xE8
	protected int ticketButtonId; // 0xEC
	private bool connectState; // 0xF0
	private string connectText; // 0xF8
	private readonly string checkedAccountWindowKey; // 0x100
	private bool isCheckAccountWindow; // 0x108

	// Methods

	[IteratorStateMachine(typeof(UIOrbBuyManager.<Start>d__24))]
	// RVA: 0x1BA8308 Offset: 0x1BA4308 VA: 0x1BA8308 Slot: 14
	protected virtual IEnumerator Start() { }

	// RVA: 0x1BA839C Offset: 0x1BA439C VA: 0x1BA839C Slot: 15
	protected virtual void initializeUI() { }

	// RVA: 0x1BA8CC8 Offset: 0x1BA4CC8 VA: 0x1BA8CC8
	protected void SetButton(string leftText, string centerText, string rightText, float y, int id, string iconName, bool green, string stampText, string bonusText) { }

	// RVA: 0x1BA9050 Offset: 0x1BA5050 VA: 0x1BA9050
	protected bool CheckBonusData(string productId) { }

	// RVA: 0x1BA924C Offset: 0x1BA524C VA: 0x1BA924C
	protected string GetBonusNumText(string productId) { }

	// RVA: 0x1BA94B0 Offset: 0x1BA54B0 VA: 0x1BA94B0
	protected string GetBonusStampText(string productId) { }

	// RVA: 0x1BA9680 Offset: 0x1BA5680 VA: 0x1BA9680
	private void Update() { }

	[IteratorStateMachine(typeof(UIOrbBuyManager.<showPopUpWindow>d__31))]
	// RVA: 0x1BA97D4 Offset: 0x1BA57D4 VA: 0x1BA97D4
	protected IEnumerator showPopUpWindow(UIPopBaseWindow popWindow, Action<int> result) { }

	[IteratorStateMachine(typeof(UIOrbBuyManager.<orbShardConnectWait>d__32))]
	// RVA: 0x1BA9898 Offset: 0x1BA5898 VA: 0x1BA9898
	private IEnumerator orbShardConnectWait(Func<bool> connectCheck) { }

	[IteratorStateMachine(typeof(UIOrbBuyManager.<OrbShardChangeEvent>d__33))]
	// RVA: 0x1BA9948 Offset: 0x1BA5948 VA: 0x1BA9948
	private IEnumerator OrbShardChangeEvent() { }

	[IteratorStateMachine(typeof(UIOrbBuyManager.<TicketExchangeChangeEvent>d__34))]
	// RVA: 0x1BA99DC Offset: 0x1BA59DC VA: 0x1BA99DC
	private IEnumerator TicketExchangeChangeEvent() { }

	// RVA: 0x1BA9A70 Offset: 0x1BA5A70 VA: 0x1BA9A70
	protected void setEnableScrollWindow(bool enabled) { }

	// RVA: 0x1BA9BC4 Offset: 0x1BA5BC4 VA: 0x1BA9BC4
	private void SetEnablePurchaseRefresh(bool enabled) { }

	// RVA: 0x1BA9BE4 Offset: 0x1BA5BE4 VA: 0x1BA9BE4 Slot: 16
	protected virtual void OnClickButton(int id) { }

	// RVA: 0x1BAA0FC Offset: 0x1BA60FC VA: 0x1BAA0FC Slot: 17
	protected virtual void Purchase(string productId) { }

	// RVA: 0x1BAA2CC Offset: 0x1BA62CC VA: 0x1BAA2CC
	protected void successCallback(ProductData product) { }

	// RVA: 0x1BAA394 Offset: 0x1BA6394 VA: 0x1BAA394
	protected void failureCallback() { }

	// RVA: 0x1BAA448 Offset: 0x1BA6448 VA: 0x1BAA448
	private void OnDestroy() { }

	// RVA: 0x1BAA518 Offset: 0x1BA6518 VA: 0x1BAA518
	private void closePopWindow() { }

	// RVA: 0x1BAA5AC Offset: 0x1BA65AC VA: 0x1BAA5AC
	private void toPreviousPanel() { }

	// RVA: 0x1BAA638 Offset: 0x1BA6638 VA: 0x1BAA638
	private void OnSetAccount() { }

	// RVA: 0x1BAA6BC Offset: 0x1BA66BC VA: 0x1BAA6BC
	private void OnAttentionOk() { }

	[IteratorStateMachine(typeof(UIOrbBuyManager.<CloseAttentionWindow>d__46))]
	// RVA: 0x1BAA7CC Offset: 0x1BA67CC VA: 0x1BAA7CC
	private IEnumerator CloseAttentionWindow() { }

	// RVA: 0x1BAA860 Offset: 0x1BA6860 VA: 0x1BAA860
	private void OnPurchaseRefresh() { }

	// RVA: 0x1BAA9F4 Offset: 0x1BA69F4 VA: 0x1BAA9F4
	private void ReturnRefreshWindow() { }

	// RVA: 0x1BAAB10 Offset: 0x1BA6B10 VA: 0x1BAAB10
	public void .ctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1BAAC30 Offset: 0x1BA6C30 VA: 0x1BAAC30
	private void <>n__0(Action pushFunction) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1BAAC38 Offset: 0x1BA6C38 VA: 0x1BAAC38
	private void <>n__1(Action targetAction) { }
}
