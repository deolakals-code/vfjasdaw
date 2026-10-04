// Assembly: System.dll
// Namespace: System.Net
internal class ServerCertValidationCallback // TypeDefIndex: 14464
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Properties
	internal RemoteCertificateValidationCallback ValidationCallback { get; }

	// Methods

	// RVA: 0x3506CB0 Offset: 0x3502CB0 VA: 0x3506CB0
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x3506D3C Offset: 0x3502D3C VA: 0x3506D3C
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x3506D44 Offset: 0x3502D44 VA: 0x3506D44
	internal void Callback(object state) { }

	// RVA: 0x3506DF0 Offset: 0x3502DF0 VA: 0x3506DF0
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}
