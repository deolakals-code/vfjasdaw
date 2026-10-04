// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
public sealed class X501 // TypeDefIndex: 16876
{
	// Fields
	private static byte[] countryName; // 0x0
	private static byte[] organizationName; // 0x8
	private static byte[] organizationalUnitName; // 0x10
	private static byte[] commonName; // 0x18
	private static byte[] localityName; // 0x20
	private static byte[] stateOrProvinceName; // 0x28
	private static byte[] streetAddress; // 0x30
	private static byte[] serialNumber; // 0x38
	private static byte[] domainComponent; // 0x40
	private static byte[] userid; // 0x48
	private static byte[] email; // 0x50
	private static byte[] dnQualifier; // 0x58
	private static byte[] title; // 0x60
	private static byte[] surname; // 0x68
	private static byte[] givenName; // 0x70
	private static byte[] initial; // 0x78

	// Methods

	// RVA: 0x2E44D44 Offset: 0x2E40D44 VA: 0x2E44D44
	public static string ToString(ASN1 seq) { }

	// RVA: 0x2E4CF08 Offset: 0x2E48F08 VA: 0x2E4CF08
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0x2E4C740 Offset: 0x2E48740 VA: 0x2E4C740
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0x2E4D0C8 Offset: 0x2E490C8 VA: 0x2E4D0C8
	private static void .cctor() { }
}
