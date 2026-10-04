// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageManager.StorageBoxData // TypeDefIndex: 2061
{
	// Fields
	private string name; // 0x10
	private string info; // 0x18
	public readonly byte No; // 0x20
	private int capacityNum; // 0x24
	private List<ItemData> itemList; // 0x28
	private int itemNum; // 0x30

	// Properties
	public string Name { get; }
	public string Info { get; }
	public int CapacityNum { get; }
	public IList<ItemData> ItemList { get; }
	public int ItemNum { get; }

	// Methods

	// RVA: 0x2142D10 Offset: 0x213ED10 VA: 0x2142D10
	public string get_Name() { }

	// RVA: 0x2142D18 Offset: 0x213ED18 VA: 0x2142D18
	public string get_Info() { }

	// RVA: 0x2142D20 Offset: 0x213ED20 VA: 0x2142D20
	public int get_CapacityNum() { }

	// RVA: 0x2141DD0 Offset: 0x213DDD0 VA: 0x2141DD0
	public IList<ItemData> get_ItemList() { }

	// RVA: 0x21414AC Offset: 0x213D4AC VA: 0x21414AC
	public int get_ItemNum() { }

	// RVA: 0x2141728 Offset: 0x213D728 VA: 0x2141728
	public void .ctor(byte no, int capacity, int num) { }

	// RVA: 0x2141954 Offset: 0x213D954 VA: 0x2141954
	public void UpdateItemList(StorageItemDatav3 storageItemData) { }

	// RVA: 0x2142D28 Offset: 0x213ED28 VA: 0x2142D28
	public void RemoveItem(StorageItemDatav3 storageItemData) { }

	// RVA: 0x2141810 Offset: 0x213D810 VA: 0x2141810
	public void UpdateStorageText(string storageName, string storageInfo) { }

	// RVA: 0x2142DB4 Offset: 0x213EDB4 VA: 0x2142DB4
	public void UpdateStorageCapacity(int capacity) { }

	// RVA: 0x2142278 Offset: 0x213E278 VA: 0x2142278
	public ItemData GetItemDataFromUuid(int uuid) { }

	// RVA: 0x2142DC4 Offset: 0x213EDC4 VA: 0x2142DC4
	public string GetNameText() { }

	// RVA: 0x2142EB4 Offset: 0x213EEB4 VA: 0x2142EB4
	public char GetNoText() { }

	// RVA: 0x2142EC0 Offset: 0x213EEC0 VA: 0x2142EC0
	public string GetCapacityText() { }
}
