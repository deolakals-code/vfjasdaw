// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable // TypeDefIndex: 17610
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { set; }
	public string error { get; }
	public string url { get; set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	[Obsolete("UnityWebRequest.isNetworkError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ConnectionError) instead.", False)]
	public bool isNetworkError { get; }
	public UnityWebRequest.Result result { get; }
	public float downloadProgress { get; }
	[Obsolete("HTTP/2 and many HTTP/1.1 servers don't support this; we recommend leaving it set to false (default).", False)]
	public bool chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	// RVA: 0x3827914 Offset: 0x3823914 VA: 0x3827914
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModules]
	// RVA: 0x3827950 Offset: 0x3823950 VA: 0x3827950
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGenerated]
	// RVA: 0x382798C Offset: 0x382398C VA: 0x382798C
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x3827994 Offset: 0x3823994 VA: 0x3827994
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38279A0 Offset: 0x38239A0 VA: 0x38279A0
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x38279A8 Offset: 0x38239A8 VA: 0x38279A8
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38279B4 Offset: 0x38239B4 VA: 0x38279B4
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x38279BC Offset: 0x38239BC VA: 0x38279BC
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[NativeThrows]
	// RVA: 0x38279C8 Offset: 0x38239C8 VA: 0x38279C8
	internal static IntPtr Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x38279F0 Offset: 0x38239F0 VA: 0x38279F0
	private void Release() { }

	// RVA: 0x3827A2C Offset: 0x3823A2C VA: 0x3827A2C
	internal void InternalDestroy() { }

	// RVA: 0x3827AE8 Offset: 0x3823AE8 VA: 0x3827AE8
	private void InternalSetDefaults() { }

	// RVA: 0x3827AFC Offset: 0x3823AFC VA: 0x3827AFC
	public void .ctor(string url, string method) { }

	// RVA: 0x3827D80 Offset: 0x3823D80 VA: 0x3827D80
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x382803C Offset: 0x382403C VA: 0x382803C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3828138 Offset: 0x3824138 VA: 0x3828138 Slot: 4
	public void Dispose() { }

	// RVA: 0x38280D8 Offset: 0x38240D8 VA: 0x38280D8
	private void DisposeHandlers() { }

	[NativeThrows]
	// RVA: 0x38281B8 Offset: 0x38241B8 VA: 0x38281B8
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x38281F4 Offset: 0x38241F4 VA: 0x38281F4
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x3827AAC Offset: 0x3823AAC VA: 0x3827AAC
	public void Abort() { }

	// RVA: 0x3828250 Offset: 0x3824250 VA: 0x3828250
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x3828294 Offset: 0x3824294 VA: 0x3828294
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x38283D0 Offset: 0x38243D0 VA: 0x38283D0
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x3828414 Offset: 0x3824414 VA: 0x3828414
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x3827C00 Offset: 0x3823C00 VA: 0x3827C00
	public void set_method(string value) { }

	// RVA: 0x3828514 Offset: 0x3824514 VA: 0x3828514
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x3828550 Offset: 0x3824550 VA: 0x3828550
	public string get_error() { }

	// RVA: 0x382876C Offset: 0x382476C VA: 0x382876C
	public string get_url() { }

	// RVA: 0x3827B78 Offset: 0x3823B78 VA: 0x3827B78
	public void set_url(string value) { }

	// RVA: 0x38287A8 Offset: 0x38247A8 VA: 0x38287A8
	private string GetUrl() { }

	// RVA: 0x38288E4 Offset: 0x38248E4 VA: 0x38288E4
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x38287E4 Offset: 0x38247E4 VA: 0x38287E4
	private void InternalSetUrl(string url) { }

	// RVA: 0x3828730 Offset: 0x3824730 VA: 0x3828730
	public long get_responseCode() { }

	// RVA: 0x3828928 Offset: 0x3824928 VA: 0x3828928
	private bool IsExecuting() { }

	[NativeMethod("IsModifiable")]
	// RVA: 0x3828394 Offset: 0x3824394 VA: 0x3828394
	public bool get_isModifiable() { }

	// RVA: 0x3828964 Offset: 0x3824964 VA: 0x3828964
	public bool get_isDone() { }

	// RVA: 0x38289AC Offset: 0x38249AC VA: 0x38289AC
	public bool get_isNetworkError() { }

	[NativeMethod("GetResult")]
	// RVA: 0x38286F4 Offset: 0x38246F4 VA: 0x38286F4
	public UnityWebRequest.Result get_result() { }

	// RVA: 0x38289F4 Offset: 0x38249F4 VA: 0x38289F4
	private float GetDownloadProgress() { }

	// RVA: 0x3828A30 Offset: 0x3824A30 VA: 0x3828A30
	public float get_downloadProgress() { }

	// RVA: 0x3828AD4 Offset: 0x3824AD4 VA: 0x3828AD4
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x3828B18 Offset: 0x3824B18 VA: 0x3828B18
	public void set_chunkedTransfer(bool value) { }

	// RVA: 0x3828C18 Offset: 0x3824C18 VA: 0x3828C18
	public string GetRequestHeader(string name) { }

	[NativeMethod("SetRequestHeader")]
	// RVA: 0x3828C5C Offset: 0x3824C5C VA: 0x3828C5C
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x3828CB0 Offset: 0x3824CB0 VA: 0x3828CB0
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x3828E28 Offset: 0x3824E28 VA: 0x3828E28
	public string GetResponseHeader(string name) { }

	// RVA: 0x3828E6C Offset: 0x3824E6C VA: 0x3828E6C
	internal string[] GetResponseHeaderKeys() { }

	// RVA: 0x3828EA8 Offset: 0x3824EA8 VA: 0x3828EA8
	public Dictionary<string, string> GetResponseHeaders() { }

	// RVA: 0x3829078 Offset: 0x3825078 VA: 0x3829078
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x38281A8 Offset: 0x38241A8 VA: 0x38281A8
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x3827F30 Offset: 0x3823F30 VA: 0x3827F30
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x38290BC Offset: 0x38250BC VA: 0x38290BC
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x38281A0 Offset: 0x38241A0 VA: 0x38281A0
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x3827E24 Offset: 0x3823E24 VA: 0x3827E24
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x38281B0 Offset: 0x38241B0 VA: 0x38281B0
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x3829100 Offset: 0x3825100 VA: 0x3829100
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x38291A4 Offset: 0x38251A4 VA: 0x38291A4
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x382922C Offset: 0x382522C VA: 0x382922C
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }
}
