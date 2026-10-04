// Assembly: System.dll
// Namespace: System.Net
internal abstract class WebReadStream : Stream // TypeDefIndex: 14527
{
	// Fields
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x30
	private bool disposed; // 0x38

	// Properties
	public WebOperation Operation { get; }
	protected Stream InnerStream { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3521014 Offset: 0x351D014 VA: 0x3521014
	public WebOperation get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x352101C Offset: 0x351D01C VA: 0x352101C
	protected Stream get_InnerStream() { }

	// RVA: 0x3513E44 Offset: 0x350FE44 VA: 0x3513E44
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x3521024 Offset: 0x351D024 VA: 0x3521024 Slot: 11
	public override long get_Length() { }

	// RVA: 0x352105C Offset: 0x351D05C VA: 0x352105C Slot: 12
	public override long get_Position() { }

	// RVA: 0x3521094 Offset: 0x351D094 VA: 0x3521094 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x35210CC Offset: 0x351D0CC VA: 0x35210CC Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x35210D4 Offset: 0x351D0D4 VA: 0x35210D4 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x35210DC Offset: 0x351D0DC VA: 0x35210DC Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x35210E4 Offset: 0x351D0E4 VA: 0x35210E4 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x352111C Offset: 0x351D11C VA: 0x352111C Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x3521154 Offset: 0x351D154 VA: 0x3521154 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x352118C Offset: 0x351D18C VA: 0x352118C Slot: 20
	public override void Flush() { }

	// RVA: 0x35211C4 Offset: 0x351D1C4 VA: 0x35211C4
	protected Exception GetException(Exception e) { }

	// RVA: 0x352132C Offset: 0x351D32C VA: 0x352132C Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x3521584 Offset: 0x351D584 VA: 0x3521584 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x3521744 Offset: 0x351D744 VA: 0x3521744 Slot: 22
	public override int EndRead(IAsyncResult r) { }

	[AsyncStateMachine(typeof(WebReadStream.<ReadAsync>d__28))]
	// RVA: 0x3521864 Offset: 0x351D864 VA: 0x3521864 Slot: 23
	public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

	// RVA: 0x3514190 Offset: 0x3510190 VA: 0x3514190 Slot: 38
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x35219C4 Offset: 0x351D9C4 VA: 0x35219C4 Slot: 19
	protected override void Dispose(bool disposing) { }
}
