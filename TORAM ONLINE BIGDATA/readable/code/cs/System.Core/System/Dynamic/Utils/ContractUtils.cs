// Assembly: System.Core.dll
// Namespace: System.Dynamic.Utils
internal static class ContractUtils // TypeDefIndex: 15795
{
	// Properties
	[ExcludeFromCodeCoverage]
	public static Exception Unreachable { get; }

	// Methods

	// RVA: 0x31893F8 Offset: 0x31853F8 VA: 0x31893F8
	public static Exception get_Unreachable() { }

	// RVA: 0x3188E4C Offset: 0x3184E4C VA: 0x3188E4C
	public static void Requires(bool precondition, string paramName) { }

	// RVA: 0x3186A24 Offset: 0x3182A24 VA: 0x3186A24
	public static void RequiresNotNull(object value, string paramName) { }

	// RVA: 0x3189464 Offset: 0x3185464 VA: 0x3189464
	public static void RequiresNotNull(object value, string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresNotNullItems<T>(IList<T> array, string arrayName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E32E0 Offset: 0x27DF2E0 VA: 0x27E32E0
	|-ContractUtils.RequiresNotNullItems<object>
	|
	|-RVA: 0x27E3474 Offset: 0x27DF474 VA: 0x27E3474
	|-ContractUtils.RequiresNotNullItems<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x31894BC Offset: 0x31854BC VA: 0x31894BC
	private static string GetParamName(string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E2F5C Offset: 0x27DEF5C VA: 0x27E2F5C
	|-ContractUtils.RequiresArrayRange<KeyValuePair<object, object>>
	|
	|-RVA: 0x27E3088 Offset: 0x27DF088 VA: 0x27E3088
	|-ContractUtils.RequiresArrayRange<object>
	|
	|-RVA: 0x27E31B4 Offset: 0x27DF1B4 VA: 0x27E31B4
	|-ContractUtils.RequiresArrayRange<__Il2CppFullySharedGenericType>
	*/
}
