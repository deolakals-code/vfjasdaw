// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class BidirectionalDictionary<TFirst, TSecond> // TypeDefIndex: 15878
{
	// Fields
	private readonly IDictionary<TFirst, TSecond> _firstToSecond; // 0x0
	private readonly IDictionary<TSecond, TFirst> _secondToFirst; // 0x0
	private readonly string _duplicateFirstErrorMessage; // 0x0
	private readonly string _duplicateSecondErrorMessage; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C687B0 Offset: 0x2C647B0 VA: 0x2C687B0
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0x2C68D08 Offset: 0x2C64D08 VA: 0x2C68D08
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Set(TFirst first, TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C68898 Offset: 0x2C64898 VA: 0x2C68898
	|-BidirectionalDictionary<object, object>.Set
	|
	|-RVA: 0x2C68DF8 Offset: 0x2C64DF8 VA: 0x2C68DF8
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public bool TryGetByFirst(TFirst first, out TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C68BC0 Offset: 0x2C64BC0 VA: 0x2C68BC0
	|-BidirectionalDictionary<object, object>.TryGetByFirst
	|
	|-RVA: 0x2C6956C Offset: 0x2C6556C VA: 0x2C6956C
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetByFirst
	*/

	// RVA: -1 Offset: -1
	public bool TryGetBySecond(TSecond second, out TFirst first) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C68C64 Offset: 0x2C64C64 VA: 0x2C68C64
	|-BidirectionalDictionary<object, object>.TryGetBySecond
	|
	|-RVA: 0x2C696B8 Offset: 0x2C656B8 VA: 0x2C696B8
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetBySecond
	*/
}
