// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Activation
internal class ActivationServices // TypeDefIndex: 10265
{
	// Fields
	private static IActivator _constructionActivator; // 0x0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0x2EE9A5C Offset: 0x2EE5A5C VA: 0x2EE9A5C
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0x2EE268C Offset: 0x2EDE68C VA: 0x2EE268C
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0x2EE9B00 Offset: 0x2EE5B00 VA: 0x2EE9B00
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0x2EE1168 Offset: 0x2EDD168 VA: 0x2EE1168
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x2EE9D44 Offset: 0x2EE5D44 VA: 0x2EE9D44
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0x2EEA140 Offset: 0x2EE6140 VA: 0x2EEA140
	public static object CreateProxyForType(Type type) { }

	// RVA: 0x2EEA13C Offset: 0x2EE613C VA: 0x2EEA13C
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0x2ECFF0C Offset: 0x2ECBF0C VA: 0x2ECFF0C
	public static void EnableProxyActivation(Type type, bool enable) { }
}
