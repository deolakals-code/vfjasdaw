// Assembly: mscorlib.dll
// Namespace: System
internal static class ParameterizedStrings // TypeDefIndex: 9816
{
	// Fields
	[ThreadStatic]
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x3039DB8 Offset: 0x3035DB8 VA: 0x3039DB8
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x303C268 Offset: 0x3038268 VA: 0x303C268
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x303D12C Offset: 0x303912C VA: 0x303D12C
	private static bool AsBool(int i) { }

	// RVA: 0x303D124 Offset: 0x3039124 VA: 0x303D124
	private static int AsInt(bool b) { }

	// RVA: 0x303D138 Offset: 0x3039138 VA: 0x303D138
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x303D230 Offset: 0x3039230 VA: 0x303D230
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x303D2FC Offset: 0x30392FC VA: 0x303D2FC
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x303CCE8 Offset: 0x3038CE8 VA: 0x303CCE8
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x303CFFC Offset: 0x3038FFC VA: 0x303CFFC
	private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index) { }
}
