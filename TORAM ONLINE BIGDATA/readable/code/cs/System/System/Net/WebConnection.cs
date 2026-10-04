// Assembly: System.dll
// Namespace: System.Net
internal class WebConnection : IDisposable // TypeDefIndex: 14518
{
	// Fields
	private NetworkCredential ntlm_credentials; // 0x10
	private bool ntlm_authenticated; // 0x18
	private bool unsafe_sharing; // 0x19
	private Stream networkStream; // 0x20
	private Socket socket; // 0x28
	private MonoTlsStream monoTlsStream; // 0x30
	private WebConnectionTunnel tunnel; // 0x38
	private int disposed; // 0x40
	[CompilerGenerated]
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x48
	private DateTime idleSince; // 0x50
	private WebOperation currentOperation; // 0x58

	// Properties
	public ServicePoint ServicePoint { get; }
	public bool Closed { get; }
	public DateTime IdleSince { get; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x351A040 Offset: 0x3516040 VA: 0x351A040
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x3518CAC Offset: 0x3514CAC VA: 0x3518CAC
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x351A048 Offset: 0x3516048 VA: 0x351A048
	private bool CanReuse() { }

	// RVA: 0x351A078 Offset: 0x3516078 VA: 0x351A078
	private bool CheckReusable() { }

	[AsyncStateMachine(typeof(WebConnection.<Connect>d__16))]
	// RVA: 0x351A114 Offset: 0x3516114 VA: 0x351A114
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<CreateStream>d__18))]
	// RVA: 0x351A230 Offset: 0x3516230 VA: 0x351A230
	private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<InitConnection>d__19))]
	// RVA: 0x351A388 Offset: 0x3516388 VA: 0x351A388
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x351A4D4 Offset: 0x35164D4 VA: 0x351A4D4
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x351A654 Offset: 0x3516654 VA: 0x351A654
	internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x351868C Offset: 0x351468C VA: 0x351868C
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x351A830 Offset: 0x3516830 VA: 0x351A830
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x351AB4C Offset: 0x3516B4C VA: 0x351AB4C
	private void Reset() { }

	// RVA: 0x351AC48 Offset: 0x3516C48 VA: 0x351AC48
	private void Close(bool reset) { }

	// RVA: 0x351AD10 Offset: 0x3516D10 VA: 0x351AD10
	private void CloseSocket() { }

	// RVA: 0x3518310 Offset: 0x3514310 VA: 0x3518310
	public bool get_Closed() { }

	// RVA: 0x351AFAC Offset: 0x3516FAC VA: 0x351AFAC
	public DateTime get_IdleSince() { }

	// RVA: 0x3518AB8 Offset: 0x3514AB8 VA: 0x3518AB8
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x3517754 Offset: 0x3513754 VA: 0x3517754
	public bool Continue(WebOperation next) { }

	// RVA: 0x351B2E4 Offset: 0x35172E4 VA: 0x351B2E4
	private void Dispose(bool disposing) { }

	// RVA: 0x3518308 Offset: 0x3514308 VA: 0x3518308 Slot: 4
	public void Dispose() { }

	// RVA: 0x351AC20 Offset: 0x3516C20 VA: 0x351AC20
	private void ResetNtlm() { }

	// RVA: 0x351B31C Offset: 0x351731C VA: 0x351B31C
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x351B324 Offset: 0x3517324 VA: 0x351B324
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x351B330 Offset: 0x3517330 VA: 0x351B330
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x351B338 Offset: 0x3517338 VA: 0x351B338
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x351B340 Offset: 0x3517340 VA: 0x351B340
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x351B348 Offset: 0x3517348 VA: 0x351B348
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }
}
