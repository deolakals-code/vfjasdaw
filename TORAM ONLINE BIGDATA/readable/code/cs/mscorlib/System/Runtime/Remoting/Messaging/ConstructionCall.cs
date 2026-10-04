// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 10296
{
	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x2EF1300 Offset: 0x2EED300 VA: 0x2EF1300
	internal void .ctor(Type type) { }

	// RVA: 0x2EF1370 Offset: 0x2EED370 VA: 0x2EF1370
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EF141C Offset: 0x2EED41C VA: 0x2EF141C Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x2EF1574 Offset: 0x2EED574 VA: 0x2EF1574
	internal bool get_IsContextOk() { }

	// RVA: 0x2EF157C Offset: 0x2EED57C VA: 0x2EF157C
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x2EF1588 Offset: 0x2EED588 VA: 0x2EF1588 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x2EF165C Offset: 0x2EED65C VA: 0x2EF165C Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x2EF1664 Offset: 0x2EED664 VA: 0x2EF1664 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x2EF166C Offset: 0x2EED66C VA: 0x2EF166C Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x2EF1674 Offset: 0x2EED674 VA: 0x2EF1674 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x2EF167C Offset: 0x2EED67C VA: 0x2EF167C
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x2EF1684 Offset: 0x2EED684 VA: 0x2EF1684 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x2EF16F4 Offset: 0x2EED6F4 VA: 0x2EF16F4 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x2EF1DF8 Offset: 0x2EEDDF8 VA: 0x2EF1DF8 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EF23E8 Offset: 0x2EEE3E8 VA: 0x2EF23E8 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x2EF2448 Offset: 0x2EEE448 VA: 0x2EF2448
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x2EF2450 Offset: 0x2EEE450 VA: 0x2EF2450
	internal void set_SourceProxy(RemotingProxy value) { }
}
