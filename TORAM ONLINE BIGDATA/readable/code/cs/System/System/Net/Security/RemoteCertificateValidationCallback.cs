// Assembly: System.dll
// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 14598
{
	// Methods

	// RVA: 0x345FC50 Offset: 0x345BC50 VA: 0x345FC50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x345FD5C Offset: 0x345BD5C VA: 0x345FD5C Slot: 12
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}
