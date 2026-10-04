// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageBoxCommand : StorageBaseCommand // TypeDefIndex: 8579
{
	// Fields
	private readonly StorageManager.StorageBoxData seletedStorage; // 0x20

	// Properties
	public override bool ConnectCheck { get; }
	public override byte MoveItemOperationCode { get; }
	public override string BuyNewSlotText { get; }
	public override OrbServiceType AddSlotServiceType { get; }

	// Methods

	// RVA: 0x1DB1564 Offset: 0x1DAD564 VA: 0x1DB1564
	public void .ctor(byte shopType, PlayerDataManager player, int selectedId) { }

	// RVA: 0x1DB1608 Offset: 0x1DAD608 VA: 0x1DB1608 Slot: 4
	public override bool get_ConnectCheck() { }

	// RVA: 0x1DB1658 Offset: 0x1DAD658 VA: 0x1DB1658 Slot: 5
	public override byte get_MoveItemOperationCode() { }

	// RVA: 0x1DB1660 Offset: 0x1DAD660 VA: 0x1DB1660 Slot: 6
	public override string get_BuyNewSlotText() { }

	// RVA: 0x1DB16A0 Offset: 0x1DAD6A0 VA: 0x1DB16A0 Slot: 7
	public override OrbServiceType get_AddSlotServiceType() { }

	// RVA: 0x1DB16A8 Offset: 0x1DAD6A8 VA: 0x1DB16A8 Slot: 8
	public override UIStorageItemPanel.StorageItemPanelData GetPanelItemList(int panelId, int addId) { }

	// RVA: 0x1DB1C1C Offset: 0x1DADC1C VA: 0x1DB1C1C Slot: 9
	public override bool MoveItemBox(int itemUid, byte itemDataType, short num) { }

	// RVA: 0x1DB1D1C Offset: 0x1DADD1C VA: 0x1DB1D1C Slot: 10
	public override bool MoveItem(int itemUid, int itemLocation) { }

	// RVA: 0x1DB1D24 Offset: 0x1DADD24 VA: 0x1DB1D24 Slot: 11
	public override bool SortItem(int pageId) { }

	// RVA: 0x1DB1D94 Offset: 0x1DADD94 VA: 0x1DB1D94 Slot: 12
	public override bool DeleteItem(int itemUid) { }

	// RVA: 0x1DB1E3C Offset: 0x1DADE3C VA: 0x1DB1E3C Slot: 13
	public override bool LockItem(int itemUid, bool lockFlag) { }

	// RVA: 0x1DB1F20 Offset: 0x1DADF20 VA: 0x1DB1F20 Slot: 14
	public override int GetBagNum() { }

	// RVA: 0x1DB1FA4 Offset: 0x1DADFA4 VA: 0x1DB1FA4 Slot: 15
	public override int GetBagCapacity(int panelId) { }

	// RVA: 0x1DB1FE0 Offset: 0x1DADFE0 VA: 0x1DB1FE0 Slot: 16
	public override int GetBagItemCount(int panelId) { }

	// RVA: 0x1DB1FE8 Offset: 0x1DADFE8 VA: 0x1DB1FE8 Slot: 17
	public override bool IsMaxBox() { }

	// RVA: 0x1DB2010 Offset: 0x1DAE010 VA: 0x1DB2010 Slot: 18
	public override bool BuyNewSlot(byte dataType) { }
}
