// Assembly: System.dll
// Namespace: 
private class ServerCertValidationCallback.CallbackContext // TypeDefIndex: 14463
{
	// Fields
	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C

	// Methods

	// RVA: 0x3506F60 Offset: 0x3502F60 VA: 0x3506F60
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}
