// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Crc
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
[ComVisible(True)]
public class CRC32 // TypeDefIndex: 17184
{
	// Fields
	private uint dwPolynomial; // 0x10
	private long _TotalBytesRead; // 0x18
	private bool reverseBits; // 0x20
	private uint[] crc32Table; // 0x28
	private uint _register; // 0x30

	// Properties
	public long TotalBytesRead { get; }
	public int Crc32Result { get; }

	// Methods

	// RVA: 0x2E4130C Offset: 0x2E3D30C VA: 0x2E4130C
	public long get_TotalBytesRead() { }

	// RVA: 0x2E41314 Offset: 0x2E3D314 VA: 0x2E41314
	public int get_Crc32Result() { }

	// RVA: 0x2E41320 Offset: 0x2E3D320 VA: 0x2E41320
	public void SlurpBlock(byte[] block, int offset, int count) { }

	// RVA: 0x2E41420 Offset: 0x2E3D420 VA: 0x2E41420
	private static uint ReverseBits(uint data) { }

	// RVA: 0x2E41428 Offset: 0x2E3D428 VA: 0x2E41428
	private static byte ReverseBits(byte data) { }

	// RVA: 0x2E41474 Offset: 0x2E3D474 VA: 0x2E41474
	private void GenerateLookupTable() { }

	// RVA: 0x2E415B4 Offset: 0x2E3D5B4 VA: 0x2E415B4
	public void .ctor() { }

	// RVA: 0x2E415E8 Offset: 0x2E3D5E8 VA: 0x2E415E8
	public void .ctor(bool reverseBits) { }

	// RVA: 0x2E41628 Offset: 0x2E3D628 VA: 0x2E41628
	public void .ctor(int polynomial, bool reverseBits) { }
}
