// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper // TypeDefIndex: 10176
{
	// Properties
	private static ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: 0x2EC7CFC Offset: 0x2EC3CFC VA: 0x2EC7CFC
	private static ISystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x2EC6BCC Offset: 0x2EC2BCC VA: 0x2EC6BCC
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x2EC6AD4 Offset: 0x2EC2AD4 VA: 0x2EC6AD4
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x2EC7650 Offset: 0x2EC3650 VA: 0x2EC7650
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x2EC793C Offset: 0x2EC393C VA: 0x2EC793C
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x2EC79B8 Offset: 0x2EC39B8 VA: 0x2EC79B8
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x2EC697C Offset: 0x2EC297C VA: 0x2EC697C
	public static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x2EC7DC4 Offset: 0x2EC3DC4 VA: 0x2EC7DC4
	public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }
}
