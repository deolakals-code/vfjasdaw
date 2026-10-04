// Assembly: System.dll
// Namespace: System.Net
internal class WebRequestStream : WebConnectionStream // TypeDefIndex: 14536
{
	// Fields
	private static byte[] crlf; // 0x0
	private MemoryStream writeBuffer; // 0x58
	private bool requestWritten; // 0x60
	private bool allowBuffering; // 0x61
	private bool sendChunked; // 0x62
	private WebCompletionSource pendingWrite; // 0x68
	private long totalWritten; // 0x70
	private byte[] headers; // 0x78
	private bool headersSent; // 0x80
	private int completeRequestWritten; // 0x84
	private int chunkTrailerWritten; // 0x88
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly bool <KeepAlive>k__BackingField; // 0x98

	// Properties
	internal Stream InnerStream { get; }
	public bool KeepAlive { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	internal bool HasWriteBuffer { get; }
	internal int WriteBufferLength { get; }

	// Methods

	// RVA: 0x351CF8C Offset: 0x3518F8C VA: 0x351CF8C
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	[CompilerGenerated]
	// RVA: 0x3522070 Offset: 0x351E070 VA: 0x3522070
	internal Stream get_InnerStream() { }

	[CompilerGenerated]
	// RVA: 0x3522078 Offset: 0x351E078 VA: 0x3522078
	public bool get_KeepAlive() { }

	// RVA: 0x3522080 Offset: 0x351E080 VA: 0x3522080 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3522088 Offset: 0x351E088 VA: 0x3522088 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x3522090 Offset: 0x351E090 VA: 0x3522090
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x35220C4 Offset: 0x351E0C4 VA: 0x35220C4
	internal int get_WriteBufferLength() { }

	// RVA: 0x3522108 Offset: 0x351E108 VA: 0x3522108
	internal BufferOffsetSize GetWriteBuffer() { }

	[AsyncStateMachine(typeof(WebRequestStream.<FinishWriting>d__31))]
	// RVA: 0x35221DC Offset: 0x351E1DC VA: 0x35221DC
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x35222D4 Offset: 0x351E2D4 VA: 0x35222D4 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteAsyncInner>d__33))]
	// RVA: 0x3522530 Offset: 0x351E530 VA: 0x3522530
	private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<ProcessWrite>d__34))]
	// RVA: 0x352267C Offset: 0x351E67C VA: 0x352267C
	private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x35227B0 Offset: 0x351E7B0 VA: 0x35227B0
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	[AsyncStateMachine(typeof(WebRequestStream.<Initialize>d__36))]
	// RVA: 0x3520D80 Offset: 0x351CD80 VA: 0x3520D80
	internal Task Initialize(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<SetHeadersAsync>d__37))]
	// RVA: 0x3522844 Offset: 0x351E844 VA: 0x3522844
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteRequestAsync>d__38))]
	// RVA: 0x3522954 Offset: 0x351E954 VA: 0x3522954
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer_inner>d__39))]
	// RVA: 0x3522A50 Offset: 0x351EA50 VA: 0x3522A50
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer>d__40))]
	// RVA: 0x3522B48 Offset: 0x351EB48 VA: 0x3522B48
	private Task WriteChunkTrailer() { }

	// RVA: 0x3511DF8 Offset: 0x350DDF8 VA: 0x3511DF8
	internal void KillBuffer() { }

	// RVA: 0x3522C34 Offset: 0x351EC34 VA: 0x3522C34 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x3522CE4 Offset: 0x351ECE4 VA: 0x3522CE4 Slot: 37
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x3522D1C Offset: 0x351ED1C VA: 0x3522D1C Slot: 38
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x3522E94 Offset: 0x351EE94 VA: 0x3522E94
	private static void .cctor() { }
}
