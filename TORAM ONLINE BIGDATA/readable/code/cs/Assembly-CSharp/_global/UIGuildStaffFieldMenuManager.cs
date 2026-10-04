// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffFieldMenuManager : UIBasePanelConnection // TypeDefIndex: 6678
{
	// Fields
	[SerializeField]
	private UISprite titleIcon; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject mainPanel; // 0x40
	[SerializeField]
	private GameObject menuPanel; // 0x48
	[SerializeField]
	private GameObject menuButtonElement; // 0x50
	[SerializeField]
	private GameObject checkButton; // 0x58
	private UIToggle[] checkButtonList; // 0x60
	[SerializeField]
	private UIScrollWindow menuScrollWindow; // 0x68
	[SerializeField]
	private GameObject playerViewPanel; // 0x70
	[SerializeField]
	private GameObject battleErrLabel; // 0x78
	[SerializeField]
	private GameObject[] shopPanel; // 0x80
	private UIBasePanel[] panel; // 0x88
	private UIBasePanel activePanel; // 0x90
	private UIGuildStaffFieldMenuManager.PanelState activeSelectedPanel; // 0x98
	private bool isUsedShop; // 0x9C
	private bool isBattleLock; // 0x9D
	private PlayerDataManager playerDataManager; // 0xA0
	private UICharacterModelBaseManager modelManager; // 0xA8
	private NewArchetypeProperties archetypeProperties; // 0xB0
	private int motionId; // 0xB8
	private byte supportType; // 0xBC
	private UILabel waitActionButtonLabel; // 0xC0

	// Properties
	public bool IsPopUpWindow { get; }

	// Methods

	// RVA: 0x19B5EA8 Offset: 0x19B1EA8 VA: 0x19B5EA8
	public bool get_IsPopUpWindow() { }

	// RVA: 0x19B5EB0 Offset: 0x19B1EB0 VA: 0x19B5EB0
	private void Start() { }

	// RVA: 0x19B674C Offset: 0x19B274C VA: 0x19B674C
	private void OnDestroy() { }

	// RVA: 0x19B6948 Offset: 0x19B2948 VA: 0x19B6948
	private void Update() { }

	// RVA: 0x19B6394 Offset: 0x19B2394 VA: 0x19B6394
	public void ChangeTitleLabel(string icon, string title) { }

	// RVA: 0x19B6C28 Offset: 0x19B2C28 VA: 0x19B6C28
	public void ChangeStaffViewEnable(bool isEnable) { }

	// RVA: 0x19B6C7C Offset: 0x19B2C7C VA: 0x19B6C7C
	public void OnSelectMenu(int param) { }

	// RVA: 0x19B63D8 Offset: 0x19B23D8 VA: 0x19B63D8
	private void InitMainMenu() { }

	// RVA: 0x19B789C Offset: 0x19B389C VA: 0x19B789C
	private void AddCheckMenuButton(UIGuildStaffFieldMenuManager.PanelState type, Vector3 pos, int index, bool isActive) { }

	// RVA: 0x19B7600 Offset: 0x19B3600 VA: 0x19B7600
	private GameObject AddMenuButton(UIGuildStaffFieldMenuManager.PanelState type, bool isSystem, string spriteName, Vector3 pos) { }

	// RVA: 0x19B7274 Offset: 0x19B3274 VA: 0x19B7274
	private void ActiveShopPanel(int id, UIGuildStaffFieldMenuManager.PanelState param, string shopName) { }

	// RVA: 0x19B6750 Offset: 0x19B2750 VA: 0x19B6750
	private void CloseShop() { }

	// RVA: 0x19B7AF4 Offset: 0x19B3AF4 VA: 0x19B7AF4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19B7E68 Offset: 0x19B3E68 VA: 0x19B7E68 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19B81DC Offset: 0x19B41DC VA: 0x19B81DC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19B8280 Offset: 0x19B4280 VA: 0x19B8280
	private void <CloseShop>b__35_1() { }
}
