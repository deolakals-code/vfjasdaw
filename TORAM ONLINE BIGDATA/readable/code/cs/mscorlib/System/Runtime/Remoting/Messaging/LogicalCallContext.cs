// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 10282
{
	// Fields
	private static Type s_callContextType; // 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30
	private Header[] _sendHeaders; // 0x38
	private Header[] _recvHeaders; // 0x40

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x2EEBDA4 Offset: 0x2EE7DA4 VA: 0x2EEBDA4
	internal void .ctor() { }

	// RVA: 0x2EEBDAC Offset: 0x2EE7DAC VA: 0x2EEBDAC
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EEC350 Offset: 0x2EE8350 VA: 0x2EEC350 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EEC99C Offset: 0x2EE899C VA: 0x2EEC99C Slot: 5
	public object Clone() { }

	// RVA: 0x2EED0B8 Offset: 0x2EE90B8 VA: 0x2EED0B8
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x2EED2E8 Offset: 0x2EE92E8 VA: 0x2EED2E8
	public bool get_HasInfo() { }

	// RVA: 0x2EEC970 Offset: 0x2EE8970 VA: 0x2EEC970
	private bool get_HasUserData() { }

	// RVA: 0x2EEC2AC Offset: 0x2EE82AC VA: 0x2EEC2AC
	private Hashtable get_Datastore() { }

	// RVA: 0x2EED368 Offset: 0x2EE9368 VA: 0x2EED368
	private static void .cctor() { }
}
