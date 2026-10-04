// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
public class X509Store // TypeDefIndex: 16886
{
	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x2E52410 Offset: 0x2E4E410 VA: 0x2E52410
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x2E5245C Offset: 0x2E4E45C VA: 0x2E5245C
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x2E5267C Offset: 0x2E4E67C VA: 0x2E5267C
	public ArrayList get_Crls() { }

	// RVA: 0x2E528DC Offset: 0x2E4E8DC VA: 0x2E528DC
	private byte[] Load(string filename) { }

	// RVA: 0x2E52AE4 Offset: 0x2E4EAE4 VA: 0x2E52AE4
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x2E52B4C Offset: 0x2E4EB4C VA: 0x2E52B4C
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x2E52BB4 Offset: 0x2E4EBB4 VA: 0x2E52BB4
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x2E524A0 Offset: 0x2E4E4A0 VA: 0x2E524A0
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x2E52714 Offset: 0x2E4E714 VA: 0x2E52714
	private ArrayList BuildCrlsCollection(string storeName) { }
}
