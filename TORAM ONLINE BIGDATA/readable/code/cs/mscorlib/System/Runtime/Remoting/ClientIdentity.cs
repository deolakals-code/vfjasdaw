// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal class ClientIdentity : Identity // TypeDefIndex: 10197
{
	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0x2ECD5F0 Offset: 0x2EC95F0 VA: 0x2ECD5F0
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0x2ECD724 Offset: 0x2EC9724 VA: 0x2ECD724
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0x2ECD7AC Offset: 0x2EC97AC VA: 0x2ECD7AC
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x2ECD81C Offset: 0x2EC981C VA: 0x2ECD81C Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x2ECD824 Offset: 0x2EC9824 VA: 0x2ECD824
	public string get_TargetUri() { }
}
