// Assembly: Photon3Unity3D.dll
// Namespace: Photon.SocketServer.Numeric
internal class BigInteger // TypeDefIndex: 16952
{
	// Fields
	public static readonly int[] primesBelow2000; // 0x0
	private uint[] data; // 0x10
	public int dataLength; // 0x18

	// Methods

	// RVA: 0x30EE5F4 Offset: 0x30EA5F4 VA: 0x30EE5F4
	public void .ctor() { }

	// RVA: 0x30EE440 Offset: 0x30EA440 VA: 0x30EE440
	public void .ctor(long value) { }

	// RVA: 0x30EE678 Offset: 0x30EA678 VA: 0x30EE678
	public void .ctor(BigInteger bi) { }

	// RVA: 0x30ECEBC Offset: 0x30E8EBC VA: 0x30ECEBC
	public void .ctor(byte[] inData) { }

	// RVA: 0x30EE768 Offset: 0x30EA768 VA: 0x30EE768
	public void .ctor(uint[] inData) { }

	// RVA: 0x30EE8E8 Offset: 0x30EA8E8 VA: 0x30EE8E8
	public static BigInteger op_Implicit(long value) { }

	// RVA: 0x30EE054 Offset: 0x30EA054 VA: 0x30EE054
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x30EE940 Offset: 0x30EA940 VA: 0x30EE940
	public static BigInteger op_Addition(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30EE0AC Offset: 0x30EA0AC VA: 0x30EE0AC
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30EEB54 Offset: 0x30EAB54 VA: 0x30EEB54
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30EF1E8 Offset: 0x30EB1E8 VA: 0x30EF1E8
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x30EF278 Offset: 0x30EB278 VA: 0x30EF278
	private static int shiftLeft(uint[] buffer, int shiftVal) { }

	// RVA: 0x30EF360 Offset: 0x30EB360 VA: 0x30EF360
	private static int shiftRight(uint[] buffer, int shiftVal) { }

	// RVA: 0x30EF02C Offset: 0x30EB02C VA: 0x30EF02C
	public static BigInteger op_UnaryNegation(BigInteger bi1) { }

	// RVA: 0x30EE378 Offset: 0x30EA378 VA: 0x30EE378
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30EF470 Offset: 0x30EB470 VA: 0x30EF470 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x30EF578 Offset: 0x30EB578 VA: 0x30EF578 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x30EF5A0 Offset: 0x30EB5A0 VA: 0x30EF5A0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30EF66C Offset: 0x30EB66C VA: 0x30EF66C
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30EE2D0 Offset: 0x30EA2D0 VA: 0x30EE2D0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30EF738 Offset: 0x30EB738 VA: 0x30EF738
	private static void multiByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder) { }

	// RVA: 0x30EFD0C Offset: 0x30EBD0C VA: 0x30EFD0C
	private static void singleByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder) { }

	// RVA: 0x30F0014 Offset: 0x30EC014 VA: 0x30F0014
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30F01C4 Offset: 0x30EC1C4 VA: 0x30F01C4
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x30F0348 Offset: 0x30EC348 VA: 0x30F0348 Slot: 3
	public override string ToString() { }

	// RVA: 0x30F0350 Offset: 0x30EC350 VA: 0x30F0350
	public string ToString(int radix) { }

	// RVA: 0x30EDC60 Offset: 0x30E9C60 VA: 0x30EDC60
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x30F0760 Offset: 0x30EC760 VA: 0x30F0760
	private BigInteger BarrettReduction(BigInteger x, BigInteger n, BigInteger constant) { }

	// RVA: 0x30EDFB8 Offset: 0x30E9FB8 VA: 0x30EDFB8
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x30F0C0C Offset: 0x30ECC0C VA: 0x30F0C0C
	public void genRandomBits(int bits, Random rand) { }

	// RVA: 0x30F06B4 Offset: 0x30EC6B4 VA: 0x30F06B4
	public int bitCount() { }

	// RVA: 0x30ED3AC Offset: 0x30E93AC VA: 0x30ED3AC
	public byte[] GetBytes() { }

	// RVA: 0x30F0DC8 Offset: 0x30ECDC8 VA: 0x30F0DC8
	private static void .cctor() { }
}
