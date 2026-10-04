// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Proxies
[ComVisible(True)]
public abstract class RealProxy // TypeDefIndex: 10224
{
	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x2EE0508 Offset: 0x2EDC508 VA: 0x2EE0508
	protected void .ctor() { }

	// RVA: 0x2EE0518 Offset: 0x2EDC518 VA: 0x2EE0518
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x2EE0618 Offset: 0x2EDC618 VA: 0x2EE0618
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x2EE0520 Offset: 0x2EDC520 VA: 0x2EE0520
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x2EE0648 Offset: 0x2EDC648 VA: 0x2EE0648
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x2ED96D8 Offset: 0x2ED56D8 VA: 0x2ED96D8
	public Type GetProxiedType() { }

	// RVA: 0x2EE064C Offset: 0x2EDC64C VA: 0x2EE064C Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EE06C8 Offset: 0x2EDC6C8 VA: 0x2EE06C8
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x2EE06D0 Offset: 0x2EDC6D0 VA: 0x2EE06D0
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x2EDF8F8 Offset: 0x2EDB8F8 VA: 0x2EDF8F8
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x2EE0EA8 Offset: 0x2EDCEA8 VA: 0x2EE0EA8 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x2EE0EAC Offset: 0x2EDCEAC VA: 0x2EE0EAC Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x2EE102C Offset: 0x2EDD02C VA: 0x2EE102C
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x2EE1034 Offset: 0x2EDD034 VA: 0x2EE1034
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x2EE103C Offset: 0x2EDD03C VA: 0x2EE103C
	internal object GetAppDomainTarget() { }

	// RVA: 0x2EE07B4 Offset: 0x2EDC7B4 VA: 0x2EE07B4
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }
}
