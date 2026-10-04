// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainPolicy // TypeDefIndex: 14149
{
	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public X509Certificate2Collection ExtraStore { get; }
	public X509RevocationFlag RevocationFlag { get; }
	public X509RevocationMode RevocationMode { get; set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }

	// Methods

	// RVA: 0x34971E4 Offset: 0x34931E4 VA: 0x34971E4
	public void .ctor() { }

	// RVA: 0x34987F8 Offset: 0x34947F8 VA: 0x34987F8
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x349A9C0 Offset: 0x34969C0 VA: 0x349A9C0
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x349A9C8 Offset: 0x34969C8 VA: 0x349A9C8
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x349A9D0 Offset: 0x34969D0 VA: 0x349A9D0
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x349AA30 Offset: 0x3496A30 VA: 0x349AA30
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x349AA38 Offset: 0x3496A38 VA: 0x349AA38
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x349AA98 Offset: 0x3496A98 VA: 0x349AA98
	public DateTime get_VerificationTime() { }

	// RVA: 0x349A8B0 Offset: 0x34968B0 VA: 0x349A8B0
	public void Reset() { }
}
