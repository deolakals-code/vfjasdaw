// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 10199
{
	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x2ECDDD8 Offset: 0x2EC9DD8 VA: 0x2ECDDD8
	public void .ctor() { }

	// RVA: 0x2ECDE50 Offset: 0x2EC9E50 VA: 0x2ECDE50
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x2ECDE94 Offset: 0x2EC9E94 VA: 0x2ECDE94
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x2ECE128 Offset: 0x2ECA128 VA: 0x2ECE128
	internal byte[] SerializeType() { }

	// RVA: 0x2ECE294 Offset: 0x2ECA294 VA: 0x2ECE294
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x2ECE7D8 Offset: 0x2ECA7D8 VA: 0x2ECE7D8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2ECED98 Offset: 0x2ECAD98 VA: 0x2ECED98
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2ECEE00 Offset: 0x2ECAE00 VA: 0x2ECEE00 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x2ECEE08 Offset: 0x2ECAE08 VA: 0x2ECEE08 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x2ECEE10 Offset: 0x2ECAE10 VA: 0x2ECEE10 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x2ECEE18 Offset: 0x2ECAE18 VA: 0x2ECEE18 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x2ECEE20 Offset: 0x2ECAE20 VA: 0x2ECEE20 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x2ECEE28 Offset: 0x2ECAE28 VA: 0x2ECEE28 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x2ECEE30 Offset: 0x2ECAE30 VA: 0x2ECEE30 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x2ECEE38 Offset: 0x2ECAE38 VA: 0x2ECEE38 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2ECF010 Offset: 0x2ECB010 VA: 0x2ECF010 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x2ECDDF4 Offset: 0x2EC9DF4 VA: 0x2ECDDF4
	internal void UpdateChannelInfo() { }

	// RVA: 0x2ECF10C Offset: 0x2ECB10C VA: 0x2ECF10C
	internal Type get_ServerType() { }

	// RVA: 0x2ECF25C Offset: 0x2ECB25C VA: 0x2ECF25C
	private static void .cctor() { }
}
