// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 16909
{
	// Methods

	// RVA: 0x2E57DBC Offset: 0x2E53DBC VA: 0x2E57DBC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2E57E70 Offset: 0x2E53E70 VA: 0x2E57E70 Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}
