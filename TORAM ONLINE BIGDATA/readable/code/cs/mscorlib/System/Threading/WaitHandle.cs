// Assembly: mscorlib.dll
// Namespace: System.Threading
[ComVisible(True)]
public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 9928
{
	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	private const int ERROR_NOT_OWNED_BY_CALLER = 299;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[Obsolete("Use the SafeWaitHandle property instead.")]
	public virtual IntPtr Handle { get; set; }
	public SafeWaitHandle SafeWaitHandle { get; }

	// Methods

	// RVA: 0x3054C08 Offset: 0x3050C08 VA: 0x3054C08
	protected void .ctor() { }

	// RVA: 0x3054C24 Offset: 0x3050C24 VA: 0x3054C24
	private void Init() { }

	// RVA: 0x3054C9C Offset: 0x3050C9C VA: 0x3054C9C Slot: 7
	public virtual IntPtr get_Handle() { }

	// RVA: 0x3054D1C Offset: 0x3050D1C VA: 0x3054D1C Slot: 8
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x3054E1C Offset: 0x3050E1C VA: 0x3054E1C
	public SafeWaitHandle get_SafeWaitHandle() { }

	// RVA: 0x3054ED4 Offset: 0x3050ED4 VA: 0x3054ED4
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x3054F14 Offset: 0x3050F14 VA: 0x3054F14 Slot: 9
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x3055014 Offset: 0x3051014 VA: 0x3055014 Slot: 10
	public virtual bool WaitOne() { }

	// RVA: 0x3055028 Offset: 0x3051028 VA: 0x3055028 Slot: 11
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x3054F94 Offset: 0x3050F94 VA: 0x3054F94
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x3055038 Offset: 0x3051038 VA: 0x3055038
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x3055320 Offset: 0x3051320 VA: 0x3055320
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x3055A40 Offset: 0x3051A40 VA: 0x3055A40
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	// RVA: 0x30552E8 Offset: 0x30512E8 VA: 0x30552E8
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x30559F4 Offset: 0x30519F4 VA: 0x30559F4
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x3055B6C Offset: 0x3051B6C VA: 0x3055B6C Slot: 12
	public virtual void Close() { }

	// RVA: 0x3055BDC Offset: 0x3051BDC VA: 0x3055BDC Slot: 13
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x3055C24 Offset: 0x3051C24 VA: 0x3055C24 Slot: 6
	public void Dispose() { }

	// RVA: 0x3055124 Offset: 0x3051124 VA: 0x3055124
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x3055620 Offset: 0x3051620 VA: 0x3055620
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x3055C94 Offset: 0x3051C94 VA: 0x3055C94
	internal static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x3055C9C Offset: 0x3051C9C VA: 0x3055C9C
	private static void .cctor() { }
}
