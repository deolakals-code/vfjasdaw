// Assembly: System.Core.dll
// Namespace: System.Dynamic.Utils
[Extension]
internal static class ExpressionUtils // TypeDefIndex: 15797
{
	// Methods

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C0824 Offset: 0x26BC824 VA: 0x26C0824
	|-ExpressionUtils.ReturnReadOnly<object>
	|
	|-RVA: 0x26C090C Offset: 0x26BC90C VA: 0x26C090C
	|-ExpressionUtils.ReturnReadOnly<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ReturnObject<T>(object collectionOrT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C06D4 Offset: 0x26BC6D4 VA: 0x26C06D4
	|-ExpressionUtils.ReturnObject<object>
	*/

	// RVA: 0x3189550 Offset: 0x3185550 VA: 0x3189550
	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x31898E8 Offset: 0x31858E8 VA: 0x31898E8
	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x3189994 Offset: 0x3185994 VA: 0x3189994
	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

	// RVA: 0x318A040 Offset: 0x3186040 VA: 0x318A040
	public static void RequiresCanRead(Expression expression, string paramName) { }

	// RVA: 0x3189BA4 Offset: 0x3185BA4 VA: 0x3189BA4
	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	// RVA: 0x3189F10 Offset: 0x3185F10 VA: 0x3189F10
	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x3189854 Offset: 0x3185854 VA: 0x3189854
	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: -1 Offset: -1
	internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C09F8 Offset: 0x26BC9F8 VA: 0x26C09F8
	|-ExpressionUtils.SameElements<object>
	*/

	// RVA: -1 Offset: -1
	private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C0B38 Offset: 0x26BCB38 VA: 0x26C0B38
	|-ExpressionUtils.SameElementsInCollection<object>
	*/

	[Extension]
	// RVA: 0x318A1F0 Offset: 0x31861F0 VA: 0x318A1F0
	public static void ValidateArgumentCount(LambdaExpression lambda) { }
}
