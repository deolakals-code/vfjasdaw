// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivator : MarshalByRefObject, IActivator // TypeDefIndex: 10273
{
	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x2EEAF94 Offset: 0x2EE6F94 VA: 0x2EEAF94 Slot: 7
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	// RVA: 0x2EEB424 Offset: 0x2EE7424 VA: 0x2EEB424 Slot: 6
	public IActivator get_NextActivator() { }
}
