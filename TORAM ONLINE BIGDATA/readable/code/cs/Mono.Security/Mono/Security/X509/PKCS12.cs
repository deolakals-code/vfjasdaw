// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
public class PKCS12 : ICloneable // TypeDefIndex: 16875
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x2E44FEC Offset: 0x2E40FEC VA: 0x2E44FEC
	public void .ctor() { }

	// RVA: 0x2E450F0 Offset: 0x2E410F0 VA: 0x2E450F0
	public void .ctor(byte[] data) { }

	// RVA: 0x2E459A8 Offset: 0x2E419A8 VA: 0x2E459A8
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x2E45314 Offset: 0x2E41314 VA: 0x2E45314
	private void Decode(byte[] data) { }

	// RVA: 0x2E46320 Offset: 0x2E42320 VA: 0x2E46320 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E45124 Offset: 0x2E41124 VA: 0x2E45124
	public void set_Password(string value) { }

	// RVA: 0x2E463E0 Offset: 0x2E423E0 VA: 0x2E463E0
	public int get_IterationCount() { }

	// RVA: 0x2E463E8 Offset: 0x2E423E8 VA: 0x2E463E8
	public void set_IterationCount(int value) { }

	// RVA: 0x2E463F0 Offset: 0x2E423F0 VA: 0x2E463F0
	public ArrayList get_Keys() { }

	// RVA: 0x2E46CA4 Offset: 0x2E42CA4 VA: 0x2E46CA4
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x2E470E4 Offset: 0x2E430E4 VA: 0x2E470E4
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x2E45B3C Offset: 0x2E41B3C VA: 0x2E45B3C
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x2E47114 Offset: 0x2E43114 VA: 0x2E47114
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x2E46AF4 Offset: 0x2E42AF4 VA: 0x2E46AF4
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x2E46290 Offset: 0x2E42290 VA: 0x2E46290
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x2E47918 Offset: 0x2E43918 VA: 0x2E47918
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x2E47B68 Offset: 0x2E43B68 VA: 0x2E47B68
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x2E482C0 Offset: 0x2E442C0 VA: 0x2E482C0
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x2E45BC4 Offset: 0x2E41BC4 VA: 0x2E45BC4
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x2E4851C Offset: 0x2E4451C VA: 0x2E4851C
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x2E459E0 Offset: 0x2E419E0 VA: 0x2E459E0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x2E491E8 Offset: 0x2E451E8 VA: 0x2E491E8
	public byte[] GetBytes() { }

	// RVA: 0x2E4B500 Offset: 0x2E47500 VA: 0x2E4B500
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x2E4B4F8 Offset: 0x2E474F8 VA: 0x2E4B4F8
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x2E4B850 Offset: 0x2E47850 VA: 0x2E4B850
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x2E4B4F0 Offset: 0x2E474F0 VA: 0x2E4B4F0
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x2E4BA98 Offset: 0x2E47A98 VA: 0x2E4BA98
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x2E4BFA4 Offset: 0x2E47FA4 VA: 0x2E4BFA4 Slot: 4
	public object Clone() { }

	// RVA: 0x2E4C06C Offset: 0x2E4806C VA: 0x2E4C06C
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x2E4C0C4 Offset: 0x2E480C4 VA: 0x2E4C0C4
	private static void .cctor() { }
}
