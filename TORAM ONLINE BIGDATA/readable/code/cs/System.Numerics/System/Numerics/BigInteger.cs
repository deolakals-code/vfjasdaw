// Assembly: System.Numerics.dll
// Namespace: System.Numerics
[IsReadOnly]
[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 17488
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Properties
	public static BigInteger Zero { get; }
	public static BigInteger MinusOne { get; }
	public bool IsZero { get; }

	// Methods

	// RVA: 0x329E338 Offset: 0x329A338 VA: 0x329E338
	public void .ctor(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x329E3BC Offset: 0x329A3BC VA: 0x329E3BC
	public void .ctor(uint value) { }

	// RVA: 0x329E460 Offset: 0x329A460 VA: 0x329E460
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x329E5AC Offset: 0x329A5AC VA: 0x329E5AC
	public void .ctor(ulong value) { }

	// RVA: 0x329E698 Offset: 0x329A698 VA: 0x329E698
	public void .ctor(float value) { }

	// RVA: 0x329E6FC Offset: 0x329A6FC VA: 0x329E6FC
	public void .ctor(double value) { }

	// RVA: 0x329EA74 Offset: 0x329AA74 VA: 0x329EA74
	public void .ctor(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x329EC70 Offset: 0x329AC70 VA: 0x329EC70
	public void .ctor(byte[] value) { }

	// RVA: 0x329ED34 Offset: 0x329AD34 VA: 0x329ED34
	public void .ctor(ReadOnlySpan<byte> value, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x329F39C Offset: 0x329B39C VA: 0x329F39C
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x329F3AC Offset: 0x329B3AC VA: 0x329F3AC
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x329F5A0 Offset: 0x329B5A0 VA: 0x329F5A0
	public static BigInteger get_Zero() { }

	// RVA: 0x329F5F8 Offset: 0x329B5F8 VA: 0x329F5F8
	public static BigInteger get_MinusOne() { }

	// RVA: 0x329F650 Offset: 0x329B650 VA: 0x329F650
	public bool get_IsZero() { }

	// RVA: 0x329F660 Offset: 0x329B660 VA: 0x329F660
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x329F6E8 Offset: 0x329B6E8 VA: 0x329F6E8
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x329F7C8 Offset: 0x329B7C8 VA: 0x329F7C8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x329F808 Offset: 0x329B808 VA: 0x329F808 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x329F96C Offset: 0x329B96C VA: 0x329F96C
	public bool Equals(long other) { }

	// RVA: 0x329F8B0 Offset: 0x329B8B0 VA: 0x329F8B0 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x329FA50 Offset: 0x329BA50 VA: 0x329FA50
	public int CompareTo(long other) { }

	// RVA: 0x329FAE0 Offset: 0x329BAE0 VA: 0x329FAE0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x329FC08 Offset: 0x329BC08 VA: 0x329FC08 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x329FD0C Offset: 0x329BD0C VA: 0x329FD0C
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x32A02C8 Offset: 0x329C2C8 VA: 0x32A02C8
	internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x329FDBC Offset: 0x329BDBC VA: 0x329FDBC
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	// RVA: 0x32A0370 Offset: 0x329C370 VA: 0x32A0370 Slot: 3
	public override string ToString() { }

	// RVA: 0x32A044C Offset: 0x329C44C VA: 0x32A044C
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x32A0480 Offset: 0x329C480 VA: 0x32A0480 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x32A04B8 Offset: 0x329C4B8 VA: 0x32A04B8
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x32A07FC Offset: 0x329C7FC VA: 0x32A07FC
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x32A08A8 Offset: 0x329C8A8 VA: 0x32A08A8
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x32A0C64 Offset: 0x329CC64 VA: 0x32A0C64
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x32A0C8C Offset: 0x329CC8C VA: 0x32A0C8C
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x32A0CB4 Offset: 0x329CCB4 VA: 0x32A0CB4
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x32A0CDC Offset: 0x329CCDC VA: 0x32A0CDC
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x32A0D04 Offset: 0x329CD04 VA: 0x32A0D04
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x32A0D2C Offset: 0x329CD2C VA: 0x32A0D2C
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x32A0604 Offset: 0x329C604 VA: 0x32A0604
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x329EA4C Offset: 0x329AA4C VA: 0x329EA4C
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x32A0D54 Offset: 0x329CD54 VA: 0x32A0D54
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x32A0EBC Offset: 0x329CEBC VA: 0x32A0EBC
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x32A0F4C Offset: 0x329CF4C VA: 0x32A0F4C
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x32A0FDC Offset: 0x329CFDC VA: 0x32A0FDC
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x32A0DE4 Offset: 0x329CDE4 VA: 0x32A0DE4
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x32A106C Offset: 0x329D06C VA: 0x32A106C
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x32A1114 Offset: 0x329D114 VA: 0x32A1114
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x32A11C0 Offset: 0x329D1C0 VA: 0x32A11C0
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x32A1278 Offset: 0x329D278 VA: 0x32A1278
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x32A12E4 Offset: 0x329D2E4 VA: 0x32A12E4
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x32A14FC Offset: 0x329D4FC VA: 0x32A14FC
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x32A1654 Offset: 0x329D654 VA: 0x32A1654
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x32A18A8 Offset: 0x329D8A8 VA: 0x32A18A8
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x32A1C90 Offset: 0x329DC90 VA: 0x32A1C90
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x32A1CC0 Offset: 0x329DCC0 VA: 0x32A1CC0
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x32A1D6C Offset: 0x329DD6C VA: 0x32A1D6C
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x32A2174 Offset: 0x329E174 VA: 0x32A2174
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x32A244C Offset: 0x329E44C VA: 0x32A244C
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x32A24CC Offset: 0x329E4CC VA: 0x32A24CC
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x32A254C Offset: 0x329E54C VA: 0x32A254C
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x32A25B8 Offset: 0x329E5B8 VA: 0x32A25B8
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x32A2628 Offset: 0x329E628 VA: 0x32A2628
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x32A2694 Offset: 0x329E694 VA: 0x32A2694
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x32A2704 Offset: 0x329E704 VA: 0x32A2704
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x32A2774 Offset: 0x329E774 VA: 0x32A2774
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x32A1BCC Offset: 0x329DBCC VA: 0x32A1BCC
	private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl) { }

	// RVA: 0x329F9E8 Offset: 0x329B9E8 VA: 0x329F9E8
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x32A27E4 Offset: 0x329E7E4 VA: 0x32A27E4
	private static void .cctor() { }
}
