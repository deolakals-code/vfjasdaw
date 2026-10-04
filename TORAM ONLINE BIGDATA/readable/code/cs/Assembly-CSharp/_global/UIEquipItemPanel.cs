// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipItemPanel : UIEquipBasePanel // TypeDefIndex: 6945
{
	// Fields
	[SerializeField]
	private UILabel statusLabel; // 0x28
	[SerializeField]
	private UISprite statusIcon; // 0x30
	[SerializeField]
	private GameObject playerViewAnchorObject; // 0x38
	private UIIruna2Anchor playerViewAnchor; // 0x40
	[SerializeField]
	private GameObject recycleButton; // 0x48
	[SerializeField]
	private GameObject favoriteaButton; // 0x50
	private UILabel favoriteaLabel; // 0x58
	[SerializeField]
	private GameObject scrollWindowObject; // 0x60
	private UIScrollWindow scrollWindow; // 0x68
	[SerializeField]
	private GameObject scrollCameraPanel; // 0x70
	[SerializeField]
	private UILabel scrollLabel; // 0x78
	[SerializeField]
	private GameObject scrollCategoryObject; // 0x80
	private UIScrollWindow scrollCategoryWindow; // 0x88
	private UIIruna2Anchor scrollCategoryWindowAnchor; // 0x90
	[SerializeField]
	private GameObject scrollCategoryButtonObject; // 0x98
	[SerializeField]
	private UILabel animationButtonLabel; // 0xA0
	[SerializeField]
	private UIEquipSlotButton[] avatarEquipSlotButton; // 0xA8
	[SerializeField]
	private GameObject avatarRecyclePanel; // 0xB0
	[SerializeField]
	private UILabel recycleMesLabel; // 0xB8
	[SerializeField]
	private UIImageButton recycleStarGemButton; // 0xC0
	[SerializeField]
	private UIEquipRecycleStarGemPanel starGemPanel; // 0xC8
	[SerializeField]
	private GameObject noAvatarObj; // 0xD0
	[SerializeField]
	private UILabel noAvatarLabel; // 0xD8
	[SerializeField]
	private UICamera categoryCamera; // 0xE0
	[SerializeField]
	private GameObject searchObj; // 0xE8
	[SerializeField]
	private GameObject[] scrollAreaObjs; // 0xF0
	[SerializeField]
	private UIInput searchInput; // 0xF8
	[SerializeField]
	private UIImageButton searchButton; // 0x100
	[SerializeField]
	private GameObject searchElement; // 0x108
	private UIEquipMainManager manager; // 0x110
	private PlayerDataManager playerDataManager; // 0x118
	private OrbEquipItemManager orbEquipItemManager; // 0x120
	private ItemDBData.EquipType selectedEquipType; // 0x128
	private UICharacterModelBaseManager modelManager; // 0x130
	private SystemTextManager systemTextManager; // 0x138
	private ItemTextManager itemTextManager; // 0x140
	private ItemPropertyTextManager itemPropertyTextManager; // 0x148
	private Dictionary<int, List<ItemData>> avatarItemList; // 0x150
	private bool selectedAvatarCategory; // 0x158
	private int selectedAvatarCategoryType; // 0x15C
	private ItemDBData.ItemType selectAvaterItemType; // 0x160
	private int recycleStarGemMax; // 0x164
	private int equipedAttackStatus; // 0x168
	private int equipedDefenseStatus; // 0x16C
	private int selectedItemUid; // 0x170
	private ItemData selectedItemData; // 0x178
	private ItemData holdItemData; // 0x180
	private BonusType[] updateBonusTypes; // 0x188
	private bool loopMotion; // 0x190
	private byte sex; // 0x191
	private int animationId; // 0x194
	private int readyMotion; // 0x198
	private int waitMotion; // 0x19C
	private int clearMotion; // 0x1A0
	private float animationTime; // 0x1A4
	private ItemDBData.ItemType weaponType; // 0x1A8
	private ItemDBData.ItemType subWeaponType; // 0x1AC
	private List<AnimationClip> animationClipList; // 0x1B0
	private List<ItemData> newAvatarEquipList; // 0x1B8
	private List<ItemData> newPrintItemList; // 0x1C0
	private const int newAvatarCategory = -10;
	private const int searchCategory = -11;
	private Dictionary<int, string> itemNameList; // 0x1C8
	private Dictionary<int, string> itemPropNameList; // 0x1D0
	private List<UIButtonSendCallAction> addSearchElementList; // 0x1D8
	private int selectSearchParam; // 0x1E0
	private bool isOpenSearchItemList; // 0x1E4
	private BonusType[] searchBonusType; // 0x1E8

	// Methods

	// RVA: 0x1A50ED0 Offset: 0x1A4CED0 VA: 0x1A50ED0 Slot: 5
	public override void Initialize(PlayerDataManager playerDataManager, IUIEquipMainManager manager) { }

	// RVA: 0x1A5201C Offset: 0x1A4E01C VA: 0x1A5201C Slot: 6
	public override void Open() { }

	// RVA: 0x1A52108 Offset: 0x1A4E108 VA: 0x1A52108 Slot: 7
	public override void Close() { }

	// RVA: 0x1A52024 Offset: 0x1A4E024 VA: 0x1A52024
	public void MoveOpen() { }

	// RVA: 0x1A52110 Offset: 0x1A4E110 VA: 0x1A52110
	public void MoveClose() { }

	// RVA: 0x1A521E0 Offset: 0x1A4E1E0 VA: 0x1A521E0 Slot: 8
	public override void SelectedEquipType(ItemDBData.EquipType equipType) { }

	// RVA: 0x1A542C0 Offset: 0x1A502C0 VA: 0x1A542C0 Slot: 9
	public override bool Cancel() { }

	// RVA: 0x1A54958 Offset: 0x1A50958 VA: 0x1A54958 Slot: 10
	public override bool Enter() { }

	// RVA: 0x1A550A0 Offset: 0x1A510A0 VA: 0x1A550A0 Slot: 12
	public override string GetSelectedItemText(ItemData itemData) { }

	// RVA: 0x1A551DC Offset: 0x1A511DC VA: 0x1A551DC Slot: 11
	public override void SelectedItem(ItemData itemData) { }

	// RVA: 0x1A551E4 Offset: 0x1A511E4 VA: 0x1A551E4
	private void SelectedItem(ItemData itemData, bool selected) { }

	// RVA: 0x1A54FA8 Offset: 0x1A50FA8 VA: 0x1A54FA8
	private void PlayAnimationCheck(ItemDBData.ItemType nextEquipType) { }

	// RVA: 0x1A55A64 Offset: 0x1A51A64 VA: 0x1A55A64 Slot: 4
	public override bool InputLock() { }

	// RVA: 0x1A55A6C Offset: 0x1A51A6C VA: 0x1A55A6C
	private void Update() { }

	// RVA: 0x1A55AB0 Offset: 0x1A51AB0 VA: 0x1A55AB0
	private void LateUpdate() { }

	// RVA: 0x1A5305C Offset: 0x1A4F05C VA: 0x1A5305C
	private bool Clear() { }

	// RVA: 0x1A55530 Offset: 0x1A51530 VA: 0x1A55530
	private void EquipChangeStatusData(string text, int changeEquipStatusPoint, int type, bool isActive) { }

	// RVA: 0x1A55C80 Offset: 0x1A51C80 VA: 0x1A55C80
	public void UpdateModelLabel() { }

	// RVA: 0x1A519E4 Offset: 0x1A4D9E4 VA: 0x1A519E4
	private void UpdateModel() { }

	// RVA: 0x1A54F00 Offset: 0x1A50F00 VA: 0x1A54F00
	private void SetEquipItemModel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x1A55750 Offset: 0x1A51750 VA: 0x1A55750
	private void FocusSetEquipItemModel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x1A55E70 Offset: 0x1A51E70 VA: 0x1A55E70
	private ItemDBData.EquipType CheakEquipType(ItemDBData.EquipType equipType) { }

	// RVA: 0x1A54A8C Offset: 0x1A50A8C VA: 0x1A54A8C
	private bool CheckEquipEnter() { }

	// RVA: 0x1A55EAC Offset: 0x1A51EAC VA: 0x1A55EAC
	private bool CheckChangeEquipGuardAvoid(ItemData equipItemData) { }

	// RVA: 0x1A55FD4 Offset: 0x1A51FD4 VA: 0x1A55FD4
	private bool CheckEquipItemGuardAvoid(ItemData equipItemData) { }

	// RVA: 0x1A5314C Offset: 0x1A4F14C VA: 0x1A5314C
	private void AvatarEquipSelect(bool categoryPopCheck) { }

	// RVA: 0x1A563F4 Offset: 0x1A523F4 VA: 0x1A563F4
	public void PushAvatarEquipCategory(int category) { }

	// RVA: 0x1A568CC Offset: 0x1A528CC VA: 0x1A568CC
	public void PushAvatarEquipCategoryEx(int category, int pageId) { }

	// RVA: 0x1A56B20 Offset: 0x1A52B20 VA: 0x1A56B20
	public void AvatarEquipRecycle() { }

	// RVA: 0x1A544D8 Offset: 0x1A504D8 VA: 0x1A544D8
	private void RecycleStartGemResult(int num) { }

	// RVA: 0x1A5726C Offset: 0x1A5326C VA: 0x1A5726C
	private void OnStarGem() { }

	// RVA: 0x1A573D8 Offset: 0x1A533D8 VA: 0x1A573D8
	private void OnRecycle() { }

	[IteratorStateMachine(typeof(UIEquipItemPanel.<CloseAvatarRecyclePanel>d__99))]
	// RVA: 0x1A5446C Offset: 0x1A5046C VA: 0x1A5446C
	private IEnumerator CloseAvatarRecyclePanel() { }

	[IteratorStateMachine(typeof(UIEquipItemPanel.<PopUpAvatarEquipRecycle>d__100))]
	// RVA: 0x1A57464 Offset: 0x1A53464 VA: 0x1A57464
	private IEnumerator PopUpAvatarEquipRecycle(ItemData itemData) { }

	// RVA: 0x1A5753C Offset: 0x1A5353C VA: 0x1A5753C
	public void AvatarEquipFavoritea() { }

	[IteratorStateMachine(typeof(UIEquipItemPanel.<PopUpvAvatarEquipFavoritea>d__102))]
	// RVA: 0x1A57588 Offset: 0x1A53588 VA: 0x1A57588
	private IEnumerator PopUpvAvatarEquipFavoritea(ItemData itemData) { }

	// RVA: 0x1A571F4 Offset: 0x1A531F4 VA: 0x1A571F4
	private void ClosedUpdate() { }

	// RVA: 0x1A57E74 Offset: 0x1A53E74 VA: 0x1A57E74
	private string getRewardName(RewardType type, int rewardValue, int num) { }

	// RVA: 0x1A58260 Offset: 0x1A54260 VA: 0x1A58260
	private void OnGetShop() { }

	// RVA: 0x1A51C7C Offset: 0x1A4DC7C VA: 0x1A51C7C
	private List<ItemData> GetNewAvatarEquipList() { }

	// RVA: 0x1A56634 Offset: 0x1A52634 VA: 0x1A56634
	private void UpdateNewAvatarEquipList() { }

	// RVA: 0x1A582BC Offset: 0x1A542BC VA: 0x1A582BC
	public void OnAvatarEquipViewEnable(int type) { }

	// RVA: 0x1A56410 Offset: 0x1A52410 VA: 0x1A56410
	private void AddCategoryButton(string text, Vector3 pos, int param, bool isSearch) { }

	// RVA: 0x1A55D68 Offset: 0x1A51D68 VA: 0x1A55D68
	private void OnAnimationChange() { }

	// RVA: 0x1A559FC Offset: 0x1A519FC VA: 0x1A559FC
	private int GetWeaponId(ItemDBData.ItemType itemType, ItemDBData.ItemType subItemType) { }

	// RVA: 0x1A51A5C Offset: 0x1A4DA5C VA: 0x1A51A5C
	private bool AnimationCheck() { }

	// RVA: 0x1A57638 Offset: 0x1A53638 VA: 0x1A57638
	public void OnSearchAvatar() { }

	// RVA: 0x1A58494 Offset: 0x1A54494 VA: 0x1A58494
	public void OnSearchSubmit() { }

	// RVA: 0x1A58564 Offset: 0x1A54564 VA: 0x1A58564
	public void OnSelectSearchElement(int param) { }

	[IteratorStateMachine(typeof(UIEquipItemPanel.<SearchAvatar>d__116))]
	// RVA: 0x1A584DC Offset: 0x1A544DC VA: 0x1A584DC
	private IEnumerator SearchAvatar(string keyword) { }

	// RVA: 0x1A58728 Offset: 0x1A54728 VA: 0x1A58728
	private void AddSearchElement(string text, Vector3 pos, int param) { }

	[IteratorStateMachine(typeof(UIEquipItemPanel.<GetContainsNames>d__118))]
	// RVA: 0x1A58960 Offset: 0x1A54960 VA: 0x1A58960
	private IEnumerator GetContainsNames(string keyword, Action<Dictionary<int, string>> callback) { }

	[IteratorStateMachine(typeof(UIEquipItemPanel.<GetContainsItemProperty>d__119))]
	// RVA: 0x1A58A24 Offset: 0x1A54A24 VA: 0x1A58A24
	private IEnumerator GetContainsItemProperty(string keyword, Action<Dictionary<int, string>> callback) { }

	// RVA: 0x1A5606C Offset: 0x1A5206C VA: 0x1A5606C
	private void ChangeActiveSearchPanel(bool isActive) { }

	// RVA: 0x1A54510 Offset: 0x1A50510 VA: 0x1A54510
	private void ReturnResultToSearchPanel() { }

	// RVA: 0x1A58AE8 Offset: 0x1A54AE8 VA: 0x1A58AE8
	public void .ctor() { }
}
