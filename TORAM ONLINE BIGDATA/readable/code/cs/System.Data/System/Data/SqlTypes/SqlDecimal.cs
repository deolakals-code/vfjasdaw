// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14807
{
	// Fields
	internal byte _bStatus; // 0x0
	internal byte _bLen; // 0x1
	internal byte _bPrec; // 0x2
	internal byte _bScale; // 0x3
	internal uint _data1; // 0x4
	internal uint _data2; // 0x8
	internal uint _data3; // 0xC
	internal uint _data4; // 0x10
	private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly byte MaxPrecision; // 0x1
	public static readonly byte MaxScale; // 0x2
	private static readonly byte s_bNullMask; // 0x3
	private static readonly byte s_bIsNull; // 0x4
	private static readonly byte s_bNotNull; // 0x5
	private static readonly byte s_bReverseNullMask; // 0x6
	private static readonly byte s_bSignMask; // 0x7
	private static readonly byte s_bPositive; // 0x8
	private static readonly byte s_bNegative; // 0x9
	private static readonly byte s_bReverseSignMask; // 0xA
	private static readonly uint s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly long s_lInt32Base; // 0x18
	private static readonly ulong s_ulInt32Base; // 0x20
	private static readonly ulong s_ulInt32BaseForMod; // 0x28
	internal static readonly ulong s_llMax; // 0x30
	private static readonly uint s_ulBase10; // 0x38
	private static readonly double s_DUINT_BASE; // 0x40
	private static readonly double s_DUINT_BASE2; // 0x48
	private static readonly double s_DUINT_BASE3; // 0x50
	private static readonly double s_DMAX_NUME; // 0x58
	private static readonly uint s_DBL_DIG; // 0x60
	private static readonly byte s_cNumeDivScaleMin; // 0x64
	private static readonly uint[] s_rgulShiftBase; // 0x68
	private static readonly uint[] s_decimalHelpersLo; // 0x70
	private static readonly uint[] s_decimalHelpersMid; // 0x78
	private static readonly uint[] s_decimalHelpersHi; // 0x80
	private static readonly uint[] s_decimalHelpersHiHi; // 0x88
	private static readonly byte[] s_rgCLenFromPrec; // 0x90
	private static readonly uint s_ulT1; // 0x98
	private static readonly uint s_ulT2; // 0x9C
	private static readonly uint s_ulT3; // 0xA0
	private static readonly uint s_ulT4; // 0xA4
	private static readonly uint s_ulT5; // 0xA8
	private static readonly uint s_ulT6; // 0xAC
	private static readonly uint s_ulT7; // 0xB0
	private static readonly uint s_ulT8; // 0xB4
	private static readonly uint s_ulT9; // 0xB8
	private static readonly ulong s_dwlT10; // 0xC0
	private static readonly ulong s_dwlT11; // 0xC8
	private static readonly ulong s_dwlT12; // 0xD0
	private static readonly ulong s_dwlT13; // 0xD8
	private static readonly ulong s_dwlT14; // 0xE0
	private static readonly ulong s_dwlT15; // 0xE8
	private static readonly ulong s_dwlT16; // 0xF0
	private static readonly ulong s_dwlT17; // 0xF8
	private static readonly ulong s_dwlT18; // 0x100
	private static readonly ulong s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }

	// Methods

	// RVA: 0x324DAB8 Offset: 0x3249AB8 VA: 0x324DAB8
	private byte CalculatePrecision() { }

	// RVA: 0x324DCDC Offset: 0x3249CDC VA: 0x324DCDC
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x324DEF8 Offset: 0x3249EF8 VA: 0x324DEF8
	private void .ctor(bool fNull) { }

	// RVA: 0x324DF60 Offset: 0x3249F60 VA: 0x324DF60
	public void .ctor(Decimal value) { }

	// RVA: 0x324E0C4 Offset: 0x324A0C4 VA: 0x324E0C4
	public void .ctor(int value) { }

	// RVA: 0x324E2D0 Offset: 0x324A2D0 VA: 0x324E2D0
	public void .ctor(long value) { }

	// RVA: 0x324E5E0 Offset: 0x324A5E0 VA: 0x324E5E0
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x324E8A4 Offset: 0x324A8A4 VA: 0x324E8A4 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x324E914 Offset: 0x324A914 VA: 0x324E914
	public Decimal get_Value() { }

	// RVA: 0x324EAC8 Offset: 0x324AAC8 VA: 0x324EAC8
	public bool get_IsPositive() { }

	// RVA: 0x324E83C Offset: 0x324A83C VA: 0x324E83C
	private void SetPositive() { }

	// RVA: 0x324EB88 Offset: 0x324AB88 VA: 0x324EB88
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x324EC0C Offset: 0x324AC0C VA: 0x324EC0C
	public byte get_Scale() { }

	// RVA: 0x324ECA0 Offset: 0x324ACA0 VA: 0x324ECA0
	public int[] get_Data() { }

	// RVA: 0x324ED9C Offset: 0x324AD9C VA: 0x324ED9C Slot: 3
	public override string ToString() { }

	// RVA: 0x324F19C Offset: 0x324B19C VA: 0x324F19C
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x324FA44 Offset: 0x324BA44 VA: 0x324FA44
	public double ToDouble() { }

	// RVA: 0x324E968 Offset: 0x324A968 VA: 0x324E968
	private Decimal ToDecimal() { }

	// RVA: 0x324FB90 Offset: 0x324BB90 VA: 0x324FB90
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0x324FBA8 Offset: 0x324BBA8 VA: 0x324FBA8
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0x324FC10 Offset: 0x324BC10 VA: 0x324FC10
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0x324FD28 Offset: 0x324BD28 VA: 0x324FD28
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x3250800 Offset: 0x324C800 VA: 0x3250800
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x32508E0 Offset: 0x324C8E0 VA: 0x32508E0
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x325121C Offset: 0x324D21C VA: 0x325121C
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x3251F04 Offset: 0x324DF04 VA: 0x3251F04
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0x3251FE0 Offset: 0x324DFE0 VA: 0x3251FE0
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0x3252118 Offset: 0x324E118 VA: 0x3252118
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0x3252294 Offset: 0x324E294 VA: 0x3252294
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0x325237C Offset: 0x324E37C VA: 0x325237C
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0x3251E88 Offset: 0x324DE88 VA: 0x3251E88
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x324E81C Offset: 0x324A81C VA: 0x324E81C
	private bool FZero() { }

	// RVA: 0x3250798 Offset: 0x324C798 VA: 0x3250798
	private bool FGt10_38() { }

	// RVA: 0x3252588 Offset: 0x324E588 VA: 0x3252588
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0x324E198 Offset: 0x324A198 VA: 0x324E198
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0x324E39C Offset: 0x324A39C VA: 0x324E39C
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x324F894 Offset: 0x324B894 VA: 0x324F894
	private void AddULong(uint ulAdd) { }

	// RVA: 0x324F68C Offset: 0x324B68C VA: 0x324F68C
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x3252658 Offset: 0x324E658 VA: 0x3252658
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x3250320 Offset: 0x324C320 VA: 0x3250320
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x3250640 Offset: 0x324C640 VA: 0x3250640
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0x32527FC Offset: 0x324E7FC VA: 0x32527FC
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0x3252860 Offset: 0x324E860 VA: 0x3252860
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0x325288C Offset: 0x324E88C VA: 0x325288C
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x32528E4 Offset: 0x324E8E4 VA: 0x32528E4
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0x324F0BC Offset: 0x324B0BC VA: 0x324F0BC
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x32529E4 Offset: 0x324E9E4 VA: 0x32529E4
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0x32529D8 Offset: 0x324E9D8 VA: 0x32529D8
	private static uint HI(ulong x) { }

	// RVA: 0x32529E0 Offset: 0x324E9E0 VA: 0x32529E0
	private static uint LO(ulong x) { }

	// RVA: 0x325164C Offset: 0x324D64C VA: 0x325164C
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x32529F0 Offset: 0x324E9F0 VA: 0x32529F0
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0x324E740 Offset: 0x324A740 VA: 0x324E740
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0x3252C5C Offset: 0x324EC5C VA: 0x3252C5C
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x3252D68 Offset: 0x324ED68 VA: 0x3252D68
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x3252E74 Offset: 0x324EE74 VA: 0x3252E74
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x3252F80 Offset: 0x324EF80 VA: 0x3252F80
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x3253034 Offset: 0x324F034 VA: 0x3253034
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x32530E8 Offset: 0x324F0E8 VA: 0x32530E8
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x325322C Offset: 0x324F22C VA: 0x325322C
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x3253470 Offset: 0x324F470 VA: 0x3253470
	public SqlMoney ToSqlMoney() { }

	// RVA: 0x324F194 Offset: 0x324B194 VA: 0x324F194
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x3252600 Offset: 0x324E600 VA: 0x3252600
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x324F614 Offset: 0x324B614 VA: 0x324F614
	private void SetToZero() { }

	// RVA: 0x32535C4 Offset: 0x324F5C4 VA: 0x32535C4 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x32536EC Offset: 0x324F6EC VA: 0x32536EC
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x32538B0 Offset: 0x324F8B0 VA: 0x32538B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3253A34 Offset: 0x324FA34 VA: 0x3253A34 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3253B3C Offset: 0x324FB3C VA: 0x3253B3C Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x3253B44 Offset: 0x324FB44 VA: 0x3253B44 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x3253CA8 Offset: 0x324FCA8 VA: 0x3253CA8 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x3253DC0 Offset: 0x324FDC0 VA: 0x3253DC0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x3253E4C Offset: 0x324FE4C VA: 0x3253E4C
	private static void .cctor() { }
}
