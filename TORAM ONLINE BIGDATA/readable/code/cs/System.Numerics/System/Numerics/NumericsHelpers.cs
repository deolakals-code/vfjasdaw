// Assembly: System.Numerics.dll
// Namespace: System.Numerics
internal static class NumericsHelpers // TypeDefIndex: 17493
{
	// Methods

	// RVA: 0x329E9D0 Offset: 0x329A9D0 VA: 0x329E9D0
	public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) { }

	// RVA: 0x32A1454 Offset: 0x329D454 VA: 0x32A1454
	public static double GetDoubleFromParts(int sign, int exp, ulong man) { }

	// RVA: 0x329F2E8 Offset: 0x329B2E8 VA: 0x329F2E8
	public static void DangerousMakeTwosComplement(uint[] d) { }

	// RVA: 0x329F9D8 Offset: 0x329B9D8 VA: 0x329F9D8
	public static ulong MakeUlong(uint uHi, uint uLo) { }

	// RVA: 0x32A062C Offset: 0x329C62C VA: 0x32A062C
	public static uint Abs(int a) { }

	// RVA: 0x32A5780 Offset: 0x32A1780 VA: 0x32A5780
	public static uint CombineHash(uint u1, uint u2) { }

	// RVA: 0x329F800 Offset: 0x329B800 VA: 0x329F800
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x32A13DC Offset: 0x329D3DC VA: 0x32A13DC
	public static int CbitHighZero(uint u) { }

	// RVA: 0x32A575C Offset: 0x32A175C VA: 0x32A575C
	public static int CbitHighZero(ulong uu) { }
}
