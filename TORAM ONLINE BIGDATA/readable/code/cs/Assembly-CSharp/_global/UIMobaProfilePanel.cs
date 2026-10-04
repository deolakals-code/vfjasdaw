// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaProfilePanel : UIBasePanelConnection // TypeDefIndex: 6108
{
	// Fields
	[SerializeField]
	private GameObject[] panelObjs; // 0x30
	[SerializeField]
	private UIScrollWindow mainScrollWindow; // 0x38
	[SerializeField]
	private UILabel[] mainMenuButtonLabels; // 0x40
	[SerializeField]
	private UILabel elementSelectLabel; // 0x48
	[SerializeField]
	private UILabel[] defenceSelectLabels; // 0x50
	[SerializeField]
	private GameObject[] defenceSelectButtonObjs; // 0x58
	[SerializeField]
	private GameObject defenceOkButtonObj; // 0x60
	[SerializeField]
	private UILabel defencePointLabel; // 0x68
	[SerializeField]
	private UIImageButton okButton; // 0x70
	[SerializeField]
	private UILabel messageLabel; // 0x78
	[SerializeField]
	private UIInput nameInput; // 0x80
	[SerializeField]
	private UIImageButton nameOkButton; // 0x88
	[SerializeField]
	private GameObject[] duelAbilityButtons; // 0x90
	[SerializeField]
	private UILabel duelAbilityCostLabel; // 0x98
	[SerializeField]
	private UIIruna2Anchor duelAbiPropAnchor; // 0xA0
	[SerializeField]
	private UIScrollWindow duelAbiScrollWindow; // 0xA8
	[SerializeField]
	private GameObject duelAbilityElement; // 0xB0
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0xB8
	private UIMobaProfilePanel.MenuType nowMenuType; // 0xBC
	private PlayerDataManager playerDataManager; // 0xC0
	private MobaDataManager mobaDataManager; // 0xC8
	private MobaProfileData nowProfileData; // 0xD0
	private UIMobaProfilePanel.ClientMobaProfileData updateProfileData; // 0xD8
	private byte changeElement; // 0xE0
	private byte[] changeDefence; // 0xE8
	private const int DefenceMax = 12;
	private string inputText; // 0xF0
	private UILabel nameInputOkLabel; // 0xF8
	private int[] changeDuelAbility; // 0x100
	private int selectDuelAbiParam; // 0x108
	private int selectDuelAbiButtonParam; // 0x10C
	private Dictionary<int, GameObject> duelAbiButtonList; // 0x110
	private const byte DuelAbilityCost = 7;
	private readonly Dictionary<int, byte> duelAbilityCostList; // 0x118
	private const float DuelAbilityButtonHeight = 100;

	// Properties
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1885BE8 Offset: 0x1881BE8 VA: 0x1885BE8
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x1885BF0 Offset: 0x1881BF0 VA: 0x1885BF0
	private void set_IsClose(bool value) { }

	// RVA: 0x1885BFC Offset: 0x1881BFC VA: 0x1885BFC
	private void Start() { }

	// RVA: 0x18865B8 Offset: 0x18825B8 VA: 0x18865B8
	private void Update() { }

	// RVA: 0x18869C8 Offset: 0x18829C8 VA: 0x18869C8
	public void OnMainMenu(int param) { }

	// RVA: 0x1886A54 Offset: 0x1882A54 VA: 0x1886A54
	public void OnMainOk() { }

	// RVA: 0x1886C80 Offset: 0x1882C80 VA: 0x1886C80
	public void OnMessageOk() { }

	// RVA: 0x1886D48 Offset: 0x1882D48 VA: 0x1886D48
	public void OnSelectElement(int param) { }

	// RVA: 0x1886EC4 Offset: 0x1882EC4 VA: 0x1886EC4
	public void OnElementOk() { }

	// RVA: 0x1886F5C Offset: 0x1882F5C VA: 0x1886F5C
	public void OnSelectNormalDefence(int param) { }

	// RVA: 0x1887048 Offset: 0x1883048 VA: 0x1887048
	public void OnSelectPhysicalDefence(int param) { }

	// RVA: 0x1887054 Offset: 0x1883054 VA: 0x1887054
	public void OnSelectMagicDefence(int param) { }

	// RVA: 0x1887060 Offset: 0x1883060 VA: 0x1887060
	public void OnDefenceOk() { }

	// RVA: 0x1887100 Offset: 0x1883100 VA: 0x1887100
	public void OnSelectDuelAbility(int param) { }

	// RVA: 0x18877F0 Offset: 0x18837F0 VA: 0x18877F0
	public void OnSelectDuelAbilityList(int param) { }

	// RVA: 0x1887EF4 Offset: 0x1883EF4 VA: 0x1887EF4
	public void OnEquipDeulAbility() { }

	// RVA: 0x1887F5C Offset: 0x1883F5C VA: 0x1887F5C
	public void OnDuelAbilityOk() { }

	// RVA: 0x1888028 Offset: 0x1884028 VA: 0x1888028
	public void OnNameOk() { }

	// RVA: 0x18880C4 Offset: 0x18840C4 VA: 0x18880C4
	public void OnNameInput() { }

	// RVA: 0x18880C8 Offset: 0x18840C8 VA: 0x18880C8
	public void OnNameSubmit() { }

	// RVA: 0x1885F54 Offset: 0x1881F54 VA: 0x1885F54
	private void InitUpdateProfileData() { }

	// RVA: 0x1886224 Offset: 0x1882224 VA: 0x1886224
	private void ChangePanel(UIMobaProfilePanel.MenuType type, string message = "") { }

	// RVA: 0x1886DF8 Offset: 0x1882DF8 VA: 0x1886DF8
	private void UpdateChangeElementLabel() { }

	// RVA: 0x1886F68 Offset: 0x1882F68 VA: 0x1886F68
	private void UpdateChangeDefenceParam(UIMobaProfilePanel.DefenceType type, int param) { }

	// RVA: 0x1888178 Offset: 0x1884178 VA: 0x1888178
	private void UpdateChangeDefenceLabel() { }

	// RVA: 0x18885E0 Offset: 0x18845E0 VA: 0x18885E0
	private void UpdateChangeDuelAbilityLabel() { }

	// RVA: 0x1887E3C Offset: 0x1883E3C VA: 0x1887E3C
	private void CloseDuelAbilitySelect(int param) { }

	// RVA: 0x1886698 Offset: 0x1882698 VA: 0x1886698
	private void UpdateDuelAbilityElementActive() { }

	// RVA: 0x1886AE0 Offset: 0x1882AE0 VA: 0x1886AE0
	private bool CheckDiffProfileData() { }

	[IteratorStateMachine(typeof(UIMobaProfilePanel.<SaveProfile>d__68))]
	// RVA: 0x1886C14 Offset: 0x1882C14 VA: 0x1886C14
	private IEnumerator SaveProfile() { }

	[IteratorStateMachine(typeof(UIMobaProfilePanel.<CloseMenuSaveProfile>d__69))]
	// RVA: 0x1888A58 Offset: 0x1884A58 VA: 0x1888A58
	private IEnumerator CloseMenuSaveProfile(UIActiveState state) { }

	// RVA: 0x1886160 Offset: 0x1882160 VA: 0x1886160
	private bool CheckConditions() { }

	// RVA: 0x188895C Offset: 0x188495C VA: 0x188895C
	private void InitNameInput(string baseName) { }

	[IteratorStateMachine(typeof(UIMobaProfilePanel.<NameCheck>d__72))]
	// RVA: 0x18880E8 Offset: 0x18840E8 VA: 0x18880E8
	private IEnumerator NameCheck() { }

	// RVA: 0x1888B24 Offset: 0x1884B24 VA: 0x1888B24 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1888CC8 Offset: 0x1884CC8 VA: 0x1888CC8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1888D9C Offset: 0x1884D9C VA: 0x1888D9C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x188934C Offset: 0x188534C VA: 0x188934C
	private void <SaveProfile>b__68_1() { }
}
