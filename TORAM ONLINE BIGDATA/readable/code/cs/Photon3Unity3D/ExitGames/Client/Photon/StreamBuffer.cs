// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public class StreamBuffer : Stream // TypeDefIndex: 16963
{
	// Fields
	private const int DefaultInitialSize = 0;
	private int pos; // 0x28
	private int len; // 0x2C
	private byte[] buf; // 0x30

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x30F0EF0 Offset: 0x30ECEF0 VA: 0x30F0EF0
	public void .ctor(int size = 0) { }

	// RVA: 0x30F2AC8 Offset: 0x30EEAC8 VA: 0x30F2AC8
	public void .ctor(byte[] buf) { }

	// RVA: 0x30F0F84 Offset: 0x30ECF84 VA: 0x30F0F84
	public byte[] ToArray() { }

	// RVA: 0x30F2B50 Offset: 0x30EEB50 VA: 0x30F2B50 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x30F2B58 Offset: 0x30EEB58 VA: 0x30F2B58 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x30F2B60 Offset: 0x30EEB60 VA: 0x30F2B60 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x30F2B68 Offset: 0x30EEB68 VA: 0x30F2B68 Slot: 11
	public override long get_Length() { }

	// RVA: 0x30F2B70 Offset: 0x30EEB70 VA: 0x30F2B70 Slot: 12
	public override long get_Position() { }

	// RVA: 0x30F2B78 Offset: 0x30EEB78 VA: 0x30F2B78 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x30F2C58 Offset: 0x30EEC58 VA: 0x30F2C58 Slot: 20
	public override void Flush() { }

	// RVA: 0x30F2C5C Offset: 0x30EEC5C VA: 0x30F2C5C Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x30F2D30 Offset: 0x30EED30 VA: 0x30F2D30 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x30F2D58 Offset: 0x30EED58 VA: 0x30F2D58 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x30F2DC0 Offset: 0x30EEDC0 VA: 0x30F2DC0 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x30F2E2C Offset: 0x30EEE2C VA: 0x30F2E2C Slot: 33
	public override int ReadByte() { }

	// RVA: 0x30F2E7C Offset: 0x30EEE7C VA: 0x30F2E7C Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x30F2B94 Offset: 0x30EEB94 VA: 0x30F2B94
	private bool CheckSize(int size) { }
}
