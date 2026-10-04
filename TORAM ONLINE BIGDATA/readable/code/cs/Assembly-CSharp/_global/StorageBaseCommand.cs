// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class StorageBaseCommand // TypeDefIndex: 8577
{
	// Fields
	protected byte shopType; // 0x10
	protected PlayerDataManager playerDataManager; // 0x18

	// Properties
	public abstract bool ConnectCheck { get; }
	public abstract byte MoveItemOperationCode { get; }
	public abstract string BuyNewSlotText { get; }
	public abstract OrbServiceType AddSlotServiceType { get; }

	// Methods

	// RVA: 0x1DB0B44 Offset: 0x1DACB44 VA: 0x1DB0B44
	public void .ctor(byte shopType, PlayerDataManager player) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_ConnectCheck();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte get_MoveItemOperationCode();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_BuyNewSlotText();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract OrbServiceType get_AddSlotServiceType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract UIStorageItemPanel.StorageItemPanelData GetPanelItemList(int panelId, int addId);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool MoveItemBox(int itemUid, byte itemDataType, short num);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool MoveItem(int itemUid, int itemLocation);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool SortItem(int pageId);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool DeleteItem(int itemUid);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool LockItem(int itemUid, bool lockFlag);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetBagNum();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int GetBagCapacity(int panelId);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetBagItemCount(int panelId);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool IsMaxBox();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool BuyNewSlot(byte dataType);
}
