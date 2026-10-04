// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class CADMessageBase // TypeDefIndex: 10291
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x2EEE570 Offset: 0x2EEA570 VA: 0x2EEE570
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x2EEE60C Offset: 0x2EEA60C VA: 0x2EEE60C
	internal MethodBase GetMethod() { }

	// RVA: 0x2EEE690 Offset: 0x2EEA690 VA: 0x2EEE690
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x2EEE880 Offset: 0x2EEA880 VA: 0x2EEE880
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x2EEF164 Offset: 0x2EEB164 VA: 0x2EEF164
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x2EEF2A0 Offset: 0x2EEB2A0 VA: 0x2EEF2A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x2EEF450 Offset: 0x2EEB450 VA: 0x2EEF450
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x2EEF618 Offset: 0x2EEB618 VA: 0x2EEF618
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x2EEFDC0 Offset: 0x2EEBDC0 VA: 0x2EEFDC0
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x2EEFED0 Offset: 0x2EEBED0 VA: 0x2EEFED0
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x2EEFFE0 Offset: 0x2EEBFE0 VA: 0x2EEFFE0
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x2EF0230 Offset: 0x2EEC230 VA: 0x2EF0230
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}
