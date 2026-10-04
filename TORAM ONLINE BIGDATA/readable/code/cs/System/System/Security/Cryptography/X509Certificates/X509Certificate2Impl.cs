// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 14137
{
	// Properties
	public abstract IEnumerable<X509Extension> Extensions { get; }
	public abstract X500DistinguishedName IssuerName { get; }
	public abstract AsymmetricAlgorithm PrivateKey { get; set; }
	public abstract string SignatureAlgorithm { get; }
	public abstract X500DistinguishedName SubjectName { get; }
	public abstract int Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IEnumerable<X509Extension> get_Extensions();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract X500DistinguishedName get_IssuerName();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract AsymmetricAlgorithm get_PrivateKey();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void set_PrivateKey(AsymmetricAlgorithm value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_SignatureAlgorithm();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract X500DistinguishedName get_SubjectName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 28
	internal abstract X509CertificateImplCollection get_IntermediateCertificates();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool Verify(X509Certificate2 thisCertificate);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void AppendPrivateKeyInfo(StringBuilder sb);

	// RVA: 0x34938D4 Offset: 0x348F8D4 VA: 0x34938D4
	protected void .ctor() { }
}
