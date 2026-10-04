// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Cryptography
public class MD2Managed : MD2 // TypeDefIndex: 16917
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x2E58678 Offset: 0x2E54678 VA: 0x2E58678
	private byte[] Padding(int nLength) { }

	// RVA: 0x2E585A4 Offset: 0x2E545A4 VA: 0x2E585A4
	public void .ctor() { }

	// RVA: 0x2E58714 Offset: 0x2E54714 VA: 0x2E58714 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2E58774 Offset: 0x2E54774 VA: 0x2E58774 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x2E58AB4 Offset: 0x2E54AB4 VA: 0x2E58AB4 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2E58850 Offset: 0x2E54850 VA: 0x2E58850
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x2E58BA4 Offset: 0x2E54BA4 VA: 0x2E58BA4
	private static void .cctor() { }
}
