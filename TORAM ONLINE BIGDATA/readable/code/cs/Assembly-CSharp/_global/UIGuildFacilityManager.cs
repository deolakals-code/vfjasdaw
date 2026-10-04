// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildFacilityManager : UIBasePanelConnection // TypeDefIndex: 6643
{
	// Fields
	[SerializeField]
	private GameObject framePanel; // 0x30
	[SerializeField]
	private UIImageButton[] topSelectButton; // 0x38
	[SerializeField]
	private GameObject listPanel; // 0x40
	[SerializeField]
	private GameObject buttonObject; // 0x48
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x50
	[SerializeField]
	private GameObject selectedPanel; // 0x58
	[SerializeField]
	private UIGuildFacilityButton[] selectFacilityButton; // 0x60
	[SerializeField]
	private UILabel selectedHaveItemNumLabel; // 0x68
	[SerializeField]
	private GameObject[] selectedHaveItems; // 0x70
	[SerializeField]
	private GameObject selectedHavePoint; // 0x78
	[SerializeField]
	private UILabel selectedUseItemNumLabel; // 0x80
	[SerializeField]
	private GameObject[] selectedUseItems; // 0x88
	[SerializeField]
	private GameObject selectedUsePoint; // 0x90
	[SerializeField]
	private GameObject selectedItemTypePanel; // 0x98
	[SerializeField]
	private UIImageButton levelUpButton; // 0xA0
	[SerializeField]
	private UILabel levelUpButtonLabel; // 0xA8
	[SerializeField]
	private GameObject connectionPanel; // 0xB0
	[SerializeField]
	private GameObject waitPanel; // 0xB8
	[SerializeField]
	private UISlider waitSlider; // 0xC0
	[SerializeField]
	private UIIconBase faclitiyIcon; // 0xC8
	[SerializeField]
	private UILabel[] faclitiyLabel; // 0xD0
	[SerializeField]
	private GameObject resultPanel; // 0xD8
	private GuildManager guildManager; // 0xE0
	private int selectedTab; // 0xE8
	private UIGuildFacilityManager.FacilityState state; // 0xEC
	private int selectedFacilityId; // 0xF0
	private List<UIGuildFacilityManager.FacilityRecipe> recipes; // 0xF8
	private List<ElementType> selectElementList; // 0x100
	private int currentElementIndex; // 0x108
	private ElementType selectElementType; // 0x10C
	private int selectedCurrentLevel; // 0x110
	private bool IsOtherUserUpdate; // 0x114

	// Methods

	[IteratorStateMachine(typeof(UIGuildFacilityManager.<Start>d__35))]
	// RVA: 0x19A2C50 Offset: 0x199EC50 VA: 0x19A2C50
	private IEnumerator Start() { }

	// RVA: 0x19A2CE4 Offset: 0x199ECE4 VA: 0x19A2CE4
	private bool LoadMaseterData(byte[] binary) { }

	// RVA: 0x19A35C0 Offset: 0x199F5C0 VA: 0x19A35C0
	private void UpdateSelectScrollList(int type) { }

	// RVA: 0x19A3E1C Offset: 0x199FE1C VA: 0x19A3E1C
	private void ItemPanelView(GameObject[] items, int num, ElementType type, bool zeroView) { }

	// RVA: 0x19A3FB0 Offset: 0x199FFB0 VA: 0x19A3FB0
	private bool ItemIconView(GameObject[] resutlItemPanel, int index, ElementType type, int num, bool zeroOn) { }

	// RVA: 0x19A41B8 Offset: 0x19A01B8 VA: 0x19A41B8
	private void PointIconView(GameObject pointObject, string text, string iconSprite) { }

	// RVA: 0x19A42EC Offset: 0x19A02EC VA: 0x19A42EC
	private bool UpdateSelectedFacility(int id) { }

	[IteratorStateMachine(typeof(UIGuildFacilityManager.<WaitConnectionTimer>d__42))]
	// RVA: 0x19A4DF4 Offset: 0x19A0DF4 VA: 0x19A4DF4
	private IEnumerator WaitConnectionTimer() { }

	// RVA: 0x19A4E88 Offset: 0x19A0E88 VA: 0x19A4E88
	public void ReceiveFacilityEvent() { }

	// RVA: 0x19A4E94 Offset: 0x19A0E94 VA: 0x19A4E94
	public void OnClick_SelectTab(int param) { }

	// RVA: 0x19A2BC4 Offset: 0x199EBC4 VA: 0x19A2BC4
	public void OnClick_SelectedFacility(int id) { }

	// RVA: 0x19A4F24 Offset: 0x19A0F24 VA: 0x19A4F24
	public void OnClick_SelectedUseItemType(int add) { }

	// RVA: 0x19A4FDC Offset: 0x19A0FDC VA: 0x19A4FDC
	public void OnClick_LevelUp() { }

	// RVA: 0x19A5084 Offset: 0x19A1084 VA: 0x19A5084
	public void OnClick_LevelUpCancel() { }

	// RVA: 0x19A50FC Offset: 0x19A10FC VA: 0x19A50FC
	public void OnClick_LevelResultEnd() { }

	// RVA: 0x19A51CC Offset: 0x19A11CC VA: 0x19A51CC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19A5318 Offset: 0x19A1318 VA: 0x19A5318 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19A53BC Offset: 0x19A13BC VA: 0x19A53BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19A5498 Offset: 0x19A1498 VA: 0x19A5498
	private bool <WaitConnectionTimer>b__42_0(UIGuildFacilityManager.FacilityRecipe x) { }

	[CompilerGenerated]
	// RVA: 0x19A54BC Offset: 0x19A14BC VA: 0x19A54BC
	private void <WaitConnectionTimer>b__42_4() { }
}
