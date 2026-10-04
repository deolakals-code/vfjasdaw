// Assembly: Mono.Security.dll
// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 16930
{
	// Methods

	// RVA: 0x2E60C34 Offset: 0x2E5CC34 VA: 0x2E60C34
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x2E62DC8 Offset: 0x2E5EDC8 VA: 0x2E62DC8
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x2E62EF8 Offset: 0x2E5EEF8 VA: 0x2E62EF8
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E60AF0 Offset: 0x2E5CAF0 VA: 0x2E60AF0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E61ECC Offset: 0x2E5DECC VA: 0x2E61ECC
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x2E60DF8 Offset: 0x2E5CDF8 VA: 0x2E60DF8
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x2E63428 Offset: 0x2E5F428 VA: 0x2E63428
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x2E60E5C Offset: 0x2E5CE5C VA: 0x2E60E5C
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E61458 Offset: 0x2E5D458 VA: 0x2E61458
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x2E61640 Offset: 0x2E5D640 VA: 0x2E61640
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x2E61358 Offset: 0x2E5D358 VA: 0x2E61358
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x2E62C8C Offset: 0x2E5EC8C VA: 0x2E62C8C
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x2E635C8 Offset: 0x2E5F5C8 VA: 0x2E635C8
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x2E620E8 Offset: 0x2E5E0E8 VA: 0x2E620E8
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}
