// Assembly: System.dll
// Namespace: System.IO.Compression
internal class DeflateStreamNative // TypeDefIndex: 14346
{
	// Fields
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x30
	private byte[] io_buffer; // 0x38
	private Exception last_error; // 0x40

	// Methods

	// RVA: 0x34D8BC8 Offset: 0x34D4BC8 VA: 0x34D8BC8
	private void .ctor() { }

	// RVA: 0x34D7448 Offset: 0x34D3448 VA: 0x34D7448
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x34D8D14 Offset: 0x34D4D14 VA: 0x34D8D14 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x34D7720 Offset: 0x34D3720 VA: 0x34D7720
	public void Dispose(bool disposing) { }

	// RVA: 0x34D7E08 Offset: 0x34D3E08 VA: 0x34D7E08
	public void Flush() { }

	// RVA: 0x34D7884 Offset: 0x34D3884 VA: 0x34D7884
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x34D7B10 Offset: 0x34D3B10 VA: 0x34D7B10
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x34D8A50 Offset: 0x34D4A50 VA: 0x34D8A50
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x34D9034 Offset: 0x34D5034 VA: 0x34D9034
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x34D8B0C Offset: 0x34D4B0C VA: 0x34D8B0C
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x34D91F4 Offset: 0x34D51F4 VA: 0x34D91F4
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x34D8E10 Offset: 0x34D4E10 VA: 0x34D8E10
	private void CheckResult(int result, string where) { }

	// RVA: 0x34D8C70 Offset: 0x34D4C70 VA: 0x34D8C70
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x34D93FC Offset: 0x34D53FC VA: 0x34D93FC
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x34D8DAC Offset: 0x34D4DAC VA: 0x34D8DAC
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x34D8F3C Offset: 0x34D4F3C VA: 0x34D8F3C
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x34D8FB8 Offset: 0x34D4FB8 VA: 0x34D8FB8
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }
}
