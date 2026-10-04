// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Proxies
internal class TransparentProxy // TypeDefIndex: 10223
{
	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x2EDF4CC Offset: 0x2EDB4CC VA: 0x2EDF4CC
	internal RuntimeType GetProxyType() { }

	// RVA: 0x2EDF59C Offset: 0x2EDB59C VA: 0x2EDF59C
	private bool get_IsContextBoundObject() { }

	// RVA: 0x2EDF5B8 Offset: 0x2EDB5B8 VA: 0x2EDF5B8
	private Context get_TargetContext() { }

	// RVA: 0x2EDF5D4 Offset: 0x2EDB5D4 VA: 0x2EDF5D4
	private bool InCurrentContext() { }

	// RVA: 0x2EDF614 Offset: 0x2EDB614 VA: 0x2EDF614
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x2EE0210 Offset: 0x2EDC210 VA: 0x2EE0210
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x2EE0500 Offset: 0x2EDC500 VA: 0x2EE0500
	public void .ctor() { }
}
