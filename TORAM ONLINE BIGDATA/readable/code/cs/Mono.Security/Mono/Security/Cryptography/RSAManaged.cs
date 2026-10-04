// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Cryptography
public class RSAManaged : RSA // TypeDefIndex: 16925
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

	// RVA: 0x2E5BCE8 Offset: 0x2E57CE8 VA: 0x2E5BCE8
	public void .ctor() { }

	// RVA: 0x2E5BCF0 Offset: 0x2E57CF0 VA: 0x2E5BCF0
	public void .ctor(int keySize) { }

	// RVA: 0x2E5BDD8 Offset: 0x2E57DD8 VA: 0x2E5BDD8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E5BE78 Offset: 0x2E57E78 VA: 0x2E5BE78
	private void GenerateKeyPair() { }

	// RVA: 0x2E5C76C Offset: 0x2E5876C VA: 0x2E5C76C Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x2E5C808 Offset: 0x2E58808 VA: 0x2E5C808
	public bool get_PublicOnly() { }

	// RVA: 0x2E5C958 Offset: 0x2E58958 VA: 0x2E5C958 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x2E5CE10 Offset: 0x2E58E10 VA: 0x2E5CE10 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x2E5D2CC Offset: 0x2E592CC VA: 0x2E5D2CC Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x2E5D814 Offset: 0x2E59814 VA: 0x2E5D814 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2E5DA98 Offset: 0x2E59A98 VA: 0x2E5DA98 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x2E5CD10 Offset: 0x2E58D10 VA: 0x2E5CD10
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}
