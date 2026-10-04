// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
public static class JsonConvert // TypeDefIndex: 15838
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38

	// Properties
	[Nullable(new[] { 2, 1 })]
	public static Func<JsonSerializerSettings> DefaultSettings { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x306CF84 Offset: 0x3068F84 VA: 0x306CF84
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	// RVA: 0x306CFDC Offset: 0x3068FDC VA: 0x306CFDC
	public static string ToString(bool value) { }

	// RVA: 0x306D048 Offset: 0x3069048 VA: 0x306D048
	public static string ToString(char value) { }

	// RVA: 0x306D12C Offset: 0x306912C VA: 0x306D12C
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x306D2E0 Offset: 0x30692E0 VA: 0x306D2E0
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x306D404 Offset: 0x3069404 VA: 0x306D404
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x306D21C Offset: 0x306921C VA: 0x306D21C
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0x306D4F0 Offset: 0x30694F0 VA: 0x306D4F0
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0x306D564 Offset: 0x3069564 VA: 0x306D564
	public static string ToString(Decimal value) { }

	// RVA: 0x306D0D4 Offset: 0x30690D4 VA: 0x306D0D4
	public static string ToString(string value) { }

	// RVA: 0x306D658 Offset: 0x3069658 VA: 0x306D658
	public static string ToString(string value, char delimiter) { }

	// RVA: 0x306D6C0 Offset: 0x30696C0 VA: 0x306D6C0
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x306D7A4 Offset: 0x30697A4 VA: 0x306D7A4
	private static void .cctor() { }
}
