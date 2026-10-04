// Assembly: System.dll
// Namespace: System.Net.Security
public sealed class LocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 14597
{
	// Methods

	// RVA: 0x345FB30 Offset: 0x345BB30 VA: 0x345FB30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x345FC3C Offset: 0x345BC3C VA: 0x345FC3C Slot: 12
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}
