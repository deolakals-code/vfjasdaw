// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IUIItemScrollPanelButton // TypeDefIndex: 8750
{
	// Properties
	public abstract bool IsDummy { get; }
	public abstract ItemData ItemData { get; }
	public abstract bool IsEquip { get; }
	public abstract bool IsQuest { get; }
	public abstract bool IsAddSlot { get; }
	public abstract bool IsAvatarEquip { get; }
	public abstract bool IsEnable { get; }
	public abstract bool IsCanDrag { get; }
	public abstract int LocationId { get; }
	public abstract bool IsSelect { get; }
	public abstract string SelectSpriteName { get; }
	public abstract bool IsSelectEnable { get; }
	public abstract bool IsNewItem { get; }
	public abstract bool IsFavoriteItem { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsDummy();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ItemData get_ItemData();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsEquip();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsQuest();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsAddSlot();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAvatarEquip();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsEnable();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsCanDrag();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_LocationId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsSelect();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_SelectSpriteName();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsSelectEnable();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_IsNewItem();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_IsFavoriteItem();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetAddSlot(bool isAddSlot);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetAvatarEquip(bool isAvatarEquip);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetItemData(ItemData itemData);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetLocationId(int locationId);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SetEnable(bool enabled);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void EquipCheck(bool flag);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void QuestCheck(bool flag);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void NewItemCheck(bool flag);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void FavorItemCheck(bool flag, bool isNewItem);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Init(IUIItemScrollPanelButton copy, UIItemScrollPanelManager panelManager, UIItemScrollListManager listManager, GameObject parentObj);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void Initialize(ItemData itemData, UIItemScrollPanelManager panelManager, UIItemScrollListManager listManager, GameObject parentObj);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void InitializeAddSlot(UIItemScrollPanelManager panelManager);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void ChangeDetachIcon();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void ChangeAvatarCategoryIcon();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void SetDragEnable(bool enable);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool SetActive(bool isActive);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void Select();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void SetSelectIcon(string spriteName, bool enabled);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void DeSelect();
}
