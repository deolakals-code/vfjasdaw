// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
public sealed class LocalDataStoreSlot // TypeDefIndex: 9738
{
	// Fields
	private LocalDataStoreMgr m_mgr; // 0x10
	private int m_slot; // 0x18
	private long m_cookie; // 0x20

	// Properties
	internal LocalDataStoreMgr Manager { get; }
	internal int Slot { get; }
	internal long Cookie { get; }

	// Methods

	// RVA: 0x300E308 Offset: 0x300A308 VA: 0x300E308
	internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

	// RVA: 0x300E354 Offset: 0x300A354 VA: 0x300E354
	internal LocalDataStoreMgr get_Manager() { }

	// RVA: 0x300E35C Offset: 0x300A35C VA: 0x300E35C
	internal int get_Slot() { }

	// RVA: 0x300E364 Offset: 0x300A364 VA: 0x300E364
	internal long get_Cookie() { }

	// RVA: 0x300E36C Offset: 0x300A36C VA: 0x300E36C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x300E5B0 Offset: 0x300A5B0 VA: 0x300E5B0
	internal void .ctor() { }
}
