// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class CollectionUtils // TypeDefIndex: 15881
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E0F7C Offset: 0x27DCF7C VA: 0x27E0F7C
	|-CollectionUtils.IsNullOrEmpty<object>
	|
	|-RVA: 0x27E1030 Offset: 0x27DD030 VA: 0x27E1030
	|-CollectionUtils.IsNullOrEmpty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DF6D0 Offset: 0x27DB6D0 VA: 0x27DF6D0
	|-CollectionUtils.AddRange<object>
	|
	|-RVA: 0x27DFA64 Offset: 0x27DBA64 VA: 0x27DFA64
	|-CollectionUtils.AddRange<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3082BBC Offset: 0x307EBBC VA: 0x3082BBC
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x3082DC4 Offset: 0x307EDC4 VA: 0x3082DC4
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x3082EE0 Offset: 0x307EEE0 VA: 0x3082EE0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E065C Offset: 0x27DC65C VA: 0x27E065C
	|-CollectionUtils.IndexOf<object>
	|
	|-RVA: 0x27E0978 Offset: 0x27DC978 VA: 0x27E0978
	|-CollectionUtils.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E0040 Offset: 0x27DC040 VA: 0x27E0040
	|-CollectionUtils.Contains<object>
	|
	|-RVA: 0x27E0160 Offset: 0x27DC160 VA: 0x27E0160
	|-CollectionUtils.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E0D74 Offset: 0x27DCD74 VA: 0x27E0D74
	|-CollectionUtils.IndexOfReference<object>
	|
	|-RVA: 0x27E0DF8 Offset: 0x27DCDF8 VA: 0x27E0DF8
	|-CollectionUtils.IndexOfReference<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void FastReverse<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E0368 Offset: 0x27DC368 VA: 0x27E0368
	|-CollectionUtils.FastReverse<JsonPosition>
	|
	|-RVA: 0x27E046C Offset: 0x27DC46C VA: 0x27E046C
	|-CollectionUtils.FastReverse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3083214 Offset: 0x307F214 VA: 0x3083214
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x30834C8 Offset: 0x307F4C8 VA: 0x30834C8
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x3083784 Offset: 0x307F784 VA: 0x3083784
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x30838C0 Offset: 0x307F8C0 VA: 0x30838C0
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: -1 Offset: -1
	public static T[] ArrayEmpty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DFED0 Offset: 0x27DBED0 VA: 0x27DFED0
	|-CollectionUtils.ArrayEmpty<byte>
	|
	|-RVA: 0x27DFF2C Offset: 0x27DBF2C VA: 0x27DFF2C
	|-CollectionUtils.ArrayEmpty<int>
	|
	|-RVA: 0x27DFF88 Offset: 0x27DBF88 VA: 0x27DFF88
	|-CollectionUtils.ArrayEmpty<object>
	|
	|-RVA: 0x27DFFE4 Offset: 0x27DBFE4 VA: 0x27DFFE4
	|-CollectionUtils.ArrayEmpty<__Il2CppFullySharedGenericType>
	*/
}
