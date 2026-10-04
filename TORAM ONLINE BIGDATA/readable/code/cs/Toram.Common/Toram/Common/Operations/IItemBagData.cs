// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public interface IItemBagData // TypeDefIndex: 11363
{
	// Properties
	public abstract AvatarEquipData AvatarEquip { get; }
	public abstract short[] InventoryCapacity { get; }
	public abstract InventoryPackData ItemBag { get; }
	public abstract WarrantyItemPackData WarrantyBag { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AvatarEquipData get_AvatarEquip();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract short[] get_InventoryCapacity();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract InventoryPackData get_ItemBag();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract WarrantyItemPackData get_WarrantyBag();
}
