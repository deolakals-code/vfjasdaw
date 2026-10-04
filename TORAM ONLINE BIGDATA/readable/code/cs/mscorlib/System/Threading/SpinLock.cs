// Assembly: mscorlib.dll
// Namespace: System.Threading
[ComVisible(False)]
[DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
[DebuggerDisplay("IsHeld = {IsHeld}")]
public struct SpinLock // TypeDefIndex: 9895
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x304D904 Offset: 0x3049904 VA: 0x304D904
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x304D93C Offset: 0x304993C VA: 0x304D93C
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x304DF14 Offset: 0x3049F14 VA: 0x304DF14
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x304DA40 Offset: 0x3049A40 VA: 0x304DA40
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x304E1B8 Offset: 0x304A1B8 VA: 0x304E1B8
	private void DecrementWaiters() { }

	// RVA: 0x304E050 Offset: 0x304A050 VA: 0x304E050
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304E388 Offset: 0x304A388 VA: 0x304E388
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x304E410 Offset: 0x304A410 VA: 0x304E410
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304E520 Offset: 0x304A520 VA: 0x304E520
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304E034 Offset: 0x304A034 VA: 0x304E034
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x304E5F0 Offset: 0x304A5F0 VA: 0x304E5F0
	private static void .cctor() { }
}
