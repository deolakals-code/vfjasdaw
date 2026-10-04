// Assembly: System.dll
// Namespace: Mono.Net.Security
internal class ChainValidationHelper : ICertificateValidator // TypeDefIndex: 13995
{
	// Fields
	private readonly WeakReference<SslStream> owner; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MobileTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly MonoTlsStream tlsStream; // 0x38
	private readonly HttpWebRequest request; // 0x40

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0x3199918 Offset: 0x3195918 VA: 0x3199918
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x3199CE8 Offset: 0x3195CE8 VA: 0x3199CE8
	internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x31999F8 Offset: 0x31959F8 VA: 0x31999F8
	private void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0x3199E94 Offset: 0x3195E94 VA: 0x3199E94
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0x319A060 Offset: 0x3196060 VA: 0x319A060
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x319A09C Offset: 0x319609C VA: 0x319A09C Slot: 4
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x319A0A4 Offset: 0x31960A4 VA: 0x319A0A4 Slot: 5
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x319A0FC Offset: 0x31960FC VA: 0x319A0FC
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x319A1D0 Offset: 0x31961D0 VA: 0x319A1D0
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x319A29C Offset: 0x319629C VA: 0x319A29C
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x319A6A4 Offset: 0x31966A4 VA: 0x319A6A4
	private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }
}
