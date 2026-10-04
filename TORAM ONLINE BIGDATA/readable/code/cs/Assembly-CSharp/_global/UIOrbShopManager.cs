// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbShopManager : UIBasePanel // TypeDefIndex: 7644
{
	// Fields
	public static readonly int Version; // 0x0
	[SerializeField]
	private UIIruna2Anchor orbWindowAcnhor; // 0x30
	[SerializeField]
	private UIImageButton createCoinButton; // 0x38
	[SerializeField]
	private GameObject buyPopLabel; // 0x40
	[SerializeField]
	private GameObject buyPopWindow; // 0x48
	[SerializeField]
	private Transform buyPopParent; // 0x50
	[SerializeField]
	private GameObject popBuyWindowButton; // 0x58
	private UILabel popBuyWindowButtonLabel; // 0x60
	private UIImageButton popBuyWindowOKButton; // 0x68
	[SerializeField]
	private UILabel popWindowTitleLabel; // 0x70
	[SerializeField]
	private GameObject popItemInfoObject; // 0x78
	[SerializeField]
	private GameObject popAvatarInfoWindow; // 0x80
	[SerializeField]
	private UILabel popAvatarInfoLabel; // 0x88
	[SerializeField]
	private UIIcon popAvatarInfoIcon; // 0x90
	[SerializeField]
	private GameObject orbShopListPanelObject; // 0x98
	private UIOrbShopListPanel orbShopListPanel; // 0xA0
	[SerializeField]
	private GameObject cancelLeftTopButton; // 0xA8
	private UIIruna2Anchor cancelLeftTopAnchor; // 0xB0
	[SerializeField]
	private GameObject skipRightTopButton; // 0xB8
	[SerializeField]
	private GameObject skipPCRightTopButton; // 0xC0
	private UIIruna2Anchor skipRightTopAnchor; // 0xC8
	[SerializeField]
	private GameObject avatarEquipButton; // 0xD0
	private UIIruna2Anchor avatarEquipButtonAnchor; // 0xD8
	[SerializeField]
	private UISprite modelManagerBackPanel; // 0xE0
	[SerializeField]
	private UILoadingBar loading; // 0xE8
	private UIOrbShopBuyPanel orbShopBuyPanel; // 0xF0
	private UICharacterModelBaseManager modelManager; // 0xF8
	private OrbManager orbManager; // 0x100
	private NewArchetypeProperties archetypeProperties; // 0x108
	private ItemData bodyData; // 0x110
	private bool inputLock; // 0x118
	private ItemTextManager itemTextManager; // 0x120
	private bool maintenanceCheck; // 0x128
	private int resultOkClick; // 0x12C
	private int shopGachaSkip; // 0x130
	private bool initFlag; // 0x134
	private bool deadCheck; // 0x135
	private bool buyLock; // 0x136
	private bool shopLock; // 0x137
	private bool popWindow; // 0x138
	private int startPage; // 0x13C
	private byte startIndex; // 0x140
	private bool moveOrbMenu; // 0x141
	private bool isBuySaveKey; // 0x142
	private string buySaveKey; // 0x148
	private int backPanelColorId; // 0x150
	private Color[] backPanelColor; // 0x158

	// Methods

	// RVA: 0x1BCCE40 Offset: 0x1BC8E40 VA: 0x1BCCE40
	public void SetDefalutViewData(int page, byte index, bool moveOrbMenu) { }

	// RVA: 0x1BCCE54 Offset: 0x1BC8E54 VA: 0x1BCCE54
	private void Start() { }

	// RVA: 0x1BCD5DC Offset: 0x1BC95DC VA: 0x1BCD5DC
	private void Update() { }

	// RVA: 0x1BCD6EC Offset: 0x1BC96EC VA: 0x1BCD6EC
	private void OnDestroy() { }

	// RVA: 0x1BCD75C Offset: 0x1BC975C VA: 0x1BCD75C
	public bool CheckDeadLock() { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<showWebAPIError>d__53))]
	// RVA: 0x1BCD770 Offset: 0x1BC9770 VA: 0x1BCD770
	private IEnumerator showWebAPIError(string titleKey, string messageKey, string[] messageParams) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<ErrKickOutPopUpWindow>d__54))]
	// RVA: 0x1BCD850 Offset: 0x1BC9850 VA: 0x1BCD850
	private IEnumerator ErrKickOutPopUpWindow(string title, string text) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<ConnectWait>d__55))]
	// RVA: 0x1BCD914 Offset: 0x1BC9914 VA: 0x1BCD914
	private IEnumerator ConnectWait(Func<bool> connectCheck) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<EnterShop>d__56))]
	// RVA: 0x1BCD570 Offset: 0x1BC9570 VA: 0x1BCD570
	private IEnumerator EnterShop() { }

	// RVA: 0x1BCD9EC Offset: 0x1BC99EC VA: 0x1BCD9EC
	public void SetMainPanelActive(bool active) { }

	// RVA: 0x1BC9D40 Offset: 0x1BC5D40 VA: 0x1BC9D40
	public void BuyOrbItem(bool isPaidOrbOnly, bool isItemInfo, int id, UIOrbListBuyButtonData.OrbItemTypes type, GameObject mainTexture, bool isBuySaveKey, string saveKey) { }

	// RVA: 0x1BC9FEC Offset: 0x1BC5FEC VA: 0x1BC9FEC
	public void BuyCourse(string productId, string productName, string productInfo, string coursePrice, byte state, bool isCanCancellationProcedure, GameObject mainTexture) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<SelectOrbItemBuy>d__60))]
	// RVA: 0x1BCDA14 Offset: 0x1BC9A14 VA: 0x1BCDA14
	public IEnumerator SelectOrbItemBuy(int productId, UIOrbShopManager.BuyOrbItemPopData[] orbItemList) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<SelectGachaItemBuy>d__61))]
	// RVA: 0x1BCDACC Offset: 0x1BC9ACC VA: 0x1BCDACC
	public IEnumerator SelectGachaItemBuy(int productId, int setId, bool ticketBuy, bool isFree) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<SelectLuckBagItemBuy>d__62))]
	// RVA: 0x1BCDB94 Offset: 0x1BC9B94 VA: 0x1BCDB94
	public IEnumerator SelectLuckBagItemBuy(int productId, int setId) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<LoadBuyItemPopUpWindow>d__63))]
	// RVA: 0x1BCDC3C Offset: 0x1BC9C3C VA: 0x1BCDC3C
	private IEnumerator LoadBuyItemPopUpWindow(int resultPrice, string buyType, List<OrbShopManager.GachaDetailData> resultItem, OrbManager.ConnectFlag flag) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<BuyItemPopUpWindow>d__64))]
	// RVA: 0x1BCDD18 Offset: 0x1BC9D18 VA: 0x1BCDD18
	private IEnumerator BuyItemPopUpWindow(List<UIOrbShopManager.BuyOrbItemPopData> buyOrbItemData) { }

	// RVA: 0x1BCDDC8 Offset: 0x1BC9DC8 VA: 0x1BCDDC8
	private void SaveBuyKey() { }

	// RVA: 0x1BCDEE4 Offset: 0x1BC9EE4 VA: 0x1BCDEE4
	public void PopUpItemInfoWindow(int itemId, Action callback) { }

	[IteratorStateMachine(typeof(UIOrbShopManager.<PopUpItemInfo>d__67))]
	// RVA: 0x1BCDF0C Offset: 0x1BC9F0C VA: 0x1BCDF0C
	private IEnumerator PopUpItemInfo(int itemId, Action callback) { }

	// RVA: 0x1BCDFC4 Offset: 0x1BC9FC4 VA: 0x1BCDFC4
	private void OnPopWindowOK() { }

	// RVA: 0x1BCDFD0 Offset: 0x1BC9FD0 VA: 0x1BCDFD0
	public void OnOrbShardChangeEvent() { }

	// RVA: 0x1BCE074 Offset: 0x1BCA074 VA: 0x1BCE074
	public void OnShopGachaSkip() { }

	// RVA: 0x1BCE0B0 Offset: 0x1BCA0B0 VA: 0x1BCE0B0
	public void OnClickAvatarEquipButton() { }

	// RVA: 0x1BCE1C4 Offset: 0x1BCA1C4 VA: 0x1BCE1C4
	public void OnClickAvatarPreviewColorChange() { }

	// RVA: 0x1BCE220 Offset: 0x1BCA220 VA: 0x1BCE220 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BCE3E8 Offset: 0x1BCA3E8 VA: 0x1BCE3E8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BCE3F8 Offset: 0x1BCA3F8 VA: 0x1BCE3F8
	private void Close() { }

	// RVA: 0x1BCE554 Offset: 0x1BCA554 VA: 0x1BCE554
	public void .ctor() { }

	// RVA: 0x1BCE634 Offset: 0x1BCA634 VA: 0x1BCE634
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1BCE680 Offset: 0x1BCA680 VA: 0x1BCE680
	private void <Update>b__50_0() { }
}
