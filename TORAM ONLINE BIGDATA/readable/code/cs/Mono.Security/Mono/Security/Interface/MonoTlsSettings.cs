// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Interface
public sealed class MonoTlsSettings // TypeDefIndex: 16912
{
	// Fields
	[CompilerGenerated]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGenerated]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGenerated]
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGenerated]
	private string[] <ClientCertificateIssuers>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x5C
	[CompilerGenerated]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x68
	private bool cloned; // 0x70
	private bool checkCertName; // 0x71
	private bool checkCertRevocationStatus; // 0x72
	private Nullable<bool> useServicePointManagerCallback; // 0x73
	private bool skipSystemValidators; // 0x75
	private bool callbackNeedsChain; // 0x76
	private ICertificateValidator certificateValidator; // 0x78
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public string[] ClientCertificateIssuers { get; set; }
	public bool DisallowUnauthenticatedCertificateRequest { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliant(False)]
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[Obsolete("Do not use outside System.dll!")]
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2E57EFC Offset: 0x2E53EFC VA: 0x2E57EFC
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x2E57F04 Offset: 0x2E53F04 VA: 0x2E57F04
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2E57F0C Offset: 0x2E53F0C VA: 0x2E57F0C
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x2E57F14 Offset: 0x2E53F14 VA: 0x2E57F14
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x2E57F1C Offset: 0x2E53F1C VA: 0x2E57F1C
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x2E57F24 Offset: 0x2E53F24 VA: 0x2E57F24
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x2E57F2C Offset: 0x2E53F2C VA: 0x2E57F2C
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGenerated]
	// RVA: 0x2E57F34 Offset: 0x2E53F34 VA: 0x2E57F34
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGenerated]
	// RVA: 0x2E57F40 Offset: 0x2E53F40 VA: 0x2E57F40
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGenerated]
	// RVA: 0x2E57F48 Offset: 0x2E53F48 VA: 0x2E57F48
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGenerated]
	// RVA: 0x2E57F50 Offset: 0x2E53F50 VA: 0x2E57F50
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGenerated]
	// RVA: 0x2E57F58 Offset: 0x2E53F58 VA: 0x2E57F58
	public object get_UserSettings() { }

	[CompilerGenerated]
	// RVA: 0x2E57F60 Offset: 0x2E53F60 VA: 0x2E57F60
	public void set_UserSettings(object value) { }

	[CompilerGenerated]
	// RVA: 0x2E57F68 Offset: 0x2E53F68 VA: 0x2E57F68
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGenerated]
	// RVA: 0x2E57F70 Offset: 0x2E53F70 VA: 0x2E57F70
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x2E57F78 Offset: 0x2E53F78 VA: 0x2E57F78
	internal bool get_SendCloseNotify() { }

	[CompilerGenerated]
	// RVA: 0x2E57F80 Offset: 0x2E53F80 VA: 0x2E57F80
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E57F8C Offset: 0x2E53F8C VA: 0x2E57F8C
	public string[] get_ClientCertificateIssuers() { }

	[CompilerGenerated]
	// RVA: 0x2E57F94 Offset: 0x2E53F94 VA: 0x2E57F94
	public void set_ClientCertificateIssuers(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x2E57F9C Offset: 0x2E53F9C VA: 0x2E57F9C
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[CompilerGenerated]
	// RVA: 0x2E57FA4 Offset: 0x2E53FA4 VA: 0x2E57FA4
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2E57FB0 Offset: 0x2E53FB0 VA: 0x2E57FB0
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGenerated]
	// RVA: 0x2E57FB8 Offset: 0x2E53FB8 VA: 0x2E57FB8
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGenerated]
	// RVA: 0x2E57FC0 Offset: 0x2E53FC0 VA: 0x2E57FC0
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGenerated]
	// RVA: 0x2E57FC8 Offset: 0x2E53FC8 VA: 0x2E57FC8
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x2E57FD0 Offset: 0x2E53FD0 VA: 0x2E57FD0
	public void .ctor() { }

	// RVA: 0x2E57FE4 Offset: 0x2E53FE4 VA: 0x2E57FE4
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x2E58070 Offset: 0x2E54070 VA: 0x2E58070
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x2E580E0 Offset: 0x2E540E0 VA: 0x2E580E0
	public ICertificateValidator get_CertificateValidator() { }

	[Obsolete("Do not use outside System.dll!")]
	// RVA: 0x2E580E8 Offset: 0x2E540E8 VA: 0x2E580E8
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x2E58088 Offset: 0x2E54088 VA: 0x2E58088
	public MonoTlsSettings Clone() { }

	// RVA: 0x2E58174 Offset: 0x2E54174 VA: 0x2E58174
	private void .ctor(MonoTlsSettings other) { }
}
