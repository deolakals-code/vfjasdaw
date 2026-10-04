// Assembly: mscorlib.dll
// Namespace: 
private struct Decimal.DecCalc // TypeDefIndex: 9850
{
	// Fields
	private uint uflags; // 0x0
	private uint uhi; // 0x4
	private uint ulo; // 0x8
	private uint umid; // 0xC
	private ulong ulomidLE; // 0x8
	private static readonly uint[] s_powers10; // 0x0
	private static readonly ulong[] s_ulongPowers10; // 0x8
	private static readonly double[] s_doublePowers10; // 0x10
	private static readonly Decimal.DecCalc.PowerOvfl[] PowerOvflValues; // 0x18

	// Properties
	private uint High { get; set; }
	private uint Low { get; set; }
	private uint Mid { get; set; }
	private bool IsNegative { get; }
	private ulong Low64 { get; set; }

	// Methods

	// RVA: 0x3045550 Offset: 0x3041550 VA: 0x3045550
	private uint get_High() { }

	// RVA: 0x3045558 Offset: 0x3041558 VA: 0x3045558
	private void set_High(uint value) { }

	// RVA: 0x3045560 Offset: 0x3041560 VA: 0x3045560
	private uint get_Low() { }

	// RVA: 0x3045568 Offset: 0x3041568 VA: 0x3045568
	private void set_Low(uint value) { }

	// RVA: 0x3045570 Offset: 0x3041570 VA: 0x3045570
	private uint get_Mid() { }

	// RVA: 0x3045578 Offset: 0x3041578 VA: 0x3045578
	private void set_Mid(uint value) { }

	// RVA: 0x3045580 Offset: 0x3041580 VA: 0x3045580
	private bool get_IsNegative() { }

	// RVA: 0x304558C Offset: 0x304158C VA: 0x304558C
	private ulong get_Low64() { }

	// RVA: 0x3045594 Offset: 0x3041594 VA: 0x3045594
	private void set_Low64(ulong value) { }

	// RVA: 0x304559C Offset: 0x304159C VA: 0x304559C
	private static uint GetExponent(float f) { }

	// RVA: 0x30455A8 Offset: 0x30415A8 VA: 0x30455A8
	private static uint GetExponent(double d) { }

	// RVA: 0x30455B4 Offset: 0x30415B4 VA: 0x30455B4
	private static ulong UInt32x32To64(uint a, uint b) { }

	// RVA: 0x30455BC Offset: 0x30415BC VA: 0x30455BC
	private static void UInt64x64To128(ulong a, ulong b, ref Decimal.DecCalc result) { }

	// RVA: 0x30456D8 Offset: 0x30416D8 VA: 0x30456D8
	private static uint Div96By32(ref Decimal.DecCalc.Buf12 bufNum, uint den) { }

	// RVA: 0x3045754 Offset: 0x3041754 VA: 0x3045754
	private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow) { }

	// RVA: 0x3045794 Offset: 0x3041794 VA: 0x3045794
	private static void Unscale(ref uint low, ref ulong high64, ref int scale) { }

	// RVA: 0x3045A08 Offset: 0x3041A08 VA: 0x3045A08
	private static uint Div96By64(ref Decimal.DecCalc.Buf12 bufNum, ulong den) { }

	// RVA: 0x3045AFC Offset: 0x3041AFC VA: 0x3045AFC
	private static uint Div128By96(ref Decimal.DecCalc.Buf16 bufNum, ref Decimal.DecCalc.Buf12 bufDen) { }

	// RVA: 0x3045C30 Offset: 0x3041C30 VA: 0x3045C30
	private static uint IncreaseScale(ref Decimal.DecCalc.Buf12 bufNum, uint power) { }

	// RVA: 0x3045CB8 Offset: 0x3041CB8 VA: 0x3045CB8
	private static void IncreaseScale64(ref Decimal.DecCalc.Buf12 bufNum, uint power) { }

	// RVA: 0x3045D34 Offset: 0x3041D34 VA: 0x3045D34
	private static int ScaleResult(Decimal.DecCalc.Buf24* bufRes, uint hiRes, int scale) { }

	// RVA: 0x30468B8 Offset: 0x30428B8 VA: 0x30468B8
	private static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power) { }

	// RVA: 0x304690C Offset: 0x304290C VA: 0x304690C
	private static int LeadingZeroCount(uint value) { }

	// RVA: 0x3046970 Offset: 0x3042970 VA: 0x3046970
	private static int OverflowUnscale(ref Decimal.DecCalc.Buf12 bufQuo, int scale, bool sticky) { }

	// RVA: 0x3046AC8 Offset: 0x3042AC8 VA: 0x3046AC8
	private static int SearchScale(ref Decimal.DecCalc.Buf12 bufQuo, int scale) { }

	// RVA: 0x3046A98 Offset: 0x3042A98 VA: 0x3046A98
	private static bool Add32To96(ref Decimal.DecCalc.Buf12 bufNum, uint value) { }

	// RVA: 0x3040E40 Offset: 0x303CE40 VA: 0x3040E40
	internal static void DecAddSub(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2, bool sign) { }

	// RVA: 0x3041530 Offset: 0x303D530 VA: 0x3041530
	internal static int VarDecCmp(in Decimal d1, in Decimal d2) { }

	// RVA: 0x3046CD0 Offset: 0x3042CD0 VA: 0x3046CD0
	private static int VarDecCmpSub(in Decimal d1, in Decimal d2) { }

	// RVA: 0x3042B98 Offset: 0x303EB98 VA: 0x3042B98
	internal static void VarDecMul(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2) { }

	// RVA: 0x3040204 Offset: 0x303C204 VA: 0x3040204
	internal static void VarDecFromR4(float input, out Decimal.DecCalc result) { }

	// RVA: 0x30406A8 Offset: 0x303C6A8 VA: 0x30406A8
	internal static void VarDecFromR8(double input, out Decimal.DecCalc result) { }

	// RVA: 0x3044310 Offset: 0x3040310 VA: 0x3044310
	internal static float VarR4FromDec(in Decimal value) { }

	// RVA: 0x3043CF4 Offset: 0x303FCF4 VA: 0x3043CF4
	internal static double VarR8FromDec(in Decimal value) { }

	// RVA: 0x3042264 Offset: 0x303E264 VA: 0x3042264
	internal static int GetHashCode(in Decimal d) { }

	// RVA: 0x3041898 Offset: 0x303D898 VA: 0x3041898
	internal static void VarDecDiv(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2) { }

	// RVA: 0x3043248 Offset: 0x303F248 VA: 0x3043248
	internal static void InternalRound(ref Decimal.DecCalc d, uint scale, Decimal.DecCalc.RoundingMode mode) { }

	// RVA: 0x30400BC Offset: 0x303C0BC VA: 0x30400BC
	internal static uint DecDivMod1E9(ref Decimal.DecCalc value) { }

	// RVA: 0x3046EA0 Offset: 0x3042EA0 VA: 0x3046EA0
	private static void .cctor() { }
}
