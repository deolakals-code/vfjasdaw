// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public static class RemotingServices // TypeDefIndex: 10207
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x2ED7D6C Offset: 0x2ED3D6C VA: 0x2ED7D6C
	private static void .cctor() { }

	// RVA: 0x2ED80A0 Offset: 0x2ED40A0 VA: 0x2ED80A0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x2ED80A4 Offset: 0x2ED40A4 VA: 0x2ED80A4
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x2ED80A8 Offset: 0x2ED40A8 VA: 0x2ED80A8
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x2ED80E0 Offset: 0x2ED40E0 VA: 0x2ED80E0
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisible(True)]
	// RVA: 0x2ED8AD4 Offset: 0x2ED4AD4 VA: 0x2ED8AD4
	public static object Connect(Type classToProxy, string url) { }

	[ComVisible(True)]
	// RVA: 0x2ED8BDC Offset: 0x2ED4BDC VA: 0x2ED8BDC
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x2ED8C7C Offset: 0x2ED4C7C VA: 0x2ED8C7C
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x2ECF0B4 Offset: 0x2ECB0B4 VA: 0x2ECF0B4
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x2ED8F74 Offset: 0x2ED4F74 VA: 0x2ED8F74
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x2ED95CC Offset: 0x2ED55CC VA: 0x2ED95CC
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x2ED9618 Offset: 0x2ED5618 VA: 0x2ED9618
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x2ED9784 Offset: 0x2ED5784 VA: 0x2ED9784
	private static string NewUri() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2ED9690 Offset: 0x2ED5690 VA: 0x2ED9690
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x2EDA2AC Offset: 0x2ED62AC VA: 0x2EDA2AC
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x2EDA58C Offset: 0x2ED658C VA: 0x2EDA58C
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x2EDA76C Offset: 0x2ED676C VA: 0x2EDA76C
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x2EDA89C Offset: 0x2ED689C VA: 0x2EDA89C
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EDA948 Offset: 0x2ED6948 VA: 0x2EDA948
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x2EDA9E0 Offset: 0x2ED69E0 VA: 0x2EDA9E0
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x2EDAADC Offset: 0x2ED6ADC VA: 0x2EDAADC
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x2EDAD3C Offset: 0x2ED6D3C VA: 0x2EDAD3C
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x2EDADA4 Offset: 0x2ED6DA4 VA: 0x2EDADA4
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x2ED8D24 Offset: 0x2ED4D24 VA: 0x2ED8D24
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x2EDAF98 Offset: 0x2ED6F98 VA: 0x2EDAF98
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x2EDB08C Offset: 0x2ED708C VA: 0x2EDB08C
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x2EDAC0C Offset: 0x2ED6C0C VA: 0x2EDAC0C
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x2EDC0A4 Offset: 0x2ED80A4 VA: 0x2EDC0A4
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x2EDA168 Offset: 0x2ED6168 VA: 0x2EDA168
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x2ED0450 Offset: 0x2ECC450 VA: 0x2ED0450
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x2ED9ABC Offset: 0x2ED5ABC VA: 0x2ED9ABC
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x2ED94D8 Offset: 0x2ED54D8 VA: 0x2ED94D8
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x2ED8B68 Offset: 0x2ED4B68 VA: 0x2ED8B68
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x2EDC210 Offset: 0x2ED8210 VA: 0x2EDC210
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x2EDC438 Offset: 0x2ED8438 VA: 0x2EDC438
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x2EDC67C Offset: 0x2ED867C VA: 0x2EDC67C
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x2ED8054 Offset: 0x2ED4054 VA: 0x2ED8054
	private static void RegisterInternalChannels() { }

	// RVA: 0x2EDB594 Offset: 0x2ED7594 VA: 0x2EDB594
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x2EDC920 Offset: 0x2ED8920 VA: 0x2EDC920
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x2EDCC54 Offset: 0x2ED8C54 VA: 0x2EDCC54
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x2EDCD68 Offset: 0x2ED8D68 VA: 0x2EDCD68
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x2EDAF20 Offset: 0x2ED6F20 VA: 0x2EDAF20
	private static string GetNormalizedUri(string uri) { }
}
