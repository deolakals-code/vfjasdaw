// Assembly: System.dll
// Namespace: Mono
internal class SystemDependencyProvider : ISystemDependencyProvider // TypeDefIndex: 13918
{
	// Fields
	private static SystemDependencyProvider instance; // 0x0
	private static object syncRoot; // 0x8
	[CompilerGenerated]
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; // 0x10

	// Properties
	public static SystemDependencyProvider Instance { get; }
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider { get; }
	public SystemCertificateProvider CertificateProvider { get; }
	public X509PalImpl X509Pal { get; }

	// Methods

	// RVA: 0x319050C Offset: 0x318C50C VA: 0x319050C
	public static SystemDependencyProvider get_Instance() { }

	// RVA: 0x3190568 Offset: 0x318C568 VA: 0x3190568
	internal static void Initialize() { }

	// RVA: 0x3190758 Offset: 0x318C758 VA: 0x3190758 Slot: 4
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	[CompilerGenerated]
	// RVA: 0x3190760 Offset: 0x318C760 VA: 0x3190760
	public SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x3190768 Offset: 0x318C768 VA: 0x3190768
	public X509PalImpl get_X509Pal() { }

	// RVA: 0x31906B4 Offset: 0x318C6B4 VA: 0x31906B4
	private void .ctor() { }

	// RVA: 0x3190780 Offset: 0x318C780 VA: 0x3190780
	private static void .cctor() { }
}
