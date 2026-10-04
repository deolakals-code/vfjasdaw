// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public class X509Crl // TypeDefIndex: 16878
{
	// Fields
	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0x2E4D57C Offset: 0x2E4957C VA: 0x2E4D57C
	public void .ctor(byte[] crl) { }

	// RVA: 0x2E4D698 Offset: 0x2E49698 VA: 0x2E4D698
	private void Parse(byte[] crl) { }

	// RVA: 0x2E4DF74 Offset: 0x2E49F74 VA: 0x2E4DF74
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x2E4DF7C Offset: 0x2E49F7C VA: 0x2E4DF7C
	public byte[] get_Hash() { }

	// RVA: 0x2E4E1A4 Offset: 0x2E4A1A4 VA: 0x2E4E1A4
	public string get_IssuerName() { }

	// RVA: 0x2E4E1AC Offset: 0x2E4A1AC VA: 0x2E4E1AC
	public DateTime get_NextUpdate() { }

	// RVA: 0x2E4E1B4 Offset: 0x2E4A1B4 VA: 0x2E4E1B4
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x2E4E244 Offset: 0x2E4A244 VA: 0x2E4E244
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x2E4E2C0 Offset: 0x2E4A2C0 VA: 0x2E4E2C0
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x2E4E47C Offset: 0x2E4A47C VA: 0x2E4E47C
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x2E4E740 Offset: 0x2E4A740 VA: 0x2E4E740
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x2E4E814 Offset: 0x2E4A814 VA: 0x2E4E814
	public bool VerifySignature(AsymmetricAlgorithm aa) { }
}
