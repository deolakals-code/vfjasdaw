// Assembly: Mono.Security.dll
// Namespace: Mono.Math
public class BigInteger // TypeDefIndex: 16931
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x2E6074C Offset: 0x2E5C74C VA: 0x2E6074C
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x2E607CC Offset: 0x2E5C7CC VA: 0x2E607CC
	public void .ctor(BigInteger bi) { }

	[CLSCompliant(False)]
	// RVA: 0x2E608B4 Offset: 0x2E5C8B4 VA: 0x2E608B4
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x2E5CA60 Offset: 0x2E58A60 VA: 0x2E5CA60
	public void .ctor(byte[] inData) { }

	[CLSCompliant(False)]
	// RVA: 0x2E609F4 Offset: 0x2E5C9F4 VA: 0x2E609F4
	public void .ctor(uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x2E5C18C Offset: 0x2E5818C VA: 0x2E5C18C
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x2E5C52C Offset: 0x2E5852C VA: 0x2E5C52C
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x2E5C5D0 Offset: 0x2E585D0 VA: 0x2E5C5D0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x2E5C250 Offset: 0x2E58250 VA: 0x2E5C250
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x2E5C740 Offset: 0x2E58740 VA: 0x2E5C740
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E61330 Offset: 0x2E5D330 VA: 0x2E61330
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E5C304 Offset: 0x2E58304 VA: 0x2E5C304
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E61454 Offset: 0x2E5D454 VA: 0x2E61454
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x2E6163C Offset: 0x2E5D63C VA: 0x2E6163C
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x2E617B8 Offset: 0x2E5D7B8 VA: 0x2E617B8
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x2E61864 Offset: 0x2E5D864 VA: 0x2E61864
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x2E619C4 Offset: 0x2E5D9C4 VA: 0x2E619C4
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x2E5C4AC Offset: 0x2E584AC VA: 0x2E5C4AC
	public int BitCount() { }

	// RVA: 0x2E61A20 Offset: 0x2E5DA20 VA: 0x2E61A20
	public bool TestBit(int bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x2E61AB4 Offset: 0x2E5DAB4 VA: 0x2E61AB4
	public void SetBit(uint bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x2E61ABC Offset: 0x2E5DABC VA: 0x2E61ABC
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x2E61B18 Offset: 0x2E5DB18 VA: 0x2E61B18
	public int LowestSetBit() { }

	// RVA: 0x2E5D198 Offset: 0x2E59198 VA: 0x2E5D198
	public byte[] GetBytes() { }

	[CLSCompliant(False)]
	// RVA: 0x2E60A84 Offset: 0x2E5CA84 VA: 0x2E60A84
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x2E61B94 Offset: 0x2E5DB94 VA: 0x2E61B94
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x2E5C8A8 Offset: 0x2E588A8 VA: 0x2E5C8A8
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E5C254 Offset: 0x2E58254 VA: 0x2E5C254
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E61C00 Offset: 0x2E5DC00 VA: 0x2E61C00
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E5C518 Offset: 0x2E58518 VA: 0x2E5C518
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E61C18 Offset: 0x2E5DC18 VA: 0x2E61C18
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E61C30 Offset: 0x2E5DC30 VA: 0x2E61C30
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x2E61C48 Offset: 0x2E5DC48 VA: 0x2E61C48
	public string ToString(uint radix) { }

	[CLSCompliant(False)]
	// RVA: 0x2E61CA0 Offset: 0x2E5DCA0 VA: 0x2E61CA0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x2E6099C Offset: 0x2E5C99C VA: 0x2E6099C
	private void Normalize() { }

	// RVA: 0x2E5CDC0 Offset: 0x2E58DC0 VA: 0x2E5CDC0
	public void Clear() { }

	// RVA: 0x2E61F40 Offset: 0x2E5DF40 VA: 0x2E61F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E61F98 Offset: 0x2E5DF98 VA: 0x2E61F98 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E61FA0 Offset: 0x2E5DFA0 VA: 0x2E61FA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2E5C73C Offset: 0x2E5873C VA: 0x2E5C73C
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x2E5CC98 Offset: 0x2E58C98 VA: 0x2E5CC98
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x2E5C1E4 Offset: 0x2E581E4 VA: 0x2E5C1E4
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x2E6290C Offset: 0x2E5E90C VA: 0x2E6290C
	public void Incr2() { }

	// RVA: 0x2E62994 Offset: 0x2E5E994 VA: 0x2E62994
	private static void .cctor() { }
}
