// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
internal class X509Certificate2ImplMono : X509Certificate2ImplUnix // TypeDefIndex: 14138
{
	// Fields
	private X509CertificateImplCollection intermediateCerts; // 0xB0
	private X509Certificate _cert; // 0xB8
	private static string empty_error; // 0x0
	private static byte[] signedData; // 0x8

	// Properties
	public override bool IsValid { get; }
	private X509Certificate Cert { get; }
	public override bool HasPrivateKey { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	internal X509Certificate MonoCertificate { get; }

	// Methods

	// RVA: 0x34938DC Offset: 0x348F8DC VA: 0x34938DC Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x34938EC Offset: 0x348F8EC VA: 0x34938EC
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x3493924 Offset: 0x348F924 VA: 0x3493924
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x34939DC Offset: 0x348F9DC VA: 0x34939DC
	public void .ctor(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x3493BAC Offset: 0x348FBAC VA: 0x3493BAC Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x3493C10 Offset: 0x348FC10 VA: 0x3493C10
	private X509Certificate get_Cert() { }

	// RVA: 0x3493C2C Offset: 0x348FC2C VA: 0x3493C2C Slot: 32
	protected override byte[] GetRawCertData() { }

	// RVA: 0x3493C64 Offset: 0x348FC64 VA: 0x3493C64 Slot: 17
	public override bool get_HasPrivateKey() { }

	// RVA: 0x3493C88 Offset: 0x348FC88 VA: 0x3493C88 Slot: 23
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x3494080 Offset: 0x3490080 VA: 0x3494080 Slot: 24
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x3494208 Offset: 0x3490208 VA: 0x3494208 Slot: 18
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x3494294 Offset: 0x3490294 VA: 0x3494294 Slot: 19
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x3493B54 Offset: 0x348FB54 VA: 0x3493B54
	private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x3494320 Offset: 0x3490320 VA: 0x3494320
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODO("by default this depends on the incomplete X509Chain")]
	// RVA: 0x3494C40 Offset: 0x3490C40 VA: 0x3494C40 Slot: 30
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x3494D5C Offset: 0x3490D5C VA: 0x3494D5C Slot: 28
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x3494D64 Offset: 0x3490D64 VA: 0x3494D64
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x3494D6C Offset: 0x3490D6C VA: 0x3494D6C
	private static void .cctor() { }
}
