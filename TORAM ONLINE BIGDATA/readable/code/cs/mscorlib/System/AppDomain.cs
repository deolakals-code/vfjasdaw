// Assembly: mscorlib.dll
// Namespace: System
[ClassInterface(0)]
[ComVisible(True)]
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 9770
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStatic]
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGenerated]
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGenerated]
	private EventHandler DomainUnload; // 0x48
	[CompilerGenerated]
	private EventHandler ProcessExit; // 0x50
	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGenerated]
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGenerated]
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGenerated]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }
	[MonoTODO]
	public bool IsHomogenous { get; }
	[MonoTODO]
	public bool IsFullyTrusted { get; }

	// Methods

	[Intrinsic]
	// RVA: 0x302A3A4 Offset: 0x30263A4 VA: 0x302A3A4
	internal static bool IsAppXModel() { }

	// RVA: 0x302A3AC Offset: 0x30263AC VA: 0x302A3AC
	private void .ctor() { }

	// RVA: 0x302A3B4 Offset: 0x30263B4 VA: 0x302A3B4
	private string getFriendlyName() { }

	// RVA: 0x302A3B8 Offset: 0x30263B8 VA: 0x302A3B8
	private static AppDomain getCurDomain() { }

	// RVA: 0x302A3BC Offset: 0x30263BC VA: 0x302A3BC
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x302A3C0 Offset: 0x30263C0 VA: 0x302A3C0
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x302A3C8 Offset: 0x30263C8 VA: 0x302A3C8 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x302A3D0 Offset: 0x30263D0 VA: 0x302A3D0 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x302A3D4 Offset: 0x30263D4 VA: 0x302A3D4 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x302A3DC Offset: 0x30263DC VA: 0x302A3DC
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	// RVA: 0x302A3E4 Offset: 0x30263E4 VA: 0x302A3E4 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x302A408 Offset: 0x3026408 VA: 0x302A408
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	// RVA: 0x302A508 Offset: 0x3026508 VA: 0x302A508
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x302A50C Offset: 0x302650C VA: 0x302A50C
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x302A510 Offset: 0x3026510 VA: 0x302A510
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x302A514 Offset: 0x3026514 VA: 0x302A514
	internal static void InternalPopDomainRef() { }

	// RVA: 0x302A518 Offset: 0x3026518 VA: 0x302A518
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x302A51C Offset: 0x302651C VA: 0x302A51C
	internal static Context InternalGetContext() { }

	// RVA: 0x302A520 Offset: 0x3026520 VA: 0x302A520
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x302A524 Offset: 0x3026524 VA: 0x302A524
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x302A528 Offset: 0x3026528 VA: 0x302A528
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x302A6B8 Offset: 0x30266B8 VA: 0x302A6B8
	internal static string GetProcessGuid() { }

	// RVA: 0x302A750 Offset: 0x3026750 VA: 0x302A750
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x302A754 Offset: 0x3026754 VA: 0x302A754
	public bool IsFinalizingForUnload() { }

	// RVA: 0x302A768 Offset: 0x3026768 VA: 0x302A768
	private int getDomainID() { }

	// RVA: 0x302A770 Offset: 0x3026770 VA: 0x302A770 Slot: 3
	public override string ToString() { }

	// RVA: 0x302A774 Offset: 0x3026774 VA: 0x302A774
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x302A804 Offset: 0x3026804 VA: 0x302A804
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x302AB0C Offset: 0x3026B0C VA: 0x302AB0C
	internal Assembly DoTypeResolve(string name) { }

	// RVA: 0x302ADE0 Offset: 0x3026DE0 VA: 0x302ADE0
	private void DoDomainUnload() { }

	// RVA: 0x302AE04 Offset: 0x3026E04 VA: 0x302AE04
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x302AEDC Offset: 0x3026EDC VA: 0x302AEDC
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGenerated]
	// RVA: 0x302B024 Offset: 0x3027024 VA: 0x302B024 Slot: 9
	public void add_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x302B21C Offset: 0x302721C VA: 0x302B21C Slot: 10
	public void remove_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x302B410 Offset: 0x3027410 VA: 0x302B410 Slot: 11
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x302B4A8 Offset: 0x30274A8 VA: 0x302B4A8 Slot: 12
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x302B540 Offset: 0x3027540 VA: 0x302B540 Slot: 13
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x302B5D8 Offset: 0x30275D8 VA: 0x302B5D8 Slot: 14
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	// RVA: 0x302B670 Offset: 0x3027670 VA: 0x302B670
	public bool get_IsHomogenous() { }

	// RVA: 0x302B678 Offset: 0x3027678 VA: 0x302B678
	public bool get_IsFullyTrusted() { }
}
