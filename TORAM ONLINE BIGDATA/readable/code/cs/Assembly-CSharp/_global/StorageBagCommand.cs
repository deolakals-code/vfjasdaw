// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageBagCommand : StorageBaseCommand // TypeDefIndex: 8576
{
	// Fields
	private readonly StorageManager.StorageBoxData seletedStorage; // 0x20
	private ItemManager.ItemConnectFlag itemConnectFlag; // 0x28
	private byte selectStorageNo; // 0x2C

	// Properties
	public override bool ConnectCheck { get; }
	public override byte MoveItemOperationCode { get; }
	public override string BuyNewSlotText { get; }
	public override OrbServiceType AddSlotServiceType { get; }

	// Methods

	// RVA: 0x1DB0A98 Offset: 0x1DACA98 VA: 0x1DB0A98
	public void .ctor(byte shopType, PlayerDataManager player, int storageNo) { }

	// RVA: 0x1DB0B7C Offset: 0x1DACB7C VA: 0x1DB0B7C Slot: 4
	public override bool get_ConnectCheck() { }

	// RVA: 0x1DB0BAC Offset: 0x1DACBAC VA: 0x1DB0BAC Slot: 5
	public override byte get_MoveItemOperationCode() { }

	// RVA: 0x1DB0BB4 Offset: 0x1DACBB4 VA: 0x1DB0BB4 Slot: 6
	public override string get_BuyNewSlotText() { }

	// RVA: 0x1DB0BF4 Offset: 0x1DACBF4 VA: 0x1DB0BF4 Slot: 7
	public override OrbServiceType get_AddSlotServiceType() { }

	// RVA: 0x1DB0BFC Offset: 0x1DACBFC VA: 0x1DB0BFC Slot: 8
	public override UIStorageItemPanel.StorageItemPanelData GetPanelItemList(int panelId, int addId) { }

	// RVA: 0x1DB113C Offset: 0x1DAD13C VA: 0x1DB113C Slot: 9
	public override bool MoveItemBox(int itemUid, byte itemDataType, short num) { }

	// RVA: 0x1DB1248 Offset: 0x1DAD248 VA: 0x1DB1248 Slot: 10
	public override bool MoveItem(int itemUid, int itemLocation) { }

	// RVA: 0x1DB1250 Offset: 0x1DAD250 VA: 0x1DB1250 Slot: 11
	public override bool SortItem(int bagId) { }

	// RVA: 0x1DB1284 Offset: 0x1DAD284 VA: 0x1DB1284 Slot: 12
	public override bool DeleteItem(int itemUid) { }

	// RVA: 0x1DB12F0 Offset: 0x1DAD2F0 VA: 0x1DB12F0 Slot: 13
	public override bool LockItem(int itemUid, bool lockFlag) { }

	// RVA: 0x1DB1354 Offset: 0x1DAD354 VA: 0x1DB1354 Slot: 14
	public override int GetBagNum() { }

	// RVA: 0x1DB135C Offset: 0x1DAD35C VA: 0x1DB135C Slot: 15
	public override int GetBagCapacity(int panelId) { }

	// RVA: 0x1DB1364 Offset: 0x1DAD364 VA: 0x1DB1364 Slot: 16
	public override int GetBagItemCount(int panelId) { }

	// RVA: 0x1DB136C Offset: 0x1DAD36C VA: 0x1DB136C Slot: 17
	public override bool IsMaxBox() { }

	// RVA: 0x1DB1398 Offset: 0x1DAD398 VA: 0x1DB1398 Slot: 18
	public override bool BuyNewSlot(byte dataType) { }
}
