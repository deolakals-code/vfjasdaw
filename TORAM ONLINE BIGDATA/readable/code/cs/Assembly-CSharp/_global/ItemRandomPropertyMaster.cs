// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemRandomPropertyMaster : Singleton<ItemRandomPropertyMaster> // TypeDefIndex: 2033
{
	// Fields
	private Dictionary<short, ItemRandomPropertyMasterData> masterDataList; // 0x20

	// Methods

	// RVA: 0x2139E1C Offset: 0x2135E1C VA: 0x2139E1C
	public void .ctor() { }

	// RVA: 0x2139EB8 Offset: 0x2135EB8 VA: 0x2139EB8
	public bool ReadMasterData(byte[] binary) { }

	// RVA: 0x21398BC Offset: 0x21358BC VA: 0x21398BC
	public ItemRandomPropertyMasterData GetMasterData(short id) { }
}
