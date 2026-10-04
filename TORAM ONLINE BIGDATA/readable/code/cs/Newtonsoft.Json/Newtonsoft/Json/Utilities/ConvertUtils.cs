// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class ConvertUtils // TypeDefIndex: 15889
{
	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	[Nullable(new[] { 1, 0, 1, 1, 2, 2, 2 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x3083AE8 Offset: 0x307FAE8 VA: 0x3083AE8
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x3083B50 Offset: 0x307FB50 VA: 0x3083B50
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x3083EF0 Offset: 0x307FEF0 VA: 0x3083EF0
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x3083FDC Offset: 0x307FFDC VA: 0x3083FDC
	public static bool IsConvertible(Type t) { }

	// RVA: 0x3084070 Offset: 0x3080070 VA: 0x3084070
	public static TimeSpan ParseTimeSpan(string input) { }

	[NullableContext(2)]
	// RVA: 0x3084100 Offset: 0x3080100 VA: 0x3084100
	private static Func<object, object> CreateCastConverter(StructMultiKey<Type, Type> t) { }

	// RVA: 0x3084364 Offset: 0x3080364 VA: 0x3084364
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0x3084788 Offset: 0x3080788 VA: 0x3084788
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0x3084C9C Offset: 0x3080C9C VA: 0x3084C9C
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x3085A28 Offset: 0x3081A28 VA: 0x3085A28
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x3084EF8 Offset: 0x3080EF8 VA: 0x3084EF8
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x3085ED4 Offset: 0x3081ED4 VA: 0x3085ED4
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x3085C84 Offset: 0x3081C84 VA: 0x3085C84
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x3085BE0 Offset: 0x3081BE0 VA: 0x3085BE0
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x3085B50 Offset: 0x3081B50 VA: 0x3085B50
	public static bool IsInteger(object value) { }

	// RVA: 0x3086068 Offset: 0x3082068 VA: 0x3086068
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x30861E4 Offset: 0x30821E4 VA: 0x30861E4
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x3086354 Offset: 0x3082354 VA: 0x3086354
	public static ParseResult DecimalTryParse(char[] chars, int start, int length, out Decimal value) { }

	// RVA: 0x3086D28 Offset: 0x3082D28 VA: 0x3086D28
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x3086D84 Offset: 0x3082D84 VA: 0x3086D84
	public static bool TryHexTextToInt(char[] text, int start, int end, out int value) { }

	// RVA: 0x3086E54 Offset: 0x3082E54 VA: 0x3086E54
	private static void .cctor() { }
}
