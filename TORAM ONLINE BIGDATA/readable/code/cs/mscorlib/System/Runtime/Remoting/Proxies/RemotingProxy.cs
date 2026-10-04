// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Proxies
internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 10225
{
	// Fields
	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x2EDB794 Offset: 0x2ED7794 VA: 0x2EDB794
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x2EDACE8 Offset: 0x2ED6CE8 VA: 0x2EDACE8
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x2EE1B5C Offset: 0x2EDDB5C VA: 0x2EE1B5C Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x2EE23FC Offset: 0x2EDE3FC VA: 0x2EE23FC
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x2EE06D8 Offset: 0x2EDC6D8 VA: 0x2EE06D8
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x2EE28BC Offset: 0x2EDE8BC VA: 0x2EE28BC Slot: 8
	public string get_TypeName() { }

	// RVA: 0x2EE29F4 Offset: 0x2EDE9F4 VA: 0x2EE29F4 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x2EE2C0C Offset: 0x2EDEC0C VA: 0x2EE2C0C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2EE2D24 Offset: 0x2EDED24 VA: 0x2EE2D24
	private static void .cctor() { }
}
