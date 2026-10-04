// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetShopSellManager : UIBasePanelConnection // TypeDefIndex: 7742
{
	// Fields
	[SerializeField]
	private GameObject[] panelObjs; // 0x30
	[SerializeField]
	private GameObject selectSaleElement; // 0x38
	[SerializeField]
	private UIScrollWindow selectScrollWindow; // 0x40
	[SerializeField]
	private UIPetShopSellElement selectSellElement; // 0x48
	[SerializeField]
	private GameObject buySlotWindow; // 0x50
	[SerializeField]
	private GameObject buySlotBuyButtonObj; // 0x58
	[SerializeField]
	private GameObject[] buySlotHaveNumObj; // 0x60
	[SerializeField]
	private GameObject buySlotDecideButtonObj; // 0x68
	[SerializeField]
	private GameObject[] buySlotDecideButtons; // 0x70
	[SerializeField]
	private UIImageButton[] registButtons; // 0x78
	[SerializeField]
	private GameObject registMainPanel; // 0x80
	[SerializeField]
	private GameObject registWindowBaseObj; // 0x88
	[SerializeField]
	private GameObject registSelectMessageObj; // 0x90
	[SerializeField]
	private UIPetShopSellRegisterInput registInputGoldWindow; // 0x98
	[SerializeField]
	private GameObject registSelectScrollButton; // 0xA0
	[SerializeField]
	private GameObject registCompleteWindow; // 0xA8
	[SerializeField]
	private UISprite registCompleteWeaponIcon; // 0xB0
	[SerializeField]
	private UILabel[] registCompletePetLabels; // 0xB8
	[SerializeField]
	private UILabel registCompletePriceLabel; // 0xC0
	[SerializeField]
	private UILabel registCompleteMessageLabel; // 0xC8
	[SerializeField]
	private GameObject registNoPetLabelObj; // 0xD0
	[SerializeField]
	private GameObject checkWindowObj; // 0xD8
	[SerializeField]
	private UILabel checkWindowLabel; // 0xE0
	[SerializeField]
	private UILabel attentionLabel; // 0xE8
	[SerializeField]
	private UIToggle attentionToggle; // 0xF0
	[SerializeField]
	private UIImageButton[] registTargetButtons; // 0xF8
	[SerializeField]
	private GameObject passwordInputWindow; // 0x100
	[SerializeField]
	private UIInput passwordInput; // 0x108
	[SerializeField]
	private UIImageButton passwordConfirmButton; // 0x110
	private UIPetShopSellManager.SelectPetButton selectPetButton; // 0x118
	private UIPetShopSellManager.SelectPetButton prevSelectPetButton; // 0x120
	private HousePetSaleData petSaleData; // 0x128
	private HousePetSaleItemData[] petSaleDataList; // 0x130
	private List<PetDataManager.PetViewData> shopPetList; // 0x138
	private UIPetShopSellManager.PanelState panelState; // 0x140
	private const int BuySlotGold = 10000;
	private EnemyTextManager enemyTextManager; // 0x148
	private PlayerDataManager playerDataManager; // 0x150
	private UIScrollWindow registScrollWindow; // 0x158
	private PetDataManager petDataManager; // 0x160
	private List<PetDataManager.PetViewData> kennelPetList; // 0x168
	private UIPetProfilePanel profilePanel; // 0x170
	private List<UIPetShopSellManager.SelectPetButton> selectPetButtonList; // 0x178
	private UIPetShopSellManager.ExhabitSaleData exhabitSaleData; // 0x180
	private UIPopWindow errorPopWindow; // 0x188
	private Action errorPopAction; // 0x190
	private OrbManager orbManager; // 0x198
	private Vector3 sellListScrollCameraPos; // 0x1A0
	private Action checkWindowAction; // 0x1B0
	private bool isStartSale; // 0x1B8
	private GameManager gameManager; // 0x1C0
	private bool isDisconnect; // 0x1C8
	private HousePetSaleExhabitType selectExhabitType; // 0x1CC

	// Methods

	// RVA: 0x1BF5058 Offset: 0x1BF1058 VA: 0x1BF5058
	private void Start() { }

	// RVA: 0x1BF5630 Offset: 0x1BF1630 VA: 0x1BF5630
	private void Update() { }

	// RVA: 0x1BF5968 Offset: 0x1BF1968 VA: 0x1BF5968
	private void OnDestroy() { }

	// RVA: 0x1BF5A0C Offset: 0x1BF1A0C VA: 0x1BF5A0C
	public void ResponseSlotNum(byte slot) { }

	// RVA: 0x1BF5A1C Offset: 0x1BF1A1C VA: 0x1BF5A1C
	public void OnTopButton() { }

	// RVA: 0x1BF5A24 Offset: 0x1BF1A24 VA: 0x1BF5A24
	public void OnSelectItem() { }

	// RVA: 0x1BF6814 Offset: 0x1BF2814 VA: 0x1BF6814
	public void OnSelectPet(int param) { }

	// RVA: 0x1BF6A54 Offset: 0x1BF2A54 VA: 0x1BF6A54
	public void OnEnterPet() { }

	// RVA: 0x1BF7258 Offset: 0x1BF3258 VA: 0x1BF7258
	public void OnInputGold() { }

	// RVA: 0x1BF753C Offset: 0x1BF353C VA: 0x1BF753C
	public void CallBackInputGold(int price) { }

	// RVA: 0x1BF7580 Offset: 0x1BF3580 VA: 0x1BF7580
	public void OnRegistItem() { }

	// RVA: 0x1BF77BC Offset: 0x1BF37BC VA: 0x1BF77BC
	public void OnRegistComplete() { }

	// RVA: 0x1BF77C8 Offset: 0x1BF37C8 VA: 0x1BF77C8
	public void OnGetSalesButton() { }

	// RVA: 0x1BF79F0 Offset: 0x1BF39F0 VA: 0x1BF79F0
	public void OnCheckWindowOk() { }

	// RVA: 0x1BF7A0C Offset: 0x1BF3A0C VA: 0x1BF7A0C
	public void OnAttentionToggle() { }

	// RVA: 0x1BF7B70 Offset: 0x1BF3B70 VA: 0x1BF7B70
	public void OnBuySlotOrb() { }

	// RVA: 0x1BF7DC4 Offset: 0x1BF3DC4 VA: 0x1BF7DC4
	public void OnBuySlotGold() { }

	// RVA: 0x1BF7FC8 Offset: 0x1BF3FC8 VA: 0x1BF7FC8
	public void OnBuySlotDecideOrb() { }

	// RVA: 0x1BF81C8 Offset: 0x1BF41C8 VA: 0x1BF81C8
	public void OnBuySlotDeiceGold() { }

	// RVA: 0x1BF81CC Offset: 0x1BF41CC VA: 0x1BF81CC
	public void OnTarget(int param) { }

	// RVA: 0x1BF82D8 Offset: 0x1BF42D8 VA: 0x1BF82D8
	public void OnSubmitPassword() { }

	// RVA: 0x1BF83B4 Offset: 0x1BF43B4 VA: 0x1BF83B4
	public void OnConfirmPassword() { }

	// RVA: 0x1BF54B4 Offset: 0x1BF14B4 VA: 0x1BF54B4
	private void ChangePanelState(UIPetShopSellManager.PanelState panelState) { }

	// RVA: 0x1BF5484 Offset: 0x1BF1484 VA: 0x1BF5484
	private void UpdateKennelPetList() { }

	// RVA: 0x1BF83E4 Offset: 0x1BF43E4 VA: 0x1BF83E4
	private void UpdateSelectScrollWindow() { }

	// RVA: 0x1BF8EEC Offset: 0x1BF4EEC VA: 0x1BF8EEC
	private void OpenRegistPanel(int no) { }

	// RVA: 0x1BF9314 Offset: 0x1BF5314 VA: 0x1BF9314
	private void OpenBuySlotWindow() { }

	// RVA: 0x1BF7A28 Offset: 0x1BF3A28 VA: 0x1BF7A28
	private void UpdateRegistButton(bool isEnable) { }

	// RVA: 0x1BF6E8C Offset: 0x1BF2E8C VA: 0x1BF6E8C
	private void UpdatePriceButton() { }

	// RVA: 0x1BF6D6C Offset: 0x1BF2D6C VA: 0x1BF6D6C
	private void UpdateSelectPetProfile() { }

	[IteratorStateMachine(typeof(UIPetShopSellManager.<PanelClose>d__91))]
	// RVA: 0x1BF814C Offset: 0x1BF414C VA: 0x1BF814C
	private IEnumerator PanelClose(UIActiveState nextState) { }

	// RVA: 0x1BF7834 Offset: 0x1BF3834 VA: 0x1BF7834
	private void GetSales(int sales) { }

	// RVA: 0x1BF93D0 Offset: 0x1BF53D0 VA: 0x1BF93D0
	private void OpencCheckWindow(string mes, Action callBack) { }

	// RVA: 0x1BF9428 Offset: 0x1BF5428 VA: 0x1BF9428
	private void CloseCheckWindow() { }

	// RVA: 0x1BF55B4 Offset: 0x1BF15B4 VA: 0x1BF55B4
	private void StopSale() { }

	// RVA: 0x1BF596C Offset: 0x1BF196C VA: 0x1BF596C
	private void StartSale() { }

	// RVA: 0x1BF56D0 Offset: 0x1BF16D0 VA: 0x1BF56D0
	private void OpenDisconnectWindow() { }

	// RVA: 0x1BF8200 Offset: 0x1BF4200 VA: 0x1BF8200
	private void UpdateTargetButton() { }

	// RVA: 0x1BF94BC Offset: 0x1BF54BC VA: 0x1BF94BC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BF9814 Offset: 0x1BF5814 VA: 0x1BF9814 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BF9838 Offset: 0x1BF5838 VA: 0x1BF9838
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1BF9AB4 Offset: 0x1BF5AB4 VA: 0x1BF9AB4
	private void <Start>b__61_1() { }

	[CompilerGenerated]
	// RVA: 0x1BF9BC8 Offset: 0x1BF5BC8 VA: 0x1BF9BC8
	private void <OnRegistItem>b__71_1() { }

	[CompilerGenerated]
	// RVA: 0x1BFA0A8 Offset: 0x1BF60A8 VA: 0x1BFA0A8
	private void <OnBuySlotDecideOrb>b__78_1() { }

	[CompilerGenerated]
	// RVA: 0x1BFA258 Offset: 0x1BF6258 VA: 0x1BFA258
	private void <UpdateSelectScrollWindow>b__85_3() { }

	[CompilerGenerated]
	// RVA: 0x1BFA2C4 Offset: 0x1BF62C4 VA: 0x1BFA2C4
	private void <UpdateSelectScrollWindow>b__85_5() { }

	[CompilerGenerated]
	// RVA: 0x1BFA440 Offset: 0x1BF6440 VA: 0x1BFA440
	private void <UpdateSelectScrollWindow>b__85_1(int no) { }

	[CompilerGenerated]
	// RVA: 0x1BFA498 Offset: 0x1BF6498 VA: 0x1BFA498
	private void <UpdateSelectScrollWindow>b__85_6() { }

	[CompilerGenerated]
	// RVA: 0x1BFA4E0 Offset: 0x1BF64E0 VA: 0x1BFA4E0
	private bool <UpdateSelectPetProfile>b__90_0(PetDataManager.PetViewData x) { }

	[CompilerGenerated]
	// RVA: 0x1BFA514 Offset: 0x1BF6514 VA: 0x1BFA514
	private void <GetSales>b__92_1() { }
}
