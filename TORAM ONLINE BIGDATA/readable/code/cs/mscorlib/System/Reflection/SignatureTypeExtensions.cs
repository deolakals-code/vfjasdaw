// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Extension]
internal static class SignatureTypeExtensions // TypeDefIndex: 10623
{
	// Methods

	[Extension]
	// RVA: 0x2F2F10C Offset: 0x2F2B10C VA: 0x2F2F10C
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[Extension]
	// RVA: 0x2F2F1C0 Offset: 0x2F2B1C0 VA: 0x2F2F1C0
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[Extension]
	// RVA: 0x2F2F568 Offset: 0x2F2B568 VA: 0x2F2F568
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

	[Extension]
	// RVA: 0x2F2F5A0 Offset: 0x2F2B5A0 VA: 0x2F2F5A0
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[Extension]
	// RVA: 0x2F2F994 Offset: 0x2F2B994 VA: 0x2F2F994
	private static Type TryMakeArrayType(Type type) { }

	[Extension]
	// RVA: 0x2F2FA30 Offset: 0x2F2BA30 VA: 0x2F2FA30
	private static Type TryMakeArrayType(Type type, int rank) { }

	[Extension]
	// RVA: 0x2F2FACC Offset: 0x2F2BACC VA: 0x2F2FACC
	private static Type TryMakeByRefType(Type type) { }

	[Extension]
	// RVA: 0x2F2FB68 Offset: 0x2F2BB68 VA: 0x2F2FB68
	private static Type TryMakePointerType(Type type) { }

	[Extension]
	// RVA: 0x2F2FC04 Offset: 0x2F2BC04 VA: 0x2F2FC04
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }
}
