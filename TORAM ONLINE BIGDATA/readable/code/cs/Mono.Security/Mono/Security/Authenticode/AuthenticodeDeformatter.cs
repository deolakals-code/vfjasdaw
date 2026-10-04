// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Authenticode
public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 16927
{
	// Fields
	private string filename; // 0x40
	private byte[] rawdata; // 0x48
	private byte[] hash; // 0x50
	private X509CertificateCollection coll; // 0x58
	private ASN1 signedHash; // 0x60
	private DateTime timestamp; // 0x68
	private X509Certificate signingCertificate; // 0x70
	private int reason; // 0x78
	private bool trustedRoot; // 0x7C
	private bool trustedTimestampRoot; // 0x7D
	private byte[] entry; // 0x80
	private X509Chain signerChain; // 0x88
	private X509Chain timestampChain; // 0x90

	// Properties
	public byte[] RawData { set; }
	public X509Certificate SigningCertificate { get; }

	// Methods

	// RVA: 0x2E5EC90 Offset: 0x2E5AC90 VA: 0x2E5EC90
	public void .ctor() { }

	// RVA: 0x2E5ED24 Offset: 0x2E5AD24 VA: 0x2E5ED24
	public void .ctor(byte[] rawData) { }

	// RVA: 0x2E5ED4C Offset: 0x2E5AD4C VA: 0x2E5ED4C
	public void set_RawData(byte[] value) { }

	// RVA: 0x2E5F204 Offset: 0x2E5B204 VA: 0x2E5F204
	public X509Certificate get_SigningCertificate() { }

	// RVA: 0x2E5EF1C Offset: 0x2E5AF1C VA: 0x2E5EF1C
	private bool CheckSignature() { }

	// RVA: 0x2E5FC64 Offset: 0x2E5BC64 VA: 0x2E5FC64
	private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509) { }

	// RVA: 0x2E5F20C Offset: 0x2E5B20C VA: 0x2E5F20C
	private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0x2E5FD60 Offset: 0x2E5BD60 VA: 0x2E5FD60
	private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature) { }

	// RVA: 0x2E5EE28 Offset: 0x2E5AE28 VA: 0x2E5EE28
	private void Reset() { }
}
