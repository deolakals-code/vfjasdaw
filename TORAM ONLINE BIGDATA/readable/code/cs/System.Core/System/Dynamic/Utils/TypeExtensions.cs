// Assembly: System.Core.dll
// Namespace: System.Dynamic.Utils
[Extension]
internal static class TypeExtensions // TypeDefIndex: 15799
{
	// Fields
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; // 0x0

	// Methods

	[Extension]
	// RVA: 0x318A9EC Offset: 0x31869EC VA: 0x318A9EC
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[Extension]
	// RVA: 0x318AA90 Offset: 0x3186A90 VA: 0x318AA90
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

	[Extension]
	// RVA: 0x318ABD8 Offset: 0x3186BD8 VA: 0x318ABD8
	public static Type GetReturnType(MethodBase mi) { }

	[Extension]
	// RVA: 0x318AC7C Offset: 0x3186C7C VA: 0x318AC7C
	public static TypeCode GetTypeCode(Type type) { }

	[Extension]
	// RVA: 0x318A0E4 Offset: 0x31860E4 VA: 0x318A0E4
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	// RVA: 0x318ACD4 Offset: 0x3186CD4 VA: 0x318ACD4
	private static void .cctor() { }
}
