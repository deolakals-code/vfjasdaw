// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightCharacterManager : UIBasePanelConnection // TypeDefIndex: 5836
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor menuPanelAnchor; // 0x30
	[SerializeField]
	private UIImageButton lootBoxButton; // 0x38
	[SerializeField]
	private UILabel lootBoxButtonLabel; // 0x40
	[SerializeField]
	private GameObject lootBoxButtonIcon; // 0x48
	[SerializeField]
	private UILabel lootBoxNeedSpinaLabel; // 0x50
	[SerializeField]
	private UILabel equipNumLabel; // 0x58
	[SerializeField]
	private GameObject[] costGuageObj; // 0x60
	[SerializeField]
	private UILabel bestScoreLabel; // 0x68
	[SerializeField]
	private UIIruna2Anchor spinaPanelAnchor; // 0x70
	[SerializeField]
	private UILabel spinaLabel; // 0x78
	[SerializeField]
	private UILabel subSpinaLabel; // 0x80
	[SerializeField]
	private GameObject fadePanelObject; // 0x88
	[SerializeField]
	private UICharacterModelBaseManager modelManager; // 0x90
	[SerializeField]
	private Camera viewportCamera; // 0x98
	[SerializeField]
	private UIBlackKnightLootBoxPopWindow lootBoxPopWinow; // 0xA0
	[SerializeField]
	private UIIruna2Anchor settingIconAnchor; // 0xA8
	[SerializeField]
	private UIBlackKnightEquipCristaPanel equipCristaPanel; // 0xB0
	[SerializeField]
	private GameObject optionPanel; // 0xB8
	[SerializeField]
	private GameObject optionChangeAvatarObj; // 0xC0
	[SerializeField]
	private GameObject[] optionAvatarButtons; // 0xC8
	[SerializeField]
	private GameObject optionDeleteSaveDataObj; // 0xD0
	private BlackKnightRoomData roomData; // 0xD8
	private Dictionary<BlackKnightAvatarType, GameObject> playerObjList; // 0xE0
	private PlayerDataManager playerDataManager; // 0xE8
	private bool activePopUpWindow; // 0xF0

	// Methods

	// RVA: 0x17FDAA8 Offset: 0x17F9AA8 VA: 0x17FDAA8
	private void Start() { }

	// RVA: 0x17FE70C Offset: 0x17FA70C VA: 0x17FE70C
	private void OnDestroy() { }

	// RVA: 0x17FEA78 Offset: 0x17FAA78 VA: 0x17FEA78
	public void UpdateGold() { }

	// RVA: 0x17FEB14 Offset: 0x17FAB14 VA: 0x17FEB14
	public void OnClick(int param) { }

	// RVA: 0x17FFEA0 Offset: 0x17FBEA0 VA: 0x17FFEA0
	public void OnOption(int param) { }

	// RVA: 0x17FFFE8 Offset: 0x17FBFE8 VA: 0x17FFFE8
	public void OnChangeAvatar(int param) { }

	// RVA: 0x17FE518 Offset: 0x17FA518 VA: 0x17FE518
	private void ChangeEnableLootBoxButton(bool isMax, int gold, int haveCrista) { }

	[IteratorStateMachine(typeof(UIBlackKnightCharacterManager.<UpdateGold>d__33))]
	// RVA: 0x180020C Offset: 0x17FC20C VA: 0x180020C
	private IEnumerator UpdateGold(int add) { }

	[IteratorStateMachine(typeof(UIBlackKnightCharacterManager.<GameStart>d__34))]
	// RVA: 0x17FFE2C Offset: 0x17FBE2C VA: 0x17FFE2C
	private IEnumerator GameStart() { }

	[IteratorStateMachine(typeof(UIBlackKnightCharacterManager.<LoadModel>d__35))]
	// RVA: 0x17FE690 Offset: 0x17FA690 VA: 0x17FE690
	private IEnumerator LoadModel(BlackKnightAvatarType type) { }

	// RVA: 0x1800300 Offset: 0x17FC300 VA: 0x1800300
	private void UpdateModel() { }

	// RVA: 0x180035C Offset: 0x17FC35C VA: 0x180035C
	private void SetEquipItemModel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x1800404 Offset: 0x17FC404 VA: 0x1800404
	private void FocusSetEquipItemModel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	[IteratorStateMachine(typeof(UIBlackKnightCharacterManager.<OpenLootBoxModel>d__39))]
	// RVA: 0x1800628 Offset: 0x17FC628 VA: 0x1800628
	private IEnumerator OpenLootBoxModel() { }

	[IteratorStateMachine(typeof(UIBlackKnightCharacterManager.<DeletaWait>d__40))]
	// RVA: 0x17FFF7C Offset: 0x17FBF7C VA: 0x17FFF7C
	private IEnumerator DeletaWait() { }

	// RVA: 0x18006E4 Offset: 0x17FC6E4 VA: 0x18006E4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1800E54 Offset: 0x17FCE54 VA: 0x1800E54 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1801308 Offset: 0x17FD308 VA: 0x1801308 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x180130C Offset: 0x17FD30C VA: 0x180130C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18013E0 Offset: 0x17FD3E0 VA: 0x18013E0
	private void <OnClick>b__29_1() { }

	[CompilerGenerated]
	// RVA: 0x18014E8 Offset: 0x17FD4E8 VA: 0x18014E8
	private void <OnLeftTopButton>b__41_1() { }

	[CompilerGenerated]
	// RVA: 0x18017E4 Offset: 0x17FD7E4 VA: 0x18017E4
	private void <OnRightTopButton>b__42_1() { }
}
