// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetShopBuyManager : UIBasePanelConnection // TypeDefIndex: 7725
{
	// Fields
	[SerializeField]
	private GameObject noListLabel; // 0x30
	[SerializeField]
	private UIScrollWindow saleScrollWindow; // 0x38
	[SerializeField]
	private UIPetShopBuyElement element; // 0x40
	[SerializeField]
	private GameObject scrollParent; // 0x48
	[SerializeField]
	private GameObject checkWindowObj; // 0x50
	[SerializeField]
	private UIPetStatusSkillCheck petSkillCheckPanel; // 0x58
	[SerializeField]
	private UILabel[] checkGoldLabels; // 0x60
	[SerializeField]
	private UIImageButton checkBuyButton; // 0x68
	[SerializeField]
	private GameObject completeWindowObj; // 0x70
	[SerializeField]
	private UILabel completeLabel; // 0x78
	[SerializeField]
	private UILabel completeGoldLabel; // 0x80
	[SerializeField]
	private UISprite completeWeaponIcon; // 0x88
	[SerializeField]
	private UILabel[] completePetLabels; // 0x90
	[SerializeField]
	private GameObject passwordInputWindow; // 0x98
	[SerializeField]
	private UIInput passwordInput; // 0xA0
	[SerializeField]
	private UIImageButton passwordConfirmButton; // 0xA8
	[SerializeField]
	private UILabel passwordNumTextLabel; // 0xB0
	private readonly float elementHeight; // 0xB8
	private List<HousePetSaleItemData> petSaleList; // 0xC0
	private Dictionary<int, UIPetShopBuyElement> elementList; // 0xC8
	private UIPetProfilePanel profilePanel; // 0xD0
	private UIPetShopBuyManager.PetShopInfoData selectInfoData; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private EnemyTextManager enemyTextManager; // 0xE8
	private UIPopWindow errorPopWindow; // 0xF0
	private int inputPassword; // 0xF8
	private int sendInputPassword; // 0xFC

	// Methods

	// RVA: 0x1BF1330 Offset: 0x1BED330 VA: 0x1BF1330
	private void Awake() { }

	// RVA: 0x1BF1768 Offset: 0x1BED768 VA: 0x1BF1768
	public void OnCheckBuyButton() { }

	// RVA: 0x1BF19F8 Offset: 0x1BED9F8 VA: 0x1BF19F8
	public void OnCompleteOkButton() { }

	// RVA: 0x1BF1A78 Offset: 0x1BEDA78 VA: 0x1BF1A78
	public void OnSubmitPassword() { }

	// RVA: 0x1BF1B64 Offset: 0x1BEDB64 VA: 0x1BF1B64
	public void OnConfirmPassword() { }

	// RVA: 0x1BF15F4 Offset: 0x1BED5F4 VA: 0x1BF15F4
	private void GetPetSales(Action callBack) { }

	// RVA: 0x1BF1D78 Offset: 0x1BEDD78 VA: 0x1BF1D78
	private void UpdateSaleList() { }

	// RVA: 0x1BF2544 Offset: 0x1BEE544 VA: 0x1BF2544
	private void OnBuy(int no) { }

	// RVA: 0x1BF2BE0 Offset: 0x1BEEBE0 VA: 0x1BF2BE0
	private void OpenCompleteWindow() { }

	// RVA: 0x1BF30A0 Offset: 0x1BEF0A0 VA: 0x1BF30A0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BF31F8 Offset: 0x1BEF1F8 VA: 0x1BF31F8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BF3254 Offset: 0x1BEF254 VA: 0x1BF3254
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1BF3384 Offset: 0x1BEF384 VA: 0x1BF3384
	private void <Awake>b__30_0() { }

	[CompilerGenerated]
	// RVA: 0x1BF33B0 Offset: 0x1BEF3B0 VA: 0x1BF33B0
	private void <OnCompleteOkButton>b__32_0() { }

	[CompilerGenerated]
	// RVA: 0x1BF3424 Offset: 0x1BEF424 VA: 0x1BF3424
	private void <OnConfirmPassword>b__34_1() { }
}
