// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBazaarSettingPanel : UIBasePanelControl // TypeDefIndex: 8306
{
	// Fields
	private string title; // 0x58
	private int sales; // 0x60
	private byte slot; // 0x64
	private const byte MAX_SLOT = 9;
	private readonly Dictionary<int, BazaarItemData> bazaarItemDataList; // 0x68
	private readonly List<UIBazaarItemPlate> plateList; // 0x70
	private UIPopBaseWindow popBaseWindow; // 0x78
	private Regex defaultBazaarName; // 0x80
	private bool isHideOpneBazaarMessage; // 0x88
	private BazaarManager bazaarManager; // 0x90
	private UIPopBaseWindow errorPopWindow; // 0x98
	private PlayerDataManager playerDataManager; // 0xA0
	[SerializeField]
	private GameObject settingPanel; // 0xA8
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0xB0
	[SerializeField]
	private UIIruna2PCInput nameLabel; // 0xB8
	[SerializeField]
	private TweenAlpha errorEffect; // 0xC0
	[SerializeField]
	private UILabel salesLabel; // 0xC8
	[SerializeField]
	private UIBazaarItemPlate itemPlate; // 0xD0
	[SerializeField]
	private UIImageButton addSlotButton; // 0xD8
	[SerializeField]
	private UIImageButton openBazaarMessagePopButton; // 0xE0
	[SerializeField]
	private GameObject registerTitle; // 0xE8
	[SerializeField]
	private UIBazaarSellRegister register; // 0xF0
	[SerializeField]
	private UIIruna2AnchorSimple openBazaarMessageAnchor; // 0xF8
	[SerializeField]
	private UIImageButton openBazaarButton; // 0x100
	[SerializeField]
	private LabelWithIcon openBazaarMessage; // 0x108
	[SerializeField]
	private GameObject addSlotWindowTitle; // 0x110
	[SerializeField]
	private GameObject addSlotWindowMessage; // 0x118
	[SerializeField]
	private UILabel orbLabel; // 0x120
	[SerializeField]
	private UILabel needOrbLabel; // 0x128
	[SerializeField]
	private UIImageButton addSlotOrbButton; // 0x130
	[SerializeField]
	private UILabel spinaLabel; // 0x138
	[SerializeField]
	private UILabel needSpinaLabel; // 0x140
	[SerializeField]
	private UIImageButton addSlotSpinaButton; // 0x148
	[SerializeField]
	private UIImageButton editNameButton; // 0x150
	[SerializeField]
	private UIImageButton salesAcquisitionButton; // 0x158

	// Properties
	public byte MaxSlot { get; }
	public int Sales { get; }
	public long TotalSales { get; }
	public bool IsSetBazaarPosition { get; }

	// Methods

	// RVA: 0x1D18EE8 Offset: 0x1D14EE8 VA: 0x1D18EE8
	public void ChangeTitle(string title) { }

	// RVA: 0x1D17660 Offset: 0x1D13660 VA: 0x1D17660
	public void Exhibit(byte slotIndex, ItemSelectData selectItem, int price) { }

	// RVA: 0x1D1747C Offset: 0x1D1347C VA: 0x1D1747C
	public void CancelExhibit(byte slotIndex, Action callback) { }

	// RVA: 0x1D190BC Offset: 0x1D150BC VA: 0x1D190BC
	public void SalesAcquisition(int gold) { }

	// RVA: 0x1D19138 Offset: 0x1D15138 VA: 0x1D19138
	public void ExpansionSlot() { }

	// RVA: 0x1D191A4 Offset: 0x1D151A4 VA: 0x1D191A4
	public byte get_MaxSlot() { }

	// RVA: 0x1D191AC Offset: 0x1D151AC VA: 0x1D191AC
	public int get_Sales() { }

	// RVA: 0x1D165D0 Offset: 0x1D125D0 VA: 0x1D165D0
	public long get_TotalSales() { }

	// RVA: 0x1D191B4 Offset: 0x1D151B4 VA: 0x1D191B4
	public bool get_IsSetBazaarPosition() { }

	// RVA: 0x1D191C4 Offset: 0x1D151C4 VA: 0x1D191C4
	private void Awake() { }

	// RVA: 0x1D197D4 Offset: 0x1D157D4 VA: 0x1D197D4
	private void Update() { }

	// RVA: 0x1D19B78 Offset: 0x1D15B78 VA: 0x1D19B78
	private void OnDestroy() { }

	// RVA: 0x1D198BC Offset: 0x1D158BC VA: 0x1D198BC
	private bool IsBattle() { }

	// RVA: 0x1D19994 Offset: 0x1D15994 VA: 0x1D19994
	private void UpdateOpenBazaarMessage() { }

	// RVA: 0x1D19BD8 Offset: 0x1D15BD8 VA: 0x1D19BD8
	private void SetData(BazaarData bazaar) { }

	// RVA: 0x1D19DC8 Offset: 0x1D15DC8 VA: 0x1D19DC8
	private void CreateSettingPanel() { }

	// RVA: 0x1D1A374 Offset: 0x1D16374 VA: 0x1D1A374
	public void SetBazaarItem(BazaarItemData bazaarItemData) { }

	// RVA: 0x1D19D2C Offset: 0x1D15D2C VA: 0x1D19D2C
	private void SetSales(int sales) { }

	// RVA: 0x1D1A58C Offset: 0x1D1658C VA: 0x1D1A58C
	private void RemoveItem(byte slotIndex) { }

	// RVA: 0x1D1A308 Offset: 0x1D16308 VA: 0x1D1A308
	private void UpdateOpenBazaarMessagePopButtonEnable() { }

	// RVA: 0x1D1A1B0 Offset: 0x1D161B0 VA: 0x1D1A1B0
	private void SetDefaultBazaarName() { }

	// RVA: 0x1D1A72C Offset: 0x1D1672C VA: 0x1D1A72C
	private int GetNextBazaarSlotExpansionFee() { }

	// RVA: 0x1D1A7D4 Offset: 0x1D167D4 VA: 0x1D1A7D4
	public void OnEditBazaarNameButton() { }

	// RVA: 0x1D1A814 Offset: 0x1D16814 VA: 0x1D1A814
	public void OnBazaarNameSubmit() { }

	// RVA: 0x1D1A818 Offset: 0x1D16818 VA: 0x1D1A818
	public bool CheckBazaarName() { }

	// RVA: 0x1D1AAD4 Offset: 0x1D16AD4 VA: 0x1D1AAD4
	private void PlayNameError() { }

	// RVA: 0x1D1AB64 Offset: 0x1D16B64 VA: 0x1D1AB64
	public void OnSalesAcquisitionButton() { }

	// RVA: 0x1D1ABE0 Offset: 0x1D16BE0 VA: 0x1D1ABE0
	private void OnEditExhibitButton(int index) { }

	// RVA: 0x1D1AD78 Offset: 0x1D16D78 VA: 0x1D1AD78
	private void OnCancelSelectItem() { }

	// RVA: 0x1D1AE60 Offset: 0x1D16E60 VA: 0x1D1AE60
	private void OnAddSlotButton() { }

	// RVA: 0x1D1B238 Offset: 0x1D17238 VA: 0x1D1B238
	private void OnAddSlotWithSpina() { }

	// RVA: 0x1D1B2E0 Offset: 0x1D172E0 VA: 0x1D1B2E0
	private void OnAddSlotWithOrb() { }

	[IteratorStateMachine(typeof(UIBazaarSettingPanel.<AddSlot>d__76))]
	// RVA: 0x1D1B25C Offset: 0x1D1725C VA: 0x1D1B25C
	private IEnumerator AddSlot(int type) { }

	// RVA: 0x1D1B304 Offset: 0x1D17304 VA: 0x1D1B304
	private void OnCloseWindow() { }

	// RVA: 0x1D1B3BC Offset: 0x1D173BC VA: 0x1D1B3BC
	private void OnSetBazaarPositionButton() { }

	// RVA: 0x1D1B508 Offset: 0x1D17508 VA: 0x1D1B508
	private void OnOpenBazaarButton() { }

	[IteratorStateMachine(typeof(UIBazaarSettingPanel.<OpenBazaar>d__80))]
	// RVA: 0x1D1B588 Offset: 0x1D17588 VA: 0x1D1B588
	private IEnumerator OpenBazaar() { }

	// RVA: 0x1D1B5E0 Offset: 0x1D175E0 VA: 0x1D1B5E0
	private void OnOpenBazaarCancel() { }

	// RVA: 0x1D1B6D0 Offset: 0x1D176D0 VA: 0x1D1B6D0
	public void OnReturnButton() { }

	// RVA: 0x1D1B75C Offset: 0x1D1775C VA: 0x1D1B75C Slot: 6
	public override void OnRightTopButton() { }

	[IteratorStateMachine(typeof(UIBazaarSettingPanel.<Connection>d__84))]
	// RVA: 0x1D18FC4 Offset: 0x1D14FC4 VA: 0x1D18FC4
	protected IEnumerator Connection(IReconnectionSubData data) { }

	[IteratorStateMachine(typeof(UIBazaarSettingPanel.<ConnectGetBazaarData>d__85))]
	// RVA: 0x1D19760 Offset: 0x1D15760 VA: 0x1D19760
	private IEnumerator ConnectGetBazaarData() { }

	// RVA: 0x1D195CC Offset: 0x1D155CC VA: 0x1D195CC
	private void OnFailed(string key, string[] list, Action callback) { }

	[IteratorStateMachine(typeof(UIBazaarSettingPanel.<popUpMessage>d__87))]
	// RVA: 0x1D1B7E0 Offset: 0x1D177E0 VA: 0x1D1B7E0
	protected IEnumerator popUpMessage(string titleText, string messageText, Action callback) { }

	// RVA: 0x1D1B8A0 Offset: 0x1D178A0 VA: 0x1D1B8A0
	private void OnCloseErrorPopWindow() { }

	// RVA: 0x1D1B9AC Offset: 0x1D179AC VA: 0x1D1B9AC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D1BA98 Offset: 0x1D17A98 VA: 0x1D1BA98
	private void <OnAddSlotButton>b__73_0() { }
}
