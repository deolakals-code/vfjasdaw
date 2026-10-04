// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal static class EnumUtils // TypeDefIndex: 15921
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 2, 1 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0x308D754 Offset: 0x3089754 VA: 0x308D754
	private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key) { }

	// RVA: 0x308DF6C Offset: 0x3089F6C VA: 0x308DF6C
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name) { }

	// RVA: 0x308E10C Offset: 0x308A10C VA: 0x308E10C
	private static string InternalFlagsFormat(EnumInfo entry, ulong result) { }

	// RVA: 0x308E2A4 Offset: 0x308A2A4 VA: 0x308E2A4
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0x308DC40 Offset: 0x3089C40 VA: 0x308DC40
	private static ulong ToUInt64(object value) { }

	// RVA: 0x308E360 Offset: 0x308A360 VA: 0x308E360
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0x308EBDC Offset: 0x308ABDC VA: 0x308EBDC
	private static Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x308EAEC Offset: 0x308AAEC VA: 0x308EAEC
	private static Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x308ECC0 Offset: 0x308ACC0 VA: 0x308ECC0
	private static void .cctor() { }
}
