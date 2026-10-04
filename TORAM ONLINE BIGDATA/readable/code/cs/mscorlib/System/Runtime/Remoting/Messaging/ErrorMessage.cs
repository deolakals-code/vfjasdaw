// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 10300
{
	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x2EF3B28 Offset: 0x2EEFB28 VA: 0x2EF3B28
	public void .ctor() { }

	// RVA: 0x2EF3B80 Offset: 0x2EEFB80 VA: 0x2EF3B80 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x2EF3B88 Offset: 0x2EEFB88 VA: 0x2EF3B88 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x2EF3B90 Offset: 0x2EEFB90 VA: 0x2EF3B90 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x2EF3B98 Offset: 0x2EEFB98 VA: 0x2EF3B98 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x2EF3BD8 Offset: 0x2EEFBD8 VA: 0x2EF3BD8 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x2EF3BE0 Offset: 0x2EEFBE0 VA: 0x2EF3BE0 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x2EF3BE8 Offset: 0x2EEFBE8 VA: 0x2EF3BE8 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x2EF3C28 Offset: 0x2EEFC28 VA: 0x2EF3C28 Slot: 11
	public string get_Uri() { }

	// RVA: 0x2EF3C30 Offset: 0x2EEFC30 VA: 0x2EF3C30 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x2EF3C38 Offset: 0x2EEFC38 VA: 0x2EF3C38 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }
}
