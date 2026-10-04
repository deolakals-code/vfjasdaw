// Assembly: System.Core.dll
// Namespace: System.Dynamic.Utils
[Extension]
internal static class TypeUtils // TypeDefIndex: 15801
{
	// Fields
	private static readonly Type[] s_arrayAssignableInterfaces; // 0x0

	// Methods

	[Extension]
	// RVA: 0x318AD70 Offset: 0x3186D70 VA: 0x318AD70
	public static Type GetNonNullableType(Type type) { }

	[Extension]
	// RVA: 0x318AECC Offset: 0x3186ECC VA: 0x318AECC
	public static Type GetNullableType(Type type) { }

	[Extension]
	// RVA: 0x318AE00 Offset: 0x3186E00 VA: 0x318AE00
	public static bool IsNullableType(Type type) { }

	[Extension]
	// RVA: 0x318B01C Offset: 0x318701C VA: 0x318B01C
	public static bool IsNullableOrReferenceType(Type type) { }

	[Extension]
	// RVA: 0x318B098 Offset: 0x3187098 VA: 0x318B098
	public static bool IsBool(Type type) { }

	[Extension]
	// RVA: 0x318B14C Offset: 0x318714C VA: 0x318B14C
	public static bool IsNumeric(Type type) { }

	[Extension]
	// RVA: 0x318B208 Offset: 0x3187208 VA: 0x318B208
	public static bool IsInteger(Type type) { }

	[Extension]
	// RVA: 0x318B2C4 Offset: 0x31872C4 VA: 0x318B2C4
	public static bool IsArithmetic(Type type) { }

	[Extension]
	// RVA: 0x318B380 Offset: 0x3187380 VA: 0x318B380
	public static bool IsUnsignedInt(Type type) { }

	[Extension]
	// RVA: 0x318B440 Offset: 0x3187440 VA: 0x318B440
	public static bool IsIntegerOrBool(Type type) { }

	[Extension]
	// RVA: 0x318B504 Offset: 0x3187504 VA: 0x318B504
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x318B584 Offset: 0x3187584 VA: 0x318B584
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[Extension]
	// RVA: 0x318BA9C Offset: 0x3187A9C VA: 0x318BA9C
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x318BD80 Offset: 0x3187D80 VA: 0x318BD80
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x318C270 Offset: 0x3188270 VA: 0x318C270
	private static bool StrictHasReferenceConversionTo(Type source, Type dest, bool skipNonArray) { }

	// RVA: 0x318C570 Offset: 0x3188570 VA: 0x318C570
	private static bool HasArrayToInterfaceConversion(Type source, Type dest) { }

	// RVA: 0x318C730 Offset: 0x3188730 VA: 0x318C730
	private static bool HasInterfaceToArrayConversion(Type source, Type dest) { }

	// RVA: 0x318C920 Offset: 0x3188920 VA: 0x318C920
	private static bool IsCovariant(Type t) { }

	// RVA: 0x318C948 Offset: 0x3188948 VA: 0x318C948
	private static bool IsContravariant(Type t) { }

	// RVA: 0x318C970 Offset: 0x3188970 VA: 0x318C970
	private static bool IsInvariant(Type t) { }

	// RVA: 0x318C99C Offset: 0x318899C VA: 0x318C99C
	private static bool IsDelegate(Type t) { }

	// RVA: 0x318BF68 Offset: 0x3187F68 VA: 0x318BF68
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[Extension]
	// RVA: 0x318BCC8 Offset: 0x3187CC8 VA: 0x318BCC8
	public static bool IsConvertible(Type type) { }

	// RVA: 0x318CA34 Offset: 0x3188A34 VA: 0x318CA34
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x318CB14 Offset: 0x3188B14 VA: 0x318CB14
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[Extension]
	// RVA: 0x318CCF8 Offset: 0x3188CF8 VA: 0x318CCF8
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x318D158 Offset: 0x3189158 VA: 0x318D158
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x318D370 Offset: 0x3189370 VA: 0x318D370
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x318CE04 Offset: 0x3188E04 VA: 0x318CE04
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x318C8F4 Offset: 0x31888F4 VA: 0x318C8F4
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x318CF40 Offset: 0x3188F40 VA: 0x318CF40
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x318D0B0 Offset: 0x31890B0 VA: 0x318D0B0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x318D53C Offset: 0x318953C VA: 0x318D53C
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x318D9DC Offset: 0x31899DC VA: 0x318D9DC
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[Extension]
	// RVA: 0x318DB5C Offset: 0x3189B5C VA: 0x318DB5C
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x3188260 Offset: 0x3184260 VA: 0x3188260
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x3189E48 Offset: 0x3185E48 VA: 0x3189E48
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x318A048 Offset: 0x3186048 VA: 0x318A048
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x318DB9C Offset: 0x3189B9C VA: 0x318DB9C
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x3189D5C Offset: 0x3185D5C VA: 0x3189D5C
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x318DC08 Offset: 0x3189C08 VA: 0x318DC08
	public static bool ValidateType(Type type, string paramName, int index) { }

	[Extension]
	// RVA: 0x318DD34 Offset: 0x3189D34 VA: 0x318DD34
	public static MethodInfo GetInvokeMethod(Type delegateType) { }

	// RVA: 0x318DD8C Offset: 0x3189D8C VA: 0x318DD8C
	private static void .cctor() { }
}
