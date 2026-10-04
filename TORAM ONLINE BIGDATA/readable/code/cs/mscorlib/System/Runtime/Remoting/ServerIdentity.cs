// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal abstract class ServerIdentity : Identity // TypeDefIndex: 10208
{
	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x2EDCED0 Offset: 0x2ED8ED0 VA: 0x2EDCED0
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x2EDCF30 Offset: 0x2ED8F30 VA: 0x2EDCF30
	public Type get_ObjectType() { }

	// RVA: 0x2ED9CBC Offset: 0x2ED5CBC VA: 0x2ED9CBC
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x2EDD0F8 Offset: 0x2ED90F8 VA: 0x2EDD0F8 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x2EDD1A4 Offset: 0x2ED91A4 VA: 0x2EDD1A4 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x2EDC194 Offset: 0x2ED8194 VA: 0x2EDC194
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x2EDD570 Offset: 0x2ED9570 VA: 0x2EDD570
	public Lease get_Lease() { }

	// RVA: 0x2EDD578 Offset: 0x2ED9578 VA: 0x2EDD578
	public Context get_Context() { }

	// RVA: 0x2EDD580 Offset: 0x2ED9580 VA: 0x2EDD580
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x2EDD0FC Offset: 0x2ED90FC VA: 0x2EDD0FC
	protected void DisposeServerObject() { }
}
