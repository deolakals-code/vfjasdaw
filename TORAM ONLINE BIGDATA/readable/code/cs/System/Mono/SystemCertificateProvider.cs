// Assembly: System.dll
// Namespace: Mono
internal class SystemCertificateProvider : ISystemCertificateProvider // TypeDefIndex: 13917
{
	// Fields
	private static int initialized; // 0x0
	private static X509PalImpl x509pal; // 0x8
	private static object syncRoot; // 0x10

	// Properties
	public X509PalImpl X509Pal { get; }

	// Methods

	// RVA: 0x318FDBC Offset: 0x318BDBC VA: 0x318FDBC
	private static X509PalImpl GetX509Pal() { }

	// RVA: 0x318FE64 Offset: 0x318BE64 VA: 0x318FE64
	private static void EnsureInitialized() { }

	// RVA: 0x318FFB4 Offset: 0x318BFB4 VA: 0x318FFB4
	public X509PalImpl get_X509Pal() { }

	// RVA: 0x3190010 Offset: 0x318C010 VA: 0x3190010 Slot: 4
	public X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x3190270 Offset: 0x318C270 VA: 0x3190270 Slot: 5
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0x3190274 Offset: 0x318C274 VA: 0x3190274
	public X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x3190378 Offset: 0x318C378 VA: 0x3190378 Slot: 6
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0x319037C Offset: 0x318C37C VA: 0x319037C
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x3190490 Offset: 0x318C490 VA: 0x3190490
	public void .ctor() { }

	// RVA: 0x3190498 Offset: 0x318C498 VA: 0x3190498
	private static void .cctor() { }
}
