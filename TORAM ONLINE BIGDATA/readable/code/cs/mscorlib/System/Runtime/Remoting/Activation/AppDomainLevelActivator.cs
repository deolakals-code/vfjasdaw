// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Activation
internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 10266
{
	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x2EE9CD0 Offset: 0x2EE5CD0 VA: 0x2EE9CD0
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x2EEA26C Offset: 0x2EE626C VA: 0x2EEA26C Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x2EEA274 Offset: 0x2EE6274 VA: 0x2EEA274 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}
