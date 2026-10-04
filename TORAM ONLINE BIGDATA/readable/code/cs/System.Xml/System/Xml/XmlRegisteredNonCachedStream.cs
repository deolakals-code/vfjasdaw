// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 13450
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x33DD36C Offset: 0x33D936C VA: 0x33DD36C
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x33DE2DC Offset: 0x33DA2DC VA: 0x33DE2DC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x33DE390 Offset: 0x33DA390 VA: 0x33DE390 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x33DE4D4 Offset: 0x33DA4D4 VA: 0x33DE4D4 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x33DE4F8 Offset: 0x33DA4F8 VA: 0x33DE4F8 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x33DE51C Offset: 0x33DA51C VA: 0x33DE51C Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x33DE540 Offset: 0x33DA540 VA: 0x33DE540 Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x33DE564 Offset: 0x33DA564 VA: 0x33DE564 Slot: 20
	public override void Flush() { }

	// RVA: 0x33DE588 Offset: 0x33DA588 VA: 0x33DE588 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x33DE5AC Offset: 0x33DA5AC VA: 0x33DE5AC Slot: 33
	public override int ReadByte() { }

	// RVA: 0x33DE5D0 Offset: 0x33DA5D0 VA: 0x33DE5D0 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x33DE5F4 Offset: 0x33DA5F4 VA: 0x33DE5F4 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x33DE618 Offset: 0x33DA618 VA: 0x33DE618 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x33DE63C Offset: 0x33DA63C VA: 0x33DE63C Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x33DE660 Offset: 0x33DA660 VA: 0x33DE660 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x33DE680 Offset: 0x33DA680 VA: 0x33DE680 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x33DE6A0 Offset: 0x33DA6A0 VA: 0x33DE6A0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x33DE6C0 Offset: 0x33DA6C0 VA: 0x33DE6C0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x33DE6E0 Offset: 0x33DA6E0 VA: 0x33DE6E0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x33DE700 Offset: 0x33DA700 VA: 0x33DE700 Slot: 13
	public override void set_Position(long value) { }
}
