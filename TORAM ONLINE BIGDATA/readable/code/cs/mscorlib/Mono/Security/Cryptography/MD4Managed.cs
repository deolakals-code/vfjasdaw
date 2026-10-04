// Assembly: mscorlib.dll
// Namespace: Mono.Security.Cryptography
internal class MD4Managed : MD4 // TypeDefIndex: 9477
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x2E742B0 Offset: 0x2E702B0 VA: 0x2E742B0
	public void .ctor() { }

	// RVA: 0x2E743BC Offset: 0x2E703BC VA: 0x2E743BC Slot: 18
	public override void Initialize() { }

	// RVA: 0x2E74470 Offset: 0x2E70470 VA: 0x2E74470 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x2E74C0C Offset: 0x2E70C0C VA: 0x2E74C0C Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2E74E00 Offset: 0x2E70E00 VA: 0x2E74E00
	private byte[] Padding(int nLength) { }

	// RVA: 0x2E74E78 Offset: 0x2E70E78 VA: 0x2E74E78
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x2E74E88 Offset: 0x2E70E88 VA: 0x2E74E88
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x2E74E9C Offset: 0x2E70E9C VA: 0x2E74E9C
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x2E74EA8 Offset: 0x2E70EA8 VA: 0x2E74EA8
	private uint ROL(uint x, byte n) { }

	// RVA: 0x2E74EB4 Offset: 0x2E70EB4 VA: 0x2E74EB4
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x2E74EDC Offset: 0x2E70EDC VA: 0x2E74EDC
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x2E74F14 Offset: 0x2E70F14 VA: 0x2E74F14
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x2E74D08 Offset: 0x2E70D08 VA: 0x2E74D08
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x2E74F44 Offset: 0x2E70F44 VA: 0x2E74F44
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x2E74594 Offset: 0x2E70594 VA: 0x2E74594
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}
