// Assembly: System.dll
// Namespace: Mono.Net.Security
internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions // TypeDefIndex: 14007
{
	// Fields
	[CompilerGenerated]
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Properties
	public SslClientAuthenticationOptions Options { get; }
	public override bool ServerMode { get; }
	public override X509RevocationMode CertificateRevocationCheckMode { set; }
	public override EncryptionPolicy EncryptionPolicy { set; }
	public override SslProtocols EnabledSslProtocols { get; set; }
	public override string TargetHost { get; set; }
	public override bool ClientCertificateRequired { get; }
	public override X509CertificateCollection ClientCertificates { get; set; }
	public override X509Certificate ServerCertificate { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x319DACC Offset: 0x3199ACC VA: 0x319DACC
	public SslClientAuthenticationOptions get_Options() { }

	// RVA: 0x319DAD4 Offset: 0x3199AD4 VA: 0x319DAD4 Slot: 4
	public override bool get_ServerMode() { }

	// RVA: 0x319AD94 Offset: 0x3196D94 VA: 0x319AD94
	public void .ctor() { }

	// RVA: 0x319DADC Offset: 0x3199ADC VA: 0x319DADC Slot: 8
	public override void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x319DAF8 Offset: 0x3199AF8 VA: 0x319DAF8 Slot: 7
	public override void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x319DB14 Offset: 0x3199B14 VA: 0x319DB14 Slot: 5
	public override SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x319DB30 Offset: 0x3199B30 VA: 0x319DB30 Slot: 6
	public override void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x319DB4C Offset: 0x3199B4C VA: 0x319DB4C Slot: 9
	public override string get_TargetHost() { }

	// RVA: 0x319DB68 Offset: 0x3199B68 VA: 0x319DB68 Slot: 10
	public override void set_TargetHost(string value) { }

	// RVA: 0x319DB84 Offset: 0x3199B84 VA: 0x319DB84 Slot: 14
	public override bool get_ClientCertificateRequired() { }

	// RVA: 0x319DBBC Offset: 0x3199BBC VA: 0x319DBBC Slot: 12
	public override X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x319DBD8 Offset: 0x3199BD8 VA: 0x319DBD8 Slot: 13
	public override void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x319DBF4 Offset: 0x3199BF4 VA: 0x319DBF4 Slot: 11
	public override X509Certificate get_ServerCertificate() { }
}
