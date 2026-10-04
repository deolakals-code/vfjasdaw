// Assembly: mscorlib.dll
// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 9486
{
	// Methods

	// RVA: 0x2E7C1C4 Offset: 0x2E781C4 VA: 0x2E7C1C4
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x2E7E544 Offset: 0x2E7A544 VA: 0x2E7E544
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x2E7E674 Offset: 0x2E7A674 VA: 0x2E7E674
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7C080 Offset: 0x2E78080 VA: 0x2E7C080
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7D5C0 Offset: 0x2E795C0 VA: 0x2E7D5C0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x2E7C388 Offset: 0x2E78388 VA: 0x2E7C388
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x2E7EBA4 Offset: 0x2E7ABA4 VA: 0x2E7EBA4
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x2E7C3EC Offset: 0x2E783EC VA: 0x2E7C3EC
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7CAB0 Offset: 0x2E78AB0 VA: 0x2E7CAB0
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x2E7CC98 Offset: 0x2E78C98 VA: 0x2E7CC98
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x2E7C9BC Offset: 0x2E789BC VA: 0x2E7C9BC
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x2E7C8C0 Offset: 0x2E788C0 VA: 0x2E7C8C0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x2E7E408 Offset: 0x2E7A408 VA: 0x2E7E408
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x2E7ED44 Offset: 0x2E7AD44 VA: 0x2E7ED44
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x2E7D818 Offset: 0x2E79818 VA: 0x2E7D818
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}
