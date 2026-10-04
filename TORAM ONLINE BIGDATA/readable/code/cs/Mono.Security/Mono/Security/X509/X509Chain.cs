// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
public class X509Chain // TypeDefIndex: 16882
{
	// Fields
	private X509CertificateCollection roots; // 0x10
	private X509CertificateCollection certs; // 0x18
	private X509Certificate _root; // 0x20
	private X509CertificateCollection _chain; // 0x28
	private X509ChainStatusFlags _status; // 0x30

	// Properties
	public X509CertificateCollection TrustAnchors { get; }

	// Methods

	// RVA: 0x2E50D00 Offset: 0x2E4CD00 VA: 0x2E50D00
	public void .ctor() { }

	// RVA: 0x2E50D6C Offset: 0x2E4CD6C VA: 0x2E50D6C
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0x2E50E94 Offset: 0x2E4CE94 VA: 0x2E50E94
	public void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0x2E50EAC Offset: 0x2E4CEAC VA: 0x2E50EAC
	public bool Build(X509Certificate leaf) { }

	// RVA: 0x2E51888 Offset: 0x2E4D888 VA: 0x2E51888
	public void Reset() { }

	// RVA: 0x2E517DC Offset: 0x2E4D7DC VA: 0x2E517DC
	private bool IsValid(X509Certificate cert) { }

	// RVA: 0x2E51274 Offset: 0x2E4D274 VA: 0x2E51274
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0x2E51450 Offset: 0x2E4D450 VA: 0x2E51450
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0x2E518E4 Offset: 0x2E4D8E4 VA: 0x2E518E4
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0x2E51698 Offset: 0x2E4D698 VA: 0x2E51698
	private bool IsParent(X509Certificate child, X509Certificate parent) { }
}
