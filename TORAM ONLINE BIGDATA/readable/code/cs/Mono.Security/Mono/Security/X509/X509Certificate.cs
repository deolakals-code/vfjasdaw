// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
public class X509Certificate : ISerializable // TypeDefIndex: 16879
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }
	public bool IsCurrent { get; }
	public bool IsSelfSigned { get; }

	// Methods

	// RVA: 0x2E4E998 Offset: 0x2E4A998 VA: 0x2E4E998
	private void Parse(byte[] data) { }

	// RVA: 0x2E44500 Offset: 0x2E40500 VA: 0x2E44500
	public void .ctor(byte[] data) { }

	// RVA: 0x2E4F4A4 Offset: 0x2E4B4A4 VA: 0x2E4F4A4
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x2E47F38 Offset: 0x2E43F38 VA: 0x2E47F38
	public DSA get_DSA() { }

	// RVA: 0x2E4F538 Offset: 0x2E4B538 VA: 0x2E4F538
	public void set_DSA(DSA value) { }

	// RVA: 0x2E4F578 Offset: 0x2E4B578 VA: 0x2E4F578
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x2E4F580 Offset: 0x2E4B580 VA: 0x2E4F580
	public byte[] get_Hash() { }

	// RVA: 0x2E4F828 Offset: 0x2E4B828 VA: 0x2E4F828 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x2E4F830 Offset: 0x2E4B830 VA: 0x2E4F830 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x2E4F838 Offset: 0x2E4B838 VA: 0x2E4F838 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x2E4F8AC Offset: 0x2E4B8AC VA: 0x2E4F8AC Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x2E4F8B4 Offset: 0x2E4B8B4 VA: 0x2E4F8B4 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x2E4F928 Offset: 0x2E4B928 VA: 0x2E4F928 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x2E4FAE0 Offset: 0x2E4BAE0 VA: 0x2E4FAE0 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x2E4FB1C Offset: 0x2E4BB1C VA: 0x2E4FB1C Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x2E4FB90 Offset: 0x2E4BB90 VA: 0x2E4FB90 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x2E4FC04 Offset: 0x2E4BC04 VA: 0x2E4FC04 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x2E50038 Offset: 0x2E4C038 VA: 0x2E50038 Slot: 15
	public virtual string get_SubjectName() { }

	// RVA: 0x2E50040 Offset: 0x2E4C040 VA: 0x2E50040 Slot: 16
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x2E50048 Offset: 0x2E4C048 VA: 0x2E50048 Slot: 17
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x2E50050 Offset: 0x2E4C050 VA: 0x2E50050
	public int get_Version() { }

	// RVA: 0x2E50058 Offset: 0x2E4C058 VA: 0x2E50058
	public bool get_IsCurrent() { }

	// RVA: 0x2E500B8 Offset: 0x2E4C0B8 VA: 0x2E500B8
	public bool WasCurrent(DateTime instant) { }

	// RVA: 0x2E50190 Offset: 0x2E4C190 VA: 0x2E50190
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x2E50258 Offset: 0x2E4C258 VA: 0x2E50258
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x2E50380 Offset: 0x2E4C380 VA: 0x2E50380
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x2E504F4 Offset: 0x2E4C4F4 VA: 0x2E504F4
	public bool get_IsSelfSigned() { }

	// RVA: 0x2E505FC Offset: 0x2E4C5FC VA: 0x2E505FC Slot: 18
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E4F370 Offset: 0x2E4B370 VA: 0x2E4F370
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x2E50658 Offset: 0x2E4C658 VA: 0x2E50658
	private static void .cctor() { }
}
