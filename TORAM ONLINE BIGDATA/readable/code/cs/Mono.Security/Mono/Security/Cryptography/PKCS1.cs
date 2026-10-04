// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Cryptography
public sealed class PKCS1 // TypeDefIndex: 16920
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x2E59A10 Offset: 0x2E55A10 VA: 0x2E59A10
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x2E59A9C Offset: 0x2E55A9C VA: 0x2E59A9C
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x2E59B28 Offset: 0x2E55B28 VA: 0x2E59B28
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x2E59BE8 Offset: 0x2E55BE8 VA: 0x2E59BE8
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x2E59C04 Offset: 0x2E55C04 VA: 0x2E59C04
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x2E59DDC Offset: 0x2E55DDC VA: 0x2E59DDC
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x2E5A110 Offset: 0x2E56110 VA: 0x2E5A110
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x2E5A518 Offset: 0x2E56518 VA: 0x2E5A518
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x2E5A574 Offset: 0x2E56574 VA: 0x2E5A574
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x2E5A978 Offset: 0x2E56978 VA: 0x2E5A978
	private static void .cctor() { }
}
