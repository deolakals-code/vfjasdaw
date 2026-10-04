// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 14416
{
	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
	private static object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public virtual RequestCachePolicy CachePolicy { set; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual WebHeaderCollection Headers { get; }
	public virtual long ContentLength { get; }
	public virtual ICredentials Credentials { get; set; }
	public virtual bool UseDefaultCredentials { get; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual int Timeout { get; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; }

	// Methods

	// RVA: 0x34F2C04 Offset: 0x34EEC04 VA: 0x34F2C04
	private static object get_InternalSyncObject() { }

	// RVA: 0x34F2CD0 Offset: 0x34EECD0 VA: 0x34F2CD0
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x34F30F4 Offset: 0x34EF0F4 VA: 0x34F30F4
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x34F31C4 Offset: 0x34EF1C4 VA: 0x34F31C4
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x34F2F58 Offset: 0x34EEF58 VA: 0x34F2F58
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x34F329C Offset: 0x34EF29C VA: 0x34F329C
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x34E7C00 Offset: 0x34E3C00 VA: 0x34E7C00
	protected void .ctor() { }

	// RVA: 0x34F34AC Offset: 0x34EF4AC VA: 0x34F34AC
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F34B4 Offset: 0x34EF4B4 VA: 0x34F34B4 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F34C0 Offset: 0x34EF4C0 VA: 0x34F34C0 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F34C4 Offset: 0x34EF4C4 VA: 0x34F34C4 Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x34F34C8 Offset: 0x34EF4C8 VA: 0x34F34C8
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x34F3598 Offset: 0x34EF598 VA: 0x34F3598 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x34F35BC Offset: 0x34EF5BC VA: 0x34F35BC Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x34F35E0 Offset: 0x34EF5E0 VA: 0x34F35E0 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x34F3604 Offset: 0x34EF604 VA: 0x34F3604 Slot: 12
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x34F3628 Offset: 0x34EF628 VA: 0x34F3628 Slot: 13
	public virtual long get_ContentLength() { }

	// RVA: 0x34F364C Offset: 0x34EF64C VA: 0x34F364C Slot: 14
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x34F3670 Offset: 0x34EF670 VA: 0x34F3670 Slot: 15
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x34F3694 Offset: 0x34EF694 VA: 0x34F3694 Slot: 16
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x34F36B8 Offset: 0x34EF6B8 VA: 0x34F36B8 Slot: 17
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x34F36DC Offset: 0x34EF6DC VA: 0x34F36DC Slot: 18
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x34F3700 Offset: 0x34EF700 VA: 0x34F3700 Slot: 19
	public virtual int get_Timeout() { }

	// RVA: 0x34F3724 Offset: 0x34EF724 VA: 0x34F3724 Slot: 20
	public virtual WebResponse GetResponse() { }

	// RVA: 0x34F3748 Offset: 0x34EF748 VA: 0x34F3748 Slot: 21
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x34F376C Offset: 0x34EF76C VA: 0x34F376C Slot: 22
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x34F3790 Offset: 0x34EF790 VA: 0x34F3790 Slot: 23
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x34F3A34 Offset: 0x34EFA34 VA: 0x34F3A34
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x34F3A84 Offset: 0x34EFA84 VA: 0x34F3A84 Slot: 24
	public virtual void Abort() { }

	// RVA: 0x34F3AA8 Offset: 0x34EFAA8 VA: 0x34F3AA8
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x34F3AB0 Offset: 0x34EFAB0 VA: 0x34F3AB0
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x34F3AB8 Offset: 0x34EFAB8 VA: 0x34F3AB8
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x34F3C88 Offset: 0x34EFC88 VA: 0x34F3C88
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x34F3F84 Offset: 0x34EFF84 VA: 0x34F3F84
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }
}
