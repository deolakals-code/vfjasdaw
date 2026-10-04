// Assembly: mscorlib.dll
// Namespace: System.Threading
internal class LockQueue // TypeDefIndex: 9930
{
	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x3055D90 Offset: 0x3051D90 VA: 0x3055D90
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x3055DC0 Offset: 0x3051DC0 VA: 0x3055DC0
	public bool Wait(int timeout) { }

	// RVA: 0x3055F64 Offset: 0x3051F64 VA: 0x3055F64
	public bool get_IsEmpty() { }

	// RVA: 0x3056024 Offset: 0x3052024 VA: 0x3056024
	public void Pulse() { }
}
