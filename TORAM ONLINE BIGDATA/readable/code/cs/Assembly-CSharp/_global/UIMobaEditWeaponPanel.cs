// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaEditWeaponPanel : MonoBehaviour, UIMobaEditBasePanel // TypeDefIndex: 6079
{
	// Fields
	[SerializeField]
	private GameObject[] panelObjs; // 0x20
	[SerializeField]
	private GameObject[] overBasePanel; // 0x28
	[SerializeField]
	private UISprite weaponIcon; // 0x30
	[SerializeField]
	private UILabel goldLabel; // 0x38
	[SerializeField]
	private UISprite[] equiptWeaponIcons; // 0x40
	[SerializeField]
	private UILabel[] equipWeaponAtkLabels; // 0x48
	[SerializeField]
	private UILabel[] equipWeaponRefineLabels; // 0x50
	[SerializeField]
	private UISprite equipSubWeaponBatsuIcon; // 0x58
	[SerializeField]
	private GameObject ninjutsuWindow; // 0x60
	[SerializeField]
	private UISprite[] ninjutsuButtonIcon; // 0x68
	[SerializeField]
	private UIImageButton ninjutsuOkButton; // 0x70
	[SerializeField]
	private UIImageButton[] actionButtons; // 0x78
	[SerializeField]
	private UILabel buyButtonLabel; // 0x80
	[SerializeField]
	private UISprite buyPanelIcon; // 0x88
	[SerializeField]
	private UILabel buyPanelLabel; // 0x90
	[SerializeField]
	private UILabel buyPanelAtkLabel; // 0x98
	[SerializeField]
	private UILabel sellPanelLabel; // 0xA0
	[SerializeField]
	private UILabel refineButtonLabel; // 0xA8
	[SerializeField]
	private GameObject refineButtonIcon; // 0xB0
	[SerializeField]
	private UILabel refinePanelLabel; // 0xB8
	[SerializeField]
	private UISprite nowParamWeaponIcon; // 0xC0
	private UIMobaEditWeaponPanel.PanelType nowPanelType; // 0xC8
	private MobaRoomData mobaRoomData; // 0xD0
	private SystemTextManager systemTextManager; // 0xD8
	private List<GameObject> weaponIconList; // 0xE0
	private List<int> selectNinjutsuList; // 0xE8
	private ItemType selectItemType; // 0xF0
	private UIMobaEditWeaponPanel.WeaponType selectWeaponType; // 0xF4
	private int[] weaponRefine; // 0xF8
	private bool isWeaponUpdate; // 0x100
	private int buyWeaponAtk; // 0x104
	private int buyWeaponPrice; // 0x108
	private int sellWeaponPrice; // 0x10C
	private byte nextRefine; // 0x110
	private int refinePrice; // 0x114
	private UIMobaMainGamePanel mainPanel; // 0x118

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x187A1D8 Offset: 0x18761D8 VA: 0x187A1D8 Slot: 9
	public bool get_IsActive() { }

	// RVA: 0x187A1F8 Offset: 0x18761F8 VA: 0x187A1F8 Slot: 4
	public void Initialize(MobaRoomData mobaRoomData, UIMobaMainGamePanel mainPanel) { }

	[IteratorStateMachine(typeof(UIMobaEditWeaponPanel.<FadeIn>d__42))]
	// RVA: 0x187A370 Offset: 0x1876370 VA: 0x187A370 Slot: 7
	public IEnumerator FadeIn() { }

	[IteratorStateMachine(typeof(UIMobaEditWeaponPanel.<FadeOut>d__43))]
	// RVA: 0x187A404 Offset: 0x1876404 VA: 0x187A404 Slot: 8
	public IEnumerator FadeOut() { }

	[IteratorStateMachine(typeof(UIMobaEditWeaponPanel.<PushLeftTopButton>d__44))]
	// RVA: 0x187A498 Offset: 0x1876498 VA: 0x187A498 Slot: 5
	public IEnumerator PushLeftTopButton(Action<bool> stayCheck) { }

	[IteratorStateMachine(typeof(UIMobaEditWeaponPanel.<PushRightTopButton>d__45))]
	// RVA: 0x187A548 Offset: 0x1876548 VA: 0x187A548 Slot: 6
	public IEnumerator PushRightTopButton(Action<bool> stayCheck) { }

	// RVA: 0x187A5F8 Offset: 0x18765F8 VA: 0x187A5F8
	public void OnSelectWeapon(int param) { }

	// RVA: 0x187BD54 Offset: 0x1877D54 VA: 0x187BD54
	public void OnWeaponIcon(int param) { }

	// RVA: 0x187BFE8 Offset: 0x1877FE8 VA: 0x187BFE8
	public void OnNinjutsuFrameIcon(int param) { }

	// RVA: 0x187C0E0 Offset: 0x18780E0 VA: 0x187C0E0
	public void OnNinjutsuSkillIcon(int param) { }

	// RVA: 0x187C2D8 Offset: 0x18782D8 VA: 0x187C2D8
	public void OnNinjutsuOk() { }

	// RVA: 0x187C3D4 Offset: 0x18783D4 VA: 0x187C3D4
	public void OnBuy() { }

	// RVA: 0x187C4B4 Offset: 0x18784B4 VA: 0x187C4B4
	public void OnSell() { }

	// RVA: 0x187C594 Offset: 0x1878594 VA: 0x187C594
	public void OnRefine() { }

	// RVA: 0x187BCE4 Offset: 0x1877CE4 VA: 0x187BCE4
	private void ChangePanel(UIMobaEditWeaponPanel.PanelType type) { }

	// RVA: 0x187C674 Offset: 0x1878674 VA: 0x187C674
	private void UpdateGold() { }

	// RVA: 0x187B210 Offset: 0x1877210 VA: 0x187B210
	private void CreateWeaponIcon(List<int> itemTypeList) { }

	// RVA: 0x187B078 Offset: 0x1877078 VA: 0x187B078
	private void DestroyWeaponIcon() { }

	// RVA: 0x187BE98 Offset: 0x1877E98 VA: 0x187BE98
	private void UpdateNinjutsuOkButton() { }

	// RVA: 0x187C33C Offset: 0x187833C VA: 0x187C33C
	private bool CloseNinjutsuWindow() { }

	// RVA: 0x187C6AC Offset: 0x18786AC VA: 0x187C6AC
	private void UpdateEquipWeaponData() { }

	// RVA: 0x187CCCC Offset: 0x1878CCC VA: 0x187CCCC
	private string RefineToString(int refine) { }

	// RVA: 0x187B6F8 Offset: 0x18776F8 VA: 0x187B6F8
	private void UpdateActionPanel() { }

	// RVA: 0x187CC48 Offset: 0x1878C48 VA: 0x187CC48
	private string GetItemText(ItemDBData.ItemType itemType) { }

	// RVA: 0x187AB9C Offset: 0x1876B9C VA: 0x187AB9C
	private List<int> GetSubWeaponList(ItemType itemType) { }

	[IteratorStateMachine(typeof(UIMobaEditWeaponPanel.<Buy>d__65))]
	// RVA: 0x187C448 Offset: 0x1878448 VA: 0x187C448
	private IEnumerator Buy() { }

	[IteratorStateMachine(typeof(UIMobaEditWeaponPanel.<Sell>d__66))]
	// RVA: 0x187C528 Offset: 0x1878528 VA: 0x187C528
	private IEnumerator Sell() { }

	[IteratorStateMachine(typeof(UIMobaEditWeaponPanel.<Refine>d__67))]
	// RVA: 0x187C608 Offset: 0x1878608 VA: 0x187C608
	private IEnumerator Refine() { }

	// RVA: 0x187D0F0 Offset: 0x18790F0 VA: 0x187D0F0
	public void .ctor() { }
}
