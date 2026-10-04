// Assembly: System.Core.dll
// Namespace: System.Threading
public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 15810
{
	// Fields
	private bool fIsReentrant; // 0x10
	private int myLock; // 0x14
	private const int LockSpinCycles = 20;
	private const int LockSpinCount = 10;
	private const int LockSleep0Count = 5;
	private uint numWriteWaiters; // 0x18
	private uint numReadWaiters; // 0x1C
	private uint numWriteUpgradeWaiters; // 0x20
	private uint numUpgradeWaiters; // 0x24
	private bool fNoWaiters; // 0x28
	private int upgradeLockOwnerId; // 0x2C
	private int writeLockOwnerId; // 0x30
	private EventWaitHandle writeEvent; // 0x38
	private EventWaitHandle readEvent; // 0x40
	private EventWaitHandle upgradeEvent; // 0x48
	private EventWaitHandle waitUpgradeEvent; // 0x50
	private static long s_nextLockID; // 0x0
	private long lockID; // 0x58
	[ThreadStatic]
	private static ReaderWriterCount t_rwc; // 0x80000000
	private bool fUpgradeThreadHoldingRead; // 0x60
	private const int MaxSpinCount = 20;
	private uint owners; // 0x64
	private const uint WRITER_HELD = 2147483648;
	private const uint WAITING_WRITERS = 1073741824;
	private const uint WAITING_UPGRADER = 536870912;
	private const uint MAX_READER = 268435454;
	private const uint READER_MASK = 268435455;
	private bool fDisposed; // 0x68

	// Properties
	public bool IsReadLockHeld { get; }
	public bool IsUpgradeableReadLockHeld { get; }
	public bool IsWriteLockHeld { get; }
	public int RecursiveReadCount { get; }
	public int RecursiveUpgradeCount { get; }
	public int RecursiveWriteCount { get; }
	public int WaitingReadCount { get; }
	public int WaitingUpgradeCount { get; }
	public int WaitingWriteCount { get; }

	// Methods

	// RVA: 0x318E060 Offset: 0x318A060 VA: 0x318E060
	private void InitializeThreadCounts() { }

	// RVA: 0x318E06C Offset: 0x318A06C VA: 0x318E06C
	public void .ctor() { }

	// RVA: 0x318E074 Offset: 0x318A074 VA: 0x318E074
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x318E0F8 Offset: 0x318A0F8 VA: 0x318E0F8
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x318E138 Offset: 0x318A138 VA: 0x318E138
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x318E15C Offset: 0x318A15C VA: 0x318E15C
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x318E298 Offset: 0x318A298 VA: 0x318E298
	public void EnterReadLock() { }

	// RVA: 0x318E2A0 Offset: 0x318A2A0 VA: 0x318E2A0
	public bool TryEnterReadLock(int millisecondsTimeout) { }

	// RVA: 0x318E350 Offset: 0x318A350 VA: 0x318E350
	private bool TryEnterReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x318E354 Offset: 0x318A354 VA: 0x318E354
	private bool TryEnterReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x318E9B8 Offset: 0x318A9B8 VA: 0x318E9B8
	public void EnterWriteLock() { }

	// RVA: 0x318E9C0 Offset: 0x318A9C0 VA: 0x318E9C0
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x318E9EC Offset: 0x318A9EC VA: 0x318E9EC
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x318E9F0 Offset: 0x318A9F0 VA: 0x318E9F0
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x318EDFC Offset: 0x318ADFC VA: 0x318EDFC
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x318EE04 Offset: 0x318AE04 VA: 0x318EE04
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x318EE30 Offset: 0x318AE30 VA: 0x318EE30
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x318EE34 Offset: 0x318AE34 VA: 0x318EE34
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x318F194 Offset: 0x318B194 VA: 0x318F194
	public void ExitReadLock() { }

	// RVA: 0x318F32C Offset: 0x318B32C VA: 0x318F32C
	public void ExitWriteLock() { }

	// RVA: 0x318F484 Offset: 0x318B484 VA: 0x318F484
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x318E794 Offset: 0x318A794 VA: 0x318E794
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x318E894 Offset: 0x318A894 VA: 0x318E894
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x318F300 Offset: 0x318B300 VA: 0x318F300
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x318F684 Offset: 0x318B684 VA: 0x318F684
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x318F708 Offset: 0x318B708 VA: 0x318F708
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x318EDD0 Offset: 0x318ADD0 VA: 0x318EDD0
	private bool IsWriterAcquired() { }

	// RVA: 0x318EDE0 Offset: 0x318ADE0 VA: 0x318EDE0
	private void SetWriterAcquired() { }

	// RVA: 0x318F474 Offset: 0x318B474 VA: 0x318F474
	private void ClearWriterAcquired() { }

	// RVA: 0x318F61C Offset: 0x318B61C VA: 0x318F61C
	private void SetWritersWaiting() { }

	// RVA: 0x318F79C Offset: 0x318B79C VA: 0x318F79C
	private void ClearWritersWaiting() { }

	// RVA: 0x318F62C Offset: 0x318B62C VA: 0x318F62C
	private void SetUpgraderWaiting() { }

	// RVA: 0x318F7AC Offset: 0x318B7AC VA: 0x318F7AC
	private void ClearUpgraderWaiting() { }

	// RVA: 0x318EDF0 Offset: 0x318ADF0 VA: 0x318EDF0
	private uint GetNumReaders() { }

	// RVA: 0x318F7BC Offset: 0x318B7BC VA: 0x318F7BC
	private void EnterMyLock() { }

	// RVA: 0x318F7F0 Offset: 0x318B7F0 VA: 0x318F7F0
	private void EnterMyLockSpin() { }

	// RVA: 0x318E6CC Offset: 0x318A6CC VA: 0x318E6CC
	private void ExitMyLock() { }

	// RVA: 0x318E6FC Offset: 0x318A6FC VA: 0x318E6FC
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x318F8C8 Offset: 0x318B8C8 VA: 0x318F8C8 Slot: 4
	public void Dispose() { }

	// RVA: 0x318F8D0 Offset: 0x318B8D0 VA: 0x318F8D0
	private void Dispose(bool disposing) { }

	// RVA: 0x318FA40 Offset: 0x318BA40 VA: 0x318FA40
	public bool get_IsReadLockHeld() { }

	// RVA: 0x318FA58 Offset: 0x318BA58 VA: 0x318FA58
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x318FA70 Offset: 0x318BA70 VA: 0x318FA70
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x318FA88 Offset: 0x318BA88 VA: 0x318FA88
	public int get_RecursiveReadCount() { }

	// RVA: 0x318FB08 Offset: 0x318BB08 VA: 0x318FB08
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x318FBB8 Offset: 0x318BBB8 VA: 0x318FBB8
	public int get_RecursiveWriteCount() { }

	// RVA: 0x318FC68 Offset: 0x318BC68 VA: 0x318FC68
	public int get_WaitingReadCount() { }

	// RVA: 0x318FC70 Offset: 0x318BC70 VA: 0x318FC70
	public int get_WaitingUpgradeCount() { }

	// RVA: 0x318FC78 Offset: 0x318BC78 VA: 0x318FC78
	public int get_WaitingWriteCount() { }
}
