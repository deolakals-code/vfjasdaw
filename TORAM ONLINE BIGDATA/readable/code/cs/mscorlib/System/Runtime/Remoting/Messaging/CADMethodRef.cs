// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CADMethodRef // TypeDefIndex: 10290
{
	// Fields
	private bool ctor; // 0x10
	private string typeName; // 0x18
	private string methodName; // 0x20
	private string[] param_names; // 0x28
	private string[] generic_arg_names; // 0x30

	// Methods

	// RVA: 0x2EEDCA8 Offset: 0x2EE9CA8 VA: 0x2EEDCA8
	private Type[] GetTypes(string[] typeArray) { }

	// RVA: 0x2EEDE10 Offset: 0x2EE9E10 VA: 0x2EEDE10
	public MethodBase Resolve() { }

	// RVA: 0x2EEE2A4 Offset: 0x2EEA2A4 VA: 0x2EEE2A4
	public void .ctor(IMethodMessage msg) { }
}
