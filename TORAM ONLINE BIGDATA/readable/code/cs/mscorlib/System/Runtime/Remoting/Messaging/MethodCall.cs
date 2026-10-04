// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 10310
{
	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x2EF1374 Offset: 0x2EED374 VA: 0x2EF1374
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EF3E24 Offset: 0x2EEFE24 VA: 0x2EF3E24
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x2EF1368 Offset: 0x2EED368 VA: 0x2EF1368
	internal void .ctor() { }

	// RVA: 0x2EF3F78 Offset: 0x2EEFF78 VA: 0x2EF3F78
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x2EF19B4 Offset: 0x2EED9B4 VA: 0x2EF19B4 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x2EF1F7C Offset: 0x2EEDF7C VA: 0x2EF1F7C Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EF4344 Offset: 0x2EF0344 VA: 0x2EF4344 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x2EF4360 Offset: 0x2EF0360 VA: 0x2EF4360 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x2EF4368 Offset: 0x2EF0368 VA: 0x2EF4368 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x2EF43D8 Offset: 0x2EF03D8 VA: 0x2EF43D8 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x2EF49A8 Offset: 0x2EF09A8 VA: 0x2EF49A8 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x2EF49F0 Offset: 0x2EF09F0 VA: 0x2EF49F0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x2EF2418 Offset: 0x2EEE418 VA: 0x2EF2418 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x2EF4B38 Offset: 0x2EF0B38 VA: 0x2EF4B38 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x2EF4C44 Offset: 0x2EF0C44 VA: 0x2EF4C44 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x2EF4CA0 Offset: 0x2EF0CA0 VA: 0x2EF4CA0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x2EF4CA8 Offset: 0x2EF0CA8 VA: 0x2EF4CA8
	public void set_Uri(string value) { }

	// RVA: 0x2EF4CB0 Offset: 0x2EF0CB0 VA: 0x2EF4CB0 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x2EF4CB8 Offset: 0x2EF0CB8 VA: 0x2EF4CB8 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x2EF4CC0 Offset: 0x2EF0CC0 VA: 0x2EF4CC0 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x2EF4CF0 Offset: 0x2EF0CF0 VA: 0x2EF4CF0 Slot: 23
	public virtual void Init() { }

	// RVA: 0x2EF4408 Offset: 0x2EF0408 VA: 0x2EF4408
	public void ResolveMethod() { }

	// RVA: 0x2EF4CF4 Offset: 0x2EF0CF4 VA: 0x2EF4CF4
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x2EF4EE0 Offset: 0x2EF0EE0 VA: 0x2EF4EE0
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x2EF4F88 Offset: 0x2EF0F88 VA: 0x2EF4F88 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x2EF4F90 Offset: 0x2EF0F90 VA: 0x2EF4F90 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x2EF4E8C Offset: 0x2EF0E8C VA: 0x2EF4E8C
	private Type[] get_GenericArguments() { }
}
