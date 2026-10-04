// Assembly: mscorlib.dll
// Namespace: Mono.Security.Cryptography
internal sealed class PKCS1 // TypeDefIndex: 9478
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x2E7500C Offset: 0x2E7100C VA: 0x2E7500C
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x2E75098 Offset: 0x2E71098 VA: 0x2E75098
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x2E75124 Offset: 0x2E71124 VA: 0x2E75124
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x2E751E4 Offset: 0x2E711E4 VA: 0x2E751E4
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x2E75200 Offset: 0x2E71200 VA: 0x2E75200
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature) { }

	// RVA: 0x2E75458 Offset: 0x2E71458 VA: 0x2E75458
	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	// RVA: 0x2E75280 Offset: 0x2E71280 VA: 0x2E75280
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x2E75A38 Offset: 0x2E71A38 VA: 0x2E75A38
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x2E75630 Offset: 0x2E71630 VA: 0x2E75630
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x2E75D98 Offset: 0x2E71D98 VA: 0x2E75D98
	private static void .cctor() { }
}
