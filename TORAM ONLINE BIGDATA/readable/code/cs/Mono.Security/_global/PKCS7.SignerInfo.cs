// Assembly: Mono.Security.dll
// Namespace: 
public class PKCS7.SignerInfo // TypeDefIndex: 16871
{
	// Fields
	private byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private ArrayList authenticatedAttributes; // 0x20
	private ArrayList unauthenticatedAttributes; // 0x28
	private byte[] signature; // 0x30
	private string issuer; // 0x38
	private byte[] serial; // 0x40
	private byte[] ski; // 0x48

	// Properties
	public string IssuerName { get; }
	public byte[] SerialNumber { get; }
	public ArrayList AuthenticatedAttributes { get; }
	public string HashName { get; set; }
	public byte[] Signature { get; }
	public ArrayList UnauthenticatedAttributes { get; }
	public byte Version { get; }

	// Methods

	// RVA: 0x2E44AA4 Offset: 0x2E40AA4 VA: 0x2E44AA4
	public void .ctor() { }

	// RVA: 0x2E446FC Offset: 0x2E406FC VA: 0x2E446FC
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2E44E80 Offset: 0x2E40E80 VA: 0x2E44E80
	public string get_IssuerName() { }

	// RVA: 0x2E44E88 Offset: 0x2E40E88 VA: 0x2E44E88
	public byte[] get_SerialNumber() { }

	// RVA: 0x2E44EFC Offset: 0x2E40EFC VA: 0x2E44EFC
	public ArrayList get_AuthenticatedAttributes() { }

	// RVA: 0x2E44F04 Offset: 0x2E40F04 VA: 0x2E44F04
	public string get_HashName() { }

	// RVA: 0x2E44F0C Offset: 0x2E40F0C VA: 0x2E44F0C
	public void set_HashName(string value) { }

	// RVA: 0x2E44F14 Offset: 0x2E40F14 VA: 0x2E44F14
	public byte[] get_Signature() { }

	// RVA: 0x2E44F88 Offset: 0x2E40F88 VA: 0x2E44F88
	public ArrayList get_UnauthenticatedAttributes() { }

	// RVA: 0x2E44F90 Offset: 0x2E40F90 VA: 0x2E44F90
	public byte get_Version() { }
}
