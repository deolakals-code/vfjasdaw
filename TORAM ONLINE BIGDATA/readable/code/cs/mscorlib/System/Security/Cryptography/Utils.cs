// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
internal static class Utils // TypeDefIndex: 10159
{
	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x0

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x2EBD9CC Offset: 0x2EB99CC VA: 0x2EBD9CC
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x2EBDB58 Offset: 0x2EB9B58 VA: 0x2EBDB58
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x2EBD3B8 Offset: 0x2EB93B8 VA: 0x2EBD3B8
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x2EBDBC8 Offset: 0x2EB9BC8 VA: 0x2EBDBC8
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x2EBDBE4 Offset: 0x2EB9BE4 VA: 0x2EBDBE4
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2EBDD6C Offset: 0x2EB9D6C VA: 0x2EBDD6C
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x2EBDDC4 Offset: 0x2EB9DC4 VA: 0x2EBDDC4
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x2EBD018 Offset: 0x2EB9018 VA: 0x2EBD018
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x2EBDEE8 Offset: 0x2EB9EE8 VA: 0x2EBDEE8
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x2EBDF38 Offset: 0x2EB9F38 VA: 0x2EBDF38
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x2EBE02C Offset: 0x2EBA02C VA: 0x2EBE02C
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x2EBE080 Offset: 0x2EBA080 VA: 0x2EBE080
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x2EBB8F4 Offset: 0x2EB78F4 VA: 0x2EBB8F4
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x2EBB738 Offset: 0x2EB7738 VA: 0x2EBB738
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x2EBE174 Offset: 0x2EBA174 VA: 0x2EBE174
	internal static bool _ProduceLegacyHmacValues() { }
}
