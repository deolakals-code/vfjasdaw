// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems
public class StreamBuffer : Stream // TypeDefIndex: 11251
{
	// Fields
	private int pos; // 0x28
	private int len; // 0x2C
	private byte[] buff; // 0x30

	// Properties
	public byte[] Buff { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x36CF748 Offset: 0x36CB748 VA: 0x36CF748
	public void .ctor(byte[] buf) { }

	// RVA: 0x36CF7D0 Offset: 0x36CB7D0 VA: 0x36CF7D0
	public byte[] get_Buff() { }

	// RVA: 0x36CF7D8 Offset: 0x36CB7D8 VA: 0x36CF7D8 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x36CF7E0 Offset: 0x36CB7E0 VA: 0x36CF7E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x36CF7E8 Offset: 0x36CB7E8 VA: 0x36CF7E8 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x36CF7F0 Offset: 0x36CB7F0 VA: 0x36CF7F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x36CF7F8 Offset: 0x36CB7F8 VA: 0x36CF7F8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x36CF800 Offset: 0x36CB800 VA: 0x36CF800 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x36CF8E0 Offset: 0x36CB8E0 VA: 0x36CF8E0 Slot: 20
	public override void Flush() { }

	// RVA: 0x36CF8E4 Offset: 0x36CB8E4 VA: 0x36CF8E4 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x36CF94C Offset: 0x36CB94C VA: 0x36CF94C Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x36CFA20 Offset: 0x36CBA20 VA: 0x36CFA20 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x36CFA48 Offset: 0x36CBA48 VA: 0x36CFA48 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x36CFAB4 Offset: 0x36CBAB4 VA: 0x36CFAB4 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x36CFB04 Offset: 0x36CBB04 VA: 0x36CFB04 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x36CFB44 Offset: 0x36CBB44 VA: 0x36CFB44
	private void WriteBuffer(byte value) { }

	// RVA: 0x36CF81C Offset: 0x36CB81C VA: 0x36CF81C
	private bool CheckSize(int size) { }

	// RVA: 0x36CFB80 Offset: 0x36CBB80 VA: 0x36CFB80
	public static string ByteArrayToString(byte[] list) { }
}
