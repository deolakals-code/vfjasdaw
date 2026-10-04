// Assembly: mscorlib.dll
// Namespace: System.Threading
[Serializable]
public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 9902
{
	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0
	internal static readonly ExecutionContext Default; // 0x8

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x304EF4C Offset: 0x304AF4C VA: 0x304EF4C
	internal bool get_isNewCapture() { }

	// RVA: 0x304EF60 Offset: 0x304AF60 VA: 0x304EF60
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x304EF70 Offset: 0x304AF70 VA: 0x304EF70
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x304EF7C Offset: 0x304AF7C VA: 0x304EF7C
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x304EF9C Offset: 0x304AF9C VA: 0x304EF9C
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304EFA8 Offset: 0x304AFA8 VA: 0x304EFA8
	internal void .ctor() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304EFB0 Offset: 0x304AFB0 VA: 0x304EFB0
	internal void .ctor(bool isPreAllocatedDefault) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x304EA94 Offset: 0x304AA94 VA: 0x304EA94
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x304EFE0 Offset: 0x304AFE0 VA: 0x304EFE0
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x304F050 Offset: 0x304B050 VA: 0x304F050
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x304F058 Offset: 0x304B058 VA: 0x304F058
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x304F0C8 Offset: 0x304B0C8 VA: 0x304F0C8
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304F0D0 Offset: 0x304B0D0 VA: 0x304F0D0
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304F0D8 Offset: 0x304B0D8 VA: 0x304F0D8
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304F0E0 Offset: 0x304B0E0 VA: 0x304F0E0
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304F0E8 Offset: 0x304B0E8 VA: 0x304F0E8
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x304F0F0 Offset: 0x304B0F0 VA: 0x304F0F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x304B7EC Offset: 0x30477EC VA: 0x304B7EC
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowed]
	// RVA: 0x304F0F4 Offset: 0x304B0F4 VA: 0x304F0F4
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x304F368 Offset: 0x304B368 VA: 0x304F368
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x304F170 Offset: 0x304B170 VA: 0x304F170
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x304F6B0 Offset: 0x304B6B0 VA: 0x304F6B0
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x304F47C Offset: 0x304B47C VA: 0x304F47C
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x304F4E8 Offset: 0x304B4E8 VA: 0x304F4E8
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x304F79C Offset: 0x304B79C VA: 0x304F79C
	public ExecutionContext CreateCopy() { }

	// RVA: 0x304F914 Offset: 0x304B914 VA: 0x304F914
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x304FA54 Offset: 0x304BA54 VA: 0x304FA54
	public static bool IsFlowSuppressed() { }

	// RVA: 0x3047D9C Offset: 0x3043D9C VA: 0x3047D9C
	public static ExecutionContext Capture() { }

	[FriendAccessAllowed]
	// RVA: 0x304FC70 Offset: 0x304BC70 VA: 0x304FC70
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x304FA94 Offset: 0x304BA94 VA: 0x304FA94
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x304FCF4 Offset: 0x304BCF4 VA: 0x304FCF4 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x304FE00 Offset: 0x304BE00 VA: 0x304FE00
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x304F404 Offset: 0x304B404 VA: 0x304F404
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x304FF18 Offset: 0x304BF18 VA: 0x304FF18
	private static void .cctor() { }
}
