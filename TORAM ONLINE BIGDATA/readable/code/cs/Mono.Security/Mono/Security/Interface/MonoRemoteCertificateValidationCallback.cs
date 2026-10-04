// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Interface
public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 16908
{
	// Methods

	// RVA: 0x2E57CF4 Offset: 0x2E53CF4 VA: 0x2E57CF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2E57DA8 Offset: 0x2E53DA8 VA: 0x2E57DA8 Slot: 12
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }
}
