// Assembly: mscorlib.dll
// Namespace: System.Threading
public sealed class Thread : CriticalFinalizerObject // TypeDefIndex: 9911
{
	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	[ThreadStatic]
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x28
	private ExecutionContext m_ExecutionContext; // 0x30
	private bool m_ExecutionContextBelongsToOuterScope; // 0x38
	private IPrincipal principal; // 0x40
	private int principal_version; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public CultureInfo CurrentUICulture { get; }
	public CultureInfo CurrentCulture { get; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	internal static int CurrentThreadId { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsBackground { set; }
	public string Name { set; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x30512BC Offset: 0x304D2BC VA: 0x30512BC
	public void .ctor(ThreadStart start) { }

	// RVA: 0x305145C Offset: 0x304D45C VA: 0x305145C
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x30514D8 Offset: 0x304D4D8 VA: 0x30514D8
	public void .ctor(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x30515C0 Offset: 0x304D5C0 VA: 0x30515C0
	public void Start() { }

	// RVA: 0x30516A0 Offset: 0x304D6A0 VA: 0x30516A0
	public void Start(object parameter) { }

	// RVA: 0x30515D4 Offset: 0x304D5D4 VA: 0x30515D4
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304EA40 Offset: 0x304AA40 VA: 0x304EA40
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x304F718 Offset: 0x304B718 VA: 0x304F718
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x304F728 Offset: 0x304B728 VA: 0x304F728
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x30505EC Offset: 0x304C5EC VA: 0x30505EC
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304F768 Offset: 0x304B768 VA: 0x304F768
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304EA60 Offset: 0x304AA60 VA: 0x304EA60
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x30517E0 Offset: 0x304D7E0 VA: 0x30517E0
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x304E284 Offset: 0x304A284 VA: 0x304E284
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x30517E4 Offset: 0x304D7E4 VA: 0x30517E4
	private static bool YieldInternal() { }

	// RVA: 0x304E2FC Offset: 0x304A2FC VA: 0x304E2FC
	public static bool Yield() { }

	// RVA: 0x3051338 Offset: 0x304D338 VA: 0x3051338
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x30518E0 Offset: 0x304D8E0 VA: 0x30518E0
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x305190C Offset: 0x304D90C VA: 0x305190C
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x30519B8 Offset: 0x304D9B8 VA: 0x30519B8
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x30519E4 Offset: 0x304D9E4 VA: 0x30519E4
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x3051A90 Offset: 0x304DA90 VA: 0x3051A90
	public static void MemoryBarrier() { }

	// RVA: 0x3051A94 Offset: 0x304DA94 VA: 0x3051A94
	private void ConstructInternalThread() { }

	// RVA: 0x3051A98 Offset: 0x304DA98 VA: 0x3051A98
	private InternalThread get_Internal() { }

	// RVA: 0x3051ABC Offset: 0x304DABC VA: 0x3051ABC
	public static Context get_CurrentContext() { }

	// RVA: 0x3051AC4 Offset: 0x304DAC4 VA: 0x3051AC4
	private static void GetCurrentThread_icall(ref Thread thread) { }

	// RVA: 0x3051AC8 Offset: 0x304DAC8 VA: 0x3051AC8
	private static Thread GetCurrentThread() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x304E300 Offset: 0x304A300 VA: 0x304E300
	public static Thread get_CurrentThread() { }

	// RVA: 0x3051AE4 Offset: 0x304DAE4 VA: 0x3051AE4
	internal static int get_CurrentThreadId() { }

	// RVA: 0x3051B08 Offset: 0x304DB08 VA: 0x3051B08
	public static int GetDomainID() { }

	// RVA: 0x3051B0C Offset: 0x304DB0C VA: 0x3051B0C
	private bool Thread_internal(MulticastDelegate start) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3051B10 Offset: 0x304DB10 VA: 0x3051B10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3051B18 Offset: 0x304DB18 VA: 0x3051B18
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x3051B1C Offset: 0x304DB1C VA: 0x3051B1C
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x3051B48 Offset: 0x304DB48 VA: 0x3051B48
	public void set_IsBackground(bool value) { }

	// RVA: 0x3051C08 Offset: 0x304DC08 VA: 0x3051C08
	private static void SetName_icall(InternalThread thread, char* name, int nameLength) { }

	// RVA: 0x3051C0C Offset: 0x304DC0C VA: 0x3051C0C
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x3051C48 Offset: 0x304DC48 VA: 0x3051C48
	public void set_Name(string value) { }

	// RVA: 0x3051C7C Offset: 0x304DC7C VA: 0x3051C7C
	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	// RVA: 0x3051C80 Offset: 0x304DC80 VA: 0x3051C80
	public void Abort() { }

	// RVA: 0x3051CA8 Offset: 0x304DCA8 VA: 0x3051CA8
	private static void SpinWait_nop() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304E25C Offset: 0x304A25C VA: 0x304E25C
	public static void SpinWait(int iterations) { }

	// RVA: 0x3051770 Offset: 0x304D770 VA: 0x3051770
	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x3051C00 Offset: 0x304DC00 VA: 0x3051C00
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x3051C04 Offset: 0x304DC04 VA: 0x3051C04
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x3051CAC Offset: 0x304DCAC VA: 0x3051CAC
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x3051CB0 Offset: 0x304DCB0 VA: 0x3051CB0
	private static int SystemMaxStackStize() { }

	// RVA: 0x30517E8 Offset: 0x304D7E8 VA: 0x30517E8
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x3051894 Offset: 0x304D894 VA: 0x3051894
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304E35C Offset: 0x304A35C VA: 0x304E35C
	public int get_ManagedThreadId() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x304D9F0 Offset: 0x30499F0 VA: 0x304D9F0
	public static void BeginCriticalRegion() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304DFE4 Offset: 0x3049FE4 VA: 0x304DFE4
	public static void EndCriticalRegion() { }

	[ComVisible(False)]
	// RVA: 0x3051CB4 Offset: 0x304DCB4 VA: 0x3051CB4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3051B90 Offset: 0x304DB90 VA: 0x3051B90
	private ThreadState ValidateThreadState() { }
}
