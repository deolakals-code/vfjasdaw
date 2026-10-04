// Assembly: mscorlib.dll
// Namespace: Mono.Security.Cryptography
internal class MD2Managed : MD2 // TypeDefIndex: 9475
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x2E73C74 Offset: 0x2E6FC74 VA: 0x2E73C74
	private byte[] Padding(int nLength) { }

	// RVA: 0x2E73BA0 Offset: 0x2E6FBA0 VA: 0x2E73BA0
	public void .ctor() { }

	// RVA: 0x2E73D10 Offset: 0x2E6FD10 VA: 0x2E73D10 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2E73D70 Offset: 0x2E6FD70 VA: 0x2E73D70 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x2E740B0 Offset: 0x2E700B0 VA: 0x2E740B0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2E73E4C Offset: 0x2E6FE4C VA: 0x2E73E4C
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x2E741A0 Offset: 0x2E701A0 VA: 0x2E741A0
	private static void .cctor() { }
}
