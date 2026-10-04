// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Cryptography
public class MD4Managed : MD4 // TypeDefIndex: 16919
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x2E58CB4 Offset: 0x2E54CB4 VA: 0x2E58CB4
	public void .ctor() { }

	// RVA: 0x2E58DC0 Offset: 0x2E54DC0 VA: 0x2E58DC0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2E58E74 Offset: 0x2E54E74 VA: 0x2E58E74 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x2E59610 Offset: 0x2E55610 VA: 0x2E59610 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2E59804 Offset: 0x2E55804 VA: 0x2E59804
	private byte[] Padding(int nLength) { }

	// RVA: 0x2E5987C Offset: 0x2E5587C VA: 0x2E5987C
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x2E5988C Offset: 0x2E5588C VA: 0x2E5988C
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x2E598A0 Offset: 0x2E558A0 VA: 0x2E598A0
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x2E598AC Offset: 0x2E558AC VA: 0x2E598AC
	private uint ROL(uint x, byte n) { }

	// RVA: 0x2E598B8 Offset: 0x2E558B8 VA: 0x2E598B8
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x2E598E0 Offset: 0x2E558E0 VA: 0x2E598E0
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x2E59918 Offset: 0x2E55918 VA: 0x2E59918
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x2E5970C Offset: 0x2E5570C VA: 0x2E5970C
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x2E59948 Offset: 0x2E55948 VA: 0x2E59948
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x2E58F98 Offset: 0x2E54F98 VA: 0x2E58F98
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}
