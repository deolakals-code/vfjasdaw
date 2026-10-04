// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Extension]
[NullableContext(1)]
[Nullable(0)]
internal static class StringUtils // TypeDefIndex: 15963
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x308A600 Offset: 0x3086600 VA: 0x308A600
	public static bool IsNullOrEmpty(string value) { }

	[Extension]
	// RVA: 0x30846D4 Offset: 0x30806D4 VA: 0x30846D4
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[Extension]
	// RVA: 0x3085934 Offset: 0x3081934 VA: 0x3085934
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[Extension]
	// RVA: 0x3099BA4 Offset: 0x3095BA4 VA: 0x3099BA4
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[NullableContext(2)]
	[Extension]
	// RVA: 0x3099CD0 Offset: 0x3095CD0 VA: 0x3099CD0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[Extension]
	// RVA: 0x3099B38 Offset: 0x3095B38 VA: 0x3099B38
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x3092CBC Offset: 0x308ECBC VA: 0x3092CBC
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x30929DC Offset: 0x308E9DC VA: 0x30929DC
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F3B34 Offset: 0x26EFB34 VA: 0x26F3B34
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	|
	|-RVA: 0x26F3CE4 Offset: 0x26EFCE4 VA: 0x26F3CE4
	|-StringUtils.ForgivingCaseSensitiveFind<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3099E3C Offset: 0x3095E3C VA: 0x3099E3C
	public static string ToCamelCase(string s) { }

	// RVA: 0x309A024 Offset: 0x3096024 VA: 0x309A024
	private static char ToLower(char c) { }

	// RVA: 0x309A0B4 Offset: 0x30960B4 VA: 0x309A0B4
	public static string ToSnakeCase(string s) { }

	// RVA: 0x309A3A4 Offset: 0x30963A4 VA: 0x309A3A4
	public static string ToKebabCase(string s) { }

	// RVA: 0x309A0BC Offset: 0x30960BC VA: 0x309A0BC
	private static string ToSeparatedCase(string s, char separator) { }

	// RVA: 0x309A3AC Offset: 0x30963AC VA: 0x309A3AC
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x309A404 Offset: 0x3096404 VA: 0x309A404
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x3093E98 Offset: 0x308FE98 VA: 0x3093E98
	public static int IndexOf(string s, char c) { }

	[Extension]
	// RVA: 0x309A45C Offset: 0x309645C VA: 0x309A45C
	public static bool StartsWith(string source, char value) { }

	[Extension]
	// RVA: 0x309A4A0 Offset: 0x30964A0 VA: 0x309A4A0
	public static bool EndsWith(string source, char value) { }

	[Extension]
	// RVA: 0x3098454 Offset: 0x3094454 VA: 0x3098454
	public static string Trim(string s, int start, int length) { }
}
