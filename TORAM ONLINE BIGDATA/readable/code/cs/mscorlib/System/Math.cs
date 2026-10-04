// Assembly: mscorlib.dll
// Namespace: System
public static class Math // TypeDefIndex: 9628
{
	// Fields
	private static double doubleRoundLimit; // 0x0
	private static double[] roundPower10Double; // 0x8

	// Methods

	// RVA: 0x2FE641C Offset: 0x2FE241C VA: 0x2FE641C
	public static short Abs(short value) { }

	// RVA: 0x2FE64C8 Offset: 0x2FE24C8 VA: 0x2FE64C8
	public static int Abs(int value) { }

	// RVA: 0x2FE6524 Offset: 0x2FE2524 VA: 0x2FE6524
	public static long Abs(long value) { }

	// RVA: 0x2FE6580 Offset: 0x2FE2580 VA: 0x2FE6580
	public static Decimal Abs(Decimal value) { }

	[StackTraceHidden]
	// RVA: 0x2FE647C Offset: 0x2FE247C VA: 0x2FE647C
	private static void ThrowAbsOverflow() { }

	// RVA: 0x2FE6604 Offset: 0x2FE2604 VA: 0x2FE6604
	public static int DivRem(int a, int b, out int result) { }

	// RVA: 0x2FE6618 Offset: 0x2FE2618 VA: 0x2FE6618
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x2FE66BC Offset: 0x2FE26BC VA: 0x2FE66BC
	public static float Clamp(float value, float min, float max) { }

	[NonVersionable]
	// RVA: 0x2FE6764 Offset: 0x2FE2764 VA: 0x2FE6764
	public static byte Max(byte val1, byte val2) { }

	// RVA: 0x2FE6774 Offset: 0x2FE2774 VA: 0x2FE6774
	public static Decimal Max(Decimal val1, Decimal val2) { }

	// RVA: 0x2FE680C Offset: 0x2FE280C VA: 0x2FE680C
	public static double Max(double val1, double val2) { }

	[NonVersionable]
	// RVA: 0x2FE682C Offset: 0x2FE282C VA: 0x2FE682C
	public static short Max(short val1, short val2) { }

	[NonVersionable]
	// RVA: 0x2FE683C Offset: 0x2FE283C VA: 0x2FE683C
	public static int Max(int val1, int val2) { }

	[NonVersionable]
	// RVA: 0x2FE6848 Offset: 0x2FE2848 VA: 0x2FE6848
	public static long Max(long val1, long val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x2FE6854 Offset: 0x2FE2854 VA: 0x2FE6854
	public static sbyte Max(sbyte val1, sbyte val2) { }

	// RVA: 0x2FE6864 Offset: 0x2FE2864 VA: 0x2FE6864
	public static float Max(float val1, float val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x2FE6884 Offset: 0x2FE2884 VA: 0x2FE6884
	public static ushort Max(ushort val1, ushort val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x2FE6894 Offset: 0x2FE2894 VA: 0x2FE6894
	public static uint Max(uint val1, uint val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	// RVA: 0x2FE68A0 Offset: 0x2FE28A0 VA: 0x2FE68A0
	public static ulong Max(ulong val1, ulong val2) { }

	[NonVersionable]
	// RVA: 0x2FE68AC Offset: 0x2FE28AC VA: 0x2FE68AC
	public static byte Min(byte val1, byte val2) { }

	// RVA: 0x2FE68BC Offset: 0x2FE28BC VA: 0x2FE68BC
	public static Decimal Min(Decimal val1, Decimal val2) { }

	// RVA: 0x2FE6954 Offset: 0x2FE2954 VA: 0x2FE6954
	public static double Min(double val1, double val2) { }

	[NonVersionable]
	// RVA: 0x2FE6974 Offset: 0x2FE2974 VA: 0x2FE6974
	public static short Min(short val1, short val2) { }

	[NonVersionable]
	// RVA: 0x2FE6984 Offset: 0x2FE2984 VA: 0x2FE6984
	public static int Min(int val1, int val2) { }

	[NonVersionable]
	// RVA: 0x2FE6990 Offset: 0x2FE2990 VA: 0x2FE6990
	public static long Min(long val1, long val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	// RVA: 0x2FE699C Offset: 0x2FE299C VA: 0x2FE699C
	public static sbyte Min(sbyte val1, sbyte val2) { }

	// RVA: 0x2FE69AC Offset: 0x2FE29AC VA: 0x2FE69AC
	public static float Min(float val1, float val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x2FE69CC Offset: 0x2FE29CC VA: 0x2FE69CC
	public static ushort Min(ushort val1, ushort val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x2FE69DC Offset: 0x2FE29DC VA: 0x2FE69DC
	public static uint Min(uint val1, uint val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x2FE69E8 Offset: 0x2FE29E8 VA: 0x2FE69E8
	public static ulong Min(ulong val1, ulong val2) { }

	// RVA: 0x2FE69F4 Offset: 0x2FE29F4 VA: 0x2FE69F4
	public static Decimal Round(Decimal d) { }

	// RVA: 0x2FE6A60 Offset: 0x2FE2A60 VA: 0x2FE6A60
	public static double Round(double a) { }

	// RVA: 0x2FE6AE4 Offset: 0x2FE2AE4 VA: 0x2FE6AE4
	public static double Round(double value, int digits) { }

	// RVA: 0x2FE6DEC Offset: 0x2FE2DEC VA: 0x2FE6DEC
	public static double Round(double value, MidpointRounding mode) { }

	// RVA: 0x2FE6B4C Offset: 0x2FE2B4C VA: 0x2FE6B4C
	public static double Round(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x2FE6E58 Offset: 0x2FE2E58 VA: 0x2FE6E58
	public static int Sign(double value) { }

	// RVA: 0x2FE6ED0 Offset: 0x2FE2ED0 VA: 0x2FE6ED0
	public static int Sign(long value) { }

	// RVA: 0x2FE6EE4 Offset: 0x2FE2EE4 VA: 0x2FE6EE4
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x2FE6F4C Offset: 0x2FE2F4C VA: 0x2FE6F4C
	public static double Truncate(double d) { }

	// RVA: -1 Offset: -1
	private static void ThrowMinMaxException<T>(T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D7DE8 Offset: 0x26D3DE8 VA: 0x26D7DE8
	|-Math.ThrowMinMaxException<int>
	|
	|-RVA: 0x26D7E88 Offset: 0x26D3E88 VA: 0x26D7E88
	|-Math.ThrowMinMaxException<float>
	|
	|-RVA: 0x26D7F28 Offset: 0x26D3F28 VA: 0x26D7F28
	|-Math.ThrowMinMaxException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2FE6FB8 Offset: 0x2FE2FB8 VA: 0x2FE6FB8
	public static double Abs(double value) { }

	// RVA: 0x2FE6FC0 Offset: 0x2FE2FC0 VA: 0x2FE6FC0
	public static float Abs(float value) { }

	// RVA: 0x2FE6FC8 Offset: 0x2FE2FC8 VA: 0x2FE6FC8
	public static double Acos(double d) { }

	// RVA: 0x2FE6FCC Offset: 0x2FE2FCC VA: 0x2FE6FCC
	public static double Asin(double d) { }

	// RVA: 0x2FE6FD0 Offset: 0x2FE2FD0 VA: 0x2FE6FD0
	public static double Atan(double d) { }

	// RVA: 0x2FE6FD4 Offset: 0x2FE2FD4 VA: 0x2FE6FD4
	public static double Atan2(double y, double x) { }

	// RVA: 0x2FE6FD8 Offset: 0x2FE2FD8 VA: 0x2FE6FD8
	public static double Ceiling(double a) { }

	// RVA: 0x2FE6FE0 Offset: 0x2FE2FE0 VA: 0x2FE6FE0
	public static double Cos(double d) { }

	// RVA: 0x2FE6FE4 Offset: 0x2FE2FE4 VA: 0x2FE6FE4
	public static double Floor(double d) { }

	// RVA: 0x2FE6FEC Offset: 0x2FE2FEC VA: 0x2FE6FEC
	public static double Log(double d) { }

	// RVA: 0x2FE6FF0 Offset: 0x2FE2FF0 VA: 0x2FE6FF0
	public static double Log10(double d) { }

	// RVA: 0x2FE6FF4 Offset: 0x2FE2FF4 VA: 0x2FE6FF4
	public static double Pow(double x, double y) { }

	// RVA: 0x2FE6FF8 Offset: 0x2FE2FF8 VA: 0x2FE6FF8
	public static double Sin(double a) { }

	// RVA: 0x2FE6FFC Offset: 0x2FE2FFC VA: 0x2FE6FFC
	public static double Sqrt(double d) { }

	// RVA: 0x2FE7004 Offset: 0x2FE3004 VA: 0x2FE7004
	public static double Tan(double a) { }

	// RVA: 0x2FE6E54 Offset: 0x2FE2E54 VA: 0x2FE6E54
	private static double ModF(double x, double* intptr) { }

	// RVA: 0x2FE7008 Offset: 0x2FE3008 VA: 0x2FE7008
	private static void .cctor() { }
}
