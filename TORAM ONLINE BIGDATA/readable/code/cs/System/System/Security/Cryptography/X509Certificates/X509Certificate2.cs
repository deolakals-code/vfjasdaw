// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate2 : X509Certificate // TypeDefIndex: 14134
{
	// Fields
	private byte[] lazyRawData; // 0x60
	private Oid lazySignatureAlgorithm; // 0x68
	private int lazyVersion; // 0x70
	private X500DistinguishedName lazySubjectName; // 0x78
	private X500DistinguishedName lazyIssuerName; // 0x80
	private PublicKey lazyPublicKey; // 0x88
	private AsymmetricAlgorithm lazyPrivateKey; // 0x90
	private X509ExtensionCollection lazyExtensions; // 0x98

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public bool HasPrivateKey { get; }
	public AsymmetricAlgorithm PrivateKey { get; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public PublicKey PublicKey { get; }
	public byte[] RawData { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public string Thumbprint { get; }
	public int Version { get; }
	internal X509Certificate2Impl Impl { get; }

	// Methods

	// RVA: 0x348F13C Offset: 0x348B13C VA: 0x348F13C Slot: 7
	public override void Reset() { }

	// RVA: 0x348F1E8 Offset: 0x348B1E8 VA: 0x348F1E8
	public void .ctor() { }

	// RVA: 0x348F1F0 Offset: 0x348B1F0 VA: 0x348F1F0
	public void .ctor(byte[] rawData) { }

	// RVA: 0x348F3B8 Offset: 0x348B3B8 VA: 0x348F3B8
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x348F3C0 Offset: 0x348B3C0 VA: 0x348F3C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x348F400 Offset: 0x348B400 VA: 0x348F400
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x348FB00 Offset: 0x348BB00 VA: 0x348FB00
	public bool get_HasPrivateKey() { }

	// RVA: 0x348FB34 Offset: 0x348BB34 VA: 0x348FB34
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x348FC98 Offset: 0x348BC98 VA: 0x348FC98
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x348FD04 Offset: 0x348BD04 VA: 0x348FD04
	public DateTime get_NotAfter() { }

	// RVA: 0x348FD0C Offset: 0x348BD0C VA: 0x348FD0C
	public DateTime get_NotBefore() { }

	// RVA: 0x348FD14 Offset: 0x348BD14 VA: 0x348FD14
	public PublicKey get_PublicKey() { }

	// RVA: 0x348FE6C Offset: 0x348BE6C VA: 0x348FE6C
	public byte[] get_RawData() { }

	// RVA: 0x348FED8 Offset: 0x348BED8 VA: 0x348FED8
	public string get_SerialNumber() { }

	// RVA: 0x348FEE8 Offset: 0x348BEE8 VA: 0x348FEE8
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x348FF5C Offset: 0x348BF5C VA: 0x348FF5C
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x348FFC8 Offset: 0x348BFC8 VA: 0x348FFC8
	public string get_Thumbprint() { }

	// RVA: 0x348FFE4 Offset: 0x348BFE4 VA: 0x348FFE4
	public int get_Version() { }

	// RVA: 0x3490040 Offset: 0x348C040 VA: 0x3490040
	public static X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x34900D8 Offset: 0x348C0D8 VA: 0x34900D8
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x3490114 Offset: 0x348C114 VA: 0x3490114 Slot: 3
	public override string ToString() { }

	// RVA: 0x3490120 Offset: 0x348C120 VA: 0x3490120 Slot: 18
	public override string ToString(bool verbose) { }

	// RVA: 0x34911C0 Offset: 0x348D1C0 VA: 0x34911C0
	public bool Verify() { }

	// RVA: 0x348F8CC Offset: 0x348B8CC VA: 0x348F8CC
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x348F840 Offset: 0x348B840 VA: 0x348F840
	internal X509Certificate2Impl get_Impl() { }
}
