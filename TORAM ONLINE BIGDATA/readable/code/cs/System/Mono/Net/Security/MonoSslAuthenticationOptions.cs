// Assembly: System.dll
// Namespace: Mono.Net.Security
internal abstract class MonoSslAuthenticationOptions // TypeDefIndex: 14006
{
	// Fields
	[CompilerGenerated]
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; // 0x10

	// Properties
	public abstract bool ServerMode { get; }
	public abstract SslProtocols EnabledSslProtocols { get; set; }
	public abstract EncryptionPolicy EncryptionPolicy { set; }
	public abstract X509RevocationMode CertificateRevocationCheckMode { set; }
	public abstract string TargetHost { get; set; }
	public abstract X509Certificate ServerCertificate { get; }
	public abstract X509CertificateCollection ClientCertificates { get; set; }
	public abstract bool ClientCertificateRequired { get; }
	internal ServerCertSelectionCallback ServerCertSelectionDelegate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_ServerMode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract SslProtocols get_EnabledSslProtocols();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_EnabledSslProtocols(SslProtocols value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_EncryptionPolicy(EncryptionPolicy value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_CertificateRevocationCheckMode(X509RevocationMode value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_TargetHost();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_TargetHost(string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract X509Certificate get_ServerCertificate();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract X509CertificateCollection get_ClientCertificates();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_ClientCertificates(X509CertificateCollection value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_ClientCertificateRequired();

	[CompilerGenerated]
	// RVA: 0x319DABC Offset: 0x3199ABC VA: 0x319DABC
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	// RVA: 0x319DAC4 Offset: 0x3199AC4 VA: 0x319DAC4
	protected void .ctor() { }
}
