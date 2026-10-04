// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipCristaPanel : UIEquipBasePanel // TypeDefIndex: 6921
{
	// Fields
	[SerializeField]
	private GameObject selectCristaEquipObject; // 0x28
	private UIEquipSlotButton selectCristaEquip; // 0x30
	private UILabel noSelectCristaLabel; // 0x38
	[SerializeField]
	private GameObject[] cristaCustomPanelObject; // 0x40
	private UIEquipCristaButton[] cristaCustomPanel; // 0x48
	[SerializeField]
	private GameObject cristaPanelAnchorObject; // 0x50
	private UIIruna2Anchor cristaPanelAnchor; // 0x58
	[SerializeField]
	private GameObject customCristaWindowSystemIcon; // 0x60
	[SerializeField]
	private GameObject customCristaWindowIcon; // 0x68
	[SerializeField]
	private GameObject basePanel; // 0x70
	[SerializeField]
	private GameObject cristaNoSelectedPanel; // 0x78
	[SerializeField]
	private GameObject selectedCristaPanel; // 0x80
	[SerializeField]
	private GameObject[] slotPanelObj; // 0x88
	private UIEquipCristaButton[] slotPanel; // 0x90
	[SerializeField]
	private GameObject expObj; // 0x98
	[SerializeField]
	private GameObject howToGetPanel; // 0xA0
	[SerializeField]
	private GameObject leftPanel; // 0xA8
	private UIIruna2Anchor leftAnchor; // 0xB0
	[SerializeField]
	private GameObject leftPanelScrollCamera; // 0xB8
	[SerializeField]
	private GameObject normalRightPanel; // 0xC0
	private UIIruna2Anchor normalRightAnchor; // 0xC8
	private UIScrollWindow normalCristaScrollWindow; // 0xD0
	[SerializeField]
	private GameObject extractRightPanel; // 0xD8
	private UIIruna2Anchor extractRightAnchor; // 0xE0
	private UIScrollWindow extractCristaScrollWindow; // 0xE8
	private UIItemPropertyStretch itemProperty; // 0xF0
	[SerializeField]
	private GameObject cristaItemElement; // 0xF8
	private List<ItemData> itemDataList; // 0x100
	private List<GameObject> buttonObjList; // 0x108
	[SerializeField]
	private GameObject selectLabelObj; // 0x110
	[SerializeField]
	private UIEquipPowerUpCristaPanel equipPowerUpCristaPanel; // 0x118
	[SerializeField]
	private UISprite selectExtractIcon; // 0x120
	private bool useExtractCristaFlag; // 0x128
	[SerializeField]
	private GameObject inputGoldObj; // 0x130
	[SerializeField]
	private GameObject attentionObj; // 0x138
	[SerializeField]
	private GameObject selectOpenSlotItemButton; // 0x140
	[SerializeField]
	private UIEquipMultiPowerUpCristaPanel multiPowerUpCristaPanel; // 0x148
	private UIEquipMainManager manager; // 0x150
	private PlayerDataManager playerDataManager; // 0x158
	private SystemTextManager systemTextManager; // 0x160
	private ItemTextManager itemTextManager; // 0x168
	private ItemDBData.EquipType selectedEquipType; // 0x170
	private int selectedItemUid; // 0x174
	private int selectedItemId; // 0x178
	private byte selectSlotId; // 0x17C
	private bool openItemList; // 0x17D
	private bool orbInitConnect; // 0x17E
	private Coroutine enableCoroutine; // 0x180
	private bool buttonPointUpFlag; // 0x188
	private int openSlotOrbItemId; // 0x18C
	private UILabel[] noSelectLabels; // 0x190
	private bool isPrevBattleActive; // 0x198
	private UIPopBaseWindow popWindow; // 0x1A0
	private string errorWindowText; // 0x1A8

	// Methods

	// RVA: 0x1A422AC Offset: 0x1A3E2AC VA: 0x1A422AC Slot: 5
	public override void Initialize(PlayerDataManager playerDataManager, IUIEquipMainManager manager) { }

	// RVA: 0x1A42D7C Offset: 0x1A3ED7C VA: 0x1A42D7C Slot: 6
	public override void Open() { }

	// RVA: 0x1A43154 Offset: 0x1A3F154 VA: 0x1A43154 Slot: 7
	public override void Close() { }

	// RVA: 0x1A43264 Offset: 0x1A3F264 VA: 0x1A43264 Slot: 8
	public override void SelectedEquipType(ItemDBData.EquipType equipType) { }

	// RVA: 0x1A43B20 Offset: 0x1A3FB20 VA: 0x1A43B20 Slot: 9
	public override bool Cancel() { }

	// RVA: 0x1A43DC0 Offset: 0x1A3FDC0 VA: 0x1A43DC0 Slot: 10
	public override bool Enter() { }

	[IteratorStateMachine(typeof(UIEquipCristaPanel.<EnterPopUpWindow>d__61))]
	// RVA: 0x1A443DC Offset: 0x1A403DC VA: 0x1A443DC
	private IEnumerator EnterPopUpWindow() { }

	// RVA: 0x1A44470 Offset: 0x1A40470 VA: 0x1A44470 Slot: 11
	public override void SelectedItem(ItemData itemData) { }

	// RVA: 0x1A44490 Offset: 0x1A40490 VA: 0x1A44490 Slot: 12
	public override string GetSelectedItemText(ItemData itemData) { }

	// RVA: 0x1A444D0 Offset: 0x1A404D0 VA: 0x1A444D0 Slot: 4
	public override bool InputLock() { }

	// RVA: 0x1A444D8 Offset: 0x1A404D8 VA: 0x1A444D8
	private void OpenCristaItemList(int id) { }

	// RVA: 0x1A46090 Offset: 0x1A42090 VA: 0x1A46090
	private void OpenExtractCristaItemList(int id) { }

	// RVA: 0x1A46D10 Offset: 0x1A42D10 VA: 0x1A46D10
	private List<ItemData> GetNormalCristaList() { }

	// RVA: 0x1A472E0 Offset: 0x1A432E0 VA: 0x1A472E0
	private List<ItemData> GetAllPowerUpCristaList() { }

	// RVA: 0x1A45044 Offset: 0x1A41044 VA: 0x1A45044
	private List<ItemData> GetCanEquipCristaList() { }

	// RVA: 0x1A465B8 Offset: 0x1A425B8 VA: 0x1A465B8
	private List<ItemData> GetPowerUpCristaList() { }

	// RVA: 0x1A4413C Offset: 0x1A4013C VA: 0x1A4413C
	private List<ItemData> GetPowerUpCristaOrderList(ItemData startItemData, int endItemId) { }

	// RVA: 0x1A47604 Offset: 0x1A43604 VA: 0x1A47604
	private List<ItemData> GetPowerUpCristaOrderList(int startItemId) { }

	// RVA: 0x1A47884 Offset: 0x1A43884 VA: 0x1A47884
	public void OnClearCristaSlot(int slotId) { }

	[IteratorStateMachine(typeof(UIEquipCristaPanel.<PopUpClearCristaSlot>d__74))]
	// RVA: 0x1A47918 Offset: 0x1A43918 VA: 0x1A47918
	private IEnumerator PopUpClearCristaSlot(int slotId) { }

	// RVA: 0x1A479BC Offset: 0x1A439BC VA: 0x1A479BC
	private void RemoveSpecificCrista(int uuid, byte slotId) { }

	// RVA: 0x1A47B7C Offset: 0x1A43B7C VA: 0x1A47B7C
	private void OpenErrorEditCristaWindow(string message) { }

	[IteratorStateMachine(typeof(UIEquipCristaPanel.<ErrorWindowProcess>d__77))]
	// RVA: 0x1A47B9C Offset: 0x1A43B9C VA: 0x1A47B9C
	private IEnumerator ErrorWindowProcess(string message) { }

	// RVA: 0x1A47C4C Offset: 0x1A43C4C VA: 0x1A47C4C
	private int CheckAddSlotOrbItemId(byte itemType, int slotNo) { }

	// RVA: 0x1A47D8C Offset: 0x1A43D8C VA: 0x1A47D8C
	private bool IsDoubleSlotTargetItem(byte type) { }

	// RVA: 0x1A47DA0 Offset: 0x1A43DA0 VA: 0x1A47DA0
	private void OnSelectItemOfOpenSlot(int itemId) { }

	// RVA: 0x1A47DA8 Offset: 0x1A43DA8 VA: 0x1A47DA8
	public void OnAddCristaSlot(int slotId) { }

	[IteratorStateMachine(typeof(UIEquipCristaPanel.<PopUpAddCristaSlot>d__82))]
	// RVA: 0x1A47E34 Offset: 0x1A43E34 VA: 0x1A47E34
	private IEnumerator PopUpAddCristaSlot(int slotId) { }

	// RVA: 0x1A432BC Offset: 0x1A3F2BC VA: 0x1A432BC
	private void UpdateDrawPanel() { }

	[IteratorStateMachine(typeof(UIEquipCristaPanel.<CheckOrbConnection>d__84))]
	// RVA: 0x1A428A0 Offset: 0x1A3E8A0 VA: 0x1A428A0
	private IEnumerator CheckOrbConnection() { }

	// RVA: 0x1A43D7C Offset: 0x1A3FD7C VA: 0x1A43D7C
	private void ChangeEquipButtonPointUp(int select, bool flag) { }

	[IteratorStateMachine(typeof(UIEquipCristaPanel.<ChangeObjectEnableToFalse>d__86))]
	// RVA: 0x1A431F8 Offset: 0x1A3F1F8 VA: 0x1A431F8
	private IEnumerator ChangeObjectEnableToFalse() { }

	// RVA: 0x1A42C20 Offset: 0x1A3EC20 VA: 0x1A42C20
	private void NoSelectCrista() { }

	// RVA: 0x1A45DFC Offset: 0x1A41DFC VA: 0x1A45DFC
	private void SetCristaLabel(GameObject obj, ItemData itemData, bool isPlusIcon = False) { }

	// RVA: 0x1A4290C Offset: 0x1A3E90C VA: 0x1A4290C
	private void UpdateBattleActiveUI() { }

	// RVA: 0x1A47F28 Offset: 0x1A43F28 VA: 0x1A47F28
	private void onSelectSlot(int param) { }

	// RVA: 0x1A4853C Offset: 0x1A4453C VA: 0x1A4853C
	private void onEdit(int param) { }

	// RVA: 0x1A48A70 Offset: 0x1A44A70 VA: 0x1A48A70
	private void onPowerUp(int param) { }

	// RVA: 0x1A48C3C Offset: 0x1A44C3C VA: 0x1A48C3C
	private void onCheckCristaProp(int param) { }

	// RVA: 0x1A49114 Offset: 0x1A45114 VA: 0x1A49114
	private void onUseExtractCrista() { }

	// RVA: 0x1A49190 Offset: 0x1A45190 VA: 0x1A49190
	private void onUsePowerUpCrista() { }

	// RVA: 0x1A49448 Offset: 0x1A45448 VA: 0x1A49448
	public void .ctor() { }
}
