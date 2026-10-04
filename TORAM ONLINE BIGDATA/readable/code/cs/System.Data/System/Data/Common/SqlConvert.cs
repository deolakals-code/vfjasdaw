// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal static class SqlConvert // TypeDefIndex: 14842
{
	// Methods

	// RVA: 0x3277C88 Offset: 0x3273C88 VA: 0x3277C88
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0x3277E64 Offset: 0x3273E64 VA: 0x3277E64
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0x3278110 Offset: 0x3274110 VA: 0x3278110
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0x32784DC Offset: 0x32744DC VA: 0x32784DC
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0x32789CC Offset: 0x32749CC VA: 0x32789CC
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0x3279114 Offset: 0x3275114 VA: 0x3279114
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0x32797B4 Offset: 0x32757B4 VA: 0x32797B4
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0x3279E74 Offset: 0x3275E74 VA: 0x3279E74
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0x327A488 Offset: 0x3276488 VA: 0x327A488
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0x327A670 Offset: 0x3276670 VA: 0x327A670
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0x327A838 Offset: 0x3276838 VA: 0x327A838
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0x327AA14 Offset: 0x3276A14 VA: 0x327AA14
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0x327ABE4 Offset: 0x3276BE4 VA: 0x327ABE4
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0x327ADC0 Offset: 0x3276DC0 VA: 0x327ADC0
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0x327AF08 Offset: 0x3276F08 VA: 0x327AF08
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0x327B050 Offset: 0x3277050 VA: 0x327B050
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0x327B0B8 Offset: 0x32770B8 VA: 0x327B0B8
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x327B294 Offset: 0x3277294 VA: 0x327B294
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x326394C Offset: 0x325F94C VA: 0x326394C
	public static object ChangeTypeForXML(object value, Type type) { }
}
