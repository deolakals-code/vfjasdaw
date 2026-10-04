// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivationAttribute : Attribute, IContextAttribute // TypeDefIndex: 10272
{
	// Fields
	private IList _contextProperties; // 0x10

	// Methods

	// RVA: 0x2EEAB74 Offset: 0x2EE6B74 VA: 0x2EEAB74
	public void .ctor(IList contextProperties) { }

	// RVA: 0x2EEABA4 Offset: 0x2EE6BA4 VA: 0x2EEABA4 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage ctor) { }

	// RVA: 0x2EEABAC Offset: 0x2EE6BAC VA: 0x2EEABAC Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage ctor) { }
}
