// Assembly: mscorlib.dll
// Namespace: System
internal sealed class LocalDataStoreMgr // TypeDefIndex: 9739
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x300E5E8 Offset: 0x300A5E8 VA: 0x300E5E8
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x300DCD0 Offset: 0x3009CD0 VA: 0x300DCD0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x300E7AC Offset: 0x300A7AC VA: 0x300E7AC
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x300EA04 Offset: 0x300AA04 VA: 0x300EA04
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x300EB20 Offset: 0x300AB20 VA: 0x300EB20
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x300EC3C Offset: 0x300AC3C VA: 0x300EC3C
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x300E418 Offset: 0x300A418 VA: 0x300E418
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x300DEA4 Offset: 0x3009EA4 VA: 0x300DEA4
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x300E2EC Offset: 0x300A2EC VA: 0x300E2EC
	internal int GetSlotTableLength() { }

	// RVA: 0x300ED40 Offset: 0x300AD40 VA: 0x300ED40
	public void .ctor() { }
}
