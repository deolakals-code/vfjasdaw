// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 10322
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x2EF905C Offset: 0x2EF505C VA: 0x2EF905C
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x2EF9224 Offset: 0x2EF5224 VA: 0x2EF9224
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x2EF9398 Offset: 0x2EF5398 VA: 0x2EF9398 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x2EF93B4 Offset: 0x2EF53B4 VA: 0x2EF93B4 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x2EF93BC Offset: 0x2EF53BC VA: 0x2EF93BC Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x2EF942C Offset: 0x2EF542C VA: 0x2EF942C Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x2EF9434 Offset: 0x2EF5434 VA: 0x2EF9434 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x2EF9498 Offset: 0x2EF5498 VA: 0x2EF9498 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x2EF95E0 Offset: 0x2EF55E0 VA: 0x2EF95E0 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x2EF9654 Offset: 0x2EF5654 VA: 0x2EF9654 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x2EF96CC Offset: 0x2EF56CC VA: 0x2EF96CC Slot: 14
	public string get_Uri() { }

	// RVA: 0x2EF96D4 Offset: 0x2EF56D4 VA: 0x2EF96D4
	public void set_Uri(string value) { }

	// RVA: 0x2EF96DC Offset: 0x2EF56DC VA: 0x2EF96DC Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x2EF96E4 Offset: 0x2EF56E4 VA: 0x2EF96E4 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x2EF96EC Offset: 0x2EF56EC VA: 0x2EF96EC Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x2EF971C Offset: 0x2EF571C VA: 0x2EF971C Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x2EF9724 Offset: 0x2EF5724 VA: 0x2EF9724 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x2EF97E8 Offset: 0x2EF57E8 VA: 0x2EF97E8 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x2EF97F0 Offset: 0x2EF57F0 VA: 0x2EF97F0 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x2EF97F8 Offset: 0x2EF57F8 VA: 0x2EF97F8 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}
