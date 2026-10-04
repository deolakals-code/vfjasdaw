// Assembly: System.dll
// Namespace: Mono
internal abstract class X509PalImpl // TypeDefIndex: 13921
{
	// Fields
	private static byte[] signedData; // 0x0

	// Properties
	public bool SupportsLegacyBasicConstraintsExtension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract X509CertificateImpl Import(byte[] data);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509Certificate2Impl Import(X509Certificate cert);

	// RVA: 0x319086C Offset: 0x318C86C VA: 0x319086C
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x31909A0 Offset: 0x318C9A0 VA: 0x31909A0
	protected static byte[] ConvertData(byte[] data) { }

	// RVA: 0x319007C Offset: 0x318C07C VA: 0x319007C
	internal X509Certificate2Impl ImportFallback(byte[] data) { }

	// RVA: 0x3190304 Offset: 0x318C304 VA: 0x3190304
	internal X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x3190AAC Offset: 0x318CAAC VA: 0x3190AAC
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0x3190AB4 Offset: 0x318CAB4 VA: 0x3190AB4
	public X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x3190864 Offset: 0x318C864 VA: 0x3190864
	protected void .ctor() { }

	// RVA: 0x3190EB4 Offset: 0x318CEB4 VA: 0x3190EB4
	private static void .cctor() { }
}
