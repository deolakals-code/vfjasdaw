// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[CLSCompliant(False)]
[Serializable]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 10314
{
	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x2EF36CC Offset: 0x2EEF6CC VA: 0x2EF36CC
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x2EF35B8 Offset: 0x2EEF5B8 VA: 0x2EF35B8
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x2EF6880 Offset: 0x2EF2880 VA: 0x2EF6880
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x2EF381C Offset: 0x2EEF81C VA: 0x2EF381C
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EF6B34 Offset: 0x2EF2B34 VA: 0x2EF6B34
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x2EF7000 Offset: 0x2EF3000 VA: 0x2EF7000 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x2EF7018 Offset: 0x2EF3018 VA: 0x2EF7018 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x2EF7020 Offset: 0x2EF3020 VA: 0x2EF7020 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x2EF7028 Offset: 0x2EF3028 VA: 0x2EF7028 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x2EF7098 Offset: 0x2EF3098 VA: 0x2EF7098 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x2EF71BC Offset: 0x2EF31BC VA: 0x2EF71BC Slot: 11
	public string get_MethodName() { }

	// RVA: 0x2EF7354 Offset: 0x2EF3354 VA: 0x2EF7354 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x2EF7474 Offset: 0x2EF3474 VA: 0x2EF7474 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x2EF38A8 Offset: 0x2EEF8A8 VA: 0x2EF38A8 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x2EF7650 Offset: 0x2EF3650 VA: 0x2EF7650 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x2EF7288 Offset: 0x2EF3288 VA: 0x2EF7288 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x2EF7658 Offset: 0x2EF3658 VA: 0x2EF7658 Slot: 14
	public string get_Uri() { }

	// RVA: 0x2EF7724 Offset: 0x2EF3724 VA: 0x2EF7724
	public void set_Uri(string value) { }

	// RVA: 0x2EF772C Offset: 0x2EF372C VA: 0x2EF772C Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x2EF7730 Offset: 0x2EF3730 VA: 0x2EF7730 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x2EF7738 Offset: 0x2EF3738 VA: 0x2EF7738 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x2EF776C Offset: 0x2EF376C VA: 0x2EF776C Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EF7BF4 Offset: 0x2EF3BF4 VA: 0x2EF7BF4 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x2EF7BFC Offset: 0x2EF3BFC VA: 0x2EF7BFC Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}
