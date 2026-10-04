// Assembly: mscorlib.dll
// Namespace: System.Threading
public class SynchronizationContext // TypeDefIndex: 9905
{
	// Fields
	private SynchronizationContextProperties _props; // 0x10
	private static Type s_cachedPreparedType1; // 0x0
	private static Type s_cachedPreparedType2; // 0x8
	private static Type s_cachedPreparedType3; // 0x10
	private static Type s_cachedPreparedType4; // 0x18
	private static Type s_cachedPreparedType5; // 0x20

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }
	internal static SynchronizationContext CurrentExplicit { get; }

	// Methods

	// RVA: 0x30502E8 Offset: 0x304C2E8 VA: 0x30502E8
	public void .ctor() { }

	// RVA: 0x30502F0 Offset: 0x304C2F0 VA: 0x30502F0
	public bool IsWaitNotificationRequired() { }

	// RVA: 0x30502FC Offset: 0x304C2FC VA: 0x30502FC Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x3050324 Offset: 0x304C324 VA: 0x3050324 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x30504B0 Offset: 0x304C4B0 VA: 0x30504B0 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x30504B4 Offset: 0x304C4B4 VA: 0x30504B4 Slot: 7
	public virtual void OperationCompleted() { }

	[PrePrepareMethod]
	[CLSCompliant(False)]
	// RVA: 0x30504B8 Offset: 0x304C4B8 VA: 0x30504B8 Slot: 8
	public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[PrePrepareMethod]
	[ReliabilityContract(3, 1)]
	[CLSCompliant(False)]
	// RVA: 0x305051C Offset: 0x304C51C VA: 0x305051C
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	// RVA: 0x30505A4 Offset: 0x304C5A4 VA: 0x30505A4
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x3047D60 Offset: 0x3043D60 VA: 0x3047D60
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowed]
	// RVA: 0x30506CC Offset: 0x304C6CC VA: 0x30506CC
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x3050680 Offset: 0x304C680 VA: 0x3050680
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x3050868 Offset: 0x304C868 VA: 0x3050868 Slot: 9
	public virtual SynchronizationContext CreateCopy() { }

	// RVA: 0x30508BC Offset: 0x304C8BC VA: 0x30508BC
	internal static SynchronizationContext get_CurrentExplicit() { }
}
