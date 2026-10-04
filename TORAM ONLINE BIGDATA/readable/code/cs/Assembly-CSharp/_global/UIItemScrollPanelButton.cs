// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIItemScrollPanelButton : MonoBehaviour, IUIItemScrollPanelButton // TypeDefIndex: 8990
{
	// Fields
	[SerializeField]
	private UIIcon itemIcon; // 0x20
	[SerializeField]
	private UILabel paramLabel1; // 0x28
	[SerializeField]
	private UILabel paramLabel2; // 0x30
	[SerializeField]
	protected UILabel paramLabel3; // 0x38
	[SerializeField]
	private UISprite buttonFrame; // 0x40
	[SerializeField]
	private UISprite buttonBack; // 0x48
	[SerializeField]
	private UIIcon[] cristaSlot; // 0x50
	[SerializeField]
	private UISprite[] cristaSlotBack; // 0x58
	[SerializeField]
	protected UILabel equipCheck; // 0x60
	[SerializeField]
	private UISprite lockIcon; // 0x68
	[SerializeField]
	private UISprite selectIcon; // 0x70
	[SerializeField]
	private UILabel questCheck; // 0x78
	[SerializeField]
	private GameObject panelObj; // 0x80
	[SerializeField]
	private GameObject newItemIconObj; // 0x88
	[SerializeField]
	private GameObject favoriteItemIconObj; // 0x90
	[SerializeField]
	private GameObject newSlotIconObj; // 0x98
	[SerializeField]
	private GameObject randomPropIconObj; // 0xA0
	protected UIItemScrollPanelManager panelManager; // 0xA8
	protected UIItemScrollListManager listManager; // 0xB0
	[CompilerGenerated]
	private ItemData <ItemData>k__BackingField; // 0xB8
	private bool dragCheck; // 0xC0
	private bool createItem; // 0xC1
	private UIPartyFieldLabel partyFieldLabel; // 0xC8
	private SystemTextManager systemManager; // 0xD0
	[CompilerGenerated]
	private int <LocationId>k__BackingField; // 0xD8
	private UIRoot parentRoot; // 0xE0
	private float dragTimer; // 0xE8
	private const float maxDragTimer = 0.5;
	private bool isPush; // 0xEC
	private bool isDragMove; // 0xED
	private bool isIconDrag; // 0xEE
	private GameObject parentObj; // 0xF0
	private bool isMoveLabel; // 0xF8
	private bool isMoveEnd; // 0xF9
	private bool isScroll; // 0xFA
	private Vector3 basePos; // 0xFC
	private float maxSize; // 0x108
	private int maxLength; // 0x10C
	private float interval; // 0x110
	private float dest; // 0x114
	[CompilerGenerated]
	private UIItemScrollPanelButton.ItemButtonTypes <ItemButtonType>k__BackingField; // 0x118
	[CompilerGenerated]
	private bool <IsCanDrag>k__BackingField; // 0x11C
	[CompilerGenerated]
	private bool <IsEquip>k__BackingField; // 0x11D
	[CompilerGenerated]
	private bool <IsQuest>k__BackingField; // 0x11E
	[CompilerGenerated]
	private bool <IsAddSlot>k__BackingField; // 0x11F
	[CompilerGenerated]
	private bool <IsAvatarEquip>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <IsEnable>k__BackingField; // 0x121
	[CompilerGenerated]
	private bool <IsSelect>k__BackingField; // 0x122
	[CompilerGenerated]
	private string <SelectSpriteName>k__BackingField; // 0x128
	[CompilerGenerated]
	private bool <IsSelectEnable>k__BackingField; // 0x130
	[CompilerGenerated]
	private bool <IsNewItem>k__BackingField; // 0x131
	[CompilerGenerated]
	private bool <IsFavoriteItem>k__BackingField; // 0x132

	// Properties
	public ItemData ItemData { get; set; }
	private SystemTextManager systemTextManager { get; }
	public int LocationId { get; set; }
	public bool IsLock { get; }
	public UIItemScrollPanelButton.ItemButtonTypes ItemButtonType { get; set; }
	public bool IsDummy { get; }
	public bool IsCanDrag { get; set; }
	public bool IsEquip { get; set; }
	public bool IsQuest { get; set; }
	public bool IsAddSlot { get; set; }
	public bool IsAvatarEquip { get; set; }
	public bool IsEnable { get; set; }
	protected virtual GameObject BaseButton { get; }
	public bool IsSelect { get; set; }
	public string SelectSpriteName { get; set; }
	public bool IsSelectEnable { get; set; }
	public bool IsNewItem { get; set; }
	public bool IsFavoriteItem { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E7BDC8 Offset: 0x1E77DC8 VA: 0x1E7BDC8
	private void set_ItemData(ItemData value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BDD0 Offset: 0x1E77DD0 VA: 0x1E7BDD0 Slot: 5
	public ItemData get_ItemData() { }

	// RVA: 0x1E7BDD8 Offset: 0x1E77DD8 VA: 0x1E7BDD8
	private SystemTextManager get_systemTextManager() { }

	[CompilerGenerated]
	// RVA: 0x1E7BEC4 Offset: 0x1E77EC4 VA: 0x1E7BEC4
	private void set_LocationId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BECC Offset: 0x1E77ECC VA: 0x1E7BECC Slot: 12
	public int get_LocationId() { }

	// RVA: 0x1E7BED4 Offset: 0x1E77ED4 VA: 0x1E7BED4
	public bool get_IsLock() { }

	[CompilerGenerated]
	// RVA: 0x1E7BEE8 Offset: 0x1E77EE8 VA: 0x1E7BEE8
	private void set_ItemButtonType(UIItemScrollPanelButton.ItemButtonTypes value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BEF0 Offset: 0x1E77EF0 VA: 0x1E7BEF0
	public UIItemScrollPanelButton.ItemButtonTypes get_ItemButtonType() { }

	// RVA: 0x1E7BEF8 Offset: 0x1E77EF8 VA: 0x1E7BEF8 Slot: 4
	public bool get_IsDummy() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF00 Offset: 0x1E77F00 VA: 0x1E7BF00 Slot: 11
	public bool get_IsCanDrag() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF08 Offset: 0x1E77F08 VA: 0x1E7BF08
	private void set_IsCanDrag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BF14 Offset: 0x1E77F14 VA: 0x1E7BF14 Slot: 6
	public bool get_IsEquip() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF1C Offset: 0x1E77F1C VA: 0x1E7BF1C
	private void set_IsEquip(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BF28 Offset: 0x1E77F28 VA: 0x1E7BF28 Slot: 7
	public bool get_IsQuest() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF30 Offset: 0x1E77F30 VA: 0x1E7BF30
	private void set_IsQuest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BF3C Offset: 0x1E77F3C VA: 0x1E7BF3C Slot: 8
	public bool get_IsAddSlot() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF44 Offset: 0x1E77F44 VA: 0x1E7BF44
	private void set_IsAddSlot(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BF50 Offset: 0x1E77F50 VA: 0x1E7BF50 Slot: 9
	public bool get_IsAvatarEquip() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF58 Offset: 0x1E77F58 VA: 0x1E7BF58
	private void set_IsAvatarEquip(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BF64 Offset: 0x1E77F64 VA: 0x1E7BF64 Slot: 10
	public bool get_IsEnable() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF6C Offset: 0x1E77F6C VA: 0x1E7BF6C
	private void set_IsEnable(bool value) { }

	// RVA: 0x1E7BF78 Offset: 0x1E77F78 VA: 0x1E7BF78 Slot: 38
	protected virtual GameObject get_BaseButton() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF80 Offset: 0x1E77F80 VA: 0x1E7BF80 Slot: 13
	public bool get_IsSelect() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF88 Offset: 0x1E77F88 VA: 0x1E7BF88
	private void set_IsSelect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BF94 Offset: 0x1E77F94 VA: 0x1E7BF94 Slot: 14
	public string get_SelectSpriteName() { }

	[CompilerGenerated]
	// RVA: 0x1E7BF9C Offset: 0x1E77F9C VA: 0x1E7BF9C
	private void set_SelectSpriteName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BFAC Offset: 0x1E77FAC VA: 0x1E7BFAC Slot: 15
	public bool get_IsSelectEnable() { }

	[CompilerGenerated]
	// RVA: 0x1E7BFB4 Offset: 0x1E77FB4 VA: 0x1E7BFB4
	private void set_IsSelectEnable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BFC0 Offset: 0x1E77FC0 VA: 0x1E7BFC0 Slot: 16
	public bool get_IsNewItem() { }

	[CompilerGenerated]
	// RVA: 0x1E7BFC8 Offset: 0x1E77FC8 VA: 0x1E7BFC8
	private void set_IsNewItem(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E7BFD4 Offset: 0x1E77FD4 VA: 0x1E7BFD4 Slot: 17
	public bool get_IsFavoriteItem() { }

	[CompilerGenerated]
	// RVA: 0x1E7BFDC Offset: 0x1E77FDC VA: 0x1E7BFDC
	private void set_IsFavoriteItem(bool value) { }

	// RVA: 0x1E7BFE8 Offset: 0x1E77FE8 VA: 0x1E7BFE8 Slot: 39
	public virtual void Init(IUIItemScrollPanelButton copy, UIItemScrollPanelManager panelManager, UIItemScrollListManager listManager, GameObject parentObj) { }

	// RVA: 0x1E7C9DC Offset: 0x1E789DC VA: 0x1E7C9DC Slot: 40
	public virtual void Initialize(ItemData itemData, UIItemScrollPanelManager panelManager, UIItemScrollListManager listManager, GameObject parentObj) { }

	// RVA: 0x1E7CE4C Offset: 0x1E78E4C VA: 0x1E7CE4C Slot: 41
	public virtual void InitializeAddSlot(UIItemScrollPanelManager panelManager) { }

	// RVA: 0x1E7D034 Offset: 0x1E79034 VA: 0x1E7D034 Slot: 42
	public virtual void Clear() { }

	// RVA: 0x1E7D590 Offset: 0x1E79590 VA: 0x1E7D590 Slot: 21
	public void SetLocationId(int locationId) { }

	// RVA: 0x1E7D598 Offset: 0x1E79598 VA: 0x1E7D598 Slot: 43
	public virtual void Select() { }

	// RVA: 0x1E7D764 Offset: 0x1E79764 VA: 0x1E7D764 Slot: 44
	public virtual void DeSelect() { }

	// RVA: 0x1E7CE40 Offset: 0x1E78E40 VA: 0x1E7CE40
	private void ClearFlag() { }

	// RVA: 0x1E7D958 Offset: 0x1E79958 VA: 0x1E7D958 Slot: 45
	public virtual void SetEnable(bool enabled) { }

	// RVA: 0x1E7DADC Offset: 0x1E79ADC VA: 0x1E7DADC Slot: 46
	public virtual void SetLock(bool lockFlag) { }

	// RVA: 0x1E7DBD8 Offset: 0x1E79BD8 VA: 0x1E7DBD8 Slot: 47
	public virtual void SetNew(bool flag) { }

	// RVA: 0x1E7DD08 Offset: 0x1E79D08 VA: 0x1E7DD08 Slot: 48
	public virtual void SetFavorite(bool flag) { }

	// RVA: 0x1E7DE04 Offset: 0x1E79E04 VA: 0x1E7DE04
	private void LateUpdate() { }

	// RVA: 0x1E7E5E0 Offset: 0x1E7A5E0 VA: 0x1E7E5E0 Slot: 49
	public virtual void EquipCheck(bool flag) { }

	// RVA: 0x1E7E798 Offset: 0x1E7A798 VA: 0x1E7E798 Slot: 50
	public virtual void QuestCheck(bool flag) { }

	// RVA: 0x1E7E944 Offset: 0x1E7A944 VA: 0x1E7E944 Slot: 51
	public virtual void NewItemCheck(bool flag) { }

	// RVA: 0x1E7EA00 Offset: 0x1E7AA00 VA: 0x1E7EA00 Slot: 52
	public virtual void FavorItemCheck(bool flag, bool isNewItem) { }

	// RVA: 0x1E7EB90 Offset: 0x1E7AB90 VA: 0x1E7EB90 Slot: 53
	public virtual void ItemUpdateCheck(ItemData itemData) { }

	// RVA: 0x1E7FB50 Offset: 0x1E7BB50 VA: 0x1E7FB50 Slot: 54
	public virtual void SetSelectIcon(string spriteName, bool enabled) { }

	// RVA: 0x1E7FC4C Offset: 0x1E7BC4C VA: 0x1E7FC4C Slot: 55
	public virtual void ChangeDetachIcon() { }

	// RVA: 0x1E80050 Offset: 0x1E7C050 VA: 0x1E80050 Slot: 56
	public virtual void ChangeAvatarCategoryIcon() { }

	// RVA: 0x1E8066C Offset: 0x1E7C66C VA: 0x1E8066C
	private void StarteScrollCategoryLabel() { }

	// RVA: 0x1E7DFD8 Offset: 0x1E79FD8 VA: 0x1E7DFD8
	private void UpdateScrollCategoryLabel() { }

	// RVA: 0x1E80740 Offset: 0x1E7C740 VA: 0x1E80740
	public void ChangeFrameDeSelect() { }

	// RVA: 0x1E80810 Offset: 0x1E7C810 VA: 0x1E80810 Slot: 18
	public void SetAddSlot(bool isAddSlot) { }

	// RVA: 0x1E8081C Offset: 0x1E7C81C VA: 0x1E8081C Slot: 19
	public void SetAvatarEquip(bool isAvatarEquip) { }

	// RVA: 0x1E80828 Offset: 0x1E7C828 VA: 0x1E80828 Slot: 20
	public void SetItemData(ItemData itemData) { }

	// RVA: 0x1E80830 Offset: 0x1E7C830 VA: 0x1E80830 Slot: 57
	public virtual bool SetActive(bool isActive) { }

	// RVA: 0x1E7E238 Offset: 0x1E7A238 VA: 0x1E7E238
	private void UpdateDrag() { }

	// RVA: 0x1E80C08 Offset: 0x1E7CC08 VA: 0x1E80C08
	public void DestroySecondDragIcon() { }

	// RVA: 0x1E7CD8C Offset: 0x1E78D8C VA: 0x1E7CD8C
	private void SetDragObjectActive(bool flag) { }

	// RVA: 0x1E80C98 Offset: 0x1E7CC98 VA: 0x1E80C98
	public bool DragCheck(Vector3 position, float r) { }

	// RVA: 0x1E80D90 Offset: 0x1E7CD90 VA: 0x1E80D90 Slot: 33
	public void SetDragEnable(bool enable) { }

	// RVA: 0x1E808C8 Offset: 0x1E7C8C8 VA: 0x1E808C8
	private bool IsScreenTouch(out Vector3 touchPos) { }

	// RVA: 0x1E80A18 Offset: 0x1E7CA18 VA: 0x1E80A18
	private void OnPress(bool push) { }

	// RVA: 0x1E80D9C Offset: 0x1E7CD9C VA: 0x1E80D9C
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1E80FA4 Offset: 0x1E7CFA4 VA: 0x1E80FA4
	public void .ctor() { }
}
