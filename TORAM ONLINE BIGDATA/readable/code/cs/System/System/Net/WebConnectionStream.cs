// Assembly: System.dll
// Namespace: System.Net
internal abstract class WebConnectionStream : Stream // TypeDefIndex: 14519
{
	// Fields
	protected bool closed; // 0x28
	private bool disposed; // 0x29
	private object locker; // 0x30
	private int read_timeout; // 0x38
	private int write_timeout; // 0x3C
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly WebConnection <Connection>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x50

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebConnection Connection { get; }
	internal WebOperation Operation { get; }
	internal ServicePoint ServicePoint { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x351D188 Offset: 0x3519188 VA: 0x351D188
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	[CompilerGenerated]
	// RVA: 0x351D280 Offset: 0x3519280 VA: 0x351D280
	internal HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x351D288 Offset: 0x3519288 VA: 0x351D288
	internal WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x351D290 Offset: 0x3519290 VA: 0x351D290
	internal WebOperation get_Operation() { }

	// RVA: 0x351D298 Offset: 0x3519298 VA: 0x351D298
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x351D2B4 Offset: 0x35192B4 VA: 0x351D2B4 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x351D2BC Offset: 0x35192BC VA: 0x351D2BC Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x351D2C4 Offset: 0x35192C4 VA: 0x351D2C4 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x351D324 Offset: 0x3519324 VA: 0x351D324 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x351D32C Offset: 0x351932C VA: 0x351D32C Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x351D38C Offset: 0x351938C VA: 0x351D38C
	protected Exception GetException(Exception e) { }

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

	// RVA: 0x351D4F4 Offset: 0x35194F4 VA: 0x351D4F4 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x351D7E8 Offset: 0x35197E8 VA: 0x351D7E8 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x351D9A8 Offset: 0x35199A8 VA: 0x351D9A8 Slot: 22
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x351DAC8 Offset: 0x3519AC8 VA: 0x351DAC8 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x351DC88 Offset: 0x3519C88 VA: 0x351DC88 Slot: 26
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x351DD7C Offset: 0x3519D7C VA: 0x351DD7C Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x351DF64 Offset: 0x3519F64 VA: 0x351DF64 Slot: 20
	public override void Flush() { }

	// RVA: 0x351DF68 Offset: 0x3519F68 VA: 0x351DF68
	internal void InternalClose() { }

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract void Close_internal(ref bool disposed);

	// RVA: 0x351DF74 Offset: 0x3519F74 VA: 0x351DF74 Slot: 18
	public override void Close() { }

	// RVA: 0x351DF88 Offset: 0x3519F88 VA: 0x351DF88 Slot: 29
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x351DFD4 Offset: 0x3519FD4 VA: 0x351DFD4 Slot: 30
	public override void SetLength(long a) { }

	// RVA: 0x351E020 Offset: 0x351A020 VA: 0x351E020 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x351E028 Offset: 0x351A028 VA: 0x351E028 Slot: 11
	public override long get_Length() { }

	// RVA: 0x351E074 Offset: 0x351A074 VA: 0x351E074 Slot: 12
	public override long get_Position() { }

	// RVA: 0x351E0C0 Offset: 0x351A0C0 VA: 0x351E0C0 Slot: 13
	public override void set_Position(long value) { }
}
