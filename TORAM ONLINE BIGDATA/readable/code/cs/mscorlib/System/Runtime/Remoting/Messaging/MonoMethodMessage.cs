// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 10316
{
	// Fields
	private RuntimeMethodInfo method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Identity identity; // 0x68
	private Type[] methodSignature; // 0x70

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x2EF7E34 Offset: 0x2EF3E34 VA: 0x2EF7E34
	internal void InitMessage(RuntimeMethodInfo method, object[] out_args) { }

	// RVA: 0x2EF80E4 Offset: 0x2EF40E4 VA: 0x2EF80E4
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x2EF81B4 Offset: 0x2EF41B4 VA: 0x2EF81B4
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x2EF82F0 Offset: 0x2EF42F0 VA: 0x2EF82F0
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x2EF83A0 Offset: 0x2EF43A0 VA: 0x2EF83A0
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x2EF83D8 Offset: 0x2EF43D8 VA: 0x2EF83D8 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x2EF844C Offset: 0x2EF444C VA: 0x2EF844C Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x2EF8500 Offset: 0x2EF4500 VA: 0x2EF8500 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x2EF8508 Offset: 0x2EF4508 VA: 0x2EF8508 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x2EF8510 Offset: 0x2EF4510 VA: 0x2EF8510
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x2EF8518 Offset: 0x2EF4518 VA: 0x2EF8518 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x2EF8520 Offset: 0x2EF4520 VA: 0x2EF8520 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x2EF85A0 Offset: 0x2EF45A0 VA: 0x2EF85A0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x2EF86D4 Offset: 0x2EF46D4 VA: 0x2EF86D4 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x2EF8768 Offset: 0x2EF4768 VA: 0x2EF8768 Slot: 19
	public string get_Uri() { }

	// RVA: 0x2EF8770 Offset: 0x2EF4770 VA: 0x2EF8770 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x2EF8778 Offset: 0x2EF4778 VA: 0x2EF8778 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x2EF87AC Offset: 0x2EF47AC VA: 0x2EF87AC Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x2EF87B4 Offset: 0x2EF47B4 VA: 0x2EF87B4 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x2EF8818 Offset: 0x2EF4818 VA: 0x2EF8818 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x2EF8954 Offset: 0x2EF4954 VA: 0x2EF8954 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x2EF895C Offset: 0x2EF495C VA: 0x2EF895C Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x2EF8964 Offset: 0x2EF4964 VA: 0x2EF8964 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x2EF896C Offset: 0x2EF496C VA: 0x2EF896C
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x2EF8484 Offset: 0x2EF4484 VA: 0x2EF8484
	internal CallType get_CallType() { }

	// RVA: 0x2EF8974 Offset: 0x2EF4974 VA: 0x2EF8974
	public bool NeedsOutProcessing(out int outCount) { }
}
