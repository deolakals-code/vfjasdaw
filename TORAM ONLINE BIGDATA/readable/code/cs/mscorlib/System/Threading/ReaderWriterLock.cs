// Assembly: mscorlib.dll
// Namespace: System.Threading
[ComVisible(True)]
public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 9933
{
	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x305647C Offset: 0x305247C VA: 0x305647C
	public void .ctor() { }

	// RVA: 0x3056570 Offset: 0x3052570 VA: 0x3056570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3056578 Offset: 0x3052578 VA: 0x3056578
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x3056580 Offset: 0x3052580 VA: 0x3056580
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3056754 Offset: 0x3052754 VA: 0x3056754
	public void ReleaseWriterLock() { }

	// RVA: 0x305687C Offset: 0x305287C VA: 0x305687C
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x3056720 Offset: 0x3052720 VA: 0x3056720
	private bool HasWriterLock() { }
}
