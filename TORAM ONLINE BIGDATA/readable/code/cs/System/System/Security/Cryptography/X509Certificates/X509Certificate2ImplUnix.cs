// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl // TypeDefIndex: 14139
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Properties
	public sealed override string KeyAlgorithm { get; }
	public sealed override byte[] KeyAlgorithmParameters { get; }
	public sealed override byte[] PublicKeyValue { get; }
	public sealed override byte[] SerialNumber { get; }
	public sealed override string SignatureAlgorithm { get; }
	public sealed override int Version { get; }
	public sealed override X500DistinguishedName SubjectName { get; }
	public sealed override X500DistinguishedName IssuerName { get; }
	public sealed override string Subject { get; }
	public sealed override string Issuer { get; }
	public sealed override byte[] RawData { get; }
	public sealed override byte[] Thumbprint { get; }
	public sealed override IEnumerable<X509Extension> Extensions { get; }
	public sealed override DateTime NotAfter { get; }
	public sealed override DateTime NotBefore { get; }

	// Methods

	// RVA: 0x3494E40 Offset: 0x3490E40 VA: 0x3494E40
	private void EnsureCertData() { }

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract byte[] GetRawCertData();

	// RVA: 0x3494ED0 Offset: 0x3490ED0 VA: 0x3494ED0 Slot: 13
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x3494EE8 Offset: 0x3490EE8 VA: 0x3494EE8 Slot: 14
	public sealed override byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x3494F00 Offset: 0x3490F00 VA: 0x3494F00 Slot: 15
	public sealed override byte[] get_PublicKeyValue() { }

	// RVA: 0x3494F18 Offset: 0x3490F18 VA: 0x3494F18 Slot: 16
	public sealed override byte[] get_SerialNumber() { }

	// RVA: 0x3494F30 Offset: 0x3490F30 VA: 0x3494F30 Slot: 25
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x3494F48 Offset: 0x3490F48 VA: 0x3494F48 Slot: 27
	public sealed override int get_Version() { }

	// RVA: 0x3494F64 Offset: 0x3490F64 VA: 0x3494F64 Slot: 26
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x3494F7C Offset: 0x3490F7C VA: 0x3494F7C Slot: 22
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x3494F94 Offset: 0x3490F94 VA: 0x3494F94 Slot: 8
	public sealed override string get_Subject() { }

	// RVA: 0x3494FBC Offset: 0x3490FBC VA: 0x3494FBC Slot: 7
	public sealed override string get_Issuer() { }

	// RVA: 0x3494FE4 Offset: 0x3490FE4 VA: 0x3494FE4 Slot: 9
	public sealed override byte[] get_RawData() { }

	// RVA: 0x3494FFC Offset: 0x3490FFC VA: 0x3494FFC Slot: 12
	public sealed override byte[] get_Thumbprint() { }

	// RVA: 0x349518C Offset: 0x349118C VA: 0x349518C Slot: 29
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x34951C0 Offset: 0x34911C0 VA: 0x34951C0 Slot: 21
	public sealed override IEnumerable<X509Extension> get_Extensions() { }

	// RVA: 0x34951D8 Offset: 0x34911D8 VA: 0x34951D8 Slot: 10
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x3495238 Offset: 0x3491238 VA: 0x3495238 Slot: 11
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x3495298 Offset: 0x3491298 VA: 0x3495298 Slot: 31
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x349391C Offset: 0x348F91C VA: 0x349391C
	protected void .ctor() { }
}
