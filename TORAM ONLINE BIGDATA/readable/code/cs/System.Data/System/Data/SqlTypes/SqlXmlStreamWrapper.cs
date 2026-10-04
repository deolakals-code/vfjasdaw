// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 14823
{
	// Fields
	private Stream _stream; // 0x28
	private long _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x325F994 Offset: 0x325B994 VA: 0x325F994
	internal void .ctor(Stream stream) { }

	// RVA: 0x32604B8 Offset: 0x325C4B8 VA: 0x32604B8 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3260560 Offset: 0x325C560 VA: 0x3260560 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3260598 Offset: 0x325C598 VA: 0x3260598 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x32605D0 Offset: 0x325C5D0 VA: 0x32605D0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x3260720 Offset: 0x325C720 VA: 0x3260720 Slot: 12
	public override long get_Position() { }

	// RVA: 0x326077C Offset: 0x325C77C VA: 0x326077C Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x3260850 Offset: 0x325C850 VA: 0x3260850 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x3260A20 Offset: 0x325CA20 VA: 0x3260A20 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x3260C54 Offset: 0x325CC54 VA: 0x3260C54 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x3260E88 Offset: 0x325CE88 VA: 0x3260E88 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x3260F9C Offset: 0x325CF9C VA: 0x3260F9C Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x3261080 Offset: 0x325D080 VA: 0x3261080 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x3261114 Offset: 0x325D114 VA: 0x3261114 Slot: 20
	public override void Flush() { }

	// RVA: 0x3261130 Offset: 0x325D130 VA: 0x3261130 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x32606A4 Offset: 0x325C6A4 VA: 0x32606A4
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0x3260BD8 Offset: 0x325CBD8 VA: 0x3260BD8
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0x3260E0C Offset: 0x325CE0C VA: 0x3260E0C
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0x326063C Offset: 0x325C63C VA: 0x326063C
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0x32604F0 Offset: 0x325C4F0 VA: 0x32604F0
	private bool IsStreamClosed() { }
}
