// Assembly: Mono.Security.dll
// Namespace: 
public class PKCS7.SignedData // TypeDefIndex: 16870
{
	// Fields
	private byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private PKCS7.ContentInfo contentInfo; // 0x20
	private X509CertificateCollection certs; // 0x28
	private ArrayList crls; // 0x30
	private PKCS7.SignerInfo signerInfo; // 0x38
	private bool mda; // 0x40

	// Properties
	public X509CertificateCollection Certificates { get; }
	public PKCS7.ContentInfo ContentInfo { get; }
	public string HashName { set; }
	public PKCS7.SignerInfo SignerInfo { get; }

	// Methods

	// RVA: 0x2E43FE8 Offset: 0x2E3FFE8 VA: 0x2E43FE8
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2E44D2C Offset: 0x2E40D2C VA: 0x2E44D2C
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x2E44D34 Offset: 0x2E40D34 VA: 0x2E44D34
	public PKCS7.ContentInfo get_ContentInfo() { }

	// RVA: 0x2E44CF0 Offset: 0x2E40CF0 VA: 0x2E44CF0
	public void set_HashName(string value) { }

	// RVA: 0x2E44D3C Offset: 0x2E40D3C VA: 0x2E44D3C
	public PKCS7.SignerInfo get_SignerInfo() { }

	// RVA: 0x2E44B3C Offset: 0x2E40B3C VA: 0x2E44B3C
	internal string OidToName(string oid) { }
}
