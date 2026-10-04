// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StorageManager : Singleton<StorageManager> // TypeDefIndex: 2063
{
	// Fields
	private StorageManager.ConnectFlag connectFlag; // 0x20
	private int activedStorageNo; // 0x24
	private Dictionary<int, StorageManager.StorageBoxData> storageDataList; // 0x28
	private string selectModeKey; // 0x30
	[CompilerGenerated]
	private byte <StorageLimit>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte[] <StorageOrderList>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsCountSelectMode>k__BackingField; // 0x48

	// Properties
	public bool IsConnect { get; }
	public bool IsError { get; }
	public int StorangeBoxNum { get; }
	public byte StorageLimit { get; set; }
	public byte[] StorageOrderList { get; set; }
	public bool IsCountSelectMode { get; set; }

	// Methods

	// RVA: 0x2141348 Offset: 0x213D348 VA: 0x2141348
	public bool get_IsConnect() { }

	// RVA: 0x2141364 Offset: 0x213D364 VA: 0x2141364
	public bool get_IsError() { }

	// RVA: 0x2141370 Offset: 0x213D370 VA: 0x2141370
	public int get_StorangeBoxNum() { }

	[CompilerGenerated]
	// RVA: 0x21413C0 Offset: 0x213D3C0 VA: 0x21413C0
	public byte get_StorageLimit() { }

	[CompilerGenerated]
	// RVA: 0x21413C8 Offset: 0x213D3C8 VA: 0x21413C8
	private void set_StorageLimit(byte value) { }

	[CompilerGenerated]
	// RVA: 0x21413D0 Offset: 0x213D3D0 VA: 0x21413D0
	public byte[] get_StorageOrderList() { }

	[CompilerGenerated]
	// RVA: 0x21413D8 Offset: 0x213D3D8 VA: 0x21413D8
	private void set_StorageOrderList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x21413E0 Offset: 0x213D3E0 VA: 0x21413E0
	public bool get_IsCountSelectMode() { }

	[CompilerGenerated]
	// RVA: 0x21413E8 Offset: 0x213D3E8 VA: 0x21413E8
	private void set_IsCountSelectMode(bool value) { }

	// RVA: 0x21413F4 Offset: 0x213D3F4 VA: 0x21413F4
	public bool StorageBoxCapacityCheck(byte storageNo) { }

	// RVA: 0x2141500 Offset: 0x213D500 VA: 0x2141500
	public bool CheckStorageBoxItemList(byte storageNo) { }

	// RVA: 0x214143C Offset: 0x213D43C VA: 0x214143C
	public StorageManager.StorageBoxData GetStorageBox(int no) { }

	// RVA: 0x2141580 Offset: 0x213D580 VA: 0x2141580
	public bool GetList() { }

	// RVA: 0x21415AC Offset: 0x213D5AC VA: 0x21415AC
	public void ReceiveStorageList(StorageDatav2[] storageList, byte storageLimit, byte[] orderList) { }

	// RVA: 0x2141870 Offset: 0x213D870 VA: 0x2141870
	public void UpdateStorageList(byte storageNo, StorageItemDatav3[] storageItemData, StorageManager.ConnectFlag connectFlag) { }

	// RVA: 0x2141AFC Offset: 0x213DAFC VA: 0x2141AFC
	public void UpdateStorageItem(StorageItemDatav3 storageItemData) { }

	// RVA: 0x2141E20 Offset: 0x213DE20 VA: 0x2141E20
	public void UpdateStorage(byte storageNo, string storageName, string storageInfo) { }

	// RVA: 0x2141EE0 Offset: 0x213DEE0 VA: 0x2141EE0
	public void UpdateStorageCapacity(byte storageNo, int capacity) { }

	// RVA: 0x2141F60 Offset: 0x213DF60 VA: 0x2141F60
	public bool StorageEdit(byte storageNo, string storageName, string storageInfo) { }

	// RVA: 0x2142020 Offset: 0x213E020 VA: 0x2142020
	public bool StorageSort(byte storageNo, byte panelId) { }

	// RVA: 0x21420B0 Offset: 0x213E0B0 VA: 0x21420B0
	public bool StorageDiscard(byte storageNo, int itemId, int location) { }

	// RVA: 0x21421C0 Offset: 0x213E1C0 VA: 0x21421C0
	public bool StorageLock(byte storageNo, int itemId, int location) { }

	// RVA: 0x214221C Offset: 0x213E21C VA: 0x214221C
	public bool StorageTake(byte storageNo, int itemId, int location) { }

	// RVA: 0x214210C Offset: 0x213E10C VA: 0x214210C
	private bool SearchStorageBoxItem(byte storageNo, int itemId, int location) { }

	// RVA: 0x214234C Offset: 0x213E34C VA: 0x214234C
	public static StorageItemDatav3 CreateStorageData(ItemData itemData) { }

	// RVA: 0x2141550 Offset: 0x213D550 VA: 0x2141550
	public bool CheckConnectFlag(StorageManager.ConnectFlag flag) { }

	// RVA: 0x2141560 Offset: 0x213D560 VA: 0x2141560
	private bool SetConnectFlag(StorageManager.ConnectFlag flag) { }

	// RVA: 0x2141850 Offset: 0x213D850 VA: 0x2141850
	public bool ClearConnectFlag(StorageManager.ConnectFlag flag) { }

	// RVA: 0x2142AE4 Offset: 0x213EAE4 VA: 0x2142AE4
	public void ConnectFlagAllClear() { }

	// RVA: 0x2142AEC Offset: 0x213EAEC VA: 0x2142AEC
	public void ReceiveParameterFailed(byte operationCode, short returnCode) { }

	// RVA: 0x2141840 Offset: 0x213D840 VA: 0x2141840
	public void SetOrderList(byte[] orderList) { }

	// RVA: 0x2142BD8 Offset: 0x213EBD8 VA: 0x2142BD8
	public void GetSelectModeFlag() { }

	// RVA: 0x2142C18 Offset: 0x213EC18 VA: 0x2142C18
	public void SaveSelectModeFlag(bool isCountSelectMode) { }

	// RVA: 0x2142C40 Offset: 0x213EC40 VA: 0x2142C40
	public void .ctor() { }
}
