// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageManager : UIBasePanel // TypeDefIndex: 7966
{
	// Fields
	[CompilerGenerated]
	private IUISpecialStoragePanel <ActivePanel>k__BackingField; // 0x30
	[SerializeField]
	private GameObject[] panelObject; // 0x38
	private IUISpecialStoragePanel[] panel; // 0x40
	[SerializeField]
	private GameObject windowPanel; // 0x48
	[SerializeField]
	private GameObject specialStorageTitle; // 0x50
	[SerializeField]
	private GameObject asobimoMarkestTitle; // 0x58
	[SerializeField]
	private UIIruna2Anchor asobimoMarkestAnchor; // 0x60
	[SerializeField]
	private UIIruna2Anchor orbPanelAnchor; // 0x68
	[SerializeField]
	private UILabel orbPanelText; // 0x70
	[SerializeField]
	private UILabel resultText; // 0x78
	[SerializeField]
	private UISprite resultIcon; // 0x80
	[SerializeField]
	private GameObject resultPanel; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	[CompilerGenerated]
	private UISpecialStorageManager.PanelType <ActivePanelType>k__BackingField; // 0x98
	[CompilerGenerated]
	private UISpecialStorageManager.PanelType <PreviousPanelType>k__BackingField; // 0x9C
	[CompilerGenerated]
	private bool <IsMarketMaintenance>k__BackingField; // 0xA0
	private int marketFreeBoxNum; // 0xA4
	private bool isResultPopWindow; // 0xA8
	private UISpecialStorageManager.ClientBankData[] bankData; // 0xB0
	private Dictionary<byte, long> bankDepositData; // 0xB8
	private List<BankPotionData> bankPotionData; // 0xC0
	private const int createPotionPotId = 0;
	private bool isWait; // 0xC8

	// Properties
	public IUISpecialStoragePanel ActivePanel { get; set; }
	public UISpecialStorageManager.PanelType ActivePanelType { get; set; }
	public UISpecialStorageManager.PanelType PreviousPanelType { get; set; }
	public bool IsMarketMaintenance { get; set; }
	public bool IsMarketBoxMax { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C8520C Offset: 0x1C8120C VA: 0x1C8520C
	public IUISpecialStoragePanel get_ActivePanel() { }

	[CompilerGenerated]
	// RVA: 0x1C85214 Offset: 0x1C81214 VA: 0x1C85214
	private void set_ActivePanel(IUISpecialStoragePanel value) { }

	[CompilerGenerated]
	// RVA: 0x1C8521C Offset: 0x1C8121C VA: 0x1C8521C
	public UISpecialStorageManager.PanelType get_ActivePanelType() { }

	[CompilerGenerated]
	// RVA: 0x1C85224 Offset: 0x1C81224 VA: 0x1C85224
	private void set_ActivePanelType(UISpecialStorageManager.PanelType value) { }

	[CompilerGenerated]
	// RVA: 0x1C8522C Offset: 0x1C8122C VA: 0x1C8522C
	public UISpecialStorageManager.PanelType get_PreviousPanelType() { }

	[CompilerGenerated]
	// RVA: 0x1C85234 Offset: 0x1C81234 VA: 0x1C85234
	private void set_PreviousPanelType(UISpecialStorageManager.PanelType value) { }

	[CompilerGenerated]
	// RVA: 0x1C8523C Offset: 0x1C8123C VA: 0x1C8523C
	public bool get_IsMarketMaintenance() { }

	[CompilerGenerated]
	// RVA: 0x1C85244 Offset: 0x1C81244 VA: 0x1C85244
	private void set_IsMarketMaintenance(bool value) { }

	// RVA: 0x1C83A3C Offset: 0x1C7FA3C VA: 0x1C83A3C
	public bool get_IsMarketBoxMax() { }

	// RVA: 0x1C85250 Offset: 0x1C81250 VA: 0x1C85250
	private void Awake() { }

	[IteratorStateMachine(typeof(UISpecialStorageManager.<Start>d__41))]
	// RVA: 0x1C85844 Offset: 0x1C81844 VA: 0x1C85844
	private IEnumerator Start() { }

	// RVA: 0x1C7EF30 Offset: 0x1C7AF30 VA: 0x1C7EF30
	public bool ChangePanel(UISpecialStorageManager.PanelType panelType) { }

	// RVA: 0x1C858D8 Offset: 0x1C818D8 VA: 0x1C858D8
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C839D0 Offset: 0x1C7F9D0 VA: 0x1C839D0
	public bool IsMarketLimit() { }

	// RVA: 0x1C7ED84 Offset: 0x1C7AD84 VA: 0x1C7ED84
	public bool IsSpecialStorageLimit() { }

	// RVA: 0x1C8597C Offset: 0x1C8197C VA: 0x1C8597C
	public void ReceiveSettingBank(BankData[] bankDatas, Dictionary<byte, long> deposit, BankPotionData[] potionData, bool isMaintenance, int bankNum) { }

	// RVA: 0x1C85D20 Offset: 0x1C81D20 VA: 0x1C85D20
	public void ReceiveUpdateBank(BankData bank, byte type, long value) { }

	// RVA: 0x1C85D88 Offset: 0x1C81D88 VA: 0x1C85D88
	public void ReceiveUpdateStorage(byte type, long value, int num) { }

	// RVA: 0x1C85DFC Offset: 0x1C81DFC VA: 0x1C85DFC
	public void ReceiveUpdateExpPotionStorage(BankData bank, BankPotionData addPotionData, short removeId) { }

	// RVA: 0x1C85E64 Offset: 0x1C81E64 VA: 0x1C85E64
	public void ReceiveUpdateExpPotionStorage(BankPotionData addPotionData, short removeId) { }

	// RVA: 0x1C85E6C Offset: 0x1C81E6C VA: 0x1C85E6C
	public void ReceiveUpdateExpPotionStorage(BankPotionData addPotionData, short removeId, int num) { }

	// RVA: 0x1C7EA14 Offset: 0x1C7AA14 VA: 0x1C7EA14
	public long GetStorageMaxPoint(BankType type) { }

	// RVA: 0x1C860E4 Offset: 0x1C820E4 VA: 0x1C860E4
	public long GetBankPoint(BankType type) { }

	// RVA: 0x1C8179C Offset: 0x1C7D79C VA: 0x1C8179C
	public int GetStorageSetPoint(BankType type) { }

	// RVA: 0x1C7E83C Offset: 0x1C7A83C VA: 0x1C7E83C
	public int GetStorageDepositCount(BankType type) { }

	// RVA: 0x1C7E878 Offset: 0x1C7A878 VA: 0x1C7E878
	public int GetStorageDepositResetDays(BankType type) { }

	// RVA: 0x1C862B0 Offset: 0x1C822B0 VA: 0x1C862B0
	public int GetStorageWithdrawCount(BankType type) { }

	// RVA: 0x1C815EC Offset: 0x1C7D5EC VA: 0x1C815EC
	public string GetSpecialItemTypeUnit(BankType type) { }

	// RVA: 0x1C86310 Offset: 0x1C82310 VA: 0x1C86310
	public int GetStorageWithdrawFee() { }

	// RVA: 0x1C826A0 Offset: 0x1C7E6A0 VA: 0x1C826A0
	public bool TryGetMaterilType_Level(BankDepositType type, out byte materialType, out byte materiallevel) { }

	// RVA: 0x1C815C8 Offset: 0x1C7D5C8 VA: 0x1C815C8
	public BankType GetBankType(BankDepositType type) { }

	// RVA: 0x1C86370 Offset: 0x1C82370 VA: 0x1C86370
	public int GetGameMaxPoint(BankDepositType type) { }

	// RVA: 0x1C8169C Offset: 0x1C7D69C VA: 0x1C8169C
	public int GetGameItemPoint(BankDepositType type) { }

	// RVA: 0x1C81724 Offset: 0x1C7D724 VA: 0x1C81724
	public long GetStorageItemPoint(BankDepositType type) { }

	// RVA: 0x1C826C0 Offset: 0x1C7E6C0 VA: 0x1C826C0
	public string GetSpecialItemTypeIcon(BankDepositType type) { }

	// RVA: 0x1C7EA54 Offset: 0x1C7AA54 VA: 0x1C7EA54
	public BankPotionData GetActiveExpPot() { }

	// RVA: 0x1C7E8BC Offset: 0x1C7A8BC VA: 0x1C7E8BC
	public int GetExpDrinkNum() { }

	// RVA: 0x1C82A40 Offset: 0x1C7EA40 VA: 0x1C82A40
	public BankPotionData[] GetExpDrinkData() { }

	// RVA: 0x1C7EB68 Offset: 0x1C7AB68 VA: 0x1C7EB68
	public int GetExp(int lv) { }

	// RVA: 0x1C7FC40 Offset: 0x1C7BC40 VA: 0x1C7FC40
	public void FrameFade(bool fadeIn) { }

	[IteratorStateMachine(typeof(UISpecialStorageManager.<LoadingWait>d__71))]
	// RVA: 0x1C7FCF0 Offset: 0x1C7BCF0 VA: 0x1C7FCF0
	public IEnumerator LoadingWait(int time, Func<bool> wait) { }

	[IteratorStateMachine(typeof(UISpecialStorageManager.<PopUpResultWindow>d__72))]
	// RVA: 0x1C7FD80 Offset: 0x1C7BD80 VA: 0x1C7FD80
	public IEnumerator PopUpResultWindow(string text, string spriteName) { }

	[IteratorStateMachine(typeof(UISpecialStorageManager.<PopUpTextWindow>d__73))]
	// RVA: 0x1C7FBB8 Offset: 0x1C7BBB8 VA: 0x1C7FBB8
	public IEnumerator PopUpTextWindow(string text) { }

	// RVA: 0x1C86418 Offset: 0x1C82418 VA: 0x1C86418
	private void OnClickPopUpResultWindow() { }

	// RVA: 0x1C8647C Offset: 0x1C8247C VA: 0x1C8647C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C865CC Offset: 0x1C825CC VA: 0x1C865CC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C86670 Offset: 0x1C82670 VA: 0x1C86670
	public void .ctor() { }
}
