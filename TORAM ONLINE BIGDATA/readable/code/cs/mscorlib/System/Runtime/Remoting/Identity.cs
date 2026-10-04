// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal abstract class Identity // TypeDefIndex: 10196
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x2ECCCCC Offset: 0x2EC8CCC VA: 0x2ECCCCC
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x2ECCCFC Offset: 0x2EC8CFC VA: 0x2ECCCFC
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x2ECCD04 Offset: 0x2EC8D04 VA: 0x2ECCD04
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x2ECCD0C Offset: 0x2EC8D0C VA: 0x2ECCD0C
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x2ECCD14 Offset: 0x2EC8D14 VA: 0x2ECCD14
	public string get_ObjectUri() { }

	// RVA: 0x2ECCD1C Offset: 0x2EC8D1C VA: 0x2ECCD1C
	public void set_ObjectUri(string value) { }

	// RVA: 0x2ECCD24 Offset: 0x2EC8D24 VA: 0x2ECCD24
	public bool get_IsConnected() { }

	// RVA: 0x2ECCD34 Offset: 0x2EC8D34 VA: 0x2ECCD34
	public bool get_Disposed() { }

	// RVA: 0x2ECCD3C Offset: 0x2EC8D3C VA: 0x2ECCD3C
	public void set_Disposed(bool value) { }

	// RVA: 0x2ECCD48 Offset: 0x2EC8D48 VA: 0x2ECCD48
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x2ECCE20 Offset: 0x2EC8E20 VA: 0x2ECCE20
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x2ECCE90 Offset: 0x2EC8E90 VA: 0x2ECCE90
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x2ECD56C Offset: 0x2EC956C VA: 0x2ECD56C
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}
