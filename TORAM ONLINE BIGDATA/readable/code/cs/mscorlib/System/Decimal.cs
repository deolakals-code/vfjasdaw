// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Decimal : IFormattable, IComparable, IConvertible, IComparable<Decimal>, IEquatable<Decimal>, IDeserializationCallback, ISpanFormattable // TypeDefIndex: 9851
{
	// Fields
	[DecimalConstant(0, 0, 0, 0, 0)]
	public static readonly Decimal Zero; // 0x0
	[DecimalConstant(0, 0, 0, 0, 1)]
	public static readonly Decimal One; // 0x10
	[DecimalConstant(0, 128, 0, 0, 1)]
	public static readonly Decimal MinusOne; // 0x20
	[DecimalConstant(0, 0, 4294967295, 4294967295, 4294967295)]
	public static readonly Decimal MaxValue; // 0x30
	[DecimalConstant(0, 128, 4294967295, 4294967295, 4294967295)]
	public static readonly Decimal MinValue; // 0x40
	private readonly int flags; // 0x0
	private readonly int hi; // 0x4
	private readonly int lo; // 0x8
	private readonly int mid; // 0xC
	private readonly ulong ulomidLE; // 0x8

	// Properties
	internal uint High { get; }
	internal uint Low { get; }
	internal uint Mid { get; }
	internal bool IsNegative { get; }
	internal int Scale { get; }
	private ulong Low64 { get; }

	// Methods

	// RVA: 0x303FF80 Offset: 0x303BF80 VA: 0x303FF80
	internal uint get_High() { }

	// RVA: 0x303FF88 Offset: 0x303BF88 VA: 0x303FF88
	internal uint get_Low() { }

	// RVA: 0x303FF90 Offset: 0x303BF90 VA: 0x303FF90
	internal uint get_Mid() { }

	// RVA: 0x303FF98 Offset: 0x303BF98 VA: 0x303FF98
	internal bool get_IsNegative() { }

	// RVA: 0x303FFA4 Offset: 0x303BFA4 VA: 0x303FFA4
	internal int get_Scale() { }

	// RVA: 0x303FFAC Offset: 0x303BFAC VA: 0x303FFAC
	private ulong get_Low64() { }

	// RVA: 0x303FFE8 Offset: 0x303BFE8 VA: 0x303FFE8
	private static ref Decimal.DecCalc AsMutable(ref Decimal d) { }

	// RVA: 0x303FFEC Offset: 0x303BFEC VA: 0x303FFEC
	internal static uint DecDivMod1E9(ref Decimal value) { }

	// RVA: 0x3040120 Offset: 0x303C120 VA: 0x3040120
	public void .ctor(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x3040144 Offset: 0x303C144 VA: 0x3040144
	public void .ctor(uint value) { }

	// RVA: 0x3040150 Offset: 0x303C150 VA: 0x3040150
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x3040174 Offset: 0x303C174 VA: 0x3040174
	public void .ctor(ulong value) { }

	// RVA: 0x304017C Offset: 0x303C17C VA: 0x304017C
	public void .ctor(float value) { }

	// RVA: 0x3040620 Offset: 0x303C620 VA: 0x3040620
	public void .ctor(double value) { }

	// RVA: 0x3040AC4 Offset: 0x303CAC4 VA: 0x3040AC4
	private static bool IsValid(int flags) { }

	// RVA: 0x3040AE4 Offset: 0x303CAE4 VA: 0x3040AE4
	public void .ctor(int[] bits) { }

	// RVA: 0x3040C1C Offset: 0x303CC1C VA: 0x3040C1C
	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	// RVA: 0x3040CB4 Offset: 0x303CCB4 VA: 0x3040CB4 Slot: 25
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x3040D68 Offset: 0x303CD68 VA: 0x3040D68
	private void .ctor(in Decimal d, int flags) { }

	// RVA: 0x3040D78 Offset: 0x303CD78 VA: 0x3040D78
	internal static Decimal Abs(ref Decimal d) { }

	// RVA: 0x3040D8C Offset: 0x303CD8C VA: 0x3040D8C
	public static Decimal Add(Decimal d1, Decimal d2) { }

	// RVA: 0x30414A8 Offset: 0x303D4A8 VA: 0x30414A8
	public static int Compare(Decimal d1, Decimal d2) { }

	// RVA: 0x3041640 Offset: 0x303D640 VA: 0x3041640 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x3041758 Offset: 0x303D758 VA: 0x3041758 Slot: 23
	public int CompareTo(Decimal value) { }

	// RVA: 0x30417E8 Offset: 0x303D7E8 VA: 0x30417E8
	public static Decimal Divide(Decimal d1, Decimal d2) { }

	// RVA: 0x30420A0 Offset: 0x303E0A0 VA: 0x30420A0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3042178 Offset: 0x303E178 VA: 0x3042178 Slot: 24
	public bool Equals(Decimal value) { }

	// RVA: 0x3042210 Offset: 0x303E210 VA: 0x3042210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x30423B0 Offset: 0x303E3B0 VA: 0x30423B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x304245C Offset: 0x303E45C VA: 0x304245C Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x3042518 Offset: 0x303E518 VA: 0x3042518 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x30425F0 Offset: 0x303E5F0 VA: 0x30425F0 Slot: 26
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x30426BC Offset: 0x303E6BC VA: 0x30426BC
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x3042790 Offset: 0x303E790 VA: 0x3042790
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x3042874 Offset: 0x303E874 VA: 0x3042874
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x304296C Offset: 0x303E96C VA: 0x304296C
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x3042A08 Offset: 0x303EA08 VA: 0x3042A08
	internal static ref Decimal Max(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x3042A78 Offset: 0x303EA78 VA: 0x3042A78
	internal static ref Decimal Min(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x3042AE8 Offset: 0x303EAE8 VA: 0x3042AE8
	public static Decimal Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x3042FEC Offset: 0x303EFEC VA: 0x3042FEC
	public static Decimal Negate(Decimal d) { }

	// RVA: 0x3042FF4 Offset: 0x303EFF4 VA: 0x3042FF4
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x3043088 Offset: 0x303F088 VA: 0x3043088
	private static Decimal Round(ref Decimal d, int decimals, MidpointRounding mode) { }

	// RVA: 0x304350C Offset: 0x303F50C VA: 0x304350C
	public static byte ToByte(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x30437FC Offset: 0x303F7FC VA: 0x30437FC
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x3043AFC Offset: 0x303FAFC VA: 0x3043AFC
	public static short ToInt16(Decimal value) { }

	// RVA: 0x3043C74 Offset: 0x303FC74 VA: 0x3043C74
	public static double ToDouble(Decimal d) { }

	// RVA: 0x3043974 Offset: 0x303F974 VA: 0x3043974
	public static int ToInt32(Decimal d) { }

	// RVA: 0x3043DF4 Offset: 0x303FDF4 VA: 0x3043DF4
	public static long ToInt64(Decimal d) { }

	[CLSCompliant(False)]
	// RVA: 0x3043F8C Offset: 0x303FF8C VA: 0x3043F8C
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x3043684 Offset: 0x303F684 VA: 0x3043684
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliant(False)]
	// RVA: 0x3044104 Offset: 0x3040104 VA: 0x3044104
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x3044290 Offset: 0x3040290 VA: 0x3044290
	public static float ToSingle(Decimal d) { }

	// RVA: 0x304436C Offset: 0x304036C VA: 0x304436C
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x304446C Offset: 0x304046C VA: 0x304446C
	private static void Truncate(ref Decimal d) { }

	// RVA: 0x3044504 Offset: 0x3040504 VA: 0x3044504
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x3044510 Offset: 0x3040510 VA: 0x3044510
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x3044528 Offset: 0x3040528 VA: 0x3044528
	public static Decimal op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x3044540 Offset: 0x3040540 VA: 0x3044540
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x304454C Offset: 0x304054C VA: 0x304454C
	public static Decimal op_Implicit(char value) { }

	// RVA: 0x3044558 Offset: 0x3040558 VA: 0x3044558
	public static Decimal op_Implicit(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x304456C Offset: 0x304056C VA: 0x304456C
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x3044578 Offset: 0x3040578 VA: 0x3044578
	public static Decimal op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x3044590 Offset: 0x3040590 VA: 0x3044590
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x304459C Offset: 0x304059C VA: 0x304459C
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x30445E0 Offset: 0x30405E0 VA: 0x30445E0
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x3044624 Offset: 0x3040624 VA: 0x3044624
	public static int op_Explicit(Decimal value) { }

	// RVA: 0x3044688 Offset: 0x3040688 VA: 0x3044688
	public static long op_Explicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x30446EC Offset: 0x30406EC VA: 0x30446EC
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x3044750 Offset: 0x3040750 VA: 0x3044750
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x30447B4 Offset: 0x30407B4 VA: 0x30447B4
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x3044818 Offset: 0x3040818 VA: 0x3044818
	public static Decimal op_UnaryNegation(Decimal d) { }

	// RVA: 0x3044820 Offset: 0x3040820 VA: 0x3044820
	public static Decimal op_Increment(Decimal d) { }

	// RVA: 0x3044890 Offset: 0x3040890 VA: 0x3044890
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x3044944 Offset: 0x3040944 VA: 0x3044944
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x30449F8 Offset: 0x30409F8 VA: 0x30449F8
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x3044AA8 Offset: 0x3040AA8 VA: 0x3044AA8
	public static Decimal op_Division(Decimal d1, Decimal d2) { }

	// RVA: 0x3044B58 Offset: 0x3040B58 VA: 0x3044B58
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x3044BE8 Offset: 0x3040BE8 VA: 0x3044BE8
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x3044C78 Offset: 0x3040C78 VA: 0x3044C78
	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	// RVA: 0x3044D04 Offset: 0x3040D04 VA: 0x3044D04
	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x3044D94 Offset: 0x3040D94 VA: 0x3044D94
	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	// RVA: 0x3044E24 Offset: 0x3040E24 VA: 0x3044E24
	public static bool op_GreaterThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x3044EB4 Offset: 0x3040EB4 VA: 0x3044EB4 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x3044EBC Offset: 0x3040EBC VA: 0x3044EBC Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x3044F1C Offset: 0x3040F1C VA: 0x3044F1C Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x3044FA0 Offset: 0x3040FA0 VA: 0x3044FA0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x3045000 Offset: 0x3041000 VA: 0x3045000 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3045060 Offset: 0x3041060 VA: 0x3045060 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x30450C0 Offset: 0x30410C0 VA: 0x30450C0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3045120 Offset: 0x3041120 VA: 0x3045120 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3045180 Offset: 0x3041180 VA: 0x3045180 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x30451E0 Offset: 0x30411E0 VA: 0x30451E0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3045240 Offset: 0x3041240 VA: 0x3045240 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x30452A0 Offset: 0x30412A0 VA: 0x30452A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3045300 Offset: 0x3041300 VA: 0x3045300 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3045360 Offset: 0x3041360 VA: 0x3045360 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x304536C Offset: 0x304136C VA: 0x304536C Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x30453F0 Offset: 0x30413F0 VA: 0x30453F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x30454C4 Offset: 0x30414C4 VA: 0x30454C4
	private static void .cctor() { }
}
