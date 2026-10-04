// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Activation
[Serializable]
internal class ContextLevelActivator : IActivator // TypeDefIndex: 10268
{
	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x2EE9D14 Offset: 0x2EE5D14 VA: 0x2EE9D14
	public void .ctor(IActivator next) { }

	// RVA: 0x2EEA830 Offset: 0x2EE6830 VA: 0x2EEA830 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x2EEA838 Offset: 0x2EE6838 VA: 0x2EEA838 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}
