// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetMenuManager : UIBaseMenuPanel // TypeDefIndex: 7809
{
	// Fields
	private UIPetMenuManager.PetMenuType menuType; // 0x7C
	private bool Lock; // 0x80
	private Action backAction; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private PetDataManager petDataManager; // 0x98
	private List<PetDataManager.PetViewData> petViewDataList; // 0xA0
	private bool hungryPetFlag; // 0xA8
	private UIPetManager petManager; // 0xB0
	private readonly Dictionary<UIPetMenuManager.PetMenuType, UIPetMenuManager.petMenuData> typeKey; // 0xB8
	private List<int> buttonKeyParam; // 0xC0
	private HouseManager houseManager; // 0xC8
	private const int PETSHOPITEMID = 1500153;

	// Methods

	// RVA: 0x1C24188 Offset: 0x1C20188 VA: 0x1C24188
	private void Awake() { }

	// RVA: 0x1C24A80 Offset: 0x1C20A80 VA: 0x1C24A80 Slot: 7
	protected override void Start() { }

	// RVA: 0x1C24CC8 Offset: 0x1C20CC8 VA: 0x1C24CC8 Slot: 11
	protected override void OnClickButton(int index) { }

	// RVA: 0x1C2508C Offset: 0x1C2108C VA: 0x1C2508C
	protected void SetButton(string text, float y, int id, bool iconFlag) { }

	// RVA: 0x1C255D4 Offset: 0x1C215D4 VA: 0x1C255D4
	private void OnHoverButton(int id) { }

	// RVA: 0x1C256B0 Offset: 0x1C216B0 VA: 0x1C256B0 Slot: 13
	protected override PopUpMessageWindow AdviceMessageData() { }

	// RVA: 0x1C259D8 Offset: 0x1C219D8 VA: 0x1C259D8 Slot: 14
	protected override void AdviceMessageButton() { }

	// RVA: 0x1C2483C Offset: 0x1C2083C VA: 0x1C2483C
	private void SetAdviceMessage() { }

	[IteratorStateMachine(typeof(UIPetMenuManager.<InitScroll>d__23))]
	// RVA: 0x1C24C5C Offset: 0x1C20C5C VA: 0x1C24C5C
	private IEnumerator InitScroll() { }

	// RVA: 0x1C25A34 Offset: 0x1C21A34 VA: 0x1C25A34 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C25A84 Offset: 0x1C21A84 VA: 0x1C25A84 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C25A98 Offset: 0x1C21A98 VA: 0x1C25A98
	public void .ctor() { }
}
