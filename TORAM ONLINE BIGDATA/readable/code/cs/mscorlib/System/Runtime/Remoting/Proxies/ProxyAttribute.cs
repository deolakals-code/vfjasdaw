// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Proxies
[Usage(4)]
[ComVisible(True)]
public class ProxyAttribute : Attribute, IContextAttribute // TypeDefIndex: 10222
{
	// Methods

	// RVA: 0x2EDF378 Offset: 0x2EDB378 VA: 0x2EDF378 Slot: 9
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x2EDF46C Offset: 0x2EDB46C VA: 0x2EDF46C Slot: 10
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[ComVisible(True)]
	// RVA: 0x2EDF4C0 Offset: 0x2EDB4C0 VA: 0x2EDF4C0 Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[ComVisible(True)]
	// RVA: 0x2EDF4C4 Offset: 0x2EDB4C4 VA: 0x2EDF4C4 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }
}
