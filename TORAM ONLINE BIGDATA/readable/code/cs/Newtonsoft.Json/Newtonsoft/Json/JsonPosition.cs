// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
internal struct JsonPosition // TypeDefIndex: 15849
{
	// Fields
	private static readonly char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x0
	internal int Position; // 0x4
	[Nullable(2)]
	internal string PropertyName; // 0x8
	internal bool HasIndex; // 0x10

	// Methods

	// RVA: 0x306DB4C Offset: 0x3069B4C VA: 0x306DB4C
	public void .ctor(JsonContainerType type) { }

	// RVA: 0x306DBE0 Offset: 0x3069BE0 VA: 0x306DBE0
	internal int CalculateLength() { }

	[NullableContext(2)]
	// RVA: 0x306DC74 Offset: 0x3069C74 VA: 0x306DC74
	internal void WriteTo(StringBuilder sb, ref StringWriter writer, ref char[] buffer) { }

	// RVA: 0x306DBD0 Offset: 0x3069BD0 VA: 0x306DBD0
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0x306DE90 Offset: 0x3069E90 VA: 0x306DE90
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0x306E198 Offset: 0x306A198 VA: 0x306E198
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0x306E4C4 Offset: 0x306A4C4 VA: 0x306E4C4
	private static void .cctor() { }
}
