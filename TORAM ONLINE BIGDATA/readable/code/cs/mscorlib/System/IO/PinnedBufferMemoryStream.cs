// Assembly: mscorlib.dll
// Namespace: System.IO
internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream // TypeDefIndex: 10697
{
	// Fields
	private byte[] _array; // 0x68
	private GCHandle _pinningHandle; // 0x70

	// Methods

	// RVA: 0x2F42E14 Offset: 0x2F3EE14 VA: 0x2F42E14
	internal void .ctor(byte[] array) { }

	// RVA: 0x2F43128 Offset: 0x2F3F128 VA: 0x2F43128 Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x2F43350 Offset: 0x2F3F350 VA: 0x2F43350 Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x2F4363C Offset: 0x2F3F63C VA: 0x2F4363C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F436E0 Offset: 0x2F3F6E0 VA: 0x2F436E0 Slot: 19
	protected override void Dispose(bool disposing) { }
}
