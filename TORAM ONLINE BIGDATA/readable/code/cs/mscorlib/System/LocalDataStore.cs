// Assembly: mscorlib.dll
// Namespace: System
internal sealed class LocalDataStore // TypeDefIndex: 9737
{
	// Fields
	private LocalDataStoreElement[] m_DataTable; // 0x10
	private LocalDataStoreMgr m_Manager; // 0x18

	// Methods

	// RVA: 0x300DC4C Offset: 0x3009C4C VA: 0x300DC4C
	public void .ctor(LocalDataStoreMgr mgr, int InitialCapacity) { }

	// RVA: 0x300DBE8 Offset: 0x3009BE8 VA: 0x300DBE8
	internal void Dispose() { }

	// RVA: 0x300DDD4 Offset: 0x3009DD4 VA: 0x300DDD4
	public object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x300DF18 Offset: 0x3009F18 VA: 0x300DF18
	public void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x300E298 Offset: 0x300A298 VA: 0x300E298
	internal void FreeData(int slot, long cookie) { }

	// RVA: 0x300DFF8 Offset: 0x3009FF8 VA: 0x300DFF8
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }
}
