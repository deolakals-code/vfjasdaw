// Assembly: Assembly-CSharp.dll
// Namespace: 
public enum ItemManager.ItemConnectFlag // TypeDefIndex: 2003
{
	// Fields
	public int value__; // 0x0
	public const ItemManager.ItemConnectFlag Non = 0;
	public const ItemManager.ItemConnectFlag DiscardItem = 1;
	public const ItemManager.ItemConnectFlag ItemBagSort = 2;
	public const ItemManager.ItemConnectFlag ItemLocationSwap = 4;
	public const ItemManager.ItemConnectFlag DiscardWarrantyItem = 8;
	public const ItemManager.ItemConnectFlag WarrantyLocationSwap = 16;
	public const ItemManager.ItemConnectFlag TakeItem = 32;
	public const ItemManager.ItemConnectFlag PutItem = 64;
	public const ItemManager.ItemConnectFlag ItemChangeFlag = 128;
	public const ItemManager.ItemConnectFlag BagLoad = 256;
	public const ItemManager.ItemConnectFlag RandomItemBox = 512;
	public const ItemManager.ItemConnectFlag BagSlotRelease = 1024;
	public const ItemManager.ItemConnectFlag Error = 32768;
	public const ItemManager.ItemConnectFlag All = 65535;
}
