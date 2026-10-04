// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Zlib
[ComVisible(True)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
public sealed class ZlibCodec // TypeDefIndex: 17183
{
	// Fields
	public byte[] InputBuffer; // 0x10
	public int NextIn; // 0x18
	public int AvailableBytesIn; // 0x1C
	public long TotalBytesIn; // 0x20
	public byte[] OutputBuffer; // 0x28
	public int NextOut; // 0x30
	public int AvailableBytesOut; // 0x34
	public long TotalBytesOut; // 0x38
	public string Message; // 0x40
	internal DeflateManager dstate; // 0x48
	internal InflateManager istate; // 0x50
	internal uint _Adler32; // 0x58
	public CompressionLevel CompressLevel; // 0x5C
	public int WindowBits; // 0x60
	public CompressionStrategy Strategy; // 0x64

	// Methods

	// RVA: 0x2E40CC0 Offset: 0x2E3CCC0 VA: 0x2E40CC0
	public void .ctor() { }

	// RVA: 0x2E40CD4 Offset: 0x2E3CCD4 VA: 0x2E40CD4
	public int InitializeInflate(bool expectRfc1950Header) { }

	// RVA: 0x2E40CE4 Offset: 0x2E3CCE4 VA: 0x2E40CE4
	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	// RVA: 0x2E40DCC Offset: 0x2E3CDCC VA: 0x2E40DCC
	public int Inflate(FlushType flush) { }

	// RVA: 0x2E40E2C Offset: 0x2E3CE2C VA: 0x2E40E2C
	public int EndInflate() { }

	// RVA: 0x2E40EB4 Offset: 0x2E3CEB4 VA: 0x2E40EB4
	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	// RVA: 0x2E40EC4 Offset: 0x2E3CEC4 VA: 0x2E40EC4
	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	// RVA: 0x2E40FAC Offset: 0x2E3CFAC VA: 0x2E40FAC
	public int Deflate(FlushType flush) { }

	// RVA: 0x2E4100C Offset: 0x2E3D00C VA: 0x2E4100C
	public int EndDeflate() { }

	// RVA: 0x2E41078 Offset: 0x2E3D078 VA: 0x2E41078
	internal void flush_pending() { }

	// RVA: 0x2E41214 Offset: 0x2E3D214 VA: 0x2E41214
	internal int read_buf(byte[] buf, int start, int size) { }
}
