// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 14148
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private int max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Properties
	public override bool IsValid { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }
	private X509Certificate2Collection Roots { get; }
	private X509Certificate2Collection CertificateAuthorities { get; }
	private X509Store LMRootStore { get; }
	private X509Store UserRootStore { get; }
	private X509Store LMCAStore { get; }
	private X509Store UserCAStore { get; }
	private X509Certificate2Collection CertificateCollection { get; }

	// Methods

	// RVA: 0x3497120 Offset: 0x3493120 VA: 0x3497120
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x3497200 Offset: 0x3493200 VA: 0x3497200 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x3497208 Offset: 0x3493208 VA: 0x3497208 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x3497210 Offset: 0x3493210 VA: 0x3497210 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x3497218 Offset: 0x3493218 VA: 0x3497218 Slot: 9
	public override void AddStatus(X509ChainStatusFlags error) { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x349721C Offset: 0x349321C VA: 0x349721C Slot: 8
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x3497A58 Offset: 0x3493A58 VA: 0x3497A58 Slot: 10
	public override void Reset() { }

	// RVA: 0x3497BD8 Offset: 0x3493BD8 VA: 0x3497BD8
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x3497F24 Offset: 0x3493F24 VA: 0x3497F24
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x3497CAC Offset: 0x3493CAC VA: 0x3497CAC
	private X509Store get_LMRootStore() { }

	// RVA: 0x3497DA4 Offset: 0x3493DA4 VA: 0x3497DA4
	private X509Store get_UserRootStore() { }

	// RVA: 0x3497FF8 Offset: 0x3493FF8 VA: 0x3497FF8
	private X509Store get_LMCAStore() { }

	// RVA: 0x34980F0 Offset: 0x34940F0 VA: 0x34980F0
	private X509Store get_UserCAStore() { }

	// RVA: 0x3498714 Offset: 0x3494714 VA: 0x3498714
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x3497818 Offset: 0x3493818 VA: 0x3497818
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x3498C44 Offset: 0x3494C44 VA: 0x3498C44
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x3498A68 Offset: 0x3494A68 VA: 0x3498A68
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x3498B7C Offset: 0x3494B7C VA: 0x3498B7C
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x3498F14 Offset: 0x3494F14 VA: 0x3498F14
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x3497900 Offset: 0x3493900 VA: 0x3497900
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x3498F5C Offset: 0x3494F5C VA: 0x3498F5C
	private void Process(int n) { }

	// RVA: 0x3499204 Offset: 0x3495204 VA: 0x3499204
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x34995FC Offset: 0x34955FC VA: 0x34995FC
	private void WrapUp() { }

	// RVA: 0x3499788 Offset: 0x3495788 VA: 0x3499788
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x3499750 Offset: 0x3495750 VA: 0x3499750
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x3498E64 Offset: 0x3494E64 VA: 0x3498E64
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x3498DD0 Offset: 0x3494DD0 VA: 0x3498DD0
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x34999D4 Offset: 0x34959D4 VA: 0x34999D4
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x3499870 Offset: 0x3495870 VA: 0x3499870
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x3499414 Offset: 0x3495414 VA: 0x3499414
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x3499A60 Offset: 0x3495A60 VA: 0x3499A60
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x3499B2C Offset: 0x3495B2C VA: 0x3499B2C
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x349A4BC Offset: 0x34964BC VA: 0x349A4BC
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x3499D00 Offset: 0x3495D00 VA: 0x3499D00
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x349A17C Offset: 0x349617C VA: 0x349A17C
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x3499E74 Offset: 0x3495E74 VA: 0x3499E74
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x349A83C Offset: 0x349683C VA: 0x349A83C
	private static void .cctor() { }
}
