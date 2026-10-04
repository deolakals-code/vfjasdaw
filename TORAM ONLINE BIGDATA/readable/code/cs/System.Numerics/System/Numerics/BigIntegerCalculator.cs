// Assembly: System.Numerics.dll
// Namespace: System.Numerics
internal static class BigIntegerCalculator // TypeDefIndex: 17489
{
	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x32A0638 Offset: 0x329C638 VA: 0x32A0638
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x32A0710 Offset: 0x329C710 VA: 0x32A0710
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x32A29A8 Offset: 0x329E9A8 VA: 0x32A29A8
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x32A2A2C Offset: 0x329EA2C VA: 0x32A2A2C
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x32A0A38 Offset: 0x329CA38 VA: 0x32A0A38
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x32A0B70 Offset: 0x329CB70 VA: 0x32A0B70
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x32A2AA0 Offset: 0x329EAA0 VA: 0x32A2AA0
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x32A0AF0 Offset: 0x329CAF0 VA: 0x32A0AF0
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x32A22C4 Offset: 0x329E2C4 VA: 0x32A22C4
	public static uint[] Divide(uint[] left, uint right) { }

	// RVA: 0x32A2370 Offset: 0x329E370 VA: 0x32A2370
	public static uint[] Divide(uint[] left, uint[] right) { }

	// RVA: 0x32A2B94 Offset: 0x329EB94 VA: 0x32A2B94
	private static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x32A2F98 Offset: 0x329EF98 VA: 0x32A2F98
	private static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x32A2F50 Offset: 0x329EF50 VA: 0x32A2F50
	private static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) { }

	// RVA: 0x32A2F04 Offset: 0x329EF04 VA: 0x32A2F04
	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	// RVA: 0x32A2B18 Offset: 0x329EB18 VA: 0x32A2B18
	private static uint[] CreateCopy(uint[] value) { }

	// RVA: 0x32A2E8C Offset: 0x329EE8C VA: 0x32A2E8C
	private static int LeadingZeros(uint value) { }

	// RVA: 0x32A1FC8 Offset: 0x329DFC8 VA: 0x32A1FC8
	public static uint[] Square(uint[] value) { }

	// RVA: 0x32A2FD8 Offset: 0x329EFD8 VA: 0x32A2FD8
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x32A1EE4 Offset: 0x329DEE4 VA: 0x32A1EE4
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x32A2088 Offset: 0x329E088 VA: 0x32A2088
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x32A3440 Offset: 0x329F440 VA: 0x32A3440
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x32A3380 Offset: 0x329F380 VA: 0x32A3380
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x32A38D4 Offset: 0x329F8D4 VA: 0x32A38D4
	private static void .cctor() { }
}
