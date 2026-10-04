// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public class Context // TypeDefIndex: 10234
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStatic]
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x2EE45F0 Offset: 0x2EE05F0 VA: 0x2EE45F0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x2EE45F4 Offset: 0x2EE05F4 VA: 0x2EE45F4
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x2EE45F8 Offset: 0x2EE05F8 VA: 0x2EE45F8
	public void .ctor() { }

	// RVA: 0x2EE467C Offset: 0x2EE067C VA: 0x2EE467C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2EDC18C Offset: 0x2ED818C VA: 0x2EDC18C
	public static Context get_DefaultContext() { }

	// RVA: 0x2EE474C Offset: 0x2EE074C VA: 0x2EE474C Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x2EE4754 Offset: 0x2EE0754 VA: 0x2EE4754 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x2EE47C8 Offset: 0x2EE07C8 VA: 0x2EE47C8
	internal bool get_IsDefaultContext() { }

	// RVA: 0x2EE47D8 Offset: 0x2EE07D8 VA: 0x2EE47D8
	internal bool get_NeedsContextSink() { }

	// RVA: 0x2EE48B8 Offset: 0x2EE08B8 VA: 0x2EE48B8
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x2EE4DB4 Offset: 0x2EE0DB4 VA: 0x2EE4DB4
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x2EE4930 Offset: 0x2EE0930 VA: 0x2EE4930
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x2EE4F98 Offset: 0x2EE0F98 VA: 0x2EE4F98
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x2EE5098 Offset: 0x2EE1098 VA: 0x2EE5098
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x2EE513C Offset: 0x2EE113C VA: 0x2EE513C
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x2EE51C0 Offset: 0x2EE11C0 VA: 0x2EE51C0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x2EE2124 Offset: 0x2EDE124 VA: 0x2EE2124
	internal bool get_HasExitSinks() { }

	// RVA: 0x2EE5200 Offset: 0x2EE1200 VA: 0x2EE5200 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x2EE53F8 Offset: 0x2EE13F8 VA: 0x2EE53F8 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x2EE55AC Offset: 0x2EE15AC VA: 0x2EE55AC Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x2EE5758 Offset: 0x2EE1758 VA: 0x2EE5758 Slot: 3
	public override string ToString() { }

	// RVA: 0x2EE57B4 Offset: 0x2EE17B4 VA: 0x2EE57B4
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x2EE21DC Offset: 0x2EDE1DC VA: 0x2EE21DC
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x2EDD9E8 Offset: 0x2ED99E8 VA: 0x2EDD9E8
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x2EDD36C Offset: 0x2ED936C VA: 0x2EDD36C
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x2EE5990 Offset: 0x2EE1990 VA: 0x2EE5990
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x2EE5998 Offset: 0x2EE1998 VA: 0x2EE5998
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x2EE61D8 Offset: 0x2EE21D8 VA: 0x2EE61D8
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x2EE635C Offset: 0x2EE235C VA: 0x2EE635C
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x2EE64D4 Offset: 0x2EE24D4 VA: 0x2EE64D4
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x2EE6538 Offset: 0x2EE2538 VA: 0x2EE6538
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x2EE65A4 Offset: 0x2EE25A4 VA: 0x2EE65A4
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x2EE6610 Offset: 0x2EE2610 VA: 0x2EE6610
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x2EE667C Offset: 0x2EE267C VA: 0x2EE667C
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x2EE66AC Offset: 0x2EE26AC VA: 0x2EE66AC
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x2EE66EC Offset: 0x2EE26EC VA: 0x2EE66EC
	private static void .cctor() { }
}
