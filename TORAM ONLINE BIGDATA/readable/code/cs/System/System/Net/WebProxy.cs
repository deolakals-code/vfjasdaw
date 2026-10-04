// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 14456
{
	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x3504598 Offset: 0x3500598 VA: 0x3504598
	public void .ctor() { }

	// RVA: 0x35045AC Offset: 0x35005AC VA: 0x35045AC
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x35048E0 Offset: 0x35008E0 VA: 0x35048E0 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x35048E8 Offset: 0x35008E8 VA: 0x35048E8
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x3504964 Offset: 0x3500964 VA: 0x3504964
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x35049DC Offset: 0x35009DC VA: 0x35049DC Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x3504680 Offset: 0x3500680 VA: 0x3504680
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x3504CA0 Offset: 0x3500CA0 VA: 0x3504CA0
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x3504E38 Offset: 0x3500E38 VA: 0x3504E38
	private bool IsLocal(Uri host) { }

	// RVA: 0x3504F94 Offset: 0x3500F94 VA: 0x3504F94
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x3505084 Offset: 0x3501084 VA: 0x3505084 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x3504BD8 Offset: 0x3500BD8 VA: 0x3504BD8
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x35051C0 Offset: 0x35011C0 VA: 0x35051C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x350554C Offset: 0x350154C VA: 0x350554C Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3505558 Offset: 0x3501558 VA: 0x3505558 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x350567C Offset: 0x350167C VA: 0x350567C
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x3505684 Offset: 0x3501684 VA: 0x3505684
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x35056E4 Offset: 0x35016E4 VA: 0x35056E4
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x3505540 Offset: 0x3501540 VA: 0x3505540
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x3504B5C Offset: 0x3500B5C VA: 0x3504B5C
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x3505158 Offset: 0x3501158 VA: 0x3505158
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x3505734 Offset: 0x3501734 VA: 0x3505734
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x3505A38 Offset: 0x3501A38 VA: 0x3505A38
	private static Uri ProxyUri(string proxyName) { }
}
