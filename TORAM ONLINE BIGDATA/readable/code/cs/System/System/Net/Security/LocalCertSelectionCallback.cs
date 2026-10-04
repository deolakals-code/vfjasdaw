// Assembly: System.dll
// Namespace: System.Net.Security
internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 14600
{
	// Methods

	// RVA: 0x345FD70 Offset: 0x345BD70 VA: 0x345FD70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x345FE24 Offset: 0x345BE24 VA: 0x345FE24 Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}
