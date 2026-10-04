// Assembly: System.dll
// Namespace: System.Net.Security
public class SslClientAuthenticationOptions // TypeDefIndex: 14593
{
	// Fields
	private EncryptionPolicy _encryptionPolicy; // 0x10
	private X509RevocationMode _checkCertificateRevocation; // 0x14
	private SslProtocols _enabledSslProtocols; // 0x18
	private bool _allowRenegotiation; // 0x1C
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0x20
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; // 0x28

	// Properties
	public string TargetHost { get; set; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public X509RevocationMode CertificateRevocationCheckMode { set; }
	public EncryptionPolicy EncryptionPolicy { set; }
	public SslProtocols EnabledSslProtocols { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x345F72C Offset: 0x345B72C VA: 0x345F72C
	public string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x345F734 Offset: 0x345B734 VA: 0x345F734
	public void set_TargetHost(string value) { }

	[CompilerGenerated]
	// RVA: 0x345F73C Offset: 0x345B73C VA: 0x345F73C
	public X509CertificateCollection get_ClientCertificates() { }

	[CompilerGenerated]
	// RVA: 0x345F744 Offset: 0x345B744 VA: 0x345F744
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x345F74C Offset: 0x345B74C VA: 0x345F74C
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x345F7E8 Offset: 0x345B7E8 VA: 0x345F7E8
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x345F884 Offset: 0x345B884 VA: 0x345F884
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x345F88C Offset: 0x345B88C VA: 0x345F88C
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x345F894 Offset: 0x345B894 VA: 0x345F894
	public void .ctor() { }
}
