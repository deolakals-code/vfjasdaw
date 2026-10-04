// Assembly: System.dll
// Namespace: System.Net
internal class WebResponseStream : WebConnectionStream // TypeDefIndex: 14542
{
	// Fields
	private WebReadStream innerStream; // 0x58
	private bool nextReadCalled; // 0x60
	private bool bufferedEntireContent; // 0x61
	private WebCompletionSource pendingRead; // 0x68
	private object locker; // 0x70
	private int nestedRead; // 0x78
	private bool read_eof; // 0x7C
	[CompilerGenerated]
	private readonly WebRequestStream <RequestStream>k__BackingField; // 0x80
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x88
	[CompilerGenerated]
	private HttpStatusCode <StatusCode>k__BackingField; // 0x90
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x98
	[CompilerGenerated]
	private Version <Version>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <KeepAlive>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <ChunkedRead>k__BackingField; // 0xA9

	// Properties
	public WebRequestStream RequestStream { get; }
	public WebHeaderCollection Headers { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public string StatusDescription { get; set; }
	public Version Version { get; set; }
	public bool KeepAlive { get; set; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	private bool ChunkedRead { get; set; }
	private bool ExpectContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3525AF8 Offset: 0x3521AF8 VA: 0x3525AF8
	public WebRequestStream get_RequestStream() { }

	[CompilerGenerated]
	// RVA: 0x3525B00 Offset: 0x3521B00 VA: 0x3525B00
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x3525B08 Offset: 0x3521B08 VA: 0x3525B08
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x3525B10 Offset: 0x3521B10 VA: 0x3525B10
	public HttpStatusCode get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x3525B18 Offset: 0x3521B18 VA: 0x3525B18
	private void set_StatusCode(HttpStatusCode value) { }

	[CompilerGenerated]
	// RVA: 0x3525B20 Offset: 0x3521B20 VA: 0x3525B20
	public string get_StatusDescription() { }

	[CompilerGenerated]
	// RVA: 0x3525B28 Offset: 0x3521B28 VA: 0x3525B28
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x3525B30 Offset: 0x3521B30 VA: 0x3525B30
	public Version get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3525B38 Offset: 0x3521B38 VA: 0x3525B38
	private void set_Version(Version value) { }

	[CompilerGenerated]
	// RVA: 0x3525B40 Offset: 0x3521B40 VA: 0x3525B40
	public bool get_KeepAlive() { }

	[CompilerGenerated]
	// RVA: 0x3525B48 Offset: 0x3521B48 VA: 0x3525B48
	private void set_KeepAlive(bool value) { }

	// RVA: 0x3520E7C Offset: 0x351CE7C VA: 0x3520E7C
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x3525B54 Offset: 0x3521B54 VA: 0x3525B54 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3525B5C Offset: 0x3521B5C VA: 0x3525B5C Slot: 10
	public override bool get_CanWrite() { }

	[CompilerGenerated]
	// RVA: 0x3525B64 Offset: 0x3521B64 VA: 0x3525B64
	private bool get_ChunkedRead() { }

	[CompilerGenerated]
	// RVA: 0x3525B6C Offset: 0x3521B6C VA: 0x3525B6C
	private void set_ChunkedRead(bool value) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAsync>d__40))]
	// RVA: 0x3525B78 Offset: 0x3521B78 VA: 0x3525B78 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x3525CE0 Offset: 0x3521CE0 VA: 0x3525CE0
	private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x3525F98 Offset: 0x3521F98 VA: 0x3525F98 Slot: 37
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x3526064 Offset: 0x3522064 VA: 0x3526064
	private bool get_ExpectContent() { }

	// RVA: 0x35260F8 Offset: 0x35220F8 VA: 0x35260F8
	private void Initialize(BufferOffsetSize buffer) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsyncInner>d__47))]
	// RVA: 0x3526634 Offset: 0x3522634 VA: 0x3526634
	private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsync>d__48))]
	// RVA: 0x3511CE4 Offset: 0x350DCE4 VA: 0x3511CE4
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x3526770 Offset: 0x3522770 VA: 0x3526770 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x352680C Offset: 0x352280C VA: 0x352680C Slot: 38
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x35268B0 Offset: 0x35228B0 VA: 0x35268B0
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[AsyncStateMachine(typeof(WebResponseStream.<InitReadAsync>d__52))]
	// RVA: 0x3520F0C Offset: 0x351CF0C VA: 0x3520F0C
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x3526B40 Offset: 0x3522B40 VA: 0x3526B40
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }
}
