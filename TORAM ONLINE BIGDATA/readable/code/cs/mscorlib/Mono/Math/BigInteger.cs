// Assembly: mscorlib.dll
// Namespace: Mono.Math
internal class BigInteger // TypeDefIndex: 9487
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x2E7BD48 Offset: 0x2E77D48 VA: 0x2E7BD48
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x2E7BDC8 Offset: 0x2E77DC8 VA: 0x2E7BDC8
	public void .ctor(BigInteger bi) { }

	// RVA: 0x2E7BEB0 Offset: 0x2E77EB0 VA: 0x2E7BEB0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x2E76E18 Offset: 0x2E72E18 VA: 0x2E76E18
	public void .ctor(byte[] inData) { }

	// RVA: 0x2E7BFF0 Offset: 0x2E77FF0 VA: 0x2E7BFF0
	public void .ctor(uint ui) { }

	// RVA: 0x2E76544 Offset: 0x2E72544 VA: 0x2E76544
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x2E768E4 Offset: 0x2E728E4 VA: 0x2E768E4
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x2E76988 Offset: 0x2E72988 VA: 0x2E76988
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E76608 Offset: 0x2E72608 VA: 0x2E76608
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x2E76AF8 Offset: 0x2E72AF8 VA: 0x2E76AF8
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7AC78 Offset: 0x2E76C78 VA: 0x2E7AC78
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E766BC Offset: 0x2E726BC VA: 0x2E766BC
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7AB4C Offset: 0x2E76B4C VA: 0x2E7AB4C
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x2E7CAAC Offset: 0x2E78AAC VA: 0x2E7CAAC
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x2E7CC94 Offset: 0x2E78C94 VA: 0x2E7CC94
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x2E7CE10 Offset: 0x2E78E10 VA: 0x2E7CE10
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x2E7CEBC Offset: 0x2E78EBC VA: 0x2E7CEBC
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x2E7A79C Offset: 0x2E7679C VA: 0x2E7A79C
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x2E7D01C Offset: 0x2E7901C VA: 0x2E7D01C
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x2E7A7F8 Offset: 0x2E767F8 VA: 0x2E7A7F8
	public void Randomize() { }

	// RVA: 0x2E76864 Offset: 0x2E72864 VA: 0x2E76864
	public int BitCount() { }

	// RVA: 0x2E7AC3C Offset: 0x2E76C3C VA: 0x2E7AC3C
	public bool TestBit(uint bitNum) { }

	// RVA: 0x2E7D19C Offset: 0x2E7919C VA: 0x2E7D19C
	public bool TestBit(int bitNum) { }

	// RVA: 0x2E7D230 Offset: 0x2E79230 VA: 0x2E7D230
	public void SetBit(uint bitNum) { }

	// RVA: 0x2E7D238 Offset: 0x2E79238 VA: 0x2E7D238
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x2E7D294 Offset: 0x2E79294 VA: 0x2E7D294
	public int LowestSetBit() { }

	// RVA: 0x2E77550 Offset: 0x2E73550 VA: 0x2E77550
	public byte[] GetBytes() { }

	// RVA: 0x2E7A854 Offset: 0x2E76854 VA: 0x2E7A854
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x2E7B0AC Offset: 0x2E770AC VA: 0x2E7B0AC
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x2E76C60 Offset: 0x2E72C60 VA: 0x2E76C60
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7660C Offset: 0x2E7260C VA: 0x2E7660C
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7D310 Offset: 0x2E79310 VA: 0x2E7D310
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E768D0 Offset: 0x2E728D0 VA: 0x2E768D0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7A8C0 Offset: 0x2E768C0 VA: 0x2E7A8C0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7ACA0 Offset: 0x2E76CA0 VA: 0x2E7ACA0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x2E7D328 Offset: 0x2E79328 VA: 0x2E7D328
	public string ToString(uint radix) { }

	// RVA: 0x2E7D380 Offset: 0x2E79380 VA: 0x2E7D380
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x2E7BF98 Offset: 0x2E77F98 VA: 0x2E7BF98
	private void Normalize() { }

	// RVA: 0x2E77178 Offset: 0x2E73178 VA: 0x2E77178
	public void Clear() { }

	// RVA: 0x2E7D670 Offset: 0x2E79670 VA: 0x2E7D670 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E7D6C8 Offset: 0x2E796C8 VA: 0x2E7D6C8 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E7D6D0 Offset: 0x2E796D0 VA: 0x2E7D6D0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2E76AF4 Offset: 0x2E72AF4 VA: 0x2E76AF4
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x2E77050 Offset: 0x2E73050 VA: 0x2E77050
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x2E7A9A4 Offset: 0x2E769A4 VA: 0x2E7A9A4
	public bool IsProbablePrime() { }

	// RVA: 0x2E7659C Offset: 0x2E7259C VA: 0x2E7659C
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x2E7E088 Offset: 0x2E7A088 VA: 0x2E7E088
	public void Incr2() { }

	// RVA: 0x2E7E110 Offset: 0x2E7A110 VA: 0x2E7E110
	private static void .cctor() { }
}
