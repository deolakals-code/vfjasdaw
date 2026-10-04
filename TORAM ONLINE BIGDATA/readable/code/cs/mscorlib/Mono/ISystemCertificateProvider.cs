// Assembly: mscorlib.dll
// Namespace: Mono
internal interface ISystemCertificateProvider // TypeDefIndex: 9422
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract X509CertificateImpl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = 0);
}
