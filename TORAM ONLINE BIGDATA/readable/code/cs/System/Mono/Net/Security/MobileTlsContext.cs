// Assembly: System.dll
// Namespace: Mono.Net.Security
internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 14004
{
	// Fields
	private ChainValidationHelper certificateValidator; // 0x10
	[CompilerGenerated]
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly bool <IsServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <TargetHost>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <ServerName>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly bool <AskForClientCertificate>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly SslProtocols <EnabledProtocols>k__BackingField; // 0x44
	[CompilerGenerated]
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; // 0x48
	[CompilerGenerated]
	private X509Certificate <LocalServerCertificate>k__BackingField; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	internal string TargetHost { get; }
	protected string ServerName { get; }
	protected bool AskForClientCertificate { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; set; }
	internal abstract X509Certificate LocalClientCertificate { get; }
	public abstract X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x3193BF8 Offset: 0x318FBF8 VA: 0x3193BF8
	protected void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[CompilerGenerated]
	// RVA: 0x319D9D4 Offset: 0x31999D4 VA: 0x319D9D4
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x319463C Offset: 0x319063C VA: 0x319463C
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated();

	[CompilerGenerated]
	// RVA: 0x319D9DC Offset: 0x31999DC VA: 0x319D9DC
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x319D9E4 Offset: 0x31999E4 VA: 0x319D9E4
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x319D9EC Offset: 0x31999EC VA: 0x319D9EC
	protected string get_ServerName() { }

	[CompilerGenerated]
	// RVA: 0x319D9F4 Offset: 0x31999F4 VA: 0x319D9F4
	protected bool get_AskForClientCertificate() { }

	[CompilerGenerated]
	// RVA: 0x319D9FC Offset: 0x31999FC VA: 0x319D9FC
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake();

	[CompilerGenerated]
	// RVA: 0x319DA04 Offset: 0x3199A04 VA: 0x319DA04
	internal X509Certificate get_LocalServerCertificate() { }

	[CompilerGenerated]
	// RVA: 0x319DA0C Offset: 0x3199A0C VA: 0x319DA0C
	private void set_LocalServerCertificate(X509Certificate value) { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract X509Certificate2 get_RemoteCertificate();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Shutdown();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool PendingRenegotiation();

	// RVA: 0x3194A54 Offset: 0x3190A54 VA: 0x3194A54
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0x3195C18 Offset: 0x3191C18 VA: 0x3195C18
	protected X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Renegotiate();

	// RVA: 0x319B9B4 Offset: 0x31979B4 VA: 0x319B9B4 Slot: 4
	public void Dispose() { }

	// RVA: 0x319DA14 Offset: 0x3199A14 VA: 0x319DA14 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x319DA18 Offset: 0x3199A18 VA: 0x319DA18 Slot: 1
	protected override void Finalize() { }
}
