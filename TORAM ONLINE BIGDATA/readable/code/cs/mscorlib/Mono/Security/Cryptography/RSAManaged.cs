// Assembly: mscorlib.dll
// Namespace: Mono.Security.Cryptography
internal class RSAManaged : RSA // TypeDefIndex: 9480
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x2E760A8 Offset: 0x2E720A8 VA: 0x2E760A8
	public void .ctor(int keySize) { }

	// RVA: 0x2E76190 Offset: 0x2E72190 VA: 0x2E76190 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E76230 Offset: 0x2E72230 VA: 0x2E76230
	private void GenerateKeyPair() { }

	// RVA: 0x2E76B24 Offset: 0x2E72B24 VA: 0x2E76B24 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x2E76BC0 Offset: 0x2E72BC0 VA: 0x2E76BC0
	public bool get_PublicOnly() { }

	// RVA: 0x2E76D10 Offset: 0x2E72D10 VA: 0x2E76D10 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x2E771C8 Offset: 0x2E731C8 VA: 0x2E771C8 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x2E77684 Offset: 0x2E73684 VA: 0x2E77684 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x2E77BCC Offset: 0x2E73BCC VA: 0x2E77BCC Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x2E77E50 Offset: 0x2E73E50 VA: 0x2E77E50
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2E77EEC Offset: 0x2E73EEC VA: 0x2E77EEC
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x2E77F88 Offset: 0x2E73F88 VA: 0x2E77F88 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x2E770C8 Offset: 0x2E730C8 VA: 0x2E770C8
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}
