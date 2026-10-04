// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class IllogicalCallContext // TypeDefIndex: 10280
{
	// Fields
	private Hashtable m_Datastore; // 0x10
	private object m_HostContext; // 0x18

	// Properties
	private Hashtable Datastore { get; }
	internal object HostContext { get; set; }
	internal bool HasUserData { get; }

	// Methods

	// RVA: 0x2EEBA94 Offset: 0x2EE7A94 VA: 0x2EEBA94
	private Hashtable get_Datastore() { }

	// RVA: 0x2EEBB04 Offset: 0x2EE7B04 VA: 0x2EEBB04
	internal object get_HostContext() { }

	// RVA: 0x2EEBB0C Offset: 0x2EE7B0C VA: 0x2EEBB0C
	internal void set_HostContext(object value) { }

	// RVA: 0x2EEBB14 Offset: 0x2EE7B14 VA: 0x2EEBB14
	internal bool get_HasUserData() { }

	// RVA: 0x2EEBB40 Offset: 0x2EE7B40 VA: 0x2EEBB40
	public IllogicalCallContext CreateCopy() { }

	// RVA: 0x2EEBD9C Offset: 0x2EE7D9C VA: 0x2EEBD9C
	public void .ctor() { }
}
